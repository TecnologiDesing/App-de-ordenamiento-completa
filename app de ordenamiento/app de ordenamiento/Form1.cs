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

        public void Dibujar_Arreglo(ref Button[] Arreglo, Point xy, ref TabPage t)
        {


            for (int i = 0; i < Arreglo.Length; i++)
            {


                Arreglo[i].Location = xy;
                t.Controls.Add(Arreglos[i]);
                xy += new Size(70, 0);


            }


        }

    }
}
