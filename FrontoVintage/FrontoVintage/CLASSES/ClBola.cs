using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontoVintage.CLASSES
{
    internal class ClBola
    {
        //Constants
        const int MIDAMIN = 10;
        const int MIDMAX = 50;

        const int INTERVALMIN = 10;
        const int INTERVALMAX = 80;

        const int DELTAMIN = -15;
        const int DELTAMAX = 15;

        //Variable (Camps a Visual Studio)
        Random R = new Random();
        int dx = 10;
        int dy = 10;
        int qttBola = 0;

        //Colors
        List<Color> llColors = new List<Color> { Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Gold };
        List<Panel> llpnl = new List<Panel>();

        //Propietats
        Form fMain { get; set; }            //Form Contenidor
        Panel pnl { get; set; }            //Contenidor de la bola que inicialment fem quadrada
        Color colorBola { get; set; }       //Color de la Bola
        Timer tmMoviment { get; set; }      //Timer que gestiona el moviment de la bola
        ClPala pala { get; set; }

        //Events
        public event EventHandler heRebotat;
        public event EventHandler eliminada;

        //Metode contructo - és públic i es diu com la Classe (ClBola)
        public ClBola(Form xfMain, ClPala xPala)
        {
            fMain = xfMain;
            pala = xPala;

            int mida = R.Next(MIDAMIN, MIDMAX + 1);
            colorBola = llColors[R.Next(0, llColors.Count)];

            iniBola(mida);
            iniTimer();
        }
        /// <summary>
        /// Parameter <c>xfMain</c> formulari contenidor.
        /// Parameter <c>xcolor</c> color de la bola.
        /// Parameter <c>xsize</c> mida de la bola en pixels.
        /// </summary>
        public ClBola(Form xfMain, Color xcolor, int xmida)
        {
            fMain = xfMain;
            colorBola = xcolor;

            iniBola(xmida);
            iniTimer();
        }

        private void iniBola(int xmida)
        {
            System.Threading.Thread.Sleep(5);
            pnl = new Panel()
            {
                Size = new Size(xmida, xmida),
                Location = new Point(R.Next(0, fMain.Width - xmida), R.Next(0, fMain.Height - xmida)),
                BackColor = colorBola
            };

            fMain.Controls.Add(pnl);
            pnl.BringToFront();
        }
        private void iniTimer()
        {
            tmMoviment = new Timer();
            tmMoviment.Interval = R.Next(INTERVALMIN, INTERVALMAX + 1);
            tmMoviment.Tick += new EventHandler(mouLaBola);
            tmMoviment.Start();
        }
        private void mouLaBola(object sender, EventArgs e)
        {
            pnl.Left += dx;
            pnl.Top += dy;

            if ((pnl.Right >= fMain.Width) || (pnl.Left <= 0))
            {
                canviarVelocitat();
                canviarAngle(dx, dy);
                canviarColor();
            }
            if ((pnl.Bottom >= fMain.Height) || (pnl.Top <= 0))
            {
                canviarVelocitat();
                canviarAngle(dx, dy);
                canviarColor();
            }
            if (pala.getPanel().Bounds.IntersectsWith(pnl.Bounds))
            {
                canviarVelocitat();
                dx = -dx;

                canviarDY(dy);
                heRebotat(this, EventArgs.Empty);
                qttBola++;
                if (qttBola == 10)
                {
                    fMain.Controls.Remove(pnl);
                    eliminada(this, EventArgs.Empty);
                }
            }

        }
        private void canviarVelocitat()
        {
            Random R = new Random();
            tmMoviment.Interval = R.Next(INTERVALMIN, INTERVALMAX);
        }
        private void canviarColor()
        {
            Random R = new Random();
            foreach (Panel p in llpnl)
            {
                p.BackColor = llColors[R.Next(0, llColors.Count)];
            }
        }
        private void canviarDY(int xdy)
        {
            dy = R.Next(DELTAMIN, DELTAMAX);
            if (xdy > 0)
            {
                dy = -dy;
            }
        }
        private void canviarAngle(int xdx, int xdy)
        {
            dx = R.Next(DELTAMIN, DELTAMAX);
            if (xdx > 0)
            {
                dx = -dx;
            }
            System.Threading.Thread.Sleep(5);
            dy = R.Next(DELTAMIN, DELTAMAX);
            if (xdy > 0)
            {
                dy = -dy;
            }
        }
        public void Aturar()
        {
            tmMoviment.Stop();
        }
        public void Marxa()
        {
            tmMoviment.Start();
        }
    }
}
