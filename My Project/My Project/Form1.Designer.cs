﻿namespace My_Project
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
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbBinarySearch = new System.Windows.Forms.RadioButton();
            this.rbLinearSearch = new System.Windows.Forms.RadioButton();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.RichTextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.BackColor = System.Drawing.Color.Turquoise;
            this.radioButton5.Location = new System.Drawing.Point(509, 253);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.Turquoise;
            this.radioButton4.Location = new System.Drawing.Point(509, 214);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(109, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ANOTHER TYPE";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Turquoise;
            this.radioButton3.Location = new System.Drawing.Point(509, 179);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3RD SEARCH";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // rbBinarySearch
            // 
            this.rbBinarySearch.AutoSize = true;
            this.rbBinarySearch.BackColor = System.Drawing.Color.Turquoise;
            this.rbBinarySearch.Location = new System.Drawing.Point(509, 140);
            this.rbBinarySearch.Name = "rbBinarySearch";
            this.rbBinarySearch.Size = new System.Drawing.Size(112, 17);
            this.rbBinarySearch.TabIndex = 16;
            this.rbBinarySearch.TabStop = true;
            this.rbBinarySearch.Text = "BINARY SEARCH";
            this.rbBinarySearch.UseVisualStyleBackColor = false;
            // 
            // rbLinearSearch
            // 
            this.rbLinearSearch.AutoSize = true;
            this.rbLinearSearch.BackColor = System.Drawing.Color.Turquoise;
            this.rbLinearSearch.Location = new System.Drawing.Point(509, 106);
            this.rbLinearSearch.Name = "rbLinearSearch";
            this.rbLinearSearch.Size = new System.Drawing.Size(111, 17);
            this.rbLinearSearch.TabIndex = 15;
            this.rbLinearSearch.TabStop = true;
            this.rbLinearSearch.Text = "LINEAR SEARCH";
            this.rbLinearSearch.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBrowse.Location = new System.Drawing.Point(381, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse file";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(365, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.BackColor = System.Drawing.Color.White;
            this.txtSearchResult.Location = new System.Drawing.Point(77, 355);
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.Size = new System.Drawing.Size(272, 20);
            this.txtSearchResult.TabIndex = 12;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Location = new System.Drawing.Point(35, 80);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(435, 246);
            this.txtData.TabIndex = 11;
            this.txtData.Text = "";
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.Location = new System.Drawing.Point(77, 32);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(294, 20);
            this.txtFileName.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 404);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.rbBinarySearch);
            this.Controls.Add(this.rbLinearSearch);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchResult);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbBinarySearch;
        private System.Windows.Forms.RadioButton rbLinearSearch;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.RichTextBox txtData;
        private System.Windows.Forms.TextBox txtFileName;
    }
}

