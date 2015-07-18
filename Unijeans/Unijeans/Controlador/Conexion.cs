using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unijeans.Controlador
{
    class Conexion
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable databla;
        public Conexion()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\HP\\Source\\Repos\\Unijeans2\\Unijeans\\Unijeans\\DBUnijeans.mdf;Integrated Security=True";
            try
            {
                conn.Open();
                
             }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Fallo al conectar a la base de datos");
                //MessageBox.Show("The calculations are complete", "My Application",MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            
        }
        public bool Verificarlogin(String usuario, String password)
        {
            
            try
            {
             
                String consulta = "SELECT * FROM personal WHERE usuario=('"+ usuario+"') AND password=('"+password+"')";
                
                cmd = new SqlCommand(consulta, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                
                if (dr.HasRows)
                {
                    dr.Close();
                    return true;
                }
                else
                {
                    dr.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validacion666");
                conn.Close();
                return false;
            }
        }
        public bool registrarUsuario(String usuario, String password)
        {
            try
            {
                
                String consulta = "INSERT INTO usuario(usuario1,password) VALUES('"+usuario+"','"+password+"')";
                MessageBox.Show(consulta);
                cmd = new SqlCommand(consulta, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en insercion");
                return false;
            }
        }
        public ArrayList login(String usuario, String password){
            try
            {
                String consulta = "SELECT * FROM personal WHERE usuario=('" + usuario + "') AND password=('" + password + "')";
                cmd = new SqlCommand(consulta, conn);
                dr = cmd.ExecuteReader();
                dr.Read();
                ArrayList array = new ArrayList();
                array.Add(dr.GetInt32(0));
                array.Add(dr.GetString(1));
                array.Add(dr.GetString(2));
                array.Add(dr.GetDateTime(3));
                array.Add(dr.GetString(4));
                array.Add(dr.GetString(5));
                array.Add(dr.GetString(6));
                array.Add(dr.GetString(7));
                array.Add(dr.GetInt32(8));
                array.Add(dr.GetInt32(9));
                MessageBox.Show("Estamos aqui jajajaja");
                return array;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return null;
            }
            
            
        }
        public bool registrarRol(String rol)
        {
            try
            {
                
                String consulta = "INSERT INTO rol(descripcion) VALUES('"+rol+"')";
                cmd = new SqlCommand(consulta, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en insercion");
                return false;
            }
        }
        public bool Verificador(String consulta)
        {

            try
            {
                
                cmd = new SqlCommand(consulta, conn);
                dr = cmd.ExecuteReader();
                MessageBox.Show("paso x aqui tranquilamente");
                dr.Read();
                if (dr.HasRows)
                {
                   
                    return true;
                }
                else
                {
                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en validacion");
                
                return false;
            }
        }
        public bool Insertar(String consulta)
        {
            try
            {
                cmd = new SqlCommand(consulta, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en insercion6666");
                return false;
            }
        }
        public SqlDataReader ObtenerListaDatos(String consulta)
        {
            try
            {
                
                cmd = new SqlCommand(consulta, conn);
                dr = cmd.ExecuteReader();
                
                return dr;
            }
            catch (Exception ex)
            {
                return dr;

            }


        }

        public void cargarDataGridView(DataGridView dgv, String consulta)
        {
            da = new SqlDataAdapter(consulta, conn);
            databla = new DataTable();
            da.Fill(databla);
            dgv.DataSource = databla;

            DataGridViewButtonColumn dgvButton = new DataGridViewButtonColumn();
            dgvButton.FlatStyle = FlatStyle.System;
            dgvButton.HeaderText = "Button";
            dgvButton.Name = "Button";
            dgvButton.UseColumnTextForButtonValue = true;
            dgvButton.Text = "New";
            dgv.Columns.Add(dgvButton);
        }
    }
}
