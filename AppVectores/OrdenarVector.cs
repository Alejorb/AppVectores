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
            int n = 0;
            lstAleatorios.Items.Clear();
            for (int i = 0; i < 20;i++)
            { 
                vector[i] = Clases.Ordenar_Vectores.generar();
                this.lstAleatorios.Items.Add(Clases.Ordenar_Vectores.generar());
            }
            
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstAleatorios.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
