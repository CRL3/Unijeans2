using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class VentaDao
    {
        private int idventa;

        private string fecha_v;

        private int costo_t;

        private int cantidad_p;

        private string estado;

        private int idprenda;

        private int personal;


        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }
        public string Fecha_v
        {
            get { return fecha_v; }
            set { fecha_v = value; }
        }
        public int Costo_t
        {
            get { return costo_t; }
            set { costo_t = value; }
        }
        public int Cantidad_p
        {
            get { return cantidad_p; }
            set { cantidad_p = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Idprenda
        {
            get { return idprenda; }
            set { idprenda = value; }
        }

        public int Personal
        {
            get { return personal; }
            set { personal = value; }
        }

    }
}
