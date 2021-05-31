
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
            this.cmbOsoblje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(458, 265);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(99, 33);
            this.btnSacuvaj.TabIndex = 44;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // cmbOsoblje
            // 
            this.cmbOsoblje.FormattingEnabled = true;
            this.cmbOsoblje.Location = new System.Drawing.Point(357, 142);
            this.cmbOsoblje.Name = "cmbOsoblje";
            this.cmbOsoblje.Size = new System.Drawing.Size(200, 23);
            this.cmbOsoblje.TabIndex = 43;
            this.cmbOsoblje.SelectedIndexChanged += new System.EventHandler(this.cmbOsoblje_SelectedIndexChanged);
            this.cmbOsoblje.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbOsoblje_Format);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(357, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Osoblje";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(38, 137);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(68, 25);
            this.lblDatum.TabIndex = 41;
            this.lblDatum.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Kraj pregleda";
            // 
            // dtpKraj
            // 
            this.dtpKraj.CustomFormat = "12:00";
            this.dtpKraj.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKraj.Location = new System.Drawing.Point(38, 275);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.ShowUpDown = true;
            this.dtpKraj.Size = new System.Drawing.Size(200, 23);
            this.dtpKraj.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "Početak pregleda";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Datum";
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.CustomFormat = "\"HH:mm\"";
            this.dtpPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPocetak.Location = new System.Drawing.Point(38, 199);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.ShowUpDown = true;
            this.dtpPocetak.Size = new System.Drawing.Size(200, 23);
            this.dtpPocetak.TabIndex = 35;
            // 
            // frmDetaljiRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(603, 342);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbOsoblje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpPocetak);
            this.Name = "frmDetaljiRaspored";
            this.Text = "frmDetaljiRaspored";
            this.Load += new System.EventHandler(this.frmDetaljiRaspored_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbOsoblje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
    }
}