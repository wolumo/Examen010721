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
    public partial class menuMDI : Form
    {
        public menuMDI()
        {
            InitializeComponent();
        }

        private void PrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrestamosVisualicer prestamosVisualicer = new PrestamosVisualicer();
            prestamosVisualicer.MdiParent = this;
            prestamosVisualicer.Show();
        }
    }
}
