using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNegocio.MainClasses;
using GestionNegocio.UIclasses;

namespace GestionNegocio
{
    public partial class MenuPrincipal : Form
    {
        // atributos y campos necesarios para cada pestana
        private PaletaDeColor coloresPrograma;
        private Negocio negocio;

        private BindingList<Movimiento> movimientos = new BindingList<Movimiento>();
        private DataGridView _tablaDeMovimientos;
        private BindingSource registroDeMovimientos = new BindingSource();

        private BindingList<Producto> productos = new BindingList<Producto>();
        private DataGridView _tablaInventario;
        private BindingSource registroInventario = new BindingSource();


        // Constructor y carga del formulario
        public MenuPrincipal(Negocio _negocio, PaletaDeColor _coloresPrograma)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            this.negocio = _negocio;
            SetNombreNegocio(negocio.GetNombre());

            // Aplicar todos los colores del tema
            this.coloresPrograma = _coloresPrograma;
            SetColorNombreNegocio(Color.Transparent, coloresPrograma.colorPrincipal);
            SetColorTextoTotal(Color.Transparent, coloresPrograma.colorSecundario);
            SetColorBotonAgregar(Color.Transparent, coloresPrograma.colorSecundario);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // obtener las datagridviews y asignarles las listas correspondientes

            _tablaDeMovimientos = GetTablaDeMovimientos();
            registroDeMovimientos.DataSource = movimientos;
            _tablaDeMovimientos.DataSource = registroDeMovimientos;

            _tablaInventario = GetTablaInventario();
            registroInventario.DataSource = productos;
            _tablaInventario.DataSource = registroInventario;

        }

        // pestana movimientos y cobros
        private string descripcionMovimiento;
        private decimal montoMovimiento;
        private int idMovimiento = 0;

        private decimal MontoTextoADecimal(string montoTexto)
        {
            decimal monto;

            if (decimal.TryParse(montoTexto, NumberStyles.Number, CultureInfo.InvariantCulture, out monto))
            {
                Console.WriteLine("monto: " + monto);
                return monto;
            }
            else
            {
                Console.WriteLine("Error, monto invalido: " + movimientoTextoMonto.Text);
                return -1;
            }
        }

        private void movimientoBotonIngreso_Click(object sender, EventArgs e)
        {
            descripcionMovimiento = GetDescripcionMovimiento();
            montoMovimiento = MontoTextoADecimal(GetMovimientoTextoMonto());

            if (montoMovimiento > 0)
            {
                movimientos.Add(new Movimiento(montoMovimiento, descripcionMovimiento, "Ingreso", true, idMovimiento));
                Console.WriteLine("Movimiento agregado (Ingreso)");
                LimpiarDescripcion();
                LimpiarMonto();
                SetMontoTotal(ContarTotalMovimientos());
            }
            else
            {
                Console.WriteLine("Error, monto invalido: " + montoMovimiento);
                LimpiarMonto();
                MessageBox.Show("Introduzca un monto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            idMovimiento++;
        }

        private void movimientoBotonEgreso_Click(object sender, EventArgs e)
        {
            descripcionMovimiento = GetDescripcionMovimiento();
            montoMovimiento = MontoTextoADecimal(GetMovimientoTextoMonto());

            if (montoMovimiento > 0)
            {
                movimientos.Add(new Movimiento(montoMovimiento, descripcionMovimiento, "Egreso", false, idMovimiento));
                Console.WriteLine("Movimiento agregado (Egreso)");
                LimpiarDescripcion();
                LimpiarMonto();
                SetMontoTotal(ContarTotalMovimientos());
            }
            else
            {
                Console.WriteLine("Error, monto invalido: " + montoMovimiento);
                LimpiarMonto();
                MessageBox.Show("Introduzca un monto valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            idMovimiento++;
        }

        private void tablaDeMovimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_tablaDeMovimientos.RowCount > 0)
            {
                // colorear el texto del tipo de movimiento
                if (_tablaDeMovimientos.Columns[e.ColumnIndex].Name == "movimiento")
                {
                    if ((string)e.Value == "Ingreso")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }

                // colorear el texto del monto segun el tipo de movimiento
                if (_tablaDeMovimientos.Columns[e.ColumnIndex].Name == "monto")
                {
                    string tipoDeMovimiento = _tablaDeMovimientos.Rows[e.RowIndex].Cells["movimiento"].Value.ToString();

                    if (tipoDeMovimiento == "Ingreso")
                    {
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private string ContarTotalMovimientos()
        {
            decimal total = 0;
            decimal monto = 0;
            string tipoDeMovimiento;

            foreach (DataGridViewRow fila in _tablaDeMovimientos.Rows)
            {
                if ((fila.Cells["monto"].Value != null) && (fila.Cells["movimiento"].Value != null))
                {
                    monto = Convert.ToDecimal(fila.Cells["monto"].Value);
                    tipoDeMovimiento = fila.Cells["movimiento"].Value.ToString();

                    if (tipoDeMovimiento == "Ingreso")
                    {
                        total += monto;
                    }
                    else
                    {
                        total -= monto;
                    }
                }
            }

            return (total.ToString() + "$");
        }

        private void botonEliminarMovimiento_Click(object sender, EventArgs e)
        {
            if (_tablaDeMovimientos.SelectedRows.Count > 0)
            {
                int indiceFilaSeleccionada = _tablaDeMovimientos.SelectedRows[0].Index;

                movimientos.RemoveAt(indiceFilaSeleccionada);
                Console.WriteLine("Movimiento " + indiceFilaSeleccionada + " eliminado");
                SetMontoTotal(ContarTotalMovimientos());
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // pestana inventarios
        private string nombreDelProducto;
        private int cantidadDelProducto;
        private decimal precioDelProducto;
        private string descripcionDelProducto;
        private string marcaDelProducto;
        private int idDelProducto = 0;

        private void botonAgregarProducto_Click(object sender, EventArgs e)
        {
            nombreDelProducto = GetNombreProducto();
            cantidadDelProducto = GetCantidadProducto();
            precioDelProducto = GetPrecioProducto();
            descripcionDelProducto = GetDescripcionProducto();
            marcaDelProducto = GetMarcaProdudcto();

            if ((nombreDelProducto != "") && (cantidadDelProducto != -1) && (precioDelProducto != -1))
            {
                productos.Add(new Producto(nombreDelProducto, idDelProducto, precioDelProducto, descripcionDelProducto, cantidadDelProducto, marcaDelProducto));
                Console.WriteLine("Producto agregado");

                LimpiarCantidadProducto();
                LimpiarDescripcionProducto();
                LimpiarPrecioProducto();
                LimpiarMarcaProducto();
                LimpiarNombreProducto();

                idDelProducto++;
            }
            else
            {
                MessageBox.Show("Rellene los campos obligatorios *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error, producto no agregado");
            }
        }

        private void botonEliminarProducto_Click(object sender, EventArgs e)
        {
            if (tablaInventario.SelectedRows.Count > 0)
            {
                int indiceFilaSeleccionada = tablaInventario.SelectedRows[0].Index;

                productos.RemoveAt(indiceFilaSeleccionada);
                Console.WriteLine("Producto " + indiceFilaSeleccionada + " eliminado");
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
