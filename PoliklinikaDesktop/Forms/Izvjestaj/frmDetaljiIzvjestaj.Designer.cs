
namespace PoliklinikaDesktop.Forms.Izvjestaj
{
    partial class frmDetaljiIzvjestaj
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpisPregleda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImeDoktora = new System.Windows.Forms.TextBox();
            this.dtpDatumPregled = new System.Windows.Forms.DateTimePicker();
            this.txtOpisIzvjestaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOdjel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(296, 382);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(124, 42);
            this.btnSacuvaj.TabIndex = 27;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(387, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Opis izvještaja";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(387, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Opis pregleda";
            // 
            // txtOpisPregleda
            // 
            this.txtOpisPregleda.Location = new System.Drawing.Point(387, 247);
            this.txtOpisPregleda.Multiline = true;
            this.txtOpisPregleda.Name = "txtOpisPregleda";
            this.txtOpisPregleda.Size = new System.Drawing.Size(334, 87);
            this.txtOpisPregleda.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Datum pregleda";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.AutoSize = true;
            this.txtKorisnik.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKorisnik.Location = new System.Drawing.Point(20, 159);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(60, 20);
            this.txtKorisnik.TabIndex = 18;
            this.txtKorisnik.Text = "Pacijent";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(20, 182);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(334, 23);
            this.txtPrezime.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Doktor";
            // 
            // txtImeDoktora
            // 
            this.txtImeDoktora.Location = new System.Drawing.Point(20, 122);
            this.txtImeDoktora.Name = "txtImeDoktora";
            this.txtImeDoktora.Size = new System.Drawing.Size(334, 23);
            this.txtImeDoktora.TabIndex = 15;
            // 
            // dtpDatumPregled
            // 
            this.dtpDatumPregled.Location = new System.Drawing.Point(20, 247);
            this.dtpDatumPregled.Name = "dtpDatumPregled";
            this.dtpDatumPregled.Size = new System.Drawing.Size(334, 23);
            this.dtpDatumPregled.TabIndex = 28;
            // 
            // txtOpisIzvjestaj
            // 
            this.txtOpisIzvjestaj.Location = new System.Drawing.Point(387, 122);
            this.txtOpisIzvjestaj.Multiline = true;
            this.txtOpisIzvjestaj.Name = "txtOpisIzvjestaj";
            this.txtOpisIzvjestaj.Size = new System.Drawing.Size(334, 83);
            this.txtOpisIzvjestaj.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Odjel";
            // 
            // txtOdjel
            // 
            this.txtOdjel.Location = new System.Drawing.Point(20, 311);
            this.txtOdjel.Name = "txtOdjel";
            this.txtOdjel.Size = new System.Drawing.Size(334, 23);
            this.txtOdjel.TabIndex = 30;
            // 
            // frmDetaljiIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOdjel);
            this.Controls.Add(this.txtOpisIzvjestaj);
            this.Controls.Add(this.dtpDatumPregled);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpisPregleda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImeDoktora);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmDetaljiIzvjestaj";
            this.Text = "frmDetaljiIzvjestaj";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpisPregleda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtKorisnik;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImeDoktora;
        private System.Windows.Forms.DateTimePicker dtpDatumPregled;
        private System.Windows.Forms.TextBox txtOpisIzvjestaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOdjel;
    }
}