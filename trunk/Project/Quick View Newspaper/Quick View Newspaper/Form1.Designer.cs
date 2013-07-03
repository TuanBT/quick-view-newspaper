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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbbNewsName = new System.Windows.Forms.ComboBox();
            this.cbbCatName = new System.Windows.Forms.ComboBox();
            this.picOptOpen = new System.Windows.Forms.PictureBox();
            this.pnlRun = new System.Windows.Forms.Panel();
            this.lblNoti = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudOpacity = new System.Windows.Forms.NumericUpDown();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblOpacity = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.picOptClose = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).BeginInit();
            this.pnlRun.SuspendLayout();
            this.pnlOption.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.cbbNewsName);
            this.pnlMain.Controls.Add(this.cbbCatName);
            this.pnlMain.Controls.Add(this.picOptOpen);
            this.pnlMain.Controls.Add(this.pnlRun);
            this.pnlMain.Controls.Add(this.lblCat);
            this.pnlMain.Controls.Add(this.lblTitle);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(856, 25);
            this.pnlMain.TabIndex = 0;
            // 
            // cbbNewsName
            // 
            this.cbbNewsName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbNewsName.FormattingEnabled = true;
            this.cbbNewsName.Location = new System.Drawing.Point(0, 0);
            this.cbbNewsName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNewsName.Name = "cbbNewsName";
            this.cbbNewsName.Size = new System.Drawing.Size(135, 21);
            this.cbbNewsName.TabIndex = 2;
            this.cbbNewsName.Visible = false;
            this.cbbNewsName.SelectedIndexChanged += new System.EventHandler(this.cbbNewsName_SelectedIndexChanged);
            // 
            // cbbCatName
            // 
            this.cbbCatName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbbCatName.FormattingEnabled = true;
            this.cbbCatName.Location = new System.Drawing.Point(134, 0);
            this.cbbCatName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbCatName.Name = "cbbCatName";
            this.cbbCatName.Size = new System.Drawing.Size(95, 21);
            this.cbbCatName.TabIndex = 3;
            this.cbbCatName.Visible = false;
            this.cbbCatName.SelectedIndexChanged += new System.EventHandler(this.cbbCatName_SelectedIndexChanged);
            // 
            // picOptOpen
            // 
            this.picOptOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.picOptOpen.Image = ((System.Drawing.Image)(resources.GetObject("picOptOpen.Image")));
            this.picOptOpen.Location = new System.Drawing.Point(810, 0);
            this.picOptOpen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOptOpen.Name = "picOptOpen";
            this.picOptOpen.Size = new System.Drawing.Size(44, 23);
            this.picOptOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptOpen.TabIndex = 5;
            this.picOptOpen.TabStop = false;
            this.picOptOpen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOptOpen_MouseClick);
            // 
            // pnlRun
            // 
            this.pnlRun.Controls.Add(this.lblNoti);
            this.pnlRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRun.Location = new System.Drawing.Point(228, 0);
            this.pnlRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlRun.Name = "pnlRun";
            this.pnlRun.Size = new System.Drawing.Size(626, 23);
            this.pnlRun.TabIndex = 3;
            // 
            // lblNoti
            // 
            this.lblNoti.BackColor = System.Drawing.Color.Blue;
            this.lblNoti.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoti.ForeColor = System.Drawing.Color.Yellow;
            this.lblNoti.Location = new System.Drawing.Point(0, 0);
            this.lblNoti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoti.Name = "lblNoti";
            this.lblNoti.Size = new System.Drawing.Size(146, 23);
            this.lblNoti.TabIndex = 0;
            this.lblNoti.Text = "Đang nạp dữ liệu";
            this.lblNoti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNoti.Visible = false;
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
            // 
            // pnlOption
            // 
            this.pnlOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOption.Controls.Add(this.btnReset);
            this.pnlOption.Controls.Add(this.nudOpacity);
            this.pnlOption.Controls.Add(this.nudSpeed);
            this.pnlOption.Controls.Add(this.nudSize);
            this.pnlOption.Controls.Add(this.lblOpacity);
            this.pnlOption.Controls.Add(this.lblSpeed);
            this.pnlOption.Controls.Add(this.lblSize);
            this.pnlOption.Controls.Add(this.picOptClose);
            this.pnlOption.Location = new System.Drawing.Point(0, 28);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(856, 25);
            this.pnlOption.TabIndex = 1;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(400, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(56, 24);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nudOpacity
            // 
            this.nudOpacity.Location = new System.Drawing.Point(342, 4);
            this.nudOpacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.nudSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSpeed.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(38, 20);
            this.nudSpeed.TabIndex = 12;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // nudSize
            // 
            this.nudSize.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSize.Location = new System.Drawing.Point(110, 3);
            this.nudSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudSize.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(38, 20);
            this.nudSize.TabIndex = 11;
            this.nudSize.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // lblOpacity
            // 
            this.lblOpacity.AutoSize = true;
            this.lblOpacity.Location = new System.Drawing.Point(276, 5);
            this.lblOpacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpacity.Name = "lblOpacity";
            this.lblOpacity.Size = new System.Drawing.Size(61, 13);
            this.lblOpacity.TabIndex = 9;
            this.lblOpacity.Text = "Trong suốt:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(163, 5);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(42, 13);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Tốc độ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(62, 3);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(44, 13);
            this.lblSize.TabIndex = 7;
            this.lblSize.Text = "Cỡ chữ:";
            // 
            // picOptClose
            // 
            this.picOptClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picOptClose.Image = ((System.Drawing.Image)(resources.GetObject("picOptClose.Image")));
            this.picOptClose.Location = new System.Drawing.Point(0, 0);
            this.picOptClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picOptClose.Name = "picOptClose";
            this.picOptClose.Size = new System.Drawing.Size(46, 23);
            this.picOptClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptClose.TabIndex = 6;
            this.picOptClose.TabStop = false;
            this.picOptClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOptClose_MouseClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "QuickViewNewspaper";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 27);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOptOpen)).EndInit();
            this.pnlRun.ResumeLayout(false);
            this.pnlOption.ResumeLayout(false);
            this.pnlOption.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nudOpacity;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblOpacity;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox picOptClose;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlRun;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbbNewsName;
        private System.Windows.Forms.ComboBox cbbCatName;
        private System.Windows.Forms.Label lblNoti;
        private System.Windows.Forms.Button btnReset;
    }
}

