using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppVectores
{
    public partial class OrdenarVector : Form
    {
        private const int MAX = 20;
        private int[] vector = new int[MAX];
        public OrdenarVector()
        {
            InitializeComponent();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int tamanio = Convert.ToInt32(this.txtTamanio.Text);
            int[] vector = Clases.Ordenar_Vectores.generar(tamanio);

            lstOriginal.Items.Clear();
            for(int i=0;i<tamanio;i++)
            {
                lstOriginal.Items.Add(vector[i]);
            }

            //ordenar el vector y vuelvo a cargar lista
            Clases.Ordenar_Vectores.ordenar(vector, tamanio);
            lstOrdenado.Items.Clear();
            for (int i = 0; i < tamanio; i++)
            {
                lstOrdenado.Items.Add(vector[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
