using System;
using System.Data.SqlClient;

namespace CRM
{
    internal class BD
    {
        SqlConnection cnn = new SqlConnection(
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=NAME-DE-TU-BBDD;User ID=sa;Password=TUCLAVE"
        );

        public SqlConnection AbrirCon()
        {
            cnn.Open();
            return cnn;
        }

        public SqlConnection CerrarCon()
        {
            cnn.Close();
            return cnn;
        }
    }
}
