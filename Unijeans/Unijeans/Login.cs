using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unijeans.Controlador;

namespace Unijeans
{
    public partial class Login : Form
    {
        Conexion con = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text.Length == 0 && txt_password.Text.Length == 0)
            {
                MessageBox.Show("Inserta Datos en los campos");
            }
            else
            {

                if (con.Verificarlogin(txt_usuario.Text, txt_password.Text))
                {
                    try
                    {
                        /*ArrayList array = con.login(txt_usuario.Text, txt_password.Text);
                        usuario = new UsuarioDao((int)array[0], "" + array[1], "" + array[2], "" + array[3], "" + array[4], "" + array[5], "" + array[6], "" + array[7], (int)array[8], (int)array[9]);
                        Principal obj = new Principal(1);
                        obj.Show();
                        this.Hide();*/
                    }
                    catch (Exception ex)
                    {
                        Console.Write("Error" + ex.StackTrace);
                    }


                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }


            }
        }
    }
}
