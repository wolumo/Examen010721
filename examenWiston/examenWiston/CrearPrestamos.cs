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
    public partial class CrearPrestamos : Form
    {
        public CrearPrestamos()
        {
            InitializeComponent();
        }
        public  PrestamosModel prestamosModel;

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int n = Convert.ToInt32(txtPlazo.Text) + 1 ;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "NO ";
            dataGridView1.Columns[1].Name = "Cuota ";
            dataGridView1.Columns[2].Name = "Abono ";
            dataGridView1.Columns[3].Name = "Interes ";
            dataGridView1.Columns[4].Name = "Saldo";
            dataGridView1.Rows.Add("0", " 0" , "0 " , "0 " , txtMonto.Text );
            for (int i = 1; i < n; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), CalculoCuota(), CalculoAbono(),  CalculoInteres(i-1) );
                dataGridView1.Rows[i].Cells[4].Value = CalculoSaldo(i-1);
            }
            double monto = Convert.ToDouble(txtMonto.Text);
            double Plazo = Convert.ToDouble(txtPlazo.Text);
            double Tasa = Convert.ToDouble(txtInteres.Text);
            int indexPeriodo = cmbPeriodo.SelectedIndex;
            Prestamos.TipoPeriodo tipoPeriodo = (Prestamos.TipoPeriodo)Enum.GetValues(typeof(Prestamos.TipoPeriodo)).GetValue(indexPeriodo);
            Prestamos pres = new Prestamos()
            {
                Monto = monto,
                Plazo = Plazo,
                Tasa = Tasa,
                Periodo = tipoPeriodo,
            };
            prestamosModel.agregarElemento(pres);
            Console.WriteLine("Se Creo jaak");
        }
        public double CalculoCuota(/*double Saldo , double Interes, int Plazo*/) 
        {
            
            double Saldo = Convert.ToDouble(txtMonto.Text);
            double Interes = Convert.ToDouble(txtInteres.Text);
            double Plazo = Convert.ToInt32(txtPlazo.Text);
            return Saldo * ((Interes * (Math.Pow((1 + Interes), Plazo))) / ((Math.Pow((1 + Interes), Plazo)) - 1));
        }
        public double CalculoInteres( int rows)
        {
            
          
            double interes = Convert.ToDouble(txtInteres.Text);
            
            double Saldo = Convert.ToDouble(dataGridView1.Rows[rows].Cells[4].Value.ToString());
            
            return Saldo * interes;
            
        }
        public double CalculoSaldo( int rows )
        {
            double Saldo = Convert.ToDouble(dataGridView1.Rows[rows].Cells[4].Value.ToString());
            double Abono = Convert.ToDouble(dataGridView1.Rows[rows+1].Cells[2].Value.ToString());
            return Saldo - Abono;
        }
        public double CalculoAbono()
        {
            double Prestamo = Convert.ToDouble(txtMonto.Text);
            double Plazo = Convert.ToDouble(txtPlazo.Text);
            return Prestamo / Plazo;
        }

        private void CrearPrestamos_Load(object sender, EventArgs e)
        {
            cmbPeriodo.Items.AddRange(Enum.GetValues(typeof(Prestamos.TipoPeriodo)).Cast<Object>().ToArray());
            //cmbPeriodo.Items.Add("Mensual");
            //cmbPeriodo.Items.Add("Anual");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
