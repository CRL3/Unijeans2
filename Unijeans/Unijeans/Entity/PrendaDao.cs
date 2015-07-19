using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class PrendaDao
    {
        private int idprenda;

        private int stock;

        private string codigo;

        private int precio_c;

        private int precio_v;

        private string estado;

        private int idmarca;

        private int idtipo_prenda;



        public int Idprenda
        {
            get { return idprenda; }
            set { idprenda = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public int Precio_c
        {
            get { return precio_c; }
            set { precio_c = value; }
        }

        public int Precio_v
        {
            get { return precio_v; }
            set { precio_v = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int Idmarca
        {
            get { return idmarca; }
            set { idmarca = value; }
        }

        public int Idtipo_prenda
        {
            get { return idtipo_prenda; }
            set { idtipo_prenda = value; }
        }

    }
}
