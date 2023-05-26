using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            btnOrdenar.Enabled = false;
            txtNumero.Enabled = false;
            btnAgregar.Enabled = false;

            Stopwatch inicio = new Stopwatch();
            Stopwatch final = new Stopwatch();
            inicio.Start();


            BubbleSort(ref Arreglos_De_Numeros, ref Arreglos);

            final.Stop();
            TimeSpan tiempo = inicio.Elapsed;

            MessageBox.Show($"El ordenamiento tardó {tiempo.TotalSeconds} segundos");

            this.Cursor = Cursors.Default;

            btnOrdenar.Enabled = true;
            txtNumero.Enabled = true;
            btnAgregar.Enabled = true;

        }

    }
}
