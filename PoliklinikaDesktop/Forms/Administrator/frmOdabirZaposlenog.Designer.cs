
namespace PoliklinikaDesktop.Forms.Administrator
{
    partial class frmOdabirZaposlenog
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
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picDodajDoktora = new System.Windows.Forms.PictureBox();
            this.picDodajTehnicara = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajDoktora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajTehnicara)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PoliklinikaDesktop.Properties.Resources.logo;
            this.pictureBox5.Location = new System.Drawing.Point(102, 36);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(605, 125);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // picDodajDoktora
            // 
            this.picDodajDoktora.Image = global::PoliklinikaDesktop.Properties.Resources.doktor;
            this.picDodajDoktora.Location = new System.Drawing.Point(135, 202);
            this.picDodajDoktora.Name = "picDodajDoktora";
            this.picDodajDoktora.Size = new System.Drawing.Size(206, 186);
            this.picDodajDoktora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDodajDoktora.TabIndex = 6;
            this.picDodajDoktora.TabStop = false;
            this.picDodajDoktora.Click += new System.EventHandler(this.picDodajDoktora_Click);
            // 
            // picDodajTehnicara
            // 
            this.picDodajTehnicara.Image = global::PoliklinikaDesktop.Properties.Resources.sestrica1;
            this.picDodajTehnicara.Location = new System.Drawing.Point(471, 202);
            this.picDodajTehnicara.Name = "picDodajTehnicara";
            this.picDodajTehnicara.Size = new System.Drawing.Size(206, 186);
            this.picDodajTehnicara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDodajTehnicara.TabIndex = 7;
            this.picDodajTehnicara.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dodaj doktora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(460, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 60);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dodaj medicinsku sestru/\r\ntehničara\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmOdabirZaposlenog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDodajTehnicara);
            this.Controls.Add(this.picDodajDoktora);
            this.Controls.Add(this.pictureBox5);
            this.Name = "frmOdabirZaposlenog";
            this.Text = "frmOdabirZaposlenog";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajDoktora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDodajTehnicara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picDodajDoktora;
        private System.Windows.Forms.PictureBox picDodajTehnicara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}