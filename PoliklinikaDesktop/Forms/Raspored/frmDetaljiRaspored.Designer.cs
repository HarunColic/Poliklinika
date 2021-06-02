﻿
namespace PoliklinikaDesktop.Forms.Raspored
{
    partial class frmDetaljiRaspored
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.cmbTehnicar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(523, 353);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(113, 44);
            this.btnSacuvaj.TabIndex = 44;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(408, 189);
            this.cmbDoktor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(228, 28);
            this.cmbDoktor.TabIndex = 43;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(408, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Doktor";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(43, 183);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(86, 32);
            this.lblDatum.TabIndex = 41;
            this.lblDatum.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kraj pregleda";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "12:00";
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKraj.Location = new System.Drawing.Point(43, 367);
            this.dtpKraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.ShowUpDown = true;
            this.dtpKraj.Size = new System.Drawing.Size(228, 27);
            this.dtpKraj.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 28);
            this.label2.TabIndex = 38;
            this.label2.Text = "Početak pregleda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(14, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Datum";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "\"HH:mm\"";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPocetak.Location = new System.Drawing.Point(43, 265);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.ShowUpDown = true;
            this.dtpPocetak.Size = new System.Drawing.Size(228, 27);
            this.dtpPocetak.TabIndex = 35;
            // 
            // cmbTehnicar
            // 
            this.cmbTehnicar.FormattingEnabled = true;
            this.cmbTehnicar.Location = new System.Drawing.Point(408, 291);
            this.cmbTehnicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTehnicar.Name = "cmbTehnicar";
            this.cmbTehnicar.Size = new System.Drawing.Size(228, 28);
            this.cmbTehnicar.TabIndex = 46;
            this.cmbTehnicar.SelectedIndexChanged += new System.EventHandler(this.cmbTehnicar_SelectedIndexChanged);
            this.cmbTehnicar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbTehnicar_Format);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(408, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 45;
            this.label5.Text = "Tehnicar";
            // 
            // frmDetaljiRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(689, 456);
            this.Controls.Add(this.cmbTehnicar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbDoktor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPocetak);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDetaljiRaspored";
            this.Text = "frmDetaljiRaspored";
            this.Load += new System.EventHandler(this.frmDetaljiRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTehnicar;
    }
}