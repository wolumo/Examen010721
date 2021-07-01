using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenWiston
{
    public partial class PrestamosVisualicer : Form
    {
        public PrestamosVisualicer()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CrearPrestamos crearPrestamos = new CrearPrestamos();
            //crearPrestamos.MdiParent = this;
            crearPrestamos.Show();
        }
    }
}
