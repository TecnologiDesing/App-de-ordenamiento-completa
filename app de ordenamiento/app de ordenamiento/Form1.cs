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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {



        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {

        }

    }
}
