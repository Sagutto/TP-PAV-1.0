using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Datos;
using System.Data;
using System.Windows.Forms;

namespace TP_PAV_1._0.Logica.Servicios_de_Usuarios
{
    internal class UserService
    {
        public static bool ValidarUsuario(string Usuario, string Contraseña)
        {
            string consultaSQL = "SELECT * FROM Usuarios WHERE Activo = 1 AND UserName='"
                                 + Usuario + "' AND Password='"
                                 + Contraseña + "'";
            if (DBConector.GetDBConector().ConsultarTablaSQL(consultaSQL).Rows.Count == 0)
                return false;
            else
                return true;
        }
        public static DataTable GetAll()
        {

            String strSql = "SELECT * FROM Usuarios WHERE Activo = 1";

            var resultadoConsulta = DBConector.GetDBConector().ConsultarTablaSQL(strSql);

            return resultadoConsulta;
        }

        public static void AgregarUsuario(string UserName, string Password, string Email, int IdPerfil)
        {
            String strSql = "INSERT INTO Usuarios(UserName, Password, Email, id_Perfil)" +
                "VALUES('" + UserName + "', '" + Password + "', '" + Email + "', " + IdPerfil + ")";

            DBConector.GetDBConector().EjecutarComando(strSql);
        }

        public static void ModifUsuario(string UsuarioAModificar, string UserName, string Password, string Email, int IdPerfil)
        {
            string str_sql = "UPDATE Usuarios " +
                 "SET UserName=" + "'" + UserName + "'" + "," +
                 " Password=" + "'" + Password + "'" + "," +
                 " Email=" + "'" + Email + "'" + "," +
                 " id_Perfil=" + IdPerfil +
                 " WHERE UserName=" + "'" + UsuarioAModificar + "'";
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }
        public static void DarDeBajaUsuario(string UsuarioAModificar)
        {
            string str_sql = "UPDATE Usuarios " +
                             "SET Activo=0" +
                             " WHERE UserName=" + "'" + UsuarioAModificar + "'";
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }



    }
}
