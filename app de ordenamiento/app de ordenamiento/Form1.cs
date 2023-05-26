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

        static void Ordenamiento_insercion(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {

                int temp = array[i];
                int j = i - 1;

                while ((j >= 0) && (array[j] > temp))
                {

                    array[j + 1] = array[j];
                    j--;

                }

                array[j + 1] = temp;

            }

        }

    }
}
