using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Logica.Entidades;
using System.Data;

namespace TP_PAV_1._0.Datos
{
    internal class ProveedorDat
    {
        public static Proveedor CrearProveedorFromRow(DataRow row)
        {
            string cuit = row["cuitProveedor"].ToString();

            string razonSocial = row["razonSocial"].ToString();
            string Contacto = row["contacto"].ToString();
            string Activo = row["activo"].ToString();
            string Telefono = row["telefono"].ToString();
            return new Proveedor(cuit, razonSocial, Contacto, Telefono, true);
        }
    }
}
