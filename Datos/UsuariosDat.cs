using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TP_PAV_1._0.Logica.Servicios_de_Usuarios;
using TP_PAV_1._0.Capa_UI.Usuarios;
namespace TP_PAV_1._0.Datos
{
    internal class UsuariosDat
    {
        public static Usuario CrearUsuarioFromRow(DataRow row)
        {
            int IdUser = Convert.ToInt32(row["UserId"].ToString());

            string UserName = row["UserName"].ToString();
            string Email = row["Email"].ToString();
            string Activo = row["Activo"].ToString();
            string Password = row.Table.Columns.Contains("Password") ? row["Password"].ToString() : null;
            int Perfil = Convert.ToInt32(row["id_Perfil"].ToString());
            PerfilUser perf = (PerfilUser)Perfil;
            return new Usuario(IdUser, UserName, Password, Email, perf);
        }
    }
}
