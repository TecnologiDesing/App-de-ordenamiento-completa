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

        public void BubbleSort(ref int[] Arreglos, ref Button[] Arreglo_De_Numeros)
        {


            for (int i = 0; i < Arreglos.Length; i++)
            {

                for (int j = 0; j < Arreglos.Length - 1; j++)
                {


                    if (Arreglos[j] > Arreglos[j + 1])
                    {


                        int aux = Arreglos[j];
                        Arreglos[j] = Arreglos[j + 1];
                        Arreglos[j + 1] = aux;

                        Intercambio(ref Arreglo_De_Numeros, j + 1, j);

                    }


                }

            }


        }

    }
}
