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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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

            estado = true;
            tabPage1.Refresh();

        }
    }
}
