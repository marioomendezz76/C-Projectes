using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontoVintage.CLASSES
{
    internal class ClPala
    {
        const int AMPLADA = 15;
        const int ALCADA = 150;

        Form fMain { get; set; }
        Panel pnl { get; set; }
        public ClPala(Form xfMain)
        {
            fMain = xfMain;

            iniPala(fMain);
        }

        private void iniPala(Form fMain)
        {
            System.Threading.Thread.Sleep(5);
            pnl = new Panel()
            {
                Size = new Size(AMPLADA, ALCADA),
                Location = new Point((Cursor.Position.X - (AMPLADA / 2)), (Cursor.Position.Y - (ALCADA / 2))),
                BackColor = Color.Red
            };

            fMain.Controls.Add(pnl);
            pnl.BringToFront();
        }
        public void mourePala()
        {
            pnl.Location = new Point((Cursor.Position.X - (AMPLADA / 2)), (Cursor.Position.Y - (ALCADA / 2)));
        }
        public Panel getPanel()
        {
            return pnl;
        }
    }
}
