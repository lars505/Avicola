using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class CE_Proveedor
    {
        private int _IdProveedor;
        private string _NombreProveedor;
        private string _Nombrecontacto;
        private string _Email;
        private int _Telefono;
        private string _Direccion;
        private int _CodDepartamento;
        private int _CodMunicipio;

        public int IdProveedor { get => _IdProveedor; set => _IdProveedor = value; }
        public string NombreProveedor { get => _NombreProveedor; set => _NombreProveedor = value; }
        public string Nombrecontacto { get => _Nombrecontacto; set => _Nombrecontacto = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int Telefono { get => _Telefono; set => _Telefono = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public int CodDepartamento { get => _CodDepartamento; set => _CodDepartamento = value; }
        public int CodMunicipio { get => _CodMunicipio; set => _CodMunicipio = value; }
    }
}
