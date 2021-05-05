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
        Form1 form = new Form1();
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-74BBU83\\SQLEXPRESS ; Initial Catalog=VENTAS ; integrated security = true");
        
        public Login()
        {
            InitializeComponent();
        }

                                            /**************************************************
                                                    **********MODULO DE LOGUEO***********
                                             **************************************************/

        /******************FUNCION PARA LOGUEAR AL USUARIO****************************/
        private void login()
        {
            string loguarse = "select * FROM Usuario WHERE nomUsuario ='" + txtUsuario.Text + "' AND contra = '" + txtContra.Text + "'";
            conexion.Open();
            using (SqlCommand cmd = new SqlCommand(loguarse, conexion))
            {
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        LoginCache.idUsuario = dr.GetInt32(0);
                        LoginCache.nomUsuario = dr.GetString(2);
                        LoginCache.nombre = dr.GetString(4);
                        LoginCache.Apepa = dr.GetString(5);
                        LoginCache.ApeMat = dr.GetString(6);
                    }

                    this.Hide();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                }
            }
            conexion.Close();
        }

        /******************ACTUALIZA EL ESTADO DEL USUARIO A ACTIVO****************************/

        private void actEstado()
        {
            string act = "UPDATE Usuario SET Estado = 1, FechaEnt = @fecha WHERE nomUsuario = @nomUser";
         
            conexion.Open();
            SqlCommand cmd = new SqlCommand(act, conexion);

            cmd.Parameters.AddWithValue("@nomUser", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@fecha", SqlDbType.SmallDateTime).Value = DateTime.Now;
            SqlDataReader dr = cmd.ExecuteReader();
            conexion.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        /******************EVENTO CLICK PARA BOTON***************************/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
            actEstado();            
        }

        /******************CERRAR FORM**************************/
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
