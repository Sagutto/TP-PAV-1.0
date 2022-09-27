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

namespace TP_PAV_1._0.Capa_UI.Usuarios
{
    public partial class MainUsuarios : Form
    {
        List<Usuario> Usuarios = new List<Usuario>();
        public MainUsuarios()
        {
            InitializeComponent();
            InitializeDataGridView();
            cmb_Perfil.DataSource= Enum.GetValues(typeof(testUser));
        }
        public enum testUser
        {
            Admin = 1,Invitado = 2
        }
       
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmb_Perfil.SelectedItem != null)
            {
                testUser erre = (testUser)cmb_Perfil.SelectedItem;
                dgr_Usuarios.DataSource = UserService.GetAll(txt_Nombre.Text, Convert.ToInt32(erre));
            }
            else
            {
                dgr_Usuarios.DataSource = UserService.GetAll(txt_Nombre.Text);
            }

        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            AltaUsuario frm = new AltaUsuario();
            frm.ElegirModo(Logica.Entidades.ABMEstado.Alta, null);
            frm.ShowDialog();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if (dgr_Usuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AltaUsuario frm = new AltaUsuario();
            frm.ElegirModo(Logica.Entidades.ABMEstado.Baja,(Usuario)dgr_Usuarios.CurrentRow.DataBoundItem);
            MessageBox.Show(dgr_Usuarios.CurrentRow.Cells[1].Value.ToString());
            frm.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgr_Usuarios.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AltaUsuario frm = new AltaUsuario();
            frm.ElegirModo(Logica.Entidades.ABMEstado.Modificar, (Usuario)dgr_Usuarios.CurrentRow.DataBoundItem);
            MessageBox.Show(dgr_Usuarios.CurrentRow.Cells[1].Value.ToString());
            frm.ShowDialog();
        }

        private void InitializeDataGridView()
        {
            dgr_Usuarios.ColumnCount = 3;
            dgr_Usuarios.ColumnHeadersVisible = true;
            dgr_Usuarios.AutoGenerateColumns = false;

            dgr_Usuarios.Columns[0].Name = "Usuario";
            dgr_Usuarios.Columns[0].DataPropertyName = "UserName";
            dgr_Usuarios.Columns[1].Name = "Email";
            dgr_Usuarios.Columns[1].DataPropertyName = "Email";
            dgr_Usuarios.Columns[2].Name = "Perfil";
            dgr_Usuarios.Columns[2].DataPropertyName = "Perfil";
            dgr_Usuarios.AutoResizeColumnHeadersHeight();
            dgr_Usuarios.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
