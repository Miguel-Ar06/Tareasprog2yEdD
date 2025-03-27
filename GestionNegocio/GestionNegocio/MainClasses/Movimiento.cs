using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNegocio.MainClasses
{
    public class Movimiento
    {
        public int id {  get; set; }
        public decimal monto {  get; set; }
        public string descripcion { get; set; }
        public string tipoDeMovimiento { get; set; }
        public string fecha { get; set; }
        public int cedulaCliente { get; set; }
        public string metodoDePago { get; set; }
        public bool ingreso { get; set; }

        // constructor
        public Movimiento(decimal _monto, string descripcion, string _tipoDeMovimiento, bool _ingreso, int _id, string _fecha, int _cedulaCliente, string _metodoDePago)
        {
            this.monto = _monto;
            this.descripcion = descripcion;
            this.tipoDeMovimiento = _tipoDeMovimiento;
            this.ingreso = _ingreso;
            this.id = _id;
            this.fecha = _fecha;
            this.cedulaCliente = _cedulaCliente;
            this.metodoDePago = _metodoDePago;
        }

        // getters
        public bool EsIngreso()
        {
            return ingreso;
        }
    }
}
