using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_1._0.Logica.Servicios_Productos;
using TP_PAV_1._0.Logica.Entidades;

namespace TP_PAV_1._0.Capa_UI.Productos
{
    public partial class ProductosMain : Form
    {
        public ProductosMain()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Alta_Click(object sender, EventArgs e)
        {
            ProductosABM frm = new ProductosABM();
            frm.ElegirModo(ABMEstado.Alta, null);
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (dgr_Productos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProductosABM frm = new ProductosABM();
            frm.ElegirModo(ABMEstado.Modificar, (Producto)dgr_Productos.CurrentRow.DataBoundItem);
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void btn_Baja_Click(object sender, EventArgs e)
        {
            if (dgr_Productos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ProductosABM frm = new ProductosABM();
            frm.ElegirModo(ABMEstado.Baja, (Producto)dgr_Productos.CurrentRow.DataBoundItem);
            frm.FormClosed += Frm_FormClosed;
            frm.ShowDialog();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            consultar();
        }
        private void consultar()
        {
            if (txt_CodProducto.Text != "")
            {
                dgr_Productos.DataSource = ProductService.GetAll(Convert.ToInt64(txt_CodProducto.Text), txt_Nombre.Text);
            }
            else
            {
                dgr_Productos.DataSource = ProductService.GetAll(nombre: txt_Nombre.Text);
            }
        }
    }
}
