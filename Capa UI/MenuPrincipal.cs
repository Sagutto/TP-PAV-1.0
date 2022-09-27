using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_1._0.Capa_UI.Usuarios;
using TP_PAV_1._0.Logica.Servicios_de_Usuarios;
using TP_PAV_1._0.Capa_UI.Proveedores;

namespace TP_PAV_1._0.Capa_UI
{
    public partial class MenuPrincipal : Form
    {

        private Usuario CurrentUser = null;
        private EventHandler myEvent;
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Login login = new Login();
            login.OnClosed_TP += LogInUser;
            login.ShowDialog();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainUsuarios login = new MainUsuarios();
            login.ShowDialog();
        }

        internal void LogInUser(Usuario user)
        {
            CurrentUser = user;
            if (CurrentUser == null)
            {
                Environment.Exit(0);
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainProveedores login = new MainProveedores();
            login.ShowDialog();
        }
    }
}
