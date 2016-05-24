using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using DataStorage;

namespace FormMain
{
    public partial class FormGraphics : Form
    {
        // Координаты текущей точки - точки, вокруг которой рисуется множество, а также масштаб изображения
        double centralPointX, centralPointY, scale; int maxiters;
        // Карта глубин. По ней строится окончательное изображение
        // Она хранится в памяти, чтобы по ней можно было потом изображение перерисовывать
        float[,] depthmap;
        
        public FormGraphics()
        {
            InitializeComponent();
            scale = 300; centralPointX = -.5; centralPointY = 0;
            PointStorage.AddPoint(0, 255, 255, 255);
            PointStorage.AddPoint(100, 0, 0, 0);
            ListFill();
            DirectoryInfo dir = new DirectoryInfo(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings"));
            if (!dir.Exists) dir.Create();
            foreach (FileInfo file in dir.GetFiles())
                if (file.Extension == ".txt")
                    listViewFiles.Items.Add(new ListViewItem(file.Name));
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            try
            {
                scale = double.Parse(textBoxScale.Text);
                centralPointX = double.Parse(textBoxCurX.Text);
                centralPointY = double.Parse(textBoxCurY.Text);
                maxiters = int.Parse(textBoxMax.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Одно из введённых вами значений имеет неверный формат.");
                return;
            }
            Stopwatch timer = new Stopwatch();
            timer.Start();
            // Создаём карту глубин (именно здесь считается множество, так что это - самая трудная по времени часть)
            depthmap = SetController.GetMap(pictureBoxMandSet.Width, pictureBoxMandSet.Height, scale, centralPointX, centralPointY, maxiters);
            labelTimeForSetMap.Text = "Карта глубин: " + timer.ElapsedMilliseconds.ToString() + " ms";
            if (PointStorage.Count > 1)          // И на её основе - картинку
                pictureBoxMandSet.Image = SetController.DrawSet(depthmap, trackBarSkip.Value);
            else
            { MessageBox.Show("Недостаточно опорных точек для построения изображения.\nНеобходимый минимум - 2 точки."); return; }
            timer.Stop();
            labelTotalTimeElapsed.Text = "Затраченное время: " + timer.ElapsedMilliseconds.ToString() + " ms";
        }

        private void buttonRedraw_Click(object sender, EventArgs e)
        {
            // Перерисовываем картинку
            // Карта высот уже есть, так что много времени это не займёт
            if (depthmap != null)
            {
                if (PointStorage.Count > 1)
                    pictureBoxMandSet.Image = SetController.DrawSet(depthmap, trackBarSkip.Value);
                else
                {
                    MessageBox.Show("Недостаточно опорных точек для построения изображения.\nНеобходимый минимум - 2 точки.");
                    return;
                }
            }
        }

        private void pictureBoxMandSet_MouseClick(object sender, MouseEventArgs e)
        {
            // При нажатии левой кнопки мыши устанавливается текущая точка
            if (e.Button == MouseButtons.Left)
            {
                // Определяем смещение текущей точки
                textBoxCurX.Text = (centralPointX + (e.X - pictureBoxMandSet.Width / 2) / scale).ToString();
                textBoxCurY.Text = (centralPointY + (e.Y - pictureBoxMandSet.Height / 2) / scale).ToString();
            }
        }

        private void buttonAddPoint_Click(object sender, EventArgs e)
        {
            FormPointOptions formopts = new FormPointOptions(PointStorage.Count, maxiters);
            // Вызываем форму для настройки нашей новой точки
            formopts.ShowDialog(this);
            ListFill();
        }

        private void listViewPoints_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewPoints.FocusedItem != null)
            { // При двойном клике по записи в списке она открывает форму для редактирования
                FormPointOptions formopts = new FormPointOptions(listViewPoints.FocusedItem.Index, maxiters);
                formopts.ShowDialog(this);
                ColorPoint newpoint = PointStorage.Points[listViewPoints.FocusedItem.Index];
                listViewPoints.FocusedItem = new ListViewItem(new string[4] {
                    newpoint.Depth.ToString(),
                    newpoint.Red.ToString(),
                    newpoint.Green.ToString(),
                    newpoint.Blue.ToString() });
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewPoints.FocusedItem != null)
            {
                int i = listViewPoints.FocusedItem.Index;
                PointStorage.RemoveItem(i);
                listViewPoints.FocusedItem.Remove();
            }
        }

        private void trackBarSkip_Scroll(object sender, EventArgs e)
        {
            textBoxSkip.Text = trackBarSkip.Value.ToString();
        }

        private void textBoxSkip_Leave(object sender, EventArgs e)
        { // Закончили писать значение вручную - оно отображается в trackbar'е
            int i = 0;
            if (textBoxSkip.Text != "") 
                i = int.Parse(textBoxSkip.Text);
            if (i < 0) i = 0; else if (i > trackBarSkip.Maximum) i = trackBarSkip.Maximum;
            trackBarSkip.Value = i; textBoxSkip.Text = i.ToString();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            if (depthmap != null)
            {
                float min = depthmap[0, 0]; // Проходим по всей матрице значений и выбираем наименьшее значение
                for (int y = 0; y < depthmap.GetLength(1); y++)
                    for (int x = 0; x < depthmap.GetLength(0); x++)
                        if (min > depthmap[x, y]) min = depthmap[x, y];
                trackBarSkip.Value = (int)min;
                textBoxSkip.Text = ((int)min).ToString();
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (listViewFiles.FocusedItem != null)
            {
                PointStorage.Clear();
                string filename = (Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings", listViewFiles.FocusedItem.Text));
                string[] data = File.ReadAllLines(filename);
                textBoxCurX.Text = data[0]; textBoxCurY.Text = data[1]; textBoxScale.Text = data[2]; textBoxMax.Text = data[3];
                trackBarSkip.Maximum = int.Parse(data[3]);
                for (int i = 4; i < data.Length; i +=4)
                    PointStorage.AddPoint(int.Parse(data[i]), byte.Parse(data[i + 1]), byte.Parse(data[i + 2]), byte.Parse(data[i + 3]));
                ListFill();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text != "")
            {
                string text = textBoxFileName.Text;
                if (text[text.Length - 4] != '.') text = text + ".txt";
                string filename = (Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Settings", text));
                string[] data = new string[PointStorage.Count * 4 + 4];
                data[0] = textBoxCurX.Text; data[1] = textBoxCurY.Text; data[2] = textBoxScale.Text; data[3] = textBoxMax.Text;
                for (int i = 4; i < data.Length; i += 4)
                {
                    ColorPoint current = PointStorage.Points[(i - 4) / 4];
                    data[i] = current.Depth.ToString();
                    data[i + 1] = current.Red.ToString();
                    data[i + 2] = current.Green.ToString();
                    data[i + 3] = current.Blue.ToString();
                }
                File.WriteAllLines(filename, data);
                ListViewItem itemnew = new ListViewItem(new string[1] { text });
                if (!listViewFiles.Items.Contains(itemnew)) listViewFiles.Items.Add(itemnew);
                textBoxFileName.Text = "";
            }
        }

        private void buttonDeleteFile_Click(object sender, EventArgs e)
        {
            if (listViewFiles.FocusedItem != null)
            {
                File.Delete(Path.GetDirectoryName(Application.ExecutablePath) + "//Settings//" + listViewFiles.FocusedItem.Text);
                listViewFiles.FocusedItem.Remove();                                                                                                     // лить!
            }
        }

        private void pictureBoxMandSet_MouseMove(object sender, MouseEventArgs e)
        {
            if (depthmap != null)
                if ((e.X >= 0) && (e.Y >= 0) && (e.X <= pictureBoxMandSet.Width) && (e.Y <= pictureBoxMandSet.Height))
                    textBoxCurrentDepth.Text = depthmap[e.X, e.Y].ToString();
        }

        private void textBoxMax_Leave(object sender, EventArgs e)
        {
            trackBarSkip.Maximum = int.Parse(textBoxMax.Text);
            PointStorage.Points[PointStorage.Count - 1].Depth = int.Parse(textBoxMax.Text);
            listViewPoints.Items[listViewPoints.Items.Count - 1].SubItems[0].Text = textBoxMax.Text;
        }

        /// <summary>
        /// Заполняет ListView списком из хранилища.
        /// </summary>
        private void ListFill()
        {
            listViewPoints.Items.Clear();
            for (int i = 0; i < PointStorage.Count; i++)
                listViewPoints.Items.Add(new ListViewItem(new string[4] {PointStorage.Points[i].Depth.ToString(),
                                                                         PointStorage.Points[i].Red.ToString(),
                                                                         PointStorage.Points[i].Green.ToString(),
                                                                         PointStorage.Points[i].Blue.ToString()}));
        }

        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Изображение PNG|*.png|Все файлы|*.*";
            save.FilterIndex = 1;
            if (save.ShowDialog(this) == DialogResult.OK)
                pictureBoxMandSet.Image.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void FormGraphics_SizeChanged(object sender, EventArgs e)
        {
            pictureBoxMandSet.Location = new System.Drawing.Point(
                tabControlOptions.Location.X + tabControlOptions.Width, 
                tabControlOptions.Location.Y + tabControlOptions.Height);
        }
    }
}