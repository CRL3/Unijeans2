using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.Entity
{
    class ClienteDao
    {
        private int idcliente;

        private string nombre;

        private string apellido;

        private int ci;

        private int nit;

        private int telefono;

        private string email;

        private string sexo;

        private int clientes_especiales;



        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public int Nit
        {
            get { return nit; }
            set { nit = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public int Clientes_especiales
        {
            get { return clientes_especiales; }
            set { clientes_especiales = value; }
        }

    }
}
