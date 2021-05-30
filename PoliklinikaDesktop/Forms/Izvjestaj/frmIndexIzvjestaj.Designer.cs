
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOdjel = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
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
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pregled izvještaja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(538, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Odjel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(388, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filtriraj po:";
            // 
            // cmbOdjel
            // 
            this.cmbOdjel.FormattingEnabled = true;
            this.cmbOdjel.Location = new System.Drawing.Point(639, 251);
            this.cmbOdjel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOdjel.Name = "cmbOdjel";
            this.cmbOdjel.Size = new System.Drawing.Size(193, 28);
            this.cmbOdjel.TabIndex = 7;
            this.cmbOdjel.SelectedIndexChanged += new System.EventHandler(this.cmbOdjel_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzvjestaj);
            this.groupBox1.Location = new System.Drawing.Point(-1, 289);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(915, 311);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaji";
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Detalji});
            this.dgvIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(3, 24);
            this.dgvIzvjestaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.RowHeadersWidth = 51;
            this.dgvIzvjestaj.RowTemplate.Height = 25;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(909, 283);
            this.dgvIzvjestaj.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // Detalji
            // 
            this.Detalji.DataPropertyName = "Detalji";
            this.Detalji.HeaderText = "Detalji";
            this.Detalji.Image = global::PoliklinikaDesktop.Properties.Resources.detalji;
            this.Detalji.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Detalji.MinimumWidth = 6;
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Width = 125;
            // 
            // frmIndexIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbOdjel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIndexIzvjestaj";
            this.Text = "frmIndexIzvjestaj";
            this.Load += new System.EventHandler(this.frmIndexIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOdjel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewImageColumn Detalji;
    }
}