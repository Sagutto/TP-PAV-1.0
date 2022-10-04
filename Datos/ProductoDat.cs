using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Logica.Entidades;
using System.Data;

namespace TP_PAV_1._0.Datos
{
    internal class ProductoDat
    {
        public static Producto CrearProductoFromRow(DataRow row)
        {
            long cod = Convert.ToInt64(row["codProducto"].ToString()); 
            string nombre = row["nombre"].ToString();
            string desc = row["descripcion"].ToString();
            double precio = Convert.ToDouble(row["precio"].ToString());
            int cantStock = Convert.ToInt32(row["cantStock"].ToString());
            string cuitProv = row["cuitProveedor"].ToString();
            int codProdEq = Convert.ToInt32(row["codProductoEq"].ToString());
            return new Producto(cod, nombre, desc,cantStock,cuitProv,codProdEq,(float)precio);
        }
    }
}
