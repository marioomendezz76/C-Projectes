using FrontoVintage.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontoVintage
{
    public partial class FrmMain : Form
    {
        List<ClBola> llBoles = new List<ClBola>();
        ClPala pala;
        int qttRebots = 0;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pala = new ClPala(this);
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                llBoles.Add(new ClBola(this, pala));
                llBoles[llBoles.Count - 1].heRebotat += new EventHandler(sumaUnRebot);
                llBoles[llBoles.Count - 1].eliminada += new EventHandler(eliminaBola);
            }
        }

        private void eliminaBola(object sender, EventArgs e)
        {
            llBoles.Remove(sender as ClBola);
        }

        private void sumaUnRebot(object sender, EventArgs e)
        {
            qttRebots++;
            lbComptador.Text = qttRebots.ToString();
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            pala.mourePala();
        }
    }
}
