using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAV_1._0.Logica.Entidades
{
    public class Proveedor
    {
        string cuit;
        string razonSocial;
        string contacto;
        string telefono;
        bool activo;

        public Proveedor(string cuit, string razonSocial, string contacto, string telefono, bool activo = true)
        {
            this.cuit = cuit;
            this.razonSocial = razonSocial;
            this.contacto = contacto;
            this.telefono = telefono;
            this.activo = activo;
        }

        public string Cuit { get => cuit; set => cuit = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public bool Activo { get => activo; set => activo = value; }

        public override string ToString()
        {
            return razonSocial + "//" + contacto + "//" + telefono;
        }

    }
}
