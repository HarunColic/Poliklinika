﻿namespace PoliklinikaDesktop.Forms.Doktor
{
    partial class frmIndexDoktor
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
            this.picNalaz = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picObaveza = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picIzvjestaj = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTrenutniUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNalaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObaveza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // picNalaz
            // 
            this.picNalaz.Image = global::PoliklinikaDesktop.Properties.Resources.nalaz;
            this.picNalaz.Location = new System.Drawing.Point(39, 287);
            this.picNalaz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picNalaz.Name = "picNalaz";
            this.picNalaz.Size = new System.Drawing.Size(240, 287);
            this.picNalaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNalaz.TabIndex = 0;
            this.picNalaz.TabStop = false;
            this.picNalaz.Click += new System.EventHandler(this.picNalaz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izdaj recept/nalaz";
            // 
            // picObaveza
            // 
            this.picObaveza.Image = global::PoliklinikaDesktop.Properties.Resources.obaveze;
            this.picObaveza.Location = new System.Drawing.Point(339, 287);
            this.picObaveza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picObaveza.Name = "picObaveza";
            this.picObaveza.Size = new System.Drawing.Size(240, 287);
            this.picObaveza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picObaveza.TabIndex = 0;
            this.picObaveza.TabStop = false;
            this.picObaveza.Click += new System.EventHandler(this.picObaveza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(349, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pregled obaveza";
            // 
            // picIzvjestaj
            // 
            this.picIzvjestaj.Image = global::PoliklinikaDesktop.Properties.Resources.report2;
            this.picIzvjestaj.Location = new System.Drawing.Point(655, 288);
            this.picIzvjestaj.Name = "picIzvjestaj";
            this.picIzvjestaj.Size = new System.Drawing.Size(240, 286);
            this.picIzvjestaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIzvjestaj.TabIndex = 0;
            this.picIzvjestaj.TabStop = false;
            this.picIzvjestaj.Click += new System.EventHandler(this.picIzvjestaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(687, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 74);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dodaj izvještaj\r\n o pregledu";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PoliklinikaDesktop.Properties.Resources.poslovne3;
            this.pictureBox4.Location = new System.Drawing.Point(958, 288);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(240, 286);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(964, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pregled rasporeda";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox5.Location = new System.Drawing.Point(257, 48);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(691, 184);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // lblTrenutniUser
            // 
            this.lblTrenutniUser.AutoSize = true;
            this.lblTrenutniUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrenutniUser.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTrenutniUser.Location = new System.Drawing.Point(1062, 20);
            this.lblTrenutniUser.Name = "lblTrenutniUser";
            this.lblTrenutniUser.Size = new System.Drawing.Size(65, 28);
            this.lblTrenutniUser.TabIndex = 5;
            this.lblTrenutniUser.Text = "label5";
            this.lblTrenutniUser.Click += new System.EventHandler(this.TrenutniUser_Click);
            // 
            // frmIndexDoktor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1251, 739);
            this.Controls.Add(this.lblTrenutniUser);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picIzvjestaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picObaveza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNalaz);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIndexDoktor";
            this.Text = "frmIndexDoktor";
            this.Load += new System.EventHandler(this.frmIndexDoktor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNalaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picObaveza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNalaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picObaveza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picIzvjestaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label TrenutniUser;
        private System.Windows.Forms.Label lblTrenutniUser;
    }
}