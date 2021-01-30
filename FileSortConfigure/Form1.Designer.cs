namespace FileSortConfigure
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DirFromText = new System.Windows.Forms.Label();
            this.DirTo = new System.Windows.Forms.ListBox();
            this.DirToText = new System.Windows.Forms.Label();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Help = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.AddDirFrom = new System.Windows.Forms.Button();
            this.AddDirTo = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.DirFrom = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DirFromText
            // 
            this.DirFromText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirFromText.AutoSize = true;
            this.DirFromText.Location = new System.Drawing.Point(3, 0);
            this.DirFromText.Name = "DirFromText";
            this.DirFromText.Size = new System.Drawing.Size(335, 13);
            this.DirFromText.TabIndex = 3;
            this.DirFromText.Text = "Директории из которых брать файлы:";
            // 
            // DirTo
            // 
            this.DirTo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirTo.FormattingEnabled = true;
            this.DirTo.Location = new System.Drawing.Point(344, 23);
            this.DirTo.MinimumSize = new System.Drawing.Size(400, 351);
            this.DirTo.Name = "DirTo";
            this.DirTo.Size = new System.Drawing.Size(460, 364);
            this.DirTo.TabIndex = 4;
            this.DirTo.Click += new System.EventHandler(this.DirTo_Click);
            // 
            // DirToText
            // 
            this.DirToText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirToText.AutoSize = true;
            this.DirToText.Location = new System.Drawing.Point(344, 0);
            this.DirToText.Name = "DirToText";
            this.DirToText.Size = new System.Drawing.Size(460, 13);
            this.DirToText.TabIndex = 3;
            this.DirToText.Text = "Директории в которые складывать файлы:";
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(138, 7);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(85, 17);
            this.AutoStart.TabIndex = 7;
            this.AutoStart.Text = "Автозапуск";
            this.AutoStart.UseVisualStyleBackColor = true;
            this.AutoStart.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Transparent;
            this.Help.BackgroundImage = global::FileSortConfigure.Properties.Resources.Help_icon_icons_com_55891;
            this.Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Help.FlatAppearance.BorderSize = 0;
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Help.Location = new System.Drawing.Point(91, 1);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(27, 23);
            this.Help.TabIndex = 10;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.Transparent;
            this.Open.BackgroundImage = global::FileSortConfigure.Properties.Resources.open;
            this.Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Location = new System.Drawing.Point(12, 1);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(28, 23);
            this.Open.TabIndex = 9;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.BackgroundImage = global::FileSortConfigure.Properties.Resources.User_Interface_Save_As_icon;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(46, 1);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(28, 23);
            this.Save.TabIndex = 8;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // AddDirFrom
            // 
            this.AddDirFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDirFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDirFrom.Location = new System.Drawing.Point(3, 396);
            this.AddDirFrom.Name = "AddDirFrom";
            this.AddDirFrom.Size = new System.Drawing.Size(335, 29);
            this.AddDirFrom.TabIndex = 11;
            this.AddDirFrom.Text = "+";
            this.AddDirFrom.UseVisualStyleBackColor = true;
            this.AddDirFrom.Click += new System.EventHandler(this.AddDirFrom_Click);
            // 
            // AddDirTo
            // 
            this.AddDirTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDirTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDirTo.Location = new System.Drawing.Point(344, 396);
            this.AddDirTo.Name = "AddDirTo";
            this.AddDirTo.Size = new System.Drawing.Size(460, 29);
            this.AddDirTo.TabIndex = 12;
            this.AddDirTo.Text = "+";
            this.AddDirTo.UseVisualStyleBackColor = true;
            this.AddDirTo.Click += new System.EventHandler(this.AddDirTo_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 470);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // DirFrom
            // 
            this.DirFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirFrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirFrom.FormattingEnabled = true;
            this.DirFrom.Location = new System.Drawing.Point(3, 23);
            this.DirFrom.MinimumSize = new System.Drawing.Size(335, 351);
            this.DirFrom.Name = "DirFrom";
            this.DirFrom.Size = new System.Drawing.Size(335, 364);
            this.DirFrom.TabIndex = 2;
            this.DirFrom.Click += new System.EventHandler(this.DirFrom_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.25527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.74473F));
            this.tableLayoutPanel1.Controls.Add(this.AddDirTo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.AddDirFrom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DirTo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DirFrom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DirToText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DirFromText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 428);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 470);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AutoStart);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(844, 490);
            this.Name = "Form1";
            this.Text = "Сортировка файлов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label DirFromText;
        private System.Windows.Forms.ListBox DirTo;
        private System.Windows.Forms.Label DirToText;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button AddDirFrom;
        private System.Windows.Forms.Button AddDirTo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListBox DirFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

