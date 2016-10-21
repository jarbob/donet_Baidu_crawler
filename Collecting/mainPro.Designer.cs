namespace Collecting
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.keywordsListBox = new System.Windows.Forms.ListBox();
            this.outputBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.setupBox = new System.Windows.Forms.GroupBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timeOutTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pageTextBox = new System.Windows.Forms.TextBox();
            this.pageLabel = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.urlListView = new System.Windows.Forms.ListView();
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logBox = new System.Windows.Forms.TextBox();
            this.browerGroupBox = new System.Windows.Forms.GroupBox();
            this.openBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openComboBox = new System.Windows.Forms.ComboBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.controlGroupBox.SuspendLayout();
            this.setupBox.SuspendLayout();
            this.browerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.Controls.Add(this.keywordsListBox);
            this.controlGroupBox.Controls.Add(this.outputBtn);
            this.controlGroupBox.Controls.Add(this.insertBtn);
            this.controlGroupBox.Location = new System.Drawing.Point(7, 3);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(200, 441);
            this.controlGroupBox.TabIndex = 1;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "操作";
            // 
            // keywordsListBox
            // 
            this.keywordsListBox.FormattingEnabled = true;
            this.keywordsListBox.ItemHeight = 12;
            this.keywordsListBox.Location = new System.Drawing.Point(7, 63);
            this.keywordsListBox.Name = "keywordsListBox";
            this.keywordsListBox.Size = new System.Drawing.Size(187, 364);
            this.keywordsListBox.TabIndex = 2;
            // 
            // outputBtn
            // 
            this.outputBtn.Enabled = false;
            this.outputBtn.Location = new System.Drawing.Point(103, 26);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(75, 23);
            this.outputBtn.TabIndex = 1;
            this.outputBtn.Text = "导出";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(6, 28);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(75, 23);
            this.insertBtn.TabIndex = 0;
            this.insertBtn.Text = "导入";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // setupBox
            // 
            this.setupBox.Controls.Add(this.stopBtn);
            this.setupBox.Controls.Add(this.label3);
            this.setupBox.Controls.Add(this.timeOutTextBox);
            this.setupBox.Controls.Add(this.label2);
            this.setupBox.Controls.Add(this.startBtn);
            this.setupBox.Controls.Add(this.label1);
            this.setupBox.Controls.Add(this.pageTextBox);
            this.setupBox.Controls.Add(this.pageLabel);
            this.setupBox.Location = new System.Drawing.Point(14, 451);
            this.setupBox.Name = "setupBox";
            this.setupBox.Size = new System.Drawing.Size(193, 122);
            this.setupBox.TabIndex = 2;
            this.setupBox.TabStop = false;
            this.setupBox.Text = "设置";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(84, 84);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(70, 23);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "停止采集";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "毫秒";
            // 
            // timeOutTextBox
            // 
            this.timeOutTextBox.Location = new System.Drawing.Point(80, 53);
            this.timeOutTextBox.Name = "timeOutTextBox";
            this.timeOutTextBox.Size = new System.Drawing.Size(48, 21);
            this.timeOutTextBox.TabIndex = 5;
            this.timeOutTextBox.Text = "1000";
            this.timeOutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "延时时间:";
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(13, 84);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(66, 23);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "开始采集";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "页";
            // 
            // pageTextBox
            // 
            this.pageTextBox.Location = new System.Drawing.Point(80, 24);
            this.pageTextBox.Name = "pageTextBox";
            this.pageTextBox.Size = new System.Drawing.Size(48, 21);
            this.pageTextBox.TabIndex = 1;
            this.pageTextBox.Text = "1";
            this.pageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(16, 30);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(59, 12);
            this.pageLabel.TabIndex = 0;
            this.pageLabel.Text = "采集页数:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "文本文件|*.txt|所有文件|*.*";
            // 
            // urlListView
            // 
            this.urlListView.AllowDrop = true;
            this.urlListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.url});
            this.urlListView.FullRowSelect = true;
            this.urlListView.Location = new System.Drawing.Point(449, 10);
            this.urlListView.Name = "urlListView";
            this.urlListView.Size = new System.Drawing.Size(695, 531);
            this.urlListView.TabIndex = 3;
            this.urlListView.UseCompatibleStateImageBehavior = false;
            this.urlListView.View = System.Windows.Forms.View.Details;
            // 
            // title
            // 
            this.title.Text = "标题";
            this.title.Width = 300;
            // 
            // url
            // 
            this.url.Text = "链接";
            this.url.Width = 390;
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.logBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logBox.ForeColor = System.Drawing.Color.Red;
            this.logBox.Location = new System.Drawing.Point(214, 13);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(229, 431);
            this.logBox.TabIndex = 4;
            // 
            // browerGroupBox
            // 
            this.browerGroupBox.Controls.Add(this.delBtn);
            this.browerGroupBox.Controls.Add(this.openBtn);
            this.browerGroupBox.Controls.Add(this.label5);
            this.browerGroupBox.Controls.Add(this.label4);
            this.browerGroupBox.Controls.Add(this.openComboBox);
            this.browerGroupBox.Location = new System.Drawing.Point(214, 461);
            this.browerGroupBox.Name = "browerGroupBox";
            this.browerGroupBox.Size = new System.Drawing.Size(229, 103);
            this.browerGroupBox.TabIndex = 5;
            this.browerGroupBox.TabStop = false;
            this.browerGroupBox.Text = "浏览器打开";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(148, 71);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "打开";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "个";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "打开前";
            // 
            // openComboBox
            // 
            this.openComboBox.FormattingEnabled = true;
            this.openComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60"});
            this.openComboBox.Location = new System.Drawing.Point(59, 71);
            this.openComboBox.Name = "openComboBox";
            this.openComboBox.Size = new System.Drawing.Size(51, 20);
            this.openComboBox.TabIndex = 0;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(11, 17);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(208, 45);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "去除重复";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1152, 567);
            this.Controls.Add(this.browerGroupBox);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.urlListView);
            this.Controls.Add(this.setupBox);
            this.Controls.Add(this.controlGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "百度采集器   --By Jarbob";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.controlGroupBox.ResumeLayout(false);
            this.setupBox.ResumeLayout(false);
            this.setupBox.PerformLayout();
            this.browerGroupBox.ResumeLayout(false);
            this.browerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.ListBox keywordsListBox;
        private System.Windows.Forms.Button outputBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.GroupBox setupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pageTextBox;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ListView urlListView;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader url;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeOutTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.GroupBox browerGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox openComboBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button delBtn;

    }
}

