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

namespace VentasNuevo
{
    public partial class Login : Form
    {
        conexionbd con = new conexionbd();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-74BBU83\\SQLEXPRESS ; Initial Catalog=VENTAS ; integrated security = true");
        
        public Login()
        {
            InitializeComponent();
        }

        private void login()
        {
            string loguarse = "select nomUsuario, contra FROM Usuario WHERE nomUsuario ='"+txtUsuario.Text+"' AND contra = '"+txtContra.Text+"'";
            conexion.Open();
            using (SqlCommand cmd = new SqlCommand(loguarse, conexion))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Logueo exitoso");
                }
                else
                {
                    MessageBox.Show("Algo salio mal");                
                }
            }
            conexion.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
