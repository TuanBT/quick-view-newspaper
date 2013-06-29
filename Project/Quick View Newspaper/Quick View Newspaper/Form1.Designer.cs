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
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picOptOpen = new System.Windows.Forms.PictureBox();
            this.pnlRun = new System.Windows.Forms.Panel();
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
            this.cbbTitle = new System.Windows.Forms.ComboBox();
            this.cbbCat = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).BeginInit();
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
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lblCat);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Controls.Add(this.picOptOpen);
            this.pnlMain.Controls.Add(this.pnlRun);
            this.pnlMain.Location = new System.Drawing.Point(9, 10);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(568, 25);
            this.pnlMain.TabIndex = 0;
            // 
            // lblCat
            // 
            this.lblCat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCat.Location = new System.Drawing.Point(134, 0);
            this.lblCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(94, 23);
            this.lblCat.TabIndex = 2;
            this.lblCat.Text = "Tình yêu -giới tính";
            this.lblCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCat_MouseClick);
            this.lblCat.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblCat_MouseDoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Nông nghiệp Việt Nam";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseClick);
            this.lblTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDoubleClick);
            // 
            // picOptOpen
            // 
            this.picOptOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOptOpen.Image = global::Quick_View_Newspaper.Properties.Resources.OptionOpen;
            this.picOptOpen.Location = new System.Drawing.Point(542, 0);
            this.picOptOpen.Margin = new System.Windows.Forms.Padding(2);
            this.picOptOpen.Name = "picOptOpen";
            this.picOptOpen.Size = new System.Drawing.Size(15, 23);
            this.picOptOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptOpen.TabIndex = 5;
            this.picOptOpen.TabStop = false;
            this.picOptOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOptOpen_MouseClick);
            // 
            // pnlRun
            // 
            this.pnlRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRun.Location = new System.Drawing.Point(0, 0);
            this.pnlRun.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRun.Name = "pnlRun";
            this.pnlRun.Size = new System.Drawing.Size(566, 23);
            this.pnlRun.TabIndex = 3;
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
            this.pnlOption.Location = new System.Drawing.Point(9, 55);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(568, 25);
            this.pnlOption.TabIndex = 1;
            // 
            // picIntNext
            // 
            this.picIntNext.Image = global::Quick_View_Newspaper.Properties.Resources.ButtonNext;
            this.picIntNext.Location = new System.Drawing.Point(516, 3);
            this.picIntNext.Margin = new System.Windows.Forms.Padding(2);
            this.picIntNext.Name = "picIntNext";
            this.picIntNext.Size = new System.Drawing.Size(16, 17);
            this.picIntNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIntNext.TabIndex = 16;
            this.picIntNext.TabStop = false;
            // 
            // picInterface
            // 
            this.picInterface.Location = new System.Drawing.Point(459, 2);
            this.picInterface.Margin = new System.Windows.Forms.Padding(2);
            this.picInterface.Name = "picInterface";
            this.picInterface.Size = new System.Drawing.Size(52, 18);
            this.picInterface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInterface.TabIndex = 14;
            this.picInterface.TabStop = false;
            // 
            // nudOpacity
            // 
            this.nudOpacity.Location = new System.Drawing.Point(342, 4);
            this.nudOpacity.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudOpacity.Size = new System.Drawing.Size(42, 20);
            this.nudOpacity.TabIndex = 13;
            this.nudOpacity.ValueChanged += new System.EventHandler(this.nudOpacity_ValueChanged);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(212, 2);
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(38, 20);
            this.nudSpeed.TabIndex = 12;
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(110, 3);
            this.nudSize.Margin = new System.Windows.Forms.Padding(2);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(38, 20);
            this.nudSize.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giao diện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trong suốt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tốc độ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cỡ chữ:";
            // 
            // picOptClose
            // 
            this.picOptClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picOptClose.Image = global::Quick_View_Newspaper.Properties.Resources.OptionClose;
            this.picOptClose.Location = new System.Drawing.Point(0, 0);
            this.picOptClose.Margin = new System.Windows.Forms.Padding(2);
            this.picOptClose.Name = "picOptClose";
            this.picOptClose.Size = new System.Drawing.Size(15, 23);
            this.picOptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptClose.TabIndex = 6;
            this.picOptClose.TabStop = false;
            this.picOptClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOptClose_MouseClick);
            // 
            // cbbTitle
            // 
            this.cbbTitle.FormattingEnabled = true;
            this.cbbTitle.Location = new System.Drawing.Point(9, 93);
            this.cbbTitle.Margin = new System.Windows.Forms.Padding(2);
            this.cbbTitle.Name = "cbbTitle";
            this.cbbTitle.Size = new System.Drawing.Size(134, 21);
            this.cbbTitle.TabIndex = 2;
            // 
            // cbbCat
            // 
            this.cbbCat.FormattingEnabled = true;
            this.cbbCat.Location = new System.Drawing.Point(143, 93);
            this.cbbCat.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCat.Name = "cbbCat";
            this.cbbCat.Size = new System.Drawing.Size(94, 21);
            this.cbbCat.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 38);
            this.Controls.Add(this.cbbCat);
            this.Controls.Add(this.cbbTitle);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).EndInit();
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
        private System.Windows.Forms.PictureBox picOptOpen;
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
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRun;
        private System.Windows.Forms.ComboBox cbbTitle;
        private System.Windows.Forms.ComboBox cbbCat;
    }
}

