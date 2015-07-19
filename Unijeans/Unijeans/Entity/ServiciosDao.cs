using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class ServiciosDao
    {
        private int Idservicios;

        private string descripcion;


      public int Idservicios1
      {
          get { return Idservicios; }
          set { Idservicios = value; }
      }

      public string Descripcion
      {
          get { return descripcion; }
          set { descripcion = value; }
      }
    }
}
