using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_1._0.Logica.Entidades
{
    internal class Producto
    {
        long codProducto;
        string nombre;
        string descripcion;
        float precio;
        int cantStock;
        string cuitProveedor;
        int codProductoEq;

        public long CodProducto { get => codProducto; }
        public string Nombre { get => nombre; }
        public string Descripcion { get => descripcion; }
        public int CantStock { get => cantStock; }
        public string CuitProveedor { get => cuitProveedor; }
        public int CodProductoEq { get => codProductoEq; }
        public float Precio { get => precio; }

        public Producto(long codProducto, string nombre, string descripcion, int cantStock, string cuitProveedor, int codProductoEq, float precio)
        {
            this.codProducto = codProducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantStock = cantStock;
            this.cuitProveedor = cuitProveedor;
            this.codProductoEq = codProductoEq;
            this.precio = precio;
        }
    }
}
