using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unijeans.etity
{
    class PersonalDao
    {
       private int Idpersonal;

       private string usuario;

       private string contraseña;

       private string nombre;

       private string apellido;

       private int ci;

       private int telefono;

       private string email;

       private string direccion;

       private string sexo;

       private string estado;

       private int idroles;



       public int Idpersonal1
       {
           get { return Idpersonal; }
           set { Idpersonal = value; }
       }

       public string Usuario
       {
           get { return usuario; }
           set { usuario = value; }
       }

       public string Contraseña
       {
           get { return contraseña; }
           set { contraseña = value; }
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

       public string Direccion
       {
           get { return direccion; }
           set { direccion = value; }
       }

       public string Sexo
       {
           get { return sexo; }
           set { sexo = value; }
       }

       public string Estado
       {
           get { return estado; }
           set { estado = value; }
       }


       public int Idroles
       {
           get { return idroles; }
           set { idroles = value; }
       }

    }
}
