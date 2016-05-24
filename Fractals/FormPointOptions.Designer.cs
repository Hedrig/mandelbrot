namespace FormMain
{
    partial class FormPointOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label9;
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.trackBarDepth = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxDepthValue = new System.Windows.Forms.TextBox();
            this.textBoxRedValue = new System.Windows.Forms.TextBox();
            this.textBoxGreenValue = new System.Windows.Forms.TextBox();
            this.textBoxBlueValue = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(12, 12);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(46, 17);
            label9.TabIndex = 27;
            label9.Text = "Depth";
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxColor.Location = new System.Drawing.Point(363, 12);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(255, 202);
            this.pictureBoxColor.TabIndex = 28;
            this.pictureBoxColor.TabStop = false;
            // 
            // trackBarDepth
            // 
            this.trackBarDepth.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarDepth.Location = new System.Drawing.Point(63, 12);
            this.trackBarDepth.Maximum = 255;
            this.trackBarDepth.Name = "trackBarDepth";
            this.trackBarDepth.Size = new System.Drawing.Size(215, 56);
            this.trackBarDepth.TabIndex = 26;
            this.trackBarDepth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarDepth.Scroll += new System.EventHandler(this.trackBarDepth_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarGreen.Location = new System.Drawing.Point(63, 127);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(215, 56);
            this.trackBarGreen.TabIndex = 22;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBlue.Location = new System.Drawing.Point(63, 189);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(215, 56);
            this.trackBarBlue.TabIndex = 21;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // trackBarRed
            // 
            this.trackBarRed.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarRed.LargeChange = 15;
            this.trackBarRed.Location = new System.Drawing.Point(63, 68);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(215, 56);
            this.trackBarRed.TabIndex = 20;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(32, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 26);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(32, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 26);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(32, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 26);
            this.panel3.TabIndex = 30;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(63, 236);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(113, 37);
            this.buttonDone.TabIndex = 35;
            this.buttonDone.Text = "Готово";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(203, 236);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 37);
            this.buttonCancel.TabIndex = 36;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxDepthValue
            // 
            this.textBoxDepthValue.Location = new System.Drawing.Point(284, 12);
            this.textBoxDepthValue.Name = "textBoxDepthValue";
            this.textBoxDepthValue.Size = new System.Drawing.Size(36, 22);
            this.textBoxDepthValue.TabIndex = 37;
            this.textBoxDepthValue.Text = "0";
            this.textBoxDepthValue.Leave += new System.EventHandler(this.textBoxDepthValue_Leave);
            // 
            // textBoxRedValue
            // 
            this.textBoxRedValue.Location = new System.Drawing.Point(284, 78);
            this.textBoxRedValue.Name = "textBoxRedValue";
            this.textBoxRedValue.Size = new System.Drawing.Size(36, 22);
            this.textBoxRedValue.TabIndex = 38;
            this.textBoxRedValue.Text = "0";
            this.textBoxRedValue.Leave += new System.EventHandler(this.textBoxRedValue_Leave);
            // 
            // textBoxGreenValue
            // 
            this.textBoxGreenValue.Location = new System.Drawing.Point(284, 136);
            this.textBoxGreenValue.Name = "textBoxGreenValue";
            this.textBoxGreenValue.Size = new System.Drawing.Size(36, 22);
            this.textBoxGreenValue.TabIndex = 39;
            this.textBoxGreenValue.Text = "0";
            this.textBoxGreenValue.Leave += new System.EventHandler(this.textBoxGreenValue_Leave);
            // 
            // textBoxBlueValue
            // 
            this.textBoxBlueValue.Location = new System.Drawing.Point(284, 194);
            this.textBoxBlueValue.Name = "textBoxBlueValue";
            this.textBoxBlueValue.Size = new System.Drawing.Size(36, 22);
            this.textBoxBlueValue.TabIndex = 40;
            this.textBoxBlueValue.Text = "0";
            this.textBoxBlueValue.Leave += new System.EventHandler(this.textBoxBlueValue_Leave);
            // 
            // FormPointOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(630, 285);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxBlueValue);
            this.Controls.Add(this.textBoxGreenValue);
            this.Controls.Add(this.textBoxRedValue);
            this.Controls.Add(this.textBoxDepthValue);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(label9);
            this.Controls.Add(this.trackBarDepth);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPointOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Свойства точки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxColor;
        internal System.Windows.Forms.TrackBar trackBarDepth;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxDepthValue;
        private System.Windows.Forms.TextBox textBoxRedValue;
        private System.Windows.Forms.TextBox textBoxGreenValue;
        private System.Windows.Forms.TextBox textBoxBlueValue;
    }
}