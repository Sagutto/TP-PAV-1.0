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

namespace TP_PAV_1._0.Capa_UI
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Login login = new Login();
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
    }
}
