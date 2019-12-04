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
            

        }
        private int generar()
        {
            int MAX = 20;
            int[] vector = new int[MAX];


        }
    }
}
