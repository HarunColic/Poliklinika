﻿
namespace PoliklinikaDesktop.Forms.Doktor
{
    partial class frmDetaljiDoktor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubSecijal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpecijal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBrRadneKnjiz = new System.Windows.Forms.TextBox();
            this.cmbOdjel = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(26, 121);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(334, 23);
            this.txtIme.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.AutoSize = true;
            this.Prezime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prezime.Location = new System.Drawing.Point(26, 158);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(62, 20);
            this.Prezime.TabIndex = 4;
            this.Prezime.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(26, 181);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(334, 23);
            this.txtPrezime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SubSpecijalizacija";
            // 
            // txtSubSecijal
            // 
            this.txtSubSecijal.Location = new System.Drawing.Point(26, 296);
            this.txtSubSecijal.Name = "txtSubSecijal";
            this.txtSubSecijal.Size = new System.Drawing.Size(334, 23);
            this.txtSubSecijal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Specijalizacija";
            // 
            // txtSpecijal
            // 
            this.txtSpecijal.Location = new System.Drawing.Point(26, 238);
            this.txtSpecijal.Name = "txtSpecijal";
            this.txtSpecijal.Size = new System.Drawing.Size(334, 23);
            this.txtSpecijal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Odjel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Broj radne knjižice";
            // 
            // txtBrRadneKnjiz
            // 
            this.txtBrRadneKnjiz.Location = new System.Drawing.Point(26, 351);
            this.txtBrRadneKnjiz.Name = "txtBrRadneKnjiz";
            this.txtBrRadneKnjiz.Size = new System.Drawing.Size(334, 23);
            this.txtBrRadneKnjiz.TabIndex = 9;
            // 
            // cmbOdjel
            // 
            this.cmbOdjel.FormattingEnabled = true;
            this.cmbOdjel.Location = new System.Drawing.Point(26, 402);
            this.cmbOdjel.Name = "cmbOdjel";
            this.cmbOdjel.Size = new System.Drawing.Size(334, 23);
            this.cmbOdjel.TabIndex = 13;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(442, 238);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(124, 42);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // frmDetaljiDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbOdjel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBrRadneKnjiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubSecijal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpecijal);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDetaljiDoktor";
            this.Text = "frmDetaljiDoktor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubSecijal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpecijal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBrRadneKnjiz;
        private System.Windows.Forms.ComboBox cmbOdjel;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}