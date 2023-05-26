using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_de_ordenamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Intercambio(ref Button[] boton, int a, int b)
        {

            string temp = boton[a].Text;

            Point pa = boton[a].Location;

            Point pb = boton[b].Location;

            int diferencia = pa.X - pb.X;
            int x = 10;
            int y = 10;
            int t = 70;

            while (y != 70)
            {


                Thread.Sleep(t);
                boton[a].Location += new Size(0, 10);
                boton[b].Location += new Size(0, -10);
                y += 10;


            }

            while (x != diferencia + 10)
            {

                Thread.Sleep(t);
                boton[a].Location += new Size(-10, 0);
                boton[b].Location += new Size(10, 0);
                x += 10;

            }

            y = 0;

            while (y != -60)
            {

                Thread.Sleep(t);
                boton[a].Location += new Size(0, -10);
                boton[b].Location += new Size(0, +10);
                y -= 10;
            }




            boton[a].Text = boton[b].Text;
            boton[b].Text = temp;
            boton[b].Location = pb;
            boton[a].Location = pa;
            estado = true;
            tabPage1.Refresh();

        }

    }
}
