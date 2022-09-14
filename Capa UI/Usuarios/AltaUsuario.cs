using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_1._0.Logica.Servicios_de_Usuarios;

namespace TP_PAV_1._0.Capa_UI
{
    public partial class AltaUsuario : Form
    {
        public enum Estado
        {
            Alta,Modificar,Baja
        }

        private string UsuarioSelect;

        private Estado MyEstado;
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void btn_AUser_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ElegirModo(Estado estado,string UserSelect)
        {
            switch (estado)
            {
                case Estado.Alta:
                    MyEstado = Estado.Alta;
                    break;
                case Estado.Modificar:
                    MyEstado = Estado.Modificar;
                    UsuarioSelect = UserSelect;
                    txt_Nombre.Text = UsuarioSelect;
                    break;
                case Estado.Baja:
                    MyEstado = Estado.Baja;
                    UsuarioSelect = UserSelect;
                    txt_Nombre.Text = UsuarioSelect;
                    txt_Contraseña.Enabled = false;
                    txt_Email.Enabled = false;
                    txt_ReptContraseña.Enabled = false;
                    break;
            }

        }
        private void btn_ABMUser_Aceptar_Click(object sender, EventArgs e)
        {

            switch (MyEstado)
            {
                case Estado.Alta:
                    Alta();
                    break;
                case Estado.Modificar:
                    Modifcar();
                    break;
                case Estado.Baja:
                    Baja();
                    break;
            }
        }

        private void Alta()
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Contraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña valida",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Contraseña.Text != txt_ReptContraseña.Text)
            {
                MessageBox.Show("Las Contraseñas no Coinciden",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            UserService.AgregarUsuario(txt_Nombre.Text, txt_Contraseña.Text, txt_Email.Text, 1);
            Close();
        }
        private void Modifcar()
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Contraseña.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña valida",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Contraseña.Text != txt_ReptContraseña.Text)
            {
                MessageBox.Show("Las Contraseñas no Coinciden",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            UserService.ModifUsuario(UsuarioSelect,txt_Nombre.Text, txt_Contraseña.Text, txt_Email.Text, 1);
            Close();
        }
        private void Baja()
        {
            UserService.DarDeBajaUsuario(UsuarioSelect);
            Close();
        }
    }
}
