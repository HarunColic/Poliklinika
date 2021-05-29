using PoliklinikaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Obaveza.Chat
{
    public partial class frmIndexChat : Form
    {
        private readonly APIService _service = new APIService("ChatPoruka");
        private int? _id = null;

        public frmIndexChat()
        {
            InitializeComponent();
        }

        private async void frmIndexChat_Load(object sender, EventArgs e)
        {
            tblLayout.AutoScroll = false;
            tblLayout.HorizontalScroll.Enabled = false;
            tblLayout.HorizontalScroll.Visible = false;
            tblLayout.AutoScroll = true;

            //var chatObaveza = new ChatObavezaVM { ID = int.Parse(_id.ToString()) };
            var chatObaveza = new ChatObavezaVM { ID = 1 };
            var poruke = await _service.Get<List<ChatPorukaVM>>(chatObaveza);

            //tblLayout.Controls.Remove();

            foreach (var i in poruke)
            {
                var lbl = new Label { Text = i.Poruka };
                lbl.MaximumSize = new Size(200, int.MaxValue);
                var nesto = lbl.MaximumSize;
                lbl.Font = new Font("Arial", 12, FontStyle.Regular);
                //if(CurrentUser.User.Id == i.OsobljeID)
                //    lbl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                //else
                //    lbl.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                //flwChat.Controls.Add(lbl);

                if (i.OsobljeID == 16)
                {
                    lbl.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                    lbl.Padding = new Padding { Right = 30 };
                }
                else
                {
                    lbl.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    lbl.Padding = new Padding { Left = 30 };
                }
                tblLayout.Controls.Add(lbl);
            }
        }
    }
}
