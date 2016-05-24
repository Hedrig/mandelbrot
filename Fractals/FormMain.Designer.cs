namespace FormMain
{
    partial class FormGraphics
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label8;
            this.labelTotalTimeElapsed = new System.Windows.Forms.Label();
            this.pictureBoxMandSet = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentDepth = new System.Windows.Forms.TextBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.textBoxSkip = new System.Windows.Forms.TextBox();
            this.trackBarSkip = new System.Windows.Forms.TrackBar();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listViewPoints = new System.Windows.Forms.ListView();
            this.listViewColumnDepth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnRed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnGreen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewColumnBlue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddPoint = new System.Windows.Forms.Button();
            this.buttonRedraw = new System.Windows.Forms.Button();
            this.tabControlOptions = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelTimeForSetMap = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.textBoxCurX = new System.Windows.Forms.TextBox();
            this.textBoxCurY = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMandSet)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkip)).BeginInit();
            this.tabControlOptions.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(9, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(26, 17);
            label7.TabIndex = 15;
            label7.Text = "Re";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(9, 73);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(22, 17);
            label6.TabIndex = 14;
            label6.Text = "Im";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(4, 222);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(97, 17);
            label10.TabIndex = 15;
            label10.Text = "Список точек";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(29, 22);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(112, 17);
            label5.TabIndex = 11;
            label5.Text = "Текущая точка:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(9, 107);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 17);
            label4.TabIndex = 9;
            label4.Text = "Масштаб";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 152);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(77, 17);
            label1.TabIndex = 17;
            label1.Text = "Итераций:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(6, 186);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(170, 17);
            label8.TabIndex = 6;
            label8.Text = "Сохранённые настройки";
            // 
            // labelTotalTimeElapsed
            // 
            this.labelTotalTimeElapsed.AutoSize = true;
            this.labelTotalTimeElapsed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTotalTimeElapsed.Location = new System.Drawing.Point(12, 288);
            this.labelTotalTimeElapsed.Name = "labelTotalTimeElapsed";
            this.labelTotalTimeElapsed.Size = new System.Drawing.Size(180, 19);
            this.labelTotalTimeElapsed.TabIndex = 23;
            this.labelTotalTimeElapsed.Text = "Затраченное время: 0 ms";
            // 
            // pictureBoxMandSet
            // 
            this.pictureBoxMandSet.BackColor = System.Drawing.Color.White;
            this.pictureBoxMandSet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMandSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxMandSet.Location = new System.Drawing.Point(282, 0);
            this.pictureBoxMandSet.Name = "pictureBoxMandSet";
            this.pictureBoxMandSet.Size = new System.Drawing.Size(1072, 821);
            this.pictureBoxMandSet.TabIndex = 23;
            this.pictureBoxMandSet.TabStop = false;
            this.pictureBoxMandSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMandSet_MouseClick);
            this.pictureBoxMandSet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMandSet_MouseMove);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBoxCurrentDepth);
            this.tabPage4.Controls.Add(this.buttonAuto);
            this.tabPage4.Controls.Add(this.textBoxSkip);
            this.tabPage4.Controls.Add(this.trackBarSkip);
            this.tabPage4.Controls.Add(this.buttonDelete);
            this.tabPage4.Controls.Add(this.listViewPoints);
            this.tabPage4.Controls.Add(this.buttonAddPoint);
            this.tabPage4.Controls.Add(label10);
            this.tabPage4.Controls.Add(this.buttonRedraw);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(274, 792);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Цвет";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Уменьшать глубину на";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Depth";
            // 
            // textBoxCurrentDepth
            // 
            this.textBoxCurrentDepth.Enabled = false;
            this.textBoxCurrentDepth.Location = new System.Drawing.Point(58, 16);
            this.textBoxCurrentDepth.Name = "textBoxCurrentDepth";
            this.textBoxCurrentDepth.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrentDepth.TabIndex = 25;
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(216, 163);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(50, 23);
            this.buttonAuto.TabIndex = 24;
            this.buttonAuto.Text = "Авто";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // textBoxSkip
            // 
            this.textBoxSkip.Location = new System.Drawing.Point(216, 192);
            this.textBoxSkip.Name = "textBoxSkip";
            this.textBoxSkip.Size = new System.Drawing.Size(50, 22);
            this.textBoxSkip.TabIndex = 23;
            this.textBoxSkip.Text = "0";
            this.textBoxSkip.Leave += new System.EventHandler(this.textBoxSkip_Leave);
            // 
            // trackBarSkip
            // 
            this.trackBarSkip.BackColor = System.Drawing.Color.White;
            this.trackBarSkip.Location = new System.Drawing.Point(5, 163);
            this.trackBarSkip.Maximum = 100;
            this.trackBarSkip.Name = "trackBarSkip";
            this.trackBarSkip.Size = new System.Drawing.Size(218, 56);
            this.trackBarSkip.TabIndex = 22;
            this.trackBarSkip.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarSkip.Scroll += new System.EventHandler(this.trackBarSkip_Scroll);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(165, 653);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(95, 23);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listViewPoints
            // 
            this.listViewPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColumnDepth,
            this.listViewColumnRed,
            this.listViewColumnGreen,
            this.listViewColumnBlue});
            this.listViewPoints.FullRowSelect = true;
            this.listViewPoints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPoints.Location = new System.Drawing.Point(7, 242);
            this.listViewPoints.Name = "listViewPoints";
            this.listViewPoints.Size = new System.Drawing.Size(256, 405);
            this.listViewPoints.TabIndex = 17;
            this.listViewPoints.UseCompatibleStateImageBehavior = false;
            this.listViewPoints.View = System.Windows.Forms.View.Details;
            this.listViewPoints.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPoints_MouseDoubleClick);
            // 
            // listViewColumnDepth
            // 
            this.listViewColumnDepth.Text = "Depth";
            // 
            // listViewColumnRed
            // 
            this.listViewColumnRed.Text = "Red";
            this.listViewColumnRed.Width = 55;
            // 
            // listViewColumnGreen
            // 
            this.listViewColumnGreen.Text = "Green";
            this.listViewColumnGreen.Width = 53;
            // 
            // listViewColumnBlue
            // 
            this.listViewColumnBlue.Text = "Blue";
            this.listViewColumnBlue.Width = 55;
            // 
            // buttonAddPoint
            // 
            this.buttonAddPoint.Location = new System.Drawing.Point(4, 653);
            this.buttonAddPoint.Name = "buttonAddPoint";
            this.buttonAddPoint.Size = new System.Drawing.Size(95, 23);
            this.buttonAddPoint.TabIndex = 16;
            this.buttonAddPoint.Text = "Добавить";
            this.buttonAddPoint.UseVisualStyleBackColor = true;
            this.buttonAddPoint.Click += new System.EventHandler(this.buttonAddPoint_Click);
            // 
            // buttonRedraw
            // 
            this.buttonRedraw.Location = new System.Drawing.Point(21, 682);
            this.buttonRedraw.Name = "buttonRedraw";
            this.buttonRedraw.Size = new System.Drawing.Size(216, 35);
            this.buttonRedraw.TabIndex = 11;
            this.buttonRedraw.Text = "Перерисовать";
            this.buttonRedraw.UseVisualStyleBackColor = true;
            this.buttonRedraw.Click += new System.EventHandler(this.buttonRedraw_Click);
            // 
            // tabControlOptions
            // 
            this.tabControlOptions.Controls.Add(this.tabPage3);
            this.tabControlOptions.Controls.Add(this.tabPage1);
            this.tabControlOptions.Controls.Add(this.tabPage4);
            this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
            this.tabControlOptions.Name = "tabControlOptions";
            this.tabControlOptions.SelectedIndex = 0;
            this.tabControlOptions.Size = new System.Drawing.Size(282, 821);
            this.tabControlOptions.TabIndex = 22;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelTimeForSetMap);
            this.tabPage3.Controls.Add(label1);
            this.tabPage3.Controls.Add(this.labelTotalTimeElapsed);
            this.tabPage3.Controls.Add(this.textBoxMax);
            this.tabPage3.Controls.Add(label5);
            this.tabPage3.Controls.Add(label4);
            this.tabPage3.Controls.Add(this.textBoxScale);
            this.tabPage3.Controls.Add(this.buttonDraw);
            this.tabPage3.Controls.Add(this.textBoxCurX);
            this.tabPage3.Controls.Add(this.textBoxCurY);
            this.tabPage3.Controls.Add(label6);
            this.tabPage3.Controls.Add(label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(274, 792);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Основные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelTimeForSetMap
            // 
            this.labelTimeForSetMap.AutoSize = true;
            this.labelTimeForSetMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTimeForSetMap.Location = new System.Drawing.Point(12, 307);
            this.labelTimeForSetMap.Name = "labelTimeForSetMap";
            this.labelTimeForSetMap.Size = new System.Drawing.Size(136, 19);
            this.labelTimeForSetMap.TabIndex = 24;
            this.labelTimeForSetMap.Text = "Карта глубин: 0 ms";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(12, 172);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(75, 22);
            this.textBoxMax.TabIndex = 16;
            this.textBoxMax.Text = "100";
            this.textBoxMax.Leave += new System.EventHandler(this.textBoxMax_Leave);
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(12, 127);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(136, 22);
            this.textBoxScale.TabIndex = 10;
            this.textBoxScale.Text = "300";
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(12, 227);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(199, 45);
            this.buttonDraw.TabIndex = 1;
            this.buttonDraw.Text = "Изобразить множество";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // textBoxCurX
            // 
            this.textBoxCurX.Location = new System.Drawing.Point(32, 42);
            this.textBoxCurX.Name = "textBoxCurX";
            this.textBoxCurX.Size = new System.Drawing.Size(109, 22);
            this.textBoxCurX.TabIndex = 12;
            this.textBoxCurX.Text = "-0,5";
            // 
            // textBoxCurY
            // 
            this.textBoxCurY.Location = new System.Drawing.Point(32, 70);
            this.textBoxCurY.Name = "textBoxCurY";
            this.textBoxCurY.Size = new System.Drawing.Size(109, 22);
            this.textBoxCurY.TabIndex = 13;
            this.textBoxCurY.Text = "0";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSaveImage);
            this.tabPage1.Controls.Add(label8);
            this.tabPage1.Controls.Add(this.buttonDeleteFile);
            this.tabPage1.Controls.Add(this.textBoxFileName);
            this.tabPage1.Controls.Add(this.listViewFiles);
            this.tabPage1.Controls.Add(this.buttonLoad);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 792);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Отрисовка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(9, 93);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(253, 50);
            this.buttonSaveImage.TabIndex = 7;
            this.buttonSaveImage.Text = "Сохранить изображение";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Location = new System.Drawing.Point(9, 422);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(111, 42);
            this.buttonDeleteFile.TabIndex = 4;
            this.buttonDeleteFile.Text = "Удалить файл настроек";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(8, 334);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(257, 22);
            this.textBoxFileName.TabIndex = 3;
            // 
            // listViewFiles
            // 
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.Location = new System.Drawing.Point(8, 206);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(256, 122);
            this.listViewFiles.TabIndex = 2;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(164, 362);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(98, 42);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Загрузить настройки";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(9, 362);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 42);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить настройки";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormGraphics
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1354, 821);
            this.Controls.Add(this.pictureBoxMandSet);
            this.Controls.Add(this.tabControlOptions);
            this.Name = "FormGraphics";
            this.Text = "Множества";
            this.SizeChanged += new System.EventHandler(this.FormGraphics_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMandSet)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSkip)).EndInit();
            this.tabControlOptions.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTotalTimeElapsed;
        private System.Windows.Forms.PictureBox pictureBoxMandSet;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listViewPoints;
        private System.Windows.Forms.ColumnHeader listViewColumnRed;
        private System.Windows.Forms.ColumnHeader listViewColumnGreen;
        private System.Windows.Forms.ColumnHeader listViewColumnBlue;
        private System.Windows.Forms.ColumnHeader listViewColumnDepth;
        private System.Windows.Forms.Button buttonAddPoint;
        private System.Windows.Forms.Button buttonRedraw;
        private System.Windows.Forms.TabControl tabControlOptions;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.TextBox textBoxCurX;
        private System.Windows.Forms.TextBox textBoxCurY;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelTimeForSetMap;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TrackBar trackBarSkip;
        private System.Windows.Forms.TextBox textBoxSkip;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonDeleteFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentDepth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSaveImage;

    }
}

