using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_1._0.Logica.Entidades;
using TP_PAV_1._0.Logica.Servicios_de_Proveedor;


namespace TP_PAV_1._0.Capa_UI.Proveedores
{
    public partial class ABMProveedorInput : Form
    {
        public ABMProveedorInput()
        {
            InitializeComponent();
        }
        private Proveedor ProvSelected;
        private ABMEstado MyEstado;
        public void ElegirModo(ABMEstado estado, Proveedor ProvSelect)
        {
            switch (estado)
            {
                case ABMEstado.Alta:
                    MyEstado = ABMEstado.Alta;
                    break;
                case ABMEstado.Modificar:
                    MyEstado = ABMEstado.Modificar;
                    ProvSelected = ProvSelect;
                    txt_Cuit.Text = ProvSelect.Cuit.ToString();
                    txt_Cuit.Enabled = false;
                    txt_Contacto.Text = ProvSelect.Contacto;
                    txt_Tel.Text = ProvSelect.Telefono;
                    txt_RazonSocial.Text = ProvSelect.RazonSocial;
                    lbl_Tittle.Text = "Modificar Proveedor";
                    break;
                case ABMEstado.Baja:
                    MyEstado = ABMEstado.Baja;
                    ProvSelected = ProvSelect;
                    txt_Cuit.Text = ProvSelect.Cuit.ToString();
                    txt_Contacto.Text = ProvSelect.Contacto;
                    txt_Tel.Text = ProvSelect.Telefono;
                    txt_RazonSocial.Text = ProvSelect.RazonSocial;
                    txt_Contacto.Enabled = false;
                    txt_RazonSocial.Enabled = false;
                    txt_Tel.Enabled = false;
                    txt_Cuit.Enabled = false;
                    lbl_Tittle.Text = "Dar de baja Proveedor";
                    break;
            }

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
            if (txt_Cuit.Text == "")
            {
                MessageBox.Show("Debe ingresar un Cuit valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Contacto.Text == "")
            {
                MessageBox.Show("Debe ingresar una Contacto valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_RazonSocial.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Razon Social",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Tel.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Telefono",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            ProveedorService.AgregarProv(new Proveedor(txt_Cuit.Text, txt_RazonSocial.Text, txt_Contacto.Text, txt_Tel.Text, true));
            Close();
        }
        private void Modifcar()
        {
            if (txt_Contacto.Text == "")
            {
                MessageBox.Show("Debe ingresar un Contacto valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_RazonSocial.Text == "")
            {
                MessageBox.Show("Debe ingresar una Razon Social valida",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Tel.Text == "")
            {
                MessageBox.Show("Debe ingresar un Telefono valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            ProveedorService.ModifProv(ProvSelected, txt_Tel.Text, txt_Contacto.Text, txt_RazonSocial.Text);
            Close();
        }
        private void Baja()
        {
            ProveedorService.DarDeBajaProv(ProvSelected);
            Close();
        }

        private void btn_AUser_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
