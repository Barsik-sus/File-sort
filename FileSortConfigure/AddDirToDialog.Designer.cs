namespace FileSortConfigure
{
    partial class AddDirToDialog
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
            this.AddOrEditButton = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DelButton = new System.Windows.Forms.Button();
            this.TestNameBox = new System.Windows.Forms.TextBox();
            this.IndicatorName = new System.Windows.Forms.PictureBox();
            this.TestName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorName)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrEditButton
            // 
            this.AddOrEditButton.Location = new System.Drawing.Point(17, 153);
            this.AddOrEditButton.Name = "AddOrEditButton";
            this.AddOrEditButton.Size = new System.Drawing.Size(152, 23);
            this.AddOrEditButton.TabIndex = 0;
            this.AddOrEditButton.Text = "Добавить";
            this.AddOrEditButton.UseVisualStyleBackColor = true;
            this.AddOrEditButton.Click += new System.EventHandler(this.AddOrEdit_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(17, 27);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(313, 20);
            this.PathBox.TabIndex = 1;
            this.PathBox.Click += new System.EventHandler(this.RegBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Путь:";
            // 
            // RegBox
            // 
            this.RegBox.Location = new System.Drawing.Point(17, 76);
            this.RegBox.Name = "RegBox";
            this.RegBox.Size = new System.Drawing.Size(290, 20);
            this.RegBox.TabIndex = 1;
            this.RegBox.TextChanged += new System.EventHandler(this.RegBox_TextChanged);
            this.RegBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RegBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Регулярное выражение:";
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(178, 153);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(152, 23);
            this.DelButton.TabIndex = 0;
            this.DelButton.Text = "Удалить";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Visible = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // TestNameBox
            // 
            this.TestNameBox.BackColor = System.Drawing.Color.White;
            this.TestNameBox.Location = new System.Drawing.Point(17, 118);
            this.TestNameBox.Name = "TestNameBox";
            this.TestNameBox.Size = new System.Drawing.Size(290, 20);
            this.TestNameBox.TabIndex = 4;
            this.TestNameBox.Visible = false;
            this.TestNameBox.TextChanged += new System.EventHandler(this.TestNameBox_TextChanged);
            // 
            // IndicatorName
            // 
            this.IndicatorName.BackColor = System.Drawing.Color.Transparent;
            this.IndicatorName.Location = new System.Drawing.Point(313, 118);
            this.IndicatorName.Name = "IndicatorName";
            this.IndicatorName.Size = new System.Drawing.Size(17, 20);
            this.IndicatorName.TabIndex = 5;
            this.IndicatorName.TabStop = false;
            this.IndicatorName.Visible = false;
            // 
            // TestName
            // 
            this.TestName.AutoSize = true;
            this.TestName.Location = new System.Drawing.Point(14, 102);
            this.TestName.Name = "TestName";
            this.TestName.Size = new System.Drawing.Size(150, 13);
            this.TestName.TabIndex = 6;
            this.TestName.Text = "Название файла (тестовое):";
            this.TestName.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(308, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 7;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDirToDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(350, 195);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TestName);
            this.Controls.Add(this.IndicatorName);
            this.Controls.Add(this.TestNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBox);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.AddOrEditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddDirToDialog";
            this.Text = "Параметры склада";
            ((System.ComponentModel.ISupportInitialize)(this.IndicatorName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrEditButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.TextBox TestNameBox;
        private System.Windows.Forms.PictureBox IndicatorName;
        private System.Windows.Forms.Label TestName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}