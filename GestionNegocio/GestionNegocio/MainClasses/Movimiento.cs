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
        public string movimiento { get; set; }
        private bool ingreso;

        // constructor
        public Movimiento(decimal _monto, string descripcion, string _tipoDeMovimiento, bool _ingreso, int _id)
        {
            this.monto = _monto;
            this.descripcion = descripcion;
            this.movimiento = _tipoDeMovimiento;
            this.ingreso = _ingreso;
            this.id = _id;
        }

        // getters
        public bool EsIngreso()
        {
            return ingreso;
        }
    }
}
