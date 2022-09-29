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
using TP_PAV_1._0.Logica.Entidades;
using TP_PAV_1._0.Capa_UI.Usuarios;

namespace TP_PAV_1._0.Capa_UI
{
    public partial class AltaUsuario : Form
    {
        private Usuario UsuarioSelect;

        private ABMEstado MyEstado;
        public AltaUsuario()
        {
            InitializeComponent();
            cmb_Perfil.DataSource = Enum.GetValues(typeof(PerfilUser));
        }

        private void btn_AUser_Cancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }



        public void ElegirModo(ABMEstado estado, Usuario UserSelect)
        {
            MyEstado = estado;
            switch (estado)
            {
                case ABMEstado.Alta:
                    label3.Visible = false;
                    txt_Nombre.KeyUp += Txt_Nombre_KeyUp;
                    txt_Contraseña.KeyUp += Txt_Contraseña_KeyUp;
                    txt_ReptContraseña.KeyUp += Txt_ReptContraseña_KeyUp;
                    cmb_Perfil.LostFocus += Cmb_Perfil_LostFocus;
                    break;
                case ABMEstado.Modificar:
                    UsuarioSelect = UserSelect;
                    txt_Nombre.Text = UserSelect.Username;
                    txt_Email.Text = UserSelect.Email;
                    txt_Contraseña.Enabled = false;
                    txt_ReptContraseña.Enabled = false;
                    cmb_Perfil.SelectedItem = UserSelect.Perfil;
                    cmb_Perfil.Enabled = false;
                    lbl_RegisUser.Text = "Modificar Usuario";
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    break;
                case ABMEstado.Baja:
                    UsuarioSelect = UserSelect;
                    txt_Nombre.Text = UserSelect.Username;
                    txt_Email.Text = UserSelect.Email;
                    txt_Nombre.Enabled = false;
                    txt_Contraseña.Enabled = false;
                    txt_Email.Enabled = false;
                    txt_ReptContraseña.Enabled = false;
                    cmb_Perfil.SelectedItem = UserSelect.Perfil;
                    cmb_Perfil.Enabled = false;
                    lbl_RegisUser.Text = "Dar de baja Usuario";
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    break;
            }

        }

        private void Cmb_Perfil_LostFocus(object sender, EventArgs e)
        {
            UpdateLabel(label6, cmb_Perfil.Text);
        }

        private void Txt_ReptContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateLabel(label5, txt_ReptContraseña.Text);
        }

        private void Txt_Contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateLabel(label4, txt_Contraseña.Text);
        }
        private void Txt_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateLabel(label2, txt_Nombre.Text);
        }

        private void btn_ABMUser_Aceptar_Click(object sender, EventArgs e)
        {

            switch (MyEstado)
            {
                case ABMEstado.Alta:
                    Alta();
                    break;
                case ABMEstado.Modificar:
                    Modifcar();
                    break;
                case ABMEstado.Baja:
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
            if (cmb_Perfil.Text == "")
            {
                MessageBox.Show("Seleccione un Perfil de Usuario",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            PerfilUser perfil = (PerfilUser)cmb_Perfil.SelectedItem;
            UserService.AgregarUsuario(new Usuario(0, txt_Nombre.Text, txt_Contraseña.Text, txt_Email.Text, perfil));
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
            UserService.ModifUsuario(UsuarioSelect, txt_Nombre.Text, txt_Contraseña.Text, txt_Email.Text, 1);
            Close();
        }
        private void Baja()
        {
            UserService.DarDeBajaUsuario(UsuarioSelect);
            Close();
        }

        private void UpdateLabel(Label label,string textBox)
        {
            if (textBox != "")
            {
                label.Text = "O";
                label.BackColor = Color.LightGreen;
            }
            else
            {
                label.Text = "!!";
                label.BackColor = Color.Red;
            }
        }
        

    }
}
