
using PoliklinikaDesktop.Forms.Raspored;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoliklinikaDesktop.Forms.Administrator
{
    public partial class frmOdabirTerminaAdmin : Form
    {
        public frmOdabirTerminaAdmin()
        {
            InitializeComponent();
        }


        private void dgvPregledi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnindex = dgvPregledi.CurrentCell.ColumnIndex;

            if (columnindex == 3)
            {
                var id = dgvPregledi.CurrentRow.Cells[0].Value;

                frmDetaljiRaspored doktor = new frmDetaljiRaspored(int.Parse(id.ToString()));
                doktor.Show();
            }
        }
    }