using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Logica.Entidades;
using TP_PAV_1._0.Datos;
using System.Data;

namespace TP_PAV_1._0.Logica.Servicios_Productos
{
    internal class ProductService
    {
        public static Producto GetProduct(string CodProducto)
        {
            string consultaSQL = "SELECT * FROM Productos WHERE cuitProveedor='"
                     + CodProducto + "'";
            DataTable prod = DBConector.GetDBConector().ConsultarTablaSQL(consultaSQL);
            return prod.Rows.Count == 0 ? null : ProductoDat.CrearProductoFromRow(prod.Rows[0]);
        }
        public static List<Producto> GetAll(long cod = -1, string nombre = null)
        {
            List<Producto> lst = new List<Producto>();
            String strSql = "SELECT * FROM Productos Where codProducto != -1";
            if (cod != -1)
            {
                strSql += " AND codProducto = " + cod;
            }
            if (nombre != null && nombre != "")
            {
                strSql += " AND nombre = '" + nombre + "'";
            }

            var resultadoConsulta = DBConector.GetDBConector().ConsultarTablaSQL(strSql);
            foreach (DataRow row in resultadoConsulta.Rows)
                lst.Add(ProductoDat.CrearProductoFromRow(row));

            return lst;
        }

        public static void AgregarProd(Producto prodcuto)
        {

            string newString = ConvertToFLoat(prodcuto.Precio.ToString());
            String strSql = "INSERT INTO Productos(codProducto, nombre, descripcion, precio, cantStock, cuitProveedor, codProductoEq)" +
                "VALUES(" + prodcuto.CodProducto + ", '" + prodcuto.Nombre + "', '" + prodcuto.Descripcion + "', " + newString + ","  +prodcuto.CantStock + "," + prodcuto.CuitProveedor + "," + prodcuto.CodProductoEq + ")";


            DBConector.GetDBConector().EjecutarComando(strSql);
        }

        public static void ModifProv(Producto ProductoMOdif, string nombre, string desc, float precio,int cantStock)
        {

            string str_sql = "UPDATE Productos " +
                 "SET nombre=" + "'" + nombre + "'" + "," +
                 " descripcion=" + "'" + desc + "'" + "," +
                 " precio=" + ConvertToFLoat(precio.ToString()) +","+
                 " cantStock=" + cantStock +
                 " WHERE codProducto=" + ProductoMOdif.CodProducto;
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }
        public static void DarDeBajaProv(Producto prodcuto)
        {
            string str_sql = "Delete FROM Productos where " +
                             "codProducto="+ prodcuto.CodProducto;
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }


        private static string ConvertToFLoat(string float1)
        {
            char str1 = (char)44;
            string newString = "";
            for (int i = 0; i < float1.Length; i++)
            {
                if (float1[i] == str1)
                {
                    newString += ".";
                }
                else
                {
                    newString += float1[i];
                }
            }
            return newString;
        }
    }
}
