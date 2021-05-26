
namespace PoliklinikaDesktop.Forms.Nalaz
{
    partial class frmDetaljiNalaz
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblImeKosrisnik = new System.Windows.Forms.Label();
            this.lblOdjel = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtpregledID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(14, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klijent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Odjel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datum pregleda";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(491, 188);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(409, 247);
            this.txtOpis.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dijagnoza i terapija";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(624, 493);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(154, 63);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblImeKosrisnik
            // 
            this.lblImeKosrisnik.AutoSize = true;
            this.lblImeKosrisnik.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblImeKosrisnik.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblImeKosrisnik.Location = new System.Drawing.Point(64, 188);
            this.lblImeKosrisnik.Name = "lblImeKosrisnik";
            this.lblImeKosrisnik.Size = new System.Drawing.Size(90, 37);
            this.lblImeKosrisnik.TabIndex = 14;
            this.lblImeKosrisnik.Text = "label5";
            // 
            // lblOdjel
            // 
            this.lblOdjel.AutoSize = true;
            this.lblOdjel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOdjel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOdjel.Location = new System.Drawing.Point(64, 281);
            this.lblOdjel.Name = "lblOdjel";
            this.lblOdjel.Size = new System.Drawing.Size(90, 37);
            this.lblOdjel.TabIndex = 15;
            this.lblOdjel.Text = "label5";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDatum.Location = new System.Drawing.Point(64, 401);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(90, 37);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "label5";
            // 
            // txtpregledID
            // 
            this.txtpregledID.Location = new System.Drawing.Point(543, 52);
            this.txtpregledID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpregledID.Name = "txtpregledID";
            this.txtpregledID.Size = new System.Drawing.Size(235, 27);
            this.txtpregledID.TabIndex = 17;
            this.txtpregledID.Visible = false;
            // 
            // frmDetaljiNalaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.txtpregledID);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblOdjel);
            this.Controls.Add(this.lblImeKosrisnik);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDetaljiNalaz";
            this.Text = "frmDetaljiNalaz";
            this.Load += new System.EventHandler(this.frmDetaljiNalaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblImeKosrisnik;
        private System.Windows.Forms.Label lblOdjel;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtpregledID;
    }
}