using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Logica.Entidades;
using System.Data;
using TP_PAV_1._0.Datos;

namespace TP_PAV_1._0.Logica.Servicios_de_Proveedor
{
    internal class ProveedorService
    {

        public static Proveedor GetProv(string CuitProveedor)
        {
            string consultaSQL = "SELECT * FROM Proveedor WHERE activo = 1 AND cuitProveedor='"
                     + CuitProveedor + "'";
            DataTable user = DBConector.GetDBConector().ConsultarTablaSQL(consultaSQL);
            return user.Rows.Count == 0 ? null : ProveedorDat.CrearProveedorFromRow(user.Rows[0]);

        }
        public static List<Proveedor> GetAll()
        {
            List<Proveedor> lst = new List<Proveedor>();
            String strSql = "SELECT * FROM Proveedor WHERE activo = 1";

            var resultadoConsulta = DBConector.GetDBConector().ConsultarTablaSQL(strSql);
            foreach (DataRow row in resultadoConsulta.Rows)
                lst.Add(ProveedorDat.CrearProveedorFromRow(row));

            return lst;
        }

        public static void AgregarProv(Proveedor prov)
        {
            String strSql = "INSERT INTO Proveedor(cuitProveedor, razonSocial, contacto, telefono)" +
                "VALUES('" + prov.Cuit + "', '" + prov.RazonSocial + "', '" + prov.Contacto + "', " + prov.Telefono + ")";

            DBConector.GetDBConector().EjecutarComando(strSql);
        }

        public static void ModifProv(Proveedor UsuarioAModificar, string Telefono, string Contacto, string RazonSocial)
        {
            string str_sql = "UPDATE Proveedor " +
                 "SET telefono=" + "'" + Telefono + "'" + "," +
                 " contacto=" + "'" + Contacto + "'" + "," +
                 " razonSocial=" + "'" + RazonSocial + "'" +
                 " WHERE cuitProveedor=" + "'" + UsuarioAModificar.Cuit + "'";
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }
        public static void DarDeBajaProv(Proveedor user)
        {
            string str_sql = "UPDATE Proveedor " +
                             "SET activo=0" +
                             " WHERE cuitProveedor=" + "'" + user.Cuit + "'";
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }

    }
}
