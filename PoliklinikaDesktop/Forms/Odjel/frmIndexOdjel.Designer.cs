namespace PoliklinikaDesktop.Forms.Odjel
{
    partial class frmIndexOdjel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndexOdjel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOdjel = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            // 
            // dgvOdjel
            // 
            this.dgvOdjel.AllowUserToAddRows = false;
            this.dgvOdjel.AllowUserToDeleteRows = false;
            this.dgvOdjel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdjel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvOdjel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdjel.Location = new System.Drawing.Point(3, 19);
            this.dgvOdjel.Name = "dgvOdjel";
            this.dgvOdjel.ReadOnly = true;
            this.dgvOdjel.Size = new System.Drawing.Size(564, 266);
            this.dgvOdjel.TabIndex = 0;
            this.dgvOdjel.Text = "dataGridView1";
            this.dgvOdjel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOdjel_CellContentClick);
            this.groupBox1.Controls.Add(this.dgvOdjel);
            this.groupBox1.Location = new System.Drawing.Point(2, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(638, 264);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(122, 41);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Dodaj odjel";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "detalji";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmIndexOdjel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIndexOdjel";
            this.Text = "frmIndexOdjel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdjel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOdjel;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}