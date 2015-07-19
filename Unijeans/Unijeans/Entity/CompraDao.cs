using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class CompraDao
    {
        private int idcompra;

        private int precio_c;

        private int cantidad_c;

        private int subtotal;

        private string fecha_ingreso;

        private string estado;

        private int idpersonal;

        private int idprenda;


        public int Idcompra
        {
            get { return idcompra; }
            set { idcompra = value; }
        }

        public int Precio_c
        {
            get { return precio_c; }
            set { precio_c = value; }
        }

        public int Cantidad_c
        {
            get { return cantidad_c; }
            set { cantidad_c = value; }
        }

        public int Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        public string Fecha_ingreso
        {
            get { return fecha_ingreso; }
            set { fecha_ingreso = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Idpersonal
        {
            get { return idpersonal; }
            set { idpersonal = value; }
        }

        public int Idprenda
        {
            get { return idprenda; }
            set { idprenda = value; }
        }
    }

}
