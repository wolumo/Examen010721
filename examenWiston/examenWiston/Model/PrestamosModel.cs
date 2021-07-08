using examenWiston.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenWiston.Model
{
    public class PrestamosModel
    {
        private Prestamos[] prestamos;
        public PrestamosModel()
        {

        }
        public void agregarElemento(Prestamos emp)
        {
            if (prestamos == null)
            {
                prestamos = new Prestamos[1];
                prestamos[0] = emp;
                return;
            }
            Prestamos[] tmp = new Prestamos[prestamos.Length + 1];
            Array.Copy(prestamos, tmp, prestamos.Length);
            tmp[tmp.Length - 1] = emp;
            prestamos = tmp;
            Console.WriteLine("Se creo");
        }
        public Prestamos[] getAll()
        {
            return prestamos;
        }
    }
}
