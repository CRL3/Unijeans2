using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class Clientes_EspecialesDao
    {
        private int idclientes_especiales;
        private string codigo;

        public int Idclientes_especiales
        {
            get { return idclientes_especiales; }
            set { idclientes_especiales = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

    }
}
