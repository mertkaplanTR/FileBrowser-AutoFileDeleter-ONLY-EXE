﻿namespace FileManagerPro.App
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxSourceDirectory = new System.Windows.Forms.TextBox();
            this.txtBoxDestinationDirectory = new System.Windows.Forms.TextBox();
            this.btnLetsZipThis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBoxSourceDirectory
            // 
            this.txtBoxSourceDirectory.Location = new System.Drawing.Point(24, 57);
            this.txtBoxSourceDirectory.Name = "txtBoxSourceDirectory";
            this.txtBoxSourceDirectory.Size = new System.Drawing.Size(234, 20);
            this.txtBoxSourceDirectory.TabIndex = 1;
            // 
            // txtBoxDestinationDirectory
            // 
            this.txtBoxDestinationDirectory.Location = new System.Drawing.Point(348, 56);
            this.txtBoxDestinationDirectory.Name = "txtBoxDestinationDirectory";
            this.txtBoxDestinationDirectory.Size = new System.Drawing.Size(241, 20);
            this.txtBoxDestinationDirectory.TabIndex = 2;
            // 
            // btnLetsZipThis
            // 
            this.btnLetsZipThis.Location = new System.Drawing.Point(487, 105);
            this.btnLetsZipThis.Name = "btnLetsZipThis";
            this.btnLetsZipThis.Size = new System.Drawing.Size(75, 23);
            this.btnLetsZipThis.TabIndex = 3;
            this.btnLetsZipThis.Text = "button1";
            this.btnLetsZipThis.UseVisualStyleBackColor = true;
            this.btnLetsZipThis.Click += new System.EventHandler(this.btnLetsZipThis_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 324);
            this.Controls.Add(this.btnLetsZipThis);
            this.Controls.Add(this.txtBoxDestinationDirectory);
            this.Controls.Add(this.txtBoxSourceDirectory);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBoxSourceDirectory;
        private System.Windows.Forms.TextBox txtBoxDestinationDirectory;
        private System.Windows.Forms.Button btnLetsZipThis;
    }
}