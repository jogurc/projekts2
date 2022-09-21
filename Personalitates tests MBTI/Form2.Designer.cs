namespace Personalitates_tests_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.labelJautSkaits.Location = new System.Drawing.Point(1025, 78);
            this.labelJautSkaits.Name = "labelJautSkaits";
            this.labelJautSkaits.Size = new System.Drawing.Size(205, 23);
            this.labelJautSkaits.TabIndex = 0;
            this.labelJautSkaits.Text = "1. no 12 jautājumiem";
            this.labelJautSkaits.Click += new System.EventHandler(this.labelJautSkaits_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Noto Naskh Arabic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jautājums";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // butJā
            // 
            this.butJā.BackColor = System.Drawing.SystemColors.Control;
            this.butJā.Location = new System.Drawing.Point(346, 746);
            this.butJā.Name = "butJā";
            this.butJā.Size = new System.Drawing.Size(172, 67);
            this.butJā.TabIndex = 3;
            this.butJā.Text = "Jā";
            this.butJā.UseVisualStyleBackColor = false;
            this.butJā.Click += new System.EventHandler(this.butJā_Click);
            // 
            // butNē
            // 
            this.butNē.BackColor = System.Drawing.SystemColors.Control;
            this.butNē.Location = new System.Drawing.Point(809, 746);
            this.butNē.Name = "butNē";
            this.butNē.Size = new System.Drawing.Size(172, 67);
            this.butNē.TabIndex = 4;
            this.butNē.Text = "Nē";
            this.butNē.UseVisualStyleBackColor = false;
            this.butNē.Click += new System.EventHandler(this.butNē_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 501);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1284, 861);
            this.Controls.Add(this.butNē);
            this.Controls.Add(this.butJā);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelJautSkaits);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = " ";
            this.Load += new System.EventHandler(this.butJa_Load);
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