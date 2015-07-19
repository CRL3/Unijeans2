using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class FacturaDao
    {
        private int idfactura;

        private string nombres;

        private string apellido;

        private int nit;

        private int total;

        private string date;

        private int idcliente;



        public int Idfactura
        {
            get { return idfactura; }
            set { idfactura = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

    }
}
