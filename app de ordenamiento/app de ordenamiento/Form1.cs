﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_de_ordenamiento
{
    public partial class Form1 : Form
    {

     //<<<<<<< datos inicio


        bool estado = false;

        int[] Arreglos_De_Numeros;

        Numeros Datos = new Numeros();

        Button[] Arreglos;


     //>>>>>>> datos final

        public Form1()
        {

         //<<<<<<< llamdos inicio

            InitializeComponent();
            tabPage1.Paint += tabPage1_Paint;
            Arreglos_De_Numeros = new int[0];
            Ordenamiento_insercion(Arreglos_De_Numeros);

         //>>>>>>> llamados final

        }

<<<<<<< HEAD




        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            //<<<<<<< BtnAgregar inicio

            try
            {


                int numero = Convert.ToInt32(txtNumero.Text);
                Datos.Insertar_Dato(numero);
                Arreglos_De_Numeros = Datos.Obtener_Arreglo();

                Arreglos = Datos.Arreglo_Botones();


            }
            catch
            {


                MessageBox.Show("Solo se admiten numeros enteros");

       

            }

        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {

            ///>>>>>>> BtnOrdenar inicio

            this.Cursor = Cursors.WaitCursor;

            BtnOrdenar.Enabled = false;
            txtNumero.Enabled = false;
            BtnAgregar.Enabled = false;

            Stopwatch inicio = new Stopwatch();
            Stopwatch final = new Stopwatch();
            inicio.Start();


            BubbleSort(ref Arreglos_De_Numeros, ref Arreglos);

            final.Stop();
            TimeSpan tiempo = inicio.Elapsed;

            MessageBox.Show($"El ordenamiento tardó {tiempo.TotalSeconds} segundos");

            this.Cursor = Cursors.Default;

            BtnOrdenar.Enabled = true;
            txtNumero.Enabled = true;
            BtnAgregar.Enabled = true;

            //>>>>>>> BtnOrdenar final

        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            //>>>>>>> tapepage_paint inicio

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


              //>>>>>>> tapepage_paint final
            }

        }

        class Numeros
        {
            //>>>>>>> Clase_numeros inicio

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

            //>>>>>>> Clase_numeros final

        }





        public void BubbleSort(ref int[] Arreglos, ref Button[] Arreglo_De_Numeros)
        {

            //>>>>>>> BubbleSort inicio

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

            //>>>>>>> BubbleSort final

        }

        

=======
        public void Dibujar_Arreglo(ref Button[] Arreglo, Point xy, ref TabPage t)
        {


            for (int i = 0; i < Arreglo.Length; i++)
            {


                Arreglo[i].Location = xy;
                t.Controls.Add(Arreglos[i]);
                xy += new Size(70, 0);


            }


        }

>>>>>>> Dibujar_Arreglo
    }
}
