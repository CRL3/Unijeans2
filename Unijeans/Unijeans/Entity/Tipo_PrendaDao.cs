using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class Tipo_PrendaDao
    {
        private int idtipo_prenda;

        private string descripcion;

        private string estado;


        public int Idtipo_prenda
        {
            get { return idtipo_prenda; }
            set { idtipo_prenda = value; }
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
