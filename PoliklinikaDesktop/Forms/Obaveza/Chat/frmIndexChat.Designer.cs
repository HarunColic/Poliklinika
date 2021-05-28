
namespace PoliklinikaDesktop.Forms.Obaveza.Chat
{
    partial class frmIndexChat
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
            this.txtPoruka = new System.Windows.Forms.RichTextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.flwChat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(12, 361);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(621, 62);
            this.txtPoruka.TabIndex = 0;
            this.txtPoruka.Text = "";
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(669, 376);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(94, 29);
            this.btnPosalji.TabIndex = 1;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            // 
            // flwChat
            // 
            this.flwChat.AutoScroll = true;
            this.flwChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwChat.Location = new System.Drawing.Point(12, 35);
            this.flwChat.Name = "flwChat";
            this.flwChat.Size = new System.Drawing.Size(751, 305);
            this.flwChat.TabIndex = 2;
            // 
            // frmIndexChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flwChat);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtPoruka);
            this.Name = "frmIndexChat";
            this.Text = "frmIndexChat";
            this.Load += new System.EventHandler(this.frmIndexChat_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPoruka;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.FlowLayoutPanel flwChat;
    }
}