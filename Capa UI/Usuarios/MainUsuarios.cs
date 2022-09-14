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
        public MainUsuarios()
        {
            InitializeComponent();
        }
       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgr_Usuarios.DataSource = UserService.GetAll();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            AltaUsuario frm = new AltaUsuario();
            frm.ElegirModo(AltaUsuario.Estado.Alta, "");
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
            frm.ElegirModo(AltaUsuario.Estado.Baja, dgr_Usuarios.CurrentRow.Cells[1].Value.ToString());
            //MessageBox.Show(dgr_Usuarios.CurrentRow.Cells[1].Value.ToString());
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
            frm.ElegirModo(AltaUsuario.Estado.Modificar, dgr_Usuarios.CurrentRow.Cells[1].Value.ToString());
            //MessageBox.Show(dgr_Usuarios.CurrentRow.Cells[1].Value.ToString());
            frm.ShowDialog();
        }
    }
}
