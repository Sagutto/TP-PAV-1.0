using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAV_1._0.Capa_UI.Usuarios;

namespace TP_PAV_1._0.Logica.Servicios_de_Usuarios
{


    public class Usuario
    {
        int idUser;
        string username;
        string password;
        string email;
        PerfilUser perfil;
        bool activo;

        public int IdUser { get => idUser; }
        public string Username { get => username; }
        public string Password { get => password; }
        public string Email { get => email; }
        public bool Activo { get => activo; }
        public PerfilUser Perfil { get => perfil; }

        public Usuario(int IdUser, string username, string password, string email, PerfilUser perfil, bool activo = true)
        {
            this.idUser = IdUser;
            this.username = username;
            this.password = password;
            this.email = email;
            this.perfil = perfil;
            this.activo = activo;
        }
        public override string ToString()
        {
            return "ID=" + idUser + " Nombre=" + username + " Email:" + email + " Perfil:" + perfil.ToString();
        }
    }
}

