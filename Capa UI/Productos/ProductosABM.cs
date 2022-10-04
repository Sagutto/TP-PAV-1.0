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
using TP_PAV_1._0.Logica.Servicios_Productos;
using TP_PAV_1._0.Logica.Servicios_de_Proveedor;

namespace TP_PAV_1._0.Capa_UI.Productos
{
    public partial class ProductosABM : Form
    {
        private Producto ProdSelected;
        private ABMEstado MyEstado;
        public ProductosABM()
        {
            InitializeComponent();
            cmb_Proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        internal void ElegirModo(ABMEstado estado, Producto Prodselected)
        {
            switch (estado)
            {
                case ABMEstado.Alta:
                    MyEstado = ABMEstado.Alta;
                    List<Proveedor> ProveedorNombre = ProveedorService.GetAll();
                    cmb_Proveedor.DataSource = ProveedorNombre;
                    break;
                case ABMEstado.Modificar:
                    MyEstado = ABMEstado.Modificar;
                    ProdSelected = Prodselected;
                    txt_CodigoProd.Text = Prodselected.CodProducto.ToString();
                    txt_CodigoProd.Enabled = false;
                    txt_CodProductoEQ.Text = Prodselected.CodProductoEq.ToString();
                    txt_CodProductoEQ.Enabled = false;
                    cmb_Proveedor.Text = Prodselected.CuitProveedor.ToString();
                    cmb_Proveedor.Enabled = false;
                    txt_Nombre.Text = Prodselected.Nombre;
                    txt_Desc.Text = Prodselected.Descripcion;
                    txt_Precio.Text = Prodselected.Precio.ToString();
                    txt_CantStock.Text = Prodselected.CantStock.ToString();
                    lbl_Tittle.Text = "Modificar Producto";
                    break;
                case ABMEstado.Baja:
                    MyEstado = ABMEstado.Baja;
                    ProdSelected = Prodselected;
                    txt_CodigoProd.Text = Prodselected.CodProducto.ToString();
                    txt_CodigoProd.Enabled = false;
                    txt_CodProductoEQ.Text = Prodselected.CodProductoEq.ToString();
                    txt_CodProductoEQ.Enabled = false;
                    cmb_Proveedor.Text = Prodselected.CuitProveedor.ToString();
                    cmb_Proveedor.Enabled = false;
                    txt_Nombre.Text = Prodselected.Nombre;
                    txt_Nombre.Enabled = false;
                    txt_Desc.Text = Prodselected.Descripcion;
                    txt_Desc.Enabled = false;
                    txt_Precio.Text = Prodselected.Precio.ToString();
                    txt_Precio.Enabled = false;
                    txt_CantStock.Text = Prodselected.CantStock.ToString();
                    txt_CantStock.Enabled = false;
                    lbl_Tittle.Text = "Dar de baja Proveedor";
                    break;
            }

        }

        private void Alta()
        {
            if (txt_CodigoProd.Text == "")
            {
                MessageBox.Show("Debe ingresar un Codigo Valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Desc.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Descripcion",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Precio.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Precio",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (cmb_Proveedor.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Proveedor",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            float value;
            if (!float.TryParse(txt_Precio.Text, out value))
            {
                txt_Precio.Text = "";
                MessageBox.Show("Debe Ingresar un Precio Valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            Proveedor prov = (Proveedor)cmb_Proveedor.SelectedItem;
            long t1 = Convert.ToInt64(txt_CodigoProd.Text);
            int t2 = Convert.ToInt32(txt_CantStock.Text);
            int t3 = 0;
            if (txt_CodProductoEQ.Text != "") t3 = Convert.ToInt32(txt_CodProductoEQ.Text);
            float t4 = value;
            ProductService.AgregarProd(new Producto(t1, txt_Nombre.Text, txt_Desc.Text, t2, prov.Cuit, t3, t4));
            Close();
        }
        private void Modifcar()
        {
            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Desc.Text == "")
            {
                MessageBox.Show("Debe Ingresar una Descripcion",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            if (txt_Precio.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Precio",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            float value;
            if (!float.TryParse(txt_Precio.Text, out value))
            {
                txt_Precio.Text = "";
                MessageBox.Show("Debe Ingresar un Precio Valido",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }
            ProductService.ModifProv(ProdSelected,txt_Nombre.Text,txt_Desc.Text, value,Convert.ToInt32(txt_CantStock.Text));
            Close();
        }
        private void Baja()
        {
            ProductService.DarDeBajaProv(ProdSelected);
            Close();
        }
        private void btn_AUser_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ABMUser_Aceptar_Click_1(object sender, EventArgs e)
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

        private void ProductosABM_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString = "342,32";
            float value;
            value = Convert.ToSingle(myString);
            char str1 = (char)44;
            char str2 = (char)46;

            string newString = "";
            for(int i = 0;i < myString.Length; i++)
            {
                if(myString[i] == str1)
                {
                    newString += ".";
                }
                else
                {
                    newString += myString[i];
                }
            }
            MessageBox.Show(newString);

        }
    }
}
