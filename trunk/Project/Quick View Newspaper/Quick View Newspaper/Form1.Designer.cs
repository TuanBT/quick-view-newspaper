namespace Quick_View_Newspaper
{
    partial class Form1
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlGen = new System.Windows.Forms.Panel();
            this.picGen = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.picTitleBack = new System.Windows.Forms.PictureBox();
            this.picTitleNext = new System.Windows.Forms.PictureBox();
            this.picName = new System.Windows.Forms.PictureBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.picOptOpen = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.picOptClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudOpacity = new System.Windows.Forms.NumericUpDown();
            this.picInterface = new System.Windows.Forms.PictureBox();
            this.picIntNext = new System.Windows.Forms.PictureBox();
            this.picNameNext = new System.Windows.Forms.PictureBox();
            this.picGenNext = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).BeginInit();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOptClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNameNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenNext)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.picOptOpen);
            this.pnlMain.Controls.Add(this.picTitleNext);
            this.pnlMain.Controls.Add(this.picTitleBack);
            this.pnlMain.Controls.Add(this.pnlGen);
            this.pnlMain.Controls.Add(this.pnlName);
            this.pnlMain.Controls.Add(this.picBackground);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(960, 108);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlGen
            // 
            this.pnlGen.Controls.Add(this.picGenNext);
            this.pnlGen.Controls.Add(this.picGen);
            this.pnlGen.Location = new System.Drawing.Point(0, 54);
            this.pnlGen.Name = "pnlGen";
            this.pnlGen.Size = new System.Drawing.Size(192, 54);
            this.pnlGen.TabIndex = 1;
            // 
            // picGen
            // 
            this.picGen.Image = global::Quick_View_Newspaper.Properties.Resources.BackgroundTypeNewspaper;
            this.picGen.Location = new System.Drawing.Point(0, 0);
            this.picGen.Name = "picGen";
            this.picGen.Size = new System.Drawing.Size(155, 54);
            this.picGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGen.TabIndex = 1;
            this.picGen.TabStop = false;
            // 
            // picBackground
            // 
            this.picBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBackground.Image = global::Quick_View_Newspaper.Properties.Resources.BackgroundMain;
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(960, 108);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 2;
            this.picBackground.TabStop = false;
            // 
            // picTitleBack
            // 
            this.picTitleBack.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonBack;
            this.picTitleBack.Location = new System.Drawing.Point(200, 4);
            this.picTitleBack.Name = "picTitleBack";
            this.picTitleBack.Size = new System.Drawing.Size(100, 100);
            this.picTitleBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitleBack.TabIndex = 3;
            this.picTitleBack.TabStop = false;
            // 
            // picTitleNext
            // 
            this.picTitleNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picTitleNext.Location = new System.Drawing.Point(800, 4);
            this.picTitleNext.Name = "picTitleNext";
            this.picTitleNext.Size = new System.Drawing.Size(100, 100);
            this.picTitleNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitleNext.TabIndex = 4;
            this.picTitleNext.TabStop = false;
            // 
            // picName
            // 
            this.picName.Image = global::Quick_View_Newspaper.Properties.Resources.BackgroundNameNewspaper;
            this.picName.Location = new System.Drawing.Point(0, 0);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(155, 54);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picName.TabIndex = 0;
            this.picName.TabStop = false;
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.picNameNext);
            this.pnlName.Controls.Add(this.picName);
            this.pnlName.Location = new System.Drawing.Point(0, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(192, 54);
            this.pnlName.TabIndex = 0;
            // 
            // picOptOpen
            // 
            this.picOptOpen.Image = global::Quick_View_Newspaper.Properties.Resources.OptionOpen;
            this.picOptOpen.Location = new System.Drawing.Point(906, 27);
            this.picOptOpen.Name = "picOptOpen";
            this.picOptOpen.Size = new System.Drawing.Size(54, 54);
            this.picOptOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptOpen.TabIndex = 5;
            this.picOptOpen.TabStop = false;
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.picIntNext);
            this.pnlOption.Controls.Add(this.picInterface);
            this.pnlOption.Controls.Add(this.nudOpacity);
            this.pnlOption.Controls.Add(this.nudSpeed);
            this.pnlOption.Controls.Add(this.nudSize);
            this.pnlOption.Controls.Add(this.label4);
            this.pnlOption.Controls.Add(this.label3);
            this.pnlOption.Controls.Add(this.label2);
            this.pnlOption.Controls.Add(this.label1);
            this.pnlOption.Controls.Add(this.picOptClose);
            this.pnlOption.Location = new System.Drawing.Point(12, 146);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(960, 108);
            this.pnlOption.TabIndex = 1;
            // 
            // picOptClose
            // 
            this.picOptClose.Image = global::Quick_View_Newspaper.Properties.Resources.OptionClose;
            this.picOptClose.Location = new System.Drawing.Point(0, 27);
            this.picOptClose.Name = "picOptClose";
            this.picOptClose.Size = new System.Drawing.Size(54, 54);
            this.picOptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptClose.TabIndex = 6;
            this.picOptClose.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cỡ chữ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tốc độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trong suốt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giao diện";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(158, 16);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(51, 22);
            this.nudSize.TabIndex = 11;
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(158, 59);
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(51, 22);
            this.nudSpeed.TabIndex = 12;
            // 
            // nudOpacity
            // 
            this.nudOpacity.Location = new System.Drawing.Point(590, 14);
            this.nudOpacity.Name = "nudOpacity";
            this.nudOpacity.Size = new System.Drawing.Size(56, 22);
            this.nudOpacity.TabIndex = 13;
            // 
            // picInterface
            // 
            this.picInterface.Location = new System.Drawing.Point(590, 59);
            this.picInterface.Name = "picInterface";
            this.picInterface.Size = new System.Drawing.Size(69, 22);
            this.picInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInterface.TabIndex = 14;
            this.picInterface.TabStop = false;
            // 
            // picIntNext
            // 
            this.picIntNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picIntNext.Location = new System.Drawing.Point(665, 59);
            this.picIntNext.Name = "picIntNext";
            this.picIntNext.Size = new System.Drawing.Size(21, 21);
            this.picIntNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIntNext.TabIndex = 16;
            this.picIntNext.TabStop = false;
            // 
            // picNameNext
            // 
            this.picNameNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picNameNext.Location = new System.Drawing.Point(161, 18);
            this.picNameNext.Name = "picNameNext";
            this.picNameNext.Size = new System.Drawing.Size(19, 19);
            this.picNameNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNameNext.TabIndex = 1;
            this.picNameNext.TabStop = false;
            // 
            // picGenNext
            // 
            this.picGenNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picGenNext.Location = new System.Drawing.Point(161, 17);
            this.picGenNext.Name = "picGenNext";
            this.picGenNext.Size = new System.Drawing.Size(19, 19);
            this.picGenNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGenNext.TabIndex = 2;
            this.picGenNext.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 274);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            this.pnlGen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            this.pnlName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOptClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIntNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNameNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGenNext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlGen;
        private System.Windows.Forms.PictureBox picGen;
        private System.Windows.Forms.PictureBox picOptOpen;
        private System.Windows.Forms.PictureBox picTitleNext;
        private System.Windows.Forms.PictureBox picTitleBack;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.PictureBox picIntNext;
        private System.Windows.Forms.PictureBox picInterface;
        private System.Windows.Forms.NumericUpDown nudOpacity;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOptClose;
        private System.Windows.Forms.PictureBox picGenNext;
        private System.Windows.Forms.PictureBox picNameNext;
    }
}

