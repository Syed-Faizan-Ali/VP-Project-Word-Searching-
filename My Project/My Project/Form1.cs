using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace My_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            txtData.Text = "";
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.InitialDirectory = "c:\\";
            FileDialog.Filter="Text Files (*.txt)|*.txt";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = FileDialog.FileName;
                txtFileName.Text = fileName;
                try
                {
                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line =  sr.ReadLine();

                        while(line != null)
                        {
                            txtData.Text += line;
                            line = sr.ReadLine();
                        }

                            sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    txtData.Text = "Could not read the file";
                }
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtData.SelectAll();
            txtData.SelectionBackColor = Color.White;

            if (rbLinearSearch.Checked)
            {
                int index = 0;
                string data = txtData.Text;
                string[] words = data.Split();
                foreach (string word in words)
                {
                    if (word == txtSearchText.Text)
                    {
                        txtData.Find(txtSearchText.Text, index, txtData.TextLength, RichTextBoxFinds.None);
                        txtData.SelectionBackColor = Color.Yellow;
                        index = txtData.Text.IndexOf(txtSearchText.Text, index) + 1;
                    }
                }
            }

            if (rbBinarySearch.Checked)
            {
                int index = 0;
                string data = txtData.Text;
                string[] words = data.Split();
                int ind = Array.BinarySearch(words, txtSearchText.Text);
                {
                    txtData.Find(txtSearchText.Text, index, txtData.TextLength, RichTextBoxFinds.None);
                    txtData.SelectionBackColor = Color.Yellow;
                    index = txtData.Text.IndexOf(txtSearchText.Text, index) + 1;
                }

            }
        }
    }
}
