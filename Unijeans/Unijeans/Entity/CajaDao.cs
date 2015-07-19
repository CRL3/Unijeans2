using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class CajaDao
    {
        private int idcaja;

        private int caja;

        private string activo;


        public int Idcaja
        {
            get { return idcaja; }
            set { idcaja = value; }
        }

        public int Caja
        {
            get { return caja; }
            set { caja = value; }
        }

        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}
