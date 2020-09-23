using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Nombrecontacto { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public int CodDepartamento { get; set; }
        public int CodMunicipio { get; set; }
    }
}
