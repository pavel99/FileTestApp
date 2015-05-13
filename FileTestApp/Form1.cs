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

namespace FileTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path = @"E:\Pavel\29.05.15\FileTestApp\FileTestApp\info.txt";

        private void saveButton_Click(object sender, EventArgs e)
        {
            //string path = @"E:\Pavel\29.05.15\FileTestApp\FileTestApp\info.txt";
            FileStream aStream =new FileStream(path,FileMode.Append);
            StreamWriter aStreamWriter=new StreamWriter(aStream);
            aStreamWriter.WriteLine(inputNameTextBox.Text);
            aStreamWriter.Close();
            aStream.Close();
            inputNameTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            FileStream afilFileStream = new FileStream(path, FileMode.Open);
            StreamReader aReader=new StreamReader(afilFileStream);
            while(!aReader.EndOfStream)
            {
                string name = aReader.ReadLine();
                showListBox.Items.Add(name);
            }
            aReader.Close();
            afilFileStream.Close();
        }
    }
}
