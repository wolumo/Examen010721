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
    public partial class CrearPrestamos : Form
    {
        public CrearPrestamos()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtPlazo.Text);
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "NO ";
            dataGridView1.Columns[1].Name = "Cuota ";
            dataGridView1.Columns[2].Name = "Abono ";
            dataGridView1.Columns[3].Name = "Interes ";
            dataGridView1.Columns[4].Name = "Saldo";
            dataGridView1.Rows.Add("0", " 0" , "0 " , "0 " , txtMonto.Text );
            for (int i= 1; i<n; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i) , CalculoCuota() , CalculoAbono() ,CalculoInteres() ,CalculoSaldo() );
            }
        }
        public double CalculoCuota(/*double Saldo , double Interes, int Plazo*/) 
        {
            
            double Saldo = Convert.ToDouble(txtMonto.Text);
            double Interes = Convert.ToDouble(txtInteres.Text);
            double Plazo = Convert.ToInt32(txtPlazo.Text);
            return Saldo * ((Interes * (Math.Pow((1 + Interes), Plazo))) / ((Math.Pow((1 + Interes), Plazo)) - 1));
        }
        public double CalculoInteres()
        {
            
            int tmp;
            int k = tmp;
            double interes = Convert.ToDouble(txtInteres.Text);
            
            double Saldo = Convert.ToDouble(dataGridView1.Rows[k].Cells[4].Value.ToString());
            tmp = k;
            tmp = tmp++;
            return Saldo * interes;
            
        }
        public double CalculoSaldo()
        {
            double Saldo = Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value.ToString());
            double Abono = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value.ToString());
            return Saldo - Abono;
        }
        public double CalculoAbono()
        {
            double Prestamo = Convert.ToDouble(txtMonto.Text);
            double Plazo = Convert.ToDouble(txtPlazo.Text);
            return Prestamo / Plazo;
        }
    }
}
