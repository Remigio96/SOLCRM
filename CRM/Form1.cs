using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            BD obj = new BD();
            try
            {
                obj.AbrirCon();
                MessageBox.Show("Conexión correcta!!!");
                obj.CerrarCon();
            }
            catch
            {
                MessageBox.Show("Error de Conexión!!!");
            }
        }

        private void btnInsertarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                BD ObjBD = new BD();
                System.Data.SqlClient.SqlConnection LocCnn = ObjBD.AbrirCon();

                SqlCommand cmd = LocCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO USUARIO VALUES ('9','9')";
                cmd.ExecuteNonQuery();

                LocCnn = ObjBD.CerrarCon();
                MessageBox.Show("Registro insertado correctamente.");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error!!!");
            }
        }

        private void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                BD ObjBD = new BD();
                System.Data.SqlClient.SqlConnection LocCnn = ObjBD.AbrirCon();

                SqlCommand cmd = LocCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE USUARIO SET clave = 'AIEP'";
                cmd.ExecuteNonQuery();

                LocCnn = ObjBD.CerrarCon();
                MessageBox.Show("Registro actualizado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error!!!");
            }
        }

        private void btnEliminarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                BD ObjBD = new BD();
                System.Data.SqlClient.SqlConnection LocCnn = ObjBD.AbrirCon();

                SqlCommand cmd = LocCnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM USUARIO WHERE rut = '9'";
                cmd.ExecuteNonQuery();

                LocCnn = ObjBD.CerrarCon();
                MessageBox.Show("Registro eliminado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error!!!");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BD ObjBD = new BD();
            string Sql = "SELECT * FROM USUARIO WHERE rut = '" + rut.Text + "'";

            SqlCommand comando = new SqlCommand(Sql, ObjBD.AbrirCon());
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read() == true)
            {
                rut2.Text = leer["rut"].ToString();
                clave.Text = leer["clave"].ToString();
                men.Text = "Usuario encontrado.";
            }
            else
            {
                rut2.Text = "";
                clave.Text = "";
                men.Text = "No existe usuario!!!";
            }

            ObjBD.CerrarCon();
        }

    }
}
