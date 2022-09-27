using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Datos;
using System.Data;
using System.Windows.Forms;
using TP_PAV_1._0.Datos;

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
        public static Usuario GetUser(string Usuario)
        {
            string consultaSQL = "SELECT * FROM Usuarios WHERE Activo = 1 AND UserName='"
                     + Usuario + "'";
            DataTable user = DBConector.GetDBConector().ConsultarTablaSQL(consultaSQL);
            return user.Rows.Count == 0? null : UsuariosDat.CrearUsuarioFromRow(user.Rows[0]);

        }
        public static List<Usuario> GetAll(string UserName = null,int Perfil = -1)
        {
            List<Usuario> lst = new List<Usuario>();
            String strSql = "SELECT * FROM Usuarios WHERE Activo = 1";
            if(UserName != null && UserName != "")
            {
                strSql += " AND UserName = '" + UserName + "'";
            }
            if(Perfil != -1)
            {
                strSql += "AND id_Perfil = " + Perfil;
            }

            var resultadoConsulta = DBConector.GetDBConector().ConsultarTablaSQL(strSql);
            foreach (DataRow row in resultadoConsulta.Rows)
                lst.Add(UsuariosDat.CrearUsuarioFromRow(row));

            return lst;
        }

        public static void AgregarUsuario(Usuario user)
        {
            String strSql = "INSERT INTO Usuarios(UserName, Password, Email, id_Perfil)" +
                "VALUES('" + user.Username + "', '" + user.Password + "', '" + user.Email + "', " + user.IdUser + ")";

            DBConector.GetDBConector().EjecutarComando(strSql);
        }

        public static void ModifUsuario(Usuario UsuarioAModificar, string UserName, string Password, string Email, int IdPerfil)
        {
            string str_sql = "UPDATE Usuarios " +
                 "SET UserName=" + "'" + UserName + "'" + "," +
                 " Password=" + "'" + Password + "'" + "," +
                 " Email=" + "'" + Email + "'" + "," +
                 " id_Perfil=" + IdPerfil +
                 " WHERE UserName=" + "'" + UsuarioAModificar.Username + "'";
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }
        public static void DarDeBajaUsuario(Usuario user)
        {
            string str_sql = "UPDATE Usuarios " +
                             "SET Activo=0" +
                             " WHERE UserName=" + "'" + user.Username + "'";
            //MessageBox.Show(str_sql);
            DBConector.GetDBConector().EjecutarComando(str_sql);
        }



    }
}
