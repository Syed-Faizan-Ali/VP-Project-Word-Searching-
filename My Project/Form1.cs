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
            if (radioButton3.Checked)
            {
                kmp_search(txtData.Text, txtSearchText.Text);
            }
            if(radioButton4.Checked)
            {
                rabinCarp(txtData.Text, txtSearchText.Text);
            }
        }
  

        private void rbLinearSearch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBinarySearch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        void kmp_search(string P, string T)
        {
            int n = T.Length;
            int m = P.Length;
            int[] pi = computePrefixFunction(P);
            int q = 0;

            for (int i = 1; i <= n; i++)
            {
                while (q > 0 && P[q] != T[i - 1])
                {
                    q = pi[q - 1];
                }
                if (P[q] == T[i - 1]) { q++; }
                if (q == m)
                {
                    MessageBox.Show("Found"); 
                    q = pi[q - 1];
                }
            }
        }

        int[] computePrefixFunction(string P)
        {
            int m = P.Length;
            int[] pi = new int[m];
            int k = 0;
            pi[0] = 0;

            for (int q = 1; q < m; q++)
            {
                while (k > 0 && P[k] != P[q]) { k = pi[k]; }

                if (P[k] == P[q]) { k++; }
                pi[q] = k;
            }
            return pi;
        }  

        void rabinCarp(String A,String B)
        {
            ulong siga = 0;
            ulong sigb = 0;
            ulong Q = 100007;
            ulong D = 256;
            for (int i = 0; i < B.Length; i++)
            {
                siga = (siga * D + (ulong)A[i]) % Q;
                sigb = (sigb * D + (ulong)B[i]) % Q;
            }
            if (siga == sigb)
            {
                MessageBox.Show(string.Format(">>{0}<<{1}", A.Substring(0, B.Length), A.Substring(B.Length)));
                return;
            }
            ulong pow = 1;
            for (int k = 1; k <= B.Length - 1; k++)
                pow = (pow * D) % Q;

            for (int j = 1; j <= A.Length - B.Length; j++)
            {
                siga = (siga + Q - pow * (ulong)A[j - 1] % Q) % Q;
                siga = (siga * D + (ulong)A[j + B.Length - 1]) % Q;
                if (siga == sigb)
                {
                    if (A.Substring(j, B.Length) == B)
                    {
                        MessageBox.Show(string.Format("{0}>>{1}<<{2}", A.Substring(0, j),
                                                                         A.Substring(j, B.Length),
                                                                         A.Substring(j + B.Length)));
                        return;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
