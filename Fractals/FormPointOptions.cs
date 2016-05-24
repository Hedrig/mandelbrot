using System;
using System.Drawing;
using System.Windows.Forms;
using DataStorage;

namespace FormMain
{
    public partial class FormPointOptions : Form
    {
        /// <summary>
        /// Создаёт новый экземпляр формы FormPointOptions для изменения параметров выбранной точки или добавления новой.
        /// </summary>
        /// <param name="index">индекс изменяемой точки. Если он больше или равен количеству элементов в списке точек, будет добавлен новый элемент.</param>
        /// <param name="maxdepth">Максимальная глубина, нужна для настройки trackbar.</param>
        public FormPointOptions(int index, int maxdepth)
        {
            InitializeComponent();
            trackBarDepth.Maximum = maxdepth;
            // Проверяем индекс изменяемой строки, если он больше длины хранилища данных, то, значит, речь идёт о новой записи
            if (index >= PointStorage.Count) // Создаём новую запись
                trackBarRed.Value = trackBarBlue.Value = trackBarGreen.Value = trackBarDepth.Value = 0;
            else
            {   // Обновляем существующую запись
                trackBarRed.Value = PointStorage.Points[index].Red;
                textBoxRedValue.Text = trackBarRed.Value.ToString();

                trackBarGreen.Value = PointStorage.Points[index].Green;
                textBoxGreenValue.Text = trackBarGreen.Value.ToString();

                trackBarBlue.Value = PointStorage.Points[index].Blue;
                textBoxBlueValue.Text = trackBarBlue.Value.ToString();

                trackBarDepth.Value = PointStorage.Points[index].Depth;
                textBoxDepthValue.Text = trackBarDepth.Value.ToString();

                trackBarDepth.Enabled = false; // Закроем-ка эту штуку от греха и пользователя
            }
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {   // Тут всё просто: двигаем этот... Ну, этот, как его... Вот этот самый, и изменения отражаются в тексте
            textBoxRedValue.Text = trackBarRed.Value.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            textBoxGreenValue.Text = trackBarGreen.Value.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            textBoxBlueValue.Text = trackBarBlue.Value.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void trackBarDepth_Scroll(object sender, EventArgs e)
        {
            textBoxDepthValue.Text = trackBarDepth.Value.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        // Пользователь может поменять значения напрямую
        private void textBoxDepthValue_Leave(object sender, EventArgs e)
        {
            // Если пользователь вводит слишком большое значение, оно сводится к максимуму
            int i = int.Parse(textBoxDepthValue.Text); if (i < 0) i = 0; else if (i > trackBarDepth.Maximum) i = trackBarDepth.Maximum;
            trackBarDepth.Value = i;
            textBoxDepthValue.Text = i.ToString();
        }

        private void textBoxRedValue_Leave(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxRedValue.Text); if (i < 0) i = 0; else if (i > trackBarRed.Maximum) i = trackBarRed.Maximum;
            trackBarRed.Value = i; textBoxRedValue.Text = i.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void textBoxGreenValue_Leave(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxGreenValue.Text); if (i < 0) i = 0; else if (i > trackBarGreen.Maximum) i = trackBarGreen.Maximum;
            trackBarGreen.Value = i; textBoxGreenValue.Text = i.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void textBoxBlueValue_Leave(object sender, EventArgs e)
        {
            int i = int.Parse(textBoxBlueValue.Text); if (i < 0) i = 0; else if (i > trackBarBlue.Maximum) i = trackBarBlue.Maximum;
            trackBarBlue.Value = i; textBoxBlueValue.Text = i.ToString();
            pictureBoxColor.BackColor = Color.FromArgb(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {   // Добавляем настроенную точку
            PointStorage.AddPoint(trackBarDepth.Value, (byte)trackBarRed.Value, (byte)trackBarGreen.Value, (byte)trackBarBlue.Value);
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}