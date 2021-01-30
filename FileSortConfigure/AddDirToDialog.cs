using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FileSortConfigure
{
    public partial class AddDirToDialog : Form
    {

        public string Path;
        public string Reg;

        public AddDirToDialog(string _Path = "", string _Reg = "")
        {
            InitializeComponent();

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 7000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;

            toolTip1.SetToolTip(this.PathBox, "Укажите путь куда будут складываться файлы");
            toolTip1.SetToolTip(this.RegBox, "Задайте регулярное выражение.\nНапример если вам нужно собарть музыкальные файлы\nможно использовать подобное:\n.+(mp3|wav)");
            Path = _Path;
            Reg = _Reg;
            PathBox.Text = Path;
            RegBox.Text = Reg;
            if (_Path == "" && _Reg == "")
            {
                AddOrEditButton.Text = "Добавить";
                DelButton.Visible = false;
            }
            else
            {
                AddOrEditButton.Text = "Редактировать";
                DelButton.Visible = true;
            }
        }

        private void AddOrEdit_Click(object sender, EventArgs e)
        {
            Path = PathBox.Text;
            Reg = RegBox.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }

        private void RegBox_Click(object sender, EventArgs e)
        {
            var fldrDlg = new FolderBrowserDialog();
            if (fldrDlg.ShowDialog() == DialogResult.OK)
            {
                PathBox.Text = fldrDlg.SelectedPath;
            }
            RegBox.Focus();
        }

        private void RegBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddOrEditButton.Focus();
        }

        private void RegBox_TextChanged(object sender, EventArgs e)
        {
            TestName.Visible = RegBox.TextLength != 0;
            TestNameBox.Visible = RegBox.TextLength != 0;
            IndicatorName.Visible = RegBox.TextLength != 0;

            try
            {
                if (TestNameBox.TextLength != 0 && RegBox.TextLength != 0)
                    if (Regex.IsMatch(TestNameBox.Text, RegBox.Text))
                        IndicatorName.BackColor = Color.Green;
                    else IndicatorName.BackColor = Color.Red;
            }
            catch { }


        }

        private void TestNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.IsMatch(TestNameBox.Text, RegBox.Text))
                    IndicatorName.BackColor = Color.Green;
                else IndicatorName.BackColor = Color.Red;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help help = new Help(false);
            help.Show();
        }
    }
}
