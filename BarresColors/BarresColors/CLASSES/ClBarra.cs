using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarresColors.CLASSES
{
    internal class ClBarra
    {
        //Constants
        const int INTERVAL = 50;
        
        //Variable (Camps a Visual Studio)
        Random R = new Random();
        int dx = 0;
        int dy = 0;
        int posX = 0;
        int posY = 0;
        int moviment = 30;


        //Colors
        List<Panel> llpnl = new List<Panel>();

        //Propietats
        Form fMain { get; set; }            //Form Contenidor
        Panel pnl { get; set; }            //Contenidor de la bola que inicialment fem quadrada
        Color colorBola { get; set; }       //Color de la Bola
        Timer tmMoviment { get; set; }      //Timer que gestiona el moviment de la bola

        public event EventHandler heXocat;
        public ClBarra(Form xfMain, int xTipus)
        {
            fMain = xfMain;
            if (xTipus == 1)
            {
                colorBola = Color.Red;
                dx = 1;
                dy = 10;
                posX = 0;
                posY = R.Next(0, fMain.Height);
            }
            else if(xTipus == 2)
            {
                colorBola = Color.Green;
                dx = 0;
                dy = 10;
                posX = fMain.Width;
                posY = R.Next(0, fMain.Height);
            }
            else if(xTipus == 3)
            {
                colorBola = Color.Blue;
                dx = 10;
                dy = 0;
                posX = R.Next(0, fMain.Width);
                posY = 0;
            }else
            {
                colorBola = Color.Yellow;
                dx = 10;
                dy = 0;
                posX = R.Next(0, fMain.Width);
                posY = fMain.Height;
            }

            iniBarra(xTipus);
            iniTimer();
        }

        private void iniBarra(int xTipus)
        {
            System.Threading.Thread.Sleep(5);
            pnl = new Panel()
            {
                Size = new Size(dx, dy),
                Location = new Point(posX, posY),
                BackColor = colorBola
            };

            fMain.Controls.Add(pnl);
            pnl.BringToFront();
        }
        private void iniTimer()
        {
            tmMoviment = new Timer();
            tmMoviment.Interval = INTERVAL;
            tmMoviment.Tick += new EventHandler(mouLaBarra);
            tmMoviment.Start();
        }
        private void mouLaBarra(object sender, EventArgs e)
        {
            if (pnl.BackColor.Name == "Red")
            {
                pnl.Width += moviment;
                if ((pnl.Right >= fMain.Width) || (pnl.Right <= 0)) moviment = moviment * -1;
            }
            else if (pnl.BackColor.Name == "Green")
            {
                pnl.Width += moviment;
                pnl.Location = new Point(pnl.Location.X - moviment, pnl.Location.Y);
                if (pnl.Left <= 0) moviment = moviment * -1;
            }
            else if (pnl.BackColor.Name == "Blue")
            {
                pnl.Height += moviment;
                if (pnl.Bottom >= fMain.Height) moviment = moviment * -1;
            }
            else
            {
                pnl.Height += moviment;
                pnl.Location = new Point(pnl.Location.X, pnl.Location.Y - moviment);
                if (pnl.Top <= 0) moviment = moviment * -1;
            }
            }
        }
}

