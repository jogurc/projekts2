﻿namespace Personalitates_tests_2
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.labelJautSkaits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butJā = new System.Windows.Forms.Button();
            this.butNē = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelJautSkaits
            // 
            this.labelJautSkaits.AutoSize = true;
            this.labelJautSkaits.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelJautSkaits.Font = new System.Drawing.Font("Humnst777 TL", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJautSkaits.Location = new System.Drawing.Point(1026, 65);
            this.labelJautSkaits.Name = "labelJautSkaits";
            this.labelJautSkaits.Size = new System.Drawing.Size(205, 23);
            this.labelJautSkaits.TabIndex = 9;
            this.labelJautSkaits.Text = "9. no 12 jautājumiem";
            this.labelJautSkaits.Click += new System.EventHandler(this.labelJautSkaits_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Naskh Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 132);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jautājums";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butJā
            // 
            this.butJā.BackColor = System.Drawing.SystemColors.Control;
            this.butJā.Location = new System.Drawing.Point(348, 749);
            this.butJā.Name = "butJā";
            this.butJā.Size = new System.Drawing.Size(172, 67);
            this.butJā.TabIndex = 13;
            this.butJā.Text = "Jā";
            this.butJā.UseVisualStyleBackColor = false;
            this.butJā.Click += new System.EventHandler(this.butJā_Click);
            // 
            // butNē
            // 
            this.butNē.BackColor = System.Drawing.SystemColors.Control;
            this.butNē.Location = new System.Drawing.Point(801, 749);
            this.butNē.Name = "butNē";
            this.butNē.Size = new System.Drawing.Size(172, 67);
            this.butNē.TabIndex = 14;
            this.butNē.Text = "Nē";
            this.butNē.UseVisualStyleBackColor = false;
            this.butNē.Click += new System.EventHandler(this.butNē_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 404);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butNē);
            this.Controls.Add(this.butJā);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJautSkaits);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelJautSkaits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butJā;
        private System.Windows.Forms.Button butNē;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}