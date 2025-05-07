using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_DJZ.Clases
{

    public class ConexionBD
    {
        public void btnProbarConexion_Click()
        {
            
        string conexion = @"server=localhost;database=sistema_de_comida;uid=root;pwd= root";
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Éxito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar: " + ex.Message, "Error");
                }
            }
        }
    }
    }
