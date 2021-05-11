
namespace PoliklinikaDesktop.Forms.Izvjestaj
{
    partial class frmIndexIzvjestaj
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbZaposlenik = new System.Windows.Forms.ComboBox();
            this.cmbOdjel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregled izvještaja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zaposlenik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(471, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odjel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(334, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filtriraj po:";
            // 
            // cmbZaposlenik
            // 
            this.cmbZaposlenik.FormattingEnabled = true;
            this.cmbZaposlenik.Location = new System.Drawing.Point(243, 188);
            this.cmbZaposlenik.Name = "cmbZaposlenik";
            this.cmbZaposlenik.Size = new System.Drawing.Size(169, 23);
            this.cmbZaposlenik.TabIndex = 6;
            // 
            // cmbOdjel
            // 
            this.cmbOdjel.FormattingEnabled = true;
            this.cmbOdjel.Location = new System.Drawing.Point(559, 188);
            this.cmbOdjel.Name = "cmbOdjel";
            this.cmbOdjel.Size = new System.Drawing.Size(169, 23);
            this.cmbOdjel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzvjestaj);
            this.groupBox1.Location = new System.Drawing.Point(-1, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 233);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaji";
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(3, 19);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.RowTemplate.Height = 25;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(795, 211);
            this.dgvIzvjestaj.TabIndex = 0;
            // 
            // frmIndexIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbOdjel);
            this.Controls.Add(this.cmbZaposlenik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "frmIndexIzvjestaj";
            this.Text = "frmIndexIzvjestaj";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbZaposlenik;
        private System.Windows.Forms.ComboBox cmbOdjel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
    }
}