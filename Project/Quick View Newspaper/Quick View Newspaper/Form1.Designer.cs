﻿namespace Quick_View_Newspaper
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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picOptOpen = new System.Windows.Forms.PictureBox();
            this.picTitleNext = new System.Windows.Forms.PictureBox();
            this.picTitleBack = new System.Windows.Forms.PictureBox();
            this.pnlGen = new System.Windows.Forms.Panel();
            this.picGen = new System.Windows.Forms.PictureBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.picName = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.picIntNext = new System.Windows.Forms.PictureBox();
            this.picInterface = new System.Windows.Forms.PictureBox();
            this.nudOpacity = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picOptClose = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleBack)).BeginInit();
            this.pnlGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGen)).BeginInit();
            this.pnlName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIntNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInterface)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOptClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.picOptOpen);
            this.pnlMain.Controls.Add(this.picTitleNext);
            this.pnlMain.Controls.Add(this.picTitleBack);
            this.pnlMain.Controls.Add(this.pnlGen);
            this.pnlMain.Controls.Add(this.pnlName);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(765, 50);
            this.pnlMain.TabIndex = 0;
            // 
            // picOptOpen
            // 
            this.picOptOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOptOpen.Image = global::Quick_View_Newspaper.Properties.Resources.OptionOpen;
            this.picOptOpen.Location = new System.Drawing.Point(731, 0);
            this.picOptOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOptOpen.Name = "picOptOpen";
            this.picOptOpen.Size = new System.Drawing.Size(20, 48);
            this.picOptOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptOpen.TabIndex = 5;
            this.picOptOpen.TabStop = false;
            this.picOptOpen.Click += new System.EventHandler(this.picOptOpen_Click);
            // 
            // picTitleNext
            // 
            this.picTitleNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picTitleNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picTitleNext.Location = new System.Drawing.Point(695, 10);
            this.picTitleNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTitleNext.Name = "picTitleNext";
            this.picTitleNext.Size = new System.Drawing.Size(29, 27);
            this.picTitleNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitleNext.TabIndex = 4;
            this.picTitleNext.TabStop = false;
            this.picTitleNext.Click += new System.EventHandler(this.picTitleNext_Click);
            // 
            // picTitleBack
            // 
            this.picTitleBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picTitleBack.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonBack;
            this.picTitleBack.Location = new System.Drawing.Point(267, 10);
            this.picTitleBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTitleBack.Name = "picTitleBack";
            this.picTitleBack.Size = new System.Drawing.Size(29, 27);
            this.picTitleBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTitleBack.TabIndex = 3;
            this.picTitleBack.TabStop = false;
            this.picTitleBack.Click += new System.EventHandler(this.picTitleBack_Click);
            // 
            // pnlGen
            // 
            this.pnlGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlGen.Controls.Add(this.picGen);
            this.pnlGen.Location = new System.Drawing.Point(160, 0);
            this.pnlGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGen.Name = "pnlGen";
            this.pnlGen.Size = new System.Drawing.Size(100, 48);
            this.pnlGen.TabIndex = 1;
            // 
            // picGen
            // 
            this.picGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picGen.Image = global::Quick_View_Newspaper.Properties.Resources.BackgroundTypeNewspaper;
            this.picGen.Location = new System.Drawing.Point(0, 0);
            this.picGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picGen.Name = "picGen";
            this.picGen.Size = new System.Drawing.Size(97, 48);
            this.picGen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGen.TabIndex = 1;
            this.picGen.TabStop = false;
            this.picGen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picGen_MouseClick);
            // 
            // pnlName
            // 
            this.pnlName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlName.Controls.Add(this.picName);
            this.pnlName.Location = new System.Drawing.Point(0, 0);
            this.pnlName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(160, 48);
            this.pnlName.TabIndex = 0;
            // 
            // picName
            // 
            this.picName.Image = global::Quick_View_Newspaper.Properties.Resources.BackgroundNameNewspaper;
            this.picName.Location = new System.Drawing.Point(0, 0);
            this.picName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(149, 50);
            this.picName.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picName.TabIndex = 0;
            this.picName.TabStop = false;
            this.picName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picName_MouseClick);
            // 
            // picBackground
            // 
            this.picBackground.Image = global::Quick_View_Newspaper.Properties.Resources.BackgroundMain;
            this.picBackground.Location = new System.Drawing.Point(7, 123);
            this.picBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(291, 50);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 2;
            this.picBackground.TabStop = false;
            // 
            // pnlOption
            // 
            this.pnlOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.pnlOption.Location = new System.Drawing.Point(12, 68);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(765, 50);
            this.pnlOption.TabIndex = 1;
            // 
            // picIntNext
            // 
            this.picIntNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picIntNext.Location = new System.Drawing.Point(699, 18);
            this.picIntNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picIntNext.Name = "picIntNext";
            this.picIntNext.Size = new System.Drawing.Size(21, 21);
            this.picIntNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIntNext.TabIndex = 16;
            this.picIntNext.TabStop = false;
            // 
            // picInterface
            // 
            this.picInterface.Location = new System.Drawing.Point(623, 18);
            this.picInterface.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picInterface.Name = "picInterface";
            this.picInterface.Size = new System.Drawing.Size(69, 22);
            this.picInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInterface.TabIndex = 14;
            this.picInterface.TabStop = false;
            // 
            // nudOpacity
            // 
            this.nudOpacity.Location = new System.Drawing.Point(467, 17);
            this.nudOpacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudOpacity.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudOpacity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
            this.nudOpacity.Name = "nudOpacity";
            this.nudOpacity.Size = new System.Drawing.Size(56, 22);
            this.nudOpacity.TabIndex = 13;
            this.nudOpacity.ValueChanged += new System.EventHandler(this.nudOpacity_ValueChanged);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(293, 14);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(51, 22);
            this.nudSpeed.TabIndex = 12;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(157, 16);
            this.nudSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(51, 22);
            this.nudSize.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giao diện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trong suốt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tốc độ";
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
            // picOptClose
            // 
            this.picOptClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picOptClose.Image = global::Quick_View_Newspaper.Properties.Resources.OptionClose;
            this.picOptClose.Location = new System.Drawing.Point(0, 0);
            this.picOptClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOptClose.Name = "picOptClose";
            this.picOptClose.Size = new System.Drawing.Size(20, 48);
            this.picOptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptClose.TabIndex = 6;
            this.picOptClose.TabStop = false;
            this.picOptClose.Click += new System.EventHandler(this.picOptClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 122);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Opacity = 0.6D;
            this.Text = "Form1";
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleBack)).EndInit();
            this.pnlGen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGen)).EndInit();
            this.pnlName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIntNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInterface)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOptClose)).EndInit();
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
        private System.Windows.Forms.Timer timer1;
    }
}

