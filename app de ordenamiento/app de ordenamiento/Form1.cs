using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {


            if (estado)
            {


                Point xy = new Point(50, 70);

                try
                {

                    Dibujar_Arreglo(ref Arreglos, xy, ref tabPage1);

                }

                catch
                {
                }

                estado = false;


            }


        }

    }
}
