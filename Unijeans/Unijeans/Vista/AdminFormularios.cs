using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unijeans.Vista
{
    class AdminFormularios
    {
        List<Form> Formularios = new List<Form>();
        int width;
        int height;
        public AdminFormularios(int width, int height){
            this.width = width;
            this.height = height;
            AgregarFormularios();
        }
        public void AgregarFormularios(){
           /* Formularios.Add(new InsertarRol());
            Formularios.Add(new InsertarUsuario());
            Formularios.Add(new ListarRol());
            Formularios.Add(new ListarUsuario());*/
        }
        public List<Form> GetLista(){
            return Formularios;
        }
        public Form getFormulario(int n){
            return Formularios[n];
        }
    }
}
