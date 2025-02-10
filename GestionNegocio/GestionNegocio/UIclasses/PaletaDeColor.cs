using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.UIclasses
{
    public class PaletaDeColor
    {
        public string nombre;
        public Color colorPrincipal;
        public Color colorSecundario;
        public Color colorTextos;

        // constructor

        public PaletaDeColor(String nombre ,Color primario, Color secundario, Color textos)
        {
            colorPrincipal = primario;
            colorSecundario = secundario;
            colorTextos = textos;
        }
    }
}
