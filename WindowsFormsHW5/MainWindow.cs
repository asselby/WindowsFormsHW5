using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHW5
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            using (StreamWriter write = new StreamWriter(File.Create(filename)))
            {
                write.WriteLine(nameBox.Text);
                write.WriteLine(surnameBox.Text);
                write.WriteLine(patronymicBox.Text);
                write.WriteLine(sexBox.Text);
                write.WriteLine(dateBox.Text);
                write.WriteLine(statusBox.Text);
                write.WriteLine(extraBox.Text);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
           if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            using (StreamReader read = new StreamReader(File.OpenRead(filename)))
            {
                nameBox.Text=read.ReadLine();
                surnameBox.Text = read.ReadLine();
                patronymicBox.Text = read.ReadLine();
                sexBox.Text = read.ReadLine();
                dateBox.Text = read.ReadLine();
                statusBox.Text = read.ReadLine();
                extraBox.Text = read.ReadLine();
                MessageBox.Show("Файл открыт");
            }
        }
    }
}
