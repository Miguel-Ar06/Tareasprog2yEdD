using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.MainClasses
{
    public class Producto
    {
        public string nombre {  get; set; }
        public int id { get; set; }
        public decimal precio { get; set; }
        public string? descripcion { get; set; }
        public int cantidad { get; set; }
        public string? marca { get; set; }

        // constructor
        public Producto(string _nombre, int _id, decimal _precio, string? _descripcion, int _cantidad, string _marca)
        {
            this.nombre = _nombre;
            this.id = _id;
            this.precio = _precio;
            this.descripcion = _descripcion;
            this.cantidad = _cantidad;
            this.marca = _marca;
        }
    }
}
