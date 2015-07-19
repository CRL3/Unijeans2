using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class MarcaDao
    {
        private int idmarca;

        private string descripcion;

        private string estado;


        public int Idmarca
        {
            get { return idmarca; }
            set { idmarca = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }
}
