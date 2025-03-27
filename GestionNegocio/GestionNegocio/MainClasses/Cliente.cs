using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.MainClasses
{
    internal class Cliente
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public int edad { get; set; }
        public string residencia { get; set; }

        public Cliente(int _cedula, string _nombre, string _correo, int _edad, string _residencia)
        {
            this.cedula = _cedula;
            this.nombre = _nombre;
            this.correo = _correo;
            this.edad = _edad;
            this.residencia = _residencia;
        }
    }
}
