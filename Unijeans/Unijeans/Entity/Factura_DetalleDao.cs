using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class Factura_DetalleDao
    {
        private int factura_detalle;

        private int total;

        private int idfactura;

        private int idventa;



        public int Factura_detalle
        {
            get { return factura_detalle; }
            set { factura_detalle = value; }
        }



        public int Total
        {
            get { return total; }
            set { total = value; }
        }


        public int Idfactura
        {
            get { return idfactura; }
            set { idfactura = value; }
        }

        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }
    }
}
