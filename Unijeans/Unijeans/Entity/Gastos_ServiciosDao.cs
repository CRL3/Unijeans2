using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class Gastos_ServiciosDao
    {
        private int Idgastos;

        private string descripcion;

        private int total;

        private string fecha;

        private int idservicios;

       private int idpersonal;


       public int Idgastos1
       {
           get { return Idgastos; }
           set { Idgastos = value; }
       }

       public string Descripcion
       {
           get { return descripcion; }
           set { descripcion = value; }
       }

       public int Total
       {
           get { return total; }
           set { total = value; }
       }

       public string Fecha
       {
           get { return fecha; }
           set { fecha = value; }
       }

       public int Idservicios
       {
           get { return idservicios; }
           set { idservicios = value; }
       }
    }
}
