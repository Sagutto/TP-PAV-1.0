using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_1._0.Datos;
using TP_PAV_1._0.Logica.Servicios_de_Usuarios;
using TP_PAV_1._0.Capa_UI;


namespace TP_PAV_1._0
{
    public partial class Login : Form
    {
        public delegate void onClosed(Usuario user);
        public event onClosed OnClosed_TP;
        private Usuario User;
        public Login()
        {
            InitializeComponent();
            FormClosing += Login_FormClosing;
           
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosed_TP(User);
        }

        private void btn_testConection_Click(object sender, EventArgs e)
        {
            if (DBConector.GetDBConector().TestConection())
            {
                MessageBox.Show("Se pudo conectar al servidor");
            }
            else
            {
                MessageBox.Show("No se pudo conectar al Servidor");
            }
        }

        private void btn_Login_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Login_User.Text == "")
            {
                MessageBox.Show("No se a ingresado un usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_Login_Contraseña.Text == "")
            {
                MessageBox.Show("No se a ingresado una contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(UserService.ValidarUsuario(txt_Login_User.Text, txt_Login_Contraseña.Text))
            {
                MessageBox.Show("Inicio de Sesión exitoso",
                                "Ingreso al sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                User = UserService.GetUser(txt_Login_User.Text);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos",
                                "Validación de datos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_Login_Contraseña.Text = string.Empty;
                txt_Login_User.Text = string.Empty;
                txt_Login_User.Focus();
            }

        }

        private void btn_Login_Salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
