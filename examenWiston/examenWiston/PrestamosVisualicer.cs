using examenWiston.Model;
using examenWiston.POCO;
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
        public PrestamosModel prestamosModel;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            CrearPrestamos crearPrestamos = new CrearPrestamos();
            crearPrestamos.prestamosModel = prestamosModel;
            //crearPrestamos.MdiParent = this;
            crearPrestamos.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Monto";
            dataGridView1.Columns[1].Name = "Plazo";
            dataGridView1.Columns[2].Name = "Tasa";
            dataGridView1.Columns[3].Name = "Periodo";
            if(prestamosModel.getAll() != null)
            {
                foreach(Prestamos p in prestamosModel.getAll())
                {
                    dataGridView1.Rows.Add(p.toArray() );
                }
                
            }
        }
    }
}
