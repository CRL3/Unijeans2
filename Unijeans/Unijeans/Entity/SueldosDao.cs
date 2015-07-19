using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class SueldosDao
    {
        private int idsueldos;

        private int cantidad;

        private int idpersonal;



      public int Idsueldos
      {
          get { return idsueldos; }
          set { idsueldos = value; }
      }

      public int Cantidad
      {
          get { return cantidad; }
          set { cantidad = value; }
      }

      public int Idpersonal
      {
          get { return idpersonal; }
          set { idpersonal = value; }
      }

    }
}
