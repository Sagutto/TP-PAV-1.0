using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_1._0.Logica.Servicios_de_Proveedor;
using TP_PAV_1._0.Logica.Entidades;
using TP_PAV_1._0.Datos;

namespace TP_PAV_1._0.Capa_UI.Proveedores
{
    public partial class MainProveedores : Form
    {
        public MainProveedores()
        {
            InitializeComponent();
            InitializeDataGridView();
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgr_Proveedores.DataSource = ProveedorService.GetAll(txt_Cuit.Text, txt_RzSocial.Text);
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            ABMProveedorInput frm = new ABMProveedorInput();
            frm.ElegirModo(ABMEstado.Alta, null);
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgr_Proveedores.DataSource = ProveedorService.GetAll(txt_Cuit.Text, txt_RzSocial.Text);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgr_Proveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ABMProveedorInput frm = new ABMProveedorInput();
            frm.ElegirModo(ABMEstado.Modificar, (Proveedor)dgr_Proveedores.CurrentRow.DataBoundItem);
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }
        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if (dgr_Proveedores.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ABMProveedorInput frm = new ABMProveedorInput();
            frm.ElegirModo(ABMEstado.Baja, (Proveedor)dgr_Proveedores.CurrentRow.DataBoundItem);
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InitializeDataGridView()
        {
            dgr_Proveedores.ColumnCount = 4;
            dgr_Proveedores.ColumnHeadersVisible = true;
            dgr_Proveedores.AutoGenerateColumns = false;

            dgr_Proveedores.Columns[0].Name = "Cuit";
            dgr_Proveedores.Columns[0].DataPropertyName = "Cuit";
            dgr_Proveedores.Columns[1].Name = "Razon Social";
            dgr_Proveedores.Columns[1].DataPropertyName = "RazonSocial";
            dgr_Proveedores.Columns[2].Name = "Contacto";
            dgr_Proveedores.Columns[2].DataPropertyName = "Contacto";
            dgr_Proveedores.Columns[3].Name = "Telefono";
            dgr_Proveedores.Columns[3].DataPropertyName = "Telefono";

            dgr_Proveedores.AutoResizeColumnHeadersHeight();
            dgr_Proveedores.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }
    }
}
