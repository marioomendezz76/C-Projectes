using BarresColors.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarresColors
{
    public partial class FrmMain : Form
    {
        List<ClBarra> llBarras = new List<ClBarra>();
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_DoubleClick(object sender, EventArgs e)
        {
            llBarras.Add(new ClBarra(this, 2));
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
