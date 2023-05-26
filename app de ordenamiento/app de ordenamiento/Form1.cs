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

        bool estado = false;

        int[] Arreglos_De_Numeros;

        Numeros Datos = new Numeros();

        Button[] Arreglos;

        public Form1()
        {
            InitializeComponent();
        }
    }
}
