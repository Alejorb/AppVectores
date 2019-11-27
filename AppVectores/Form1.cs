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
    public partial class Form1 : Form
    {
        private int cont = 0;
        private const int MAX = 100;
        private double[] vector = new double[MAX];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cont < MAX)
                {
                    vector[cont] = int.Parse(this.txtEnteros.Text);
                    
                }
                cont++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
        private void llenarlistra()
        {
            //
        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            //agregar elemento al LixtBox
            for (int i = 0; i < cont; i++)
            {
                this.LstEnteros.Items.Add(vector[i]);
            }
            this.txtSuma.Text = sumatoria().ToString();
            this.txtPromedio.Text = promedio().ToString();
        }
        private double sumatoria()
        {
            double suma=0;
            for(int i=0;i<cont;i++)
            {
                suma = suma + vector[i];
            }
            return suma;
        }
        private double promedio()
        {
            double suma;
            return (sumatoria() / cont);
        }

    }
    
}
