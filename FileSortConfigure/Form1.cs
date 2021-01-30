using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using IWshRuntimeLibrary;

namespace FileSortConfigure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 7000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            toolTip1.SetToolTip(this.Open, "Импортировать конфиг");
            toolTip1.SetToolTip(this.Save, "Сохранить конфиг");

            toolTip1.SetToolTip(this.DirFromText, "Поиск файлов будет проводиться только в выбраных каталогах (Файлы из подкаталогов не расматриваются)");
            toolTip1.SetToolTip(this.DirToText, "Файлы для переноса определяются по регулярным выражениям и складываются в соответствующие папки");
            toolTip1.SetToolTip(this.AutoStart, "Сортировка будет выполнена при запуске OC");

            openFileDialog1.Filter = "Config (*.cfg)|*.cfg|All files(*.*)|*.*";
            openFileDialog1.FileName = "main";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            openFileDialog2.Filter = "Sorter (*.py)|*.py|All files(*.*)|*.*";
            openFileDialog2.FileName = "FileSort";
            openFileDialog2.InitialDirectory = Environment.CurrentDirectory;

            saveFileDialog1.Filter = "Config (*.cfg)|*.cfg|All files(*.*)|*.*";
            saveFileDialog1.FileName = "main";
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\").GetValue("FileSort") != null)
                AutoStart.Checked = true;
        }

        private void SaveCFG(string WritePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(WritePath, false, System.Text.Encoding.GetEncoding(1251)))
                {
                    sw.WriteLine("[DirTo]");
                    for (int i = 0; i < DirTo.Items.Count; i++)
                    {
                        string[] tmp = DirTo.Items[i].ToString().Split(';');
                        sw.WriteLine("Path=" + tmp[0]);
                        sw.WriteLine("Reg=" + tmp[1]);
                    }
                    sw.WriteLine("[DirFrom]");
                    for (int i = 0; i < DirFrom.Items.Count; i++)
                        sw.WriteLine(DirFrom.Items[i].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }

        private void LoadCFG(string LoadPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(LoadPath, System.Text.Encoding.GetEncoding(1251)))
                {
                    char switcher = ' ';
                    string line = "";
                    string tmp = "";
                    while ((line = sr.ReadLine()) != null) 
                    {
                        if (switcher == 'T' && line.Contains("Path=")) 
                            tmp = line.Substring(5);
                        if (switcher == 'T' && line.Contains("Reg=") && !DirTo.Items.Contains(tmp+";"+line.Substring(4))) 
                            DirTo.Items.Add(tmp+";"+line.Substring(4));
                        if (switcher == 'F' && !DirFrom.Items.Contains(line))
                            DirFrom.Items.Add(line);

                        if (line.Contains("[DirTo]"))
                            switcher = 'T';
                        if (line.Contains("[DirFrom]"))
                            switcher = 'F';
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                LoadCFG(openFileDialog1.FileName);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                SaveCFG(saveFileDialog1.FileName);
        }

        // Справка
        private void Help_Click(object sender, EventArgs e)
        {
            Help help = new Help(true);
            help.Show();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            string Path = Environment.CurrentDirectory + "\\save.BAK";
            if (System.IO.File.Exists(Path))
                LoadCFG(Path);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверенны что хотите выйти?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
            SaveCFG(Environment.CurrentDirectory + "\\save.BAK");
        }

        // По хорошему было бы вынести это в отдельные сущности(DirFrom и DirTo), но тогда они будут занимать в 2 раза больш
        // (Возможно это не столь важно). Вобщем было принято рещение что лучше сделать так(хранить данные в интерфейсе)
        // но я понимаю что лучше так не делать.

        // Добавление элементов
        private void AddDirFrom_Click(object sender, EventArgs e)
        {
            var fldrDlg = new FolderBrowserDialog();
            if (fldrDlg.ShowDialog() == DialogResult.OK)
            {
                string Path = fldrDlg.SelectedPath.Replace('\\', '/');
                if (!DirFrom.Items.Contains(Path))
                    DirFrom.Items.Add(Path);
                else MessageBox.Show("Данный элемент уже присутствует в списке", "Хмм");
            }
        }

        private void AddDirTo_Click(object sender, EventArgs e)
        {
            AddDirToDialog ADTD;
            ADTD = new AddDirToDialog();
            if (ADTD.ShowDialog() != DialogResult.Cancel)
            {
                ADTD.Path = ADTD.Path.Replace('\\', '/');
                if (!DirTo.Items.Contains(ADTD.Path + ";" + ADTD.Reg))
                    DirTo.Items.Add(ADTD.Path + ";" + ADTD.Reg);
                else MessageBox.Show("Данный элемент уже присутствует в списке", "Хмм");
            }
        }

        // Изменение/удаление элементов
        private void DirFrom_Click(object sender, EventArgs e)
        {
            if (DirFrom.SelectedIndex != -1)
            {
                if (MessageBox.Show("Вы уверенны что хотите удалить этот элемент?", "Уверенны?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    DirFrom.Items.RemoveAt(DirFrom.SelectedIndex);
            }
            DirFrom.SelectedIndex = -1;
        }

        private void DirTo_Click(object sender, EventArgs e)
        { 
            if (DirTo.SelectedIndex != -1)
            {
                AddDirToDialog ADTD;
                string[] PathAndReg = DirTo.Items[DirTo.SelectedIndex].ToString().Split(';');
                ADTD = new AddDirToDialog(PathAndReg[0], PathAndReg[1]);
                int Index = DirTo.SelectedIndex;
                DialogResult Rez = ADTD.ShowDialog();
                if (Rez == DialogResult.No)
                    DirTo.Items.RemoveAt(Index);
                else if (Rez != DialogResult.Cancel)
                {
                    ADTD.Path = ADTD.Path.Replace('\\', '/');
                    if (!DirTo.Items.Contains(ADTD.Path + ";" + ADTD.Reg))
                        DirTo.Items[Index] = ADTD.Path + ";" + ADTD.Reg;
                    else MessageBox.Show("Данный элемент уже присутствует в списке", "Хмм");
                }
            }
            DirTo.SelectedIndex = -1;
        }

        // Добавление в автозапуск
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
                Microsoft.Win32.RegistryKey Key =   
    Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run",true);  

            if (AutoStart.Checked)
            {
                DialogResult Dial = DialogResult.OK;
                string FileSortPyPath = Environment.CurrentDirectory + "\\FileSort.py";
                if (!System.IO.File.Exists(FileSortPyPath))
                {
                    Dial =  openFileDialog2.ShowDialog();
                    FileSortPyPath = openFileDialog2.FileName;
                }
                if (Dial != DialogResult.Cancel)
                    Key.SetValue("FileSort", FileSortPyPath);
                else AutoStart.Checked = false;
                Key.Close();  
            }
            else
            {
                Key.DeleteValue("FileSort", false);  
                Key.Close();  
            }
        }

    }
}
