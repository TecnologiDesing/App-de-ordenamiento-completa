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

        class Numeros
        {


            private int Longitud;
            private int[] Arreglo = new int[1];
            private Button[] Arreglos_Botones = new Button[1];

            public Numeros()
            {


                int a = 0;
                Arreglo[0] = a;
                Arreglos_Botones[0] = new Button();
                Arreglos_Botones[0].Width = 40;
                Arreglos_Botones[0].Height = 40;
                Arreglos_Botones[0].BackColor = Color.GreenYellow;
                Arreglos_Botones[0].Text = a.ToString();
                Calcular_Longitud();


            }

            public void Calcular_Longitud()
            {


                Longitud = Arreglos_Botones.Length;


            }

            public int Obtener_Longitud()
            {


                return Longitud;


            }

            public int[] Obtener_Arreglo()
            {


                return Arreglo;


            }



            public void Insertar_Dato(int Dato)
            {


                Array.Resize<int>(ref Arreglo, Longitud + 1);
                Arreglo[Longitud] = Dato;

                Array.Resize<Button>(ref Arreglos_Botones, Longitud + 1);


                Arreglos_Botones[Longitud] = new Button();
                Arreglos_Botones[Longitud].Width = 50;
                Arreglos_Botones[Longitud].Height = 50;
                Arreglos_Botones[Longitud].BackColor = Color.GreenYellow;
                Arreglos_Botones[Longitud].Text = Dato.ToString();
                Calcular_Longitud();


            }

            public Button[] Arreglo_Botones()
            {


                return Arreglos_Botones;


            }


        }

    }
}
