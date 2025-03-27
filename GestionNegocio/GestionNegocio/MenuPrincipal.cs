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
using System.IO;

namespace GestionNegocio
{
    public partial class MenuPrincipal : Form
    {
        #region Variables Necesarias

        // atributos y campos necesarios para cada pestana
        private PaletaDeColor coloresPrograma;
        private Negocio negocio;

        // rutas relativas de archivos
        private static string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
        private static string rutaDeArchivoClientes = Path.Combine(rutaDeAplicacion, "Resources", "data", "clientes.csv");
        private static string rutaDeArchivoMovimientos = Path.Combine(rutaDeAplicacion, "Resources", "data", "movimientos.csv");

        // datagrids y manipulacion
        private static BindingList<Movimiento> movimientos = HerramientasCsv.ListaStringsAMovimientos(HerramientasCsv.LeerTodasLasLineas(rutaDeArchivoMovimientos));
        private DataGridView _tablaDeMovimientos;
        private BindingSource registroDeMovimientos = new BindingSource();

        private static BindingList<Producto> productos = new BindingList<Producto>(); // pendiente el archivo csv
        private DataGridView _tablaInventario;
        private BindingSource registroInventario = new BindingSource();

        private static BindingList<Cliente> clientes = HerramientasCsv.ListaStringsAClientes(HerramientasCsv.LeerTodasLasLineas(rutaDeArchivoClientes));
        private DataGridView _tablaClientes;
        private BindingSource registroClientes = new BindingSource();



        #endregion

        #region Constructor y carga del formulario

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
            SetColorBotonAgregarProducto(Color.Transparent, coloresPrograma.colorSecundario);
            SetColorBotonBuscarProducto(Color.Transparent, coloresPrograma.colorSecundario);
            SetColorBotonAgregarCliente(Color.Transparent, coloresPrograma.colorSecundario);
            SetColorBotonBuscarCliente(Color.Transparent, coloresPrograma.colorSecundario);
            SetColorBotonBuscarMovimientos(Color.Transparent, coloresPrograma.colorSecundario);
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            // obtener las datagridviews y asignarles las listas correspondientes

            _tablaDeMovimientos = GetTablaDeMovimientos();
            _tablaDeMovimientos.ReadOnly = true;
            registroDeMovimientos.DataSource = movimientos;
            _tablaDeMovimientos.DataSource = registroDeMovimientos;

            _tablaInventario = GetTablaInventario();
            _tablaInventario.ReadOnly = true;
            registroInventario.DataSource = productos;
            _tablaInventario.DataSource = registroInventario;

            _tablaClientes = GetTablaClientes();
            _tablaClientes.ReadOnly = true;
            registroClientes.DataSource = clientes;
            _tablaClientes.DataSource = registroClientes;

            SetMontoTotal(ContarTotalMovimientos());
        }

        #endregion

        #region pestana movimientos y cobros

        private string descripcionMovimiento;
        private decimal montoMovimiento;
        int idMovimiento = 1; // Valor por defecto si no hay movimientos previos
        private string metodoDePago;
        private int cedulaMovimiento;
        private string fechaMovimiento;

        // utilidades
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
                Console.WriteLine("Error, monto invalido: " + montoTexto);
                return -1;
            }
        }

        private string ContarTotalMovimientos()
        {
            decimal total = 0;
            decimal monto = 0;
            string tipoDeMovimiento;

            foreach (DataGridViewRow fila in _tablaDeMovimientos.Rows)
            {
                if ((fila.Cells["monto"].Value != null) && (fila.Cells["tipoDeMovimiento"].Value != null))
                {
                    monto = Convert.ToDecimal(fila.Cells["monto"].Value);
                    tipoDeMovimiento = fila.Cells["tipoDeMovimiento"].Value.ToString();

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

        // eventos
        private void movimientoBotonIngreso_Click(object sender, EventArgs e)
        {
            descripcionMovimiento = GetDescripcionMovimiento();
            montoMovimiento = MontoTextoADecimal(GetMovimientoTextoMonto());
            cedulaMovimiento = GetCedulaClienteMovimiento();
            metodoDePago = GetMetodoDePago();
            fechaMovimiento = GetFechaMovimientoString();

            if (!cedulaClienteExiste(cedulaMovimiento))
            {
                MessageBox.Show("El cliente no existe, debe agregarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (movimientos.Count > 0)
            {
                idMovimiento = movimientos.Max(m => m.id) + 1; // Encuentra el ID máximo y suma 1
            }

            if (montoMovimiento > 0 && cedulaMovimiento != -1 && metodoDePago != "" && fechaMovimiento != "")
            {
                Movimiento movimientoActual = new Movimiento(montoMovimiento, descripcionMovimiento, "Ingreso", true, idMovimiento, fechaMovimiento, cedulaMovimiento, metodoDePago);
                movimientos.Add(movimientoActual);
                HerramientasCsv.AgregarMovimiento(rutaDeArchivoMovimientos, movimientoActual);
                Console.WriteLine("Movimiento agregado (Ingreso)");
                LimpiarDescripcion();
                LimpiarMonto();
                LimpiarCedulaMovimiento();
                LimpiarMetodoDePago();
                SetMontoTotal(ContarTotalMovimientos());
            }
            else
            {
                Console.WriteLine("Error, movimiento invalido: " + montoMovimiento);
                LimpiarMonto();
                MessageBox.Show("Introduzca un movimiento valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void movimientoBotonEgreso_Click(object sender, EventArgs e)
        {
            descripcionMovimiento = GetDescripcionMovimiento();
            montoMovimiento = MontoTextoADecimal(GetMovimientoTextoMonto());
            cedulaMovimiento = GetCedulaClienteMovimiento();
            metodoDePago = GetMetodoDePago();
            fechaMovimiento = GetFechaMovimientoString();

            if (!cedulaClienteExiste(cedulaMovimiento))
            {
                MessageBox.Show("El cliente no existe, debe agregarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (movimientos.Count > 0)
            {
                idMovimiento = movimientos.Max(m => m.id) + 1; // Encuentra el ID máximo y suma 1
            }

            if (montoMovimiento > 0 && cedulaMovimiento != -1 && metodoDePago != "" && fechaMovimiento != "")
            {
                Movimiento movimientoActual = new Movimiento(montoMovimiento, descripcionMovimiento, "Egreso", false, idMovimiento, fechaMovimiento, cedulaMovimiento, metodoDePago);
                movimientos.Add(movimientoActual);
                HerramientasCsv.AgregarMovimiento(rutaDeArchivoMovimientos, movimientoActual);
                Console.WriteLine("Movimiento agregado (Egreso)");
                LimpiarDescripcion();
                LimpiarMonto();
                LimpiarCedulaMovimiento();
                LimpiarMetodoDePago();
                SetMontoTotal(ContarTotalMovimientos());
            }
            else
            {
                Console.WriteLine("Error, movimiento invalido: " + montoMovimiento);
                LimpiarMonto();
                MessageBox.Show("Introduzca un movimiento valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tablaDeMovimientos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_tablaDeMovimientos.RowCount > 0)
            {
                // colorear el texto del tipo de movimiento
                if (_tablaDeMovimientos.Columns[e.ColumnIndex].Name == "tipoDeMovimiento")
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
                    string tipoDeMovimiento = _tablaDeMovimientos.Rows[e.RowIndex].Cells["tipoDeMovimiento"].Value.ToString();

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

        private void botonEliminarMovimiento_Click(object sender, EventArgs e)
        {
            if (_tablaDeMovimientos.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)_tablaDeMovimientos.SelectedRows[0].Cells["Id"].Value;
                Movimiento movimientoAEliminar = movimientos.FirstOrDefault(m => m.id == idSeleccionado);

                if (movimientoAEliminar != null)
                {
                    movimientos.Remove(movimientoAEliminar);

                    HerramientasCsv.SobreescribirArchivo(rutaDeArchivoMovimientos, HerramientasCsv.BingdingListMovimientosALista(movimientos));
                    Console.WriteLine("Movimiento con ID " + idSeleccionado + " eliminado");
                    
                    if (_tablaDeMovimientos.RowCount == movimientos.Count)
                    {
                        SetMontoTotal(ContarTotalMovimientos());
                    }

                    registroDeMovimientos.DataSource = movimientos;
                    _tablaDeMovimientos.DataSource = registroDeMovimientos;

                    LimpiarCedulaMovimiento();
                    LimpiarDescripcion();
                    LimpiarMonto();
                    LimpiarMetodoDePago();
                    SetMontoTotal(ContarTotalMovimientos());

                }
                else
                {
                    MessageBox.Show("No se encontró el movimiento con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonBuscarMovimientos_Click(object sender, EventArgs e)
        {
            int cedulaBusquedaMovimientos = GetCedulaClienteMovimiento();

            if (cedulaClienteExiste(cedulaBusquedaMovimientos))
            {
                List<Movimiento> movimientosBuscados = movimientos.Where(m => m.cedulaCliente == cedulaBusquedaMovimientos).ToList();
                registroDeMovimientos.DataSource = movimientosBuscados;
                _tablaDeMovimientos.DataSource = registroDeMovimientos;
            }
            else
            {
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonResetearMovimientos_Click(object sender, EventArgs e)
        {
            registroDeMovimientos.DataSource = movimientos;
            _tablaDeMovimientos.DataSource = registroDeMovimientos;

            LimpiarCedulaMovimiento();
            LimpiarDescripcion();
            LimpiarMonto();
            LimpiarMetodoDePago();
            SetMontoTotal(ContarTotalMovimientos());
        }

        private void movimientoBotonEditar_Click(object sender, EventArgs e)
        {
            if (_tablaDeMovimientos.SelectedRows.Count > 0)
            {
                int idSeleccionado = (int)_tablaDeMovimientos.SelectedRows[0].Cells["Id"].Value;

                decimal monto = MontoTextoADecimal(GetMovimientoTextoMonto());
                string descripcion = GetDescripcionMovimiento();
                string tipoDeMovimiento = GetMovimientoTextoMonto();
                int id = idSeleccionado;
                string fecha = GetFechaMovimientoString();
                int cedulaCliente = GetCedulaClienteMovimiento();
                string metodoDePago = GetMetodoDePago();

                Movimiento movimientoAEditar = movimientos.FirstOrDefault(m => m.id == idSeleccionado);

                if (movimientoAEditar != null)
                {
                    movimientoAEditar.monto = monto;
                    movimientoAEditar.descripcion = descripcion;
                    movimientoAEditar.tipoDeMovimiento = tipoDeMovimiento;
                    if (tipoDeMovimiento == "Ingreso")
                    {
                        movimientoAEditar.ingreso = true;
                    }
                    else
                    {
                        movimientoAEditar.ingreso = false;
                    }
                    movimientoAEditar.fecha = fecha;
                    movimientoAEditar.cedulaCliente = cedulaCliente;
                    movimientoAEditar.metodoDePago = metodoDePago;

                    movimientos.ResetItem(movimientos.IndexOf(movimientoAEditar));
                    _tablaDeMovimientos.Refresh();

                    HerramientasCsv.SobreescribirArchivo(rutaDeArchivoMovimientos, HerramientasCsv.BingdingListMovimientosALista(movimientos));
                }
                else
                {
                    MessageBox.Show("No se encontró el movimiento con el ID seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region pestana inventarios

        private string nombreDelProducto;
        private int cantidadDelProducto;
        private decimal precioDelProducto;
        private string descripcionDelProducto;
        private string marcaDelProducto;
        private int idDelProducto = 0;

        // eventos

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

        #endregion

        #region Pestana clientes

        private int clienteCedula;
        private string clienteNombre;
        private string clienteCorreo;
        private int clienteEdad;
        private string clienteResidencia;

        private void botonAgregarCliente_Click(object sender, EventArgs e)
        {
            clienteCedula = GetCedulaCliente();
            clienteNombre = GetNombreCliente();
            clienteCorreo = GetCorreoCliente();
            clienteEdad = GetEdadCliente();
            clienteResidencia = GetResidenciaCliente();

            Cliente clienteActual = new Cliente(clienteCedula, clienteNombre, clienteCorreo, clienteEdad, clienteResidencia);

            if (clienteCedula != -1 && clienteNombre != "" && clienteCorreo != "" && clienteEdad != -1 && clienteResidencia != "" && ValidarCorreo(clienteCorreo))
            {
                if (cedulaClienteExiste(clienteCedula) == false)
                {
                    clientes.Add(clienteActual);
                    HerramientasCsv.AgregarCliente(rutaDeArchivoClientes, clienteActual);
                    Console.WriteLine("Cliente agregado");
                    LimpiarCedulaCliente();
                    LimpiarNombreCliente();
                    LimpiarCorreoCliente();
                    LimpiarEdadCliente();
                    LimpiarResidenciaCliente();
                }
                else
                {
                    MessageBox.Show("El cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error, cliente no agregado");
            }
        }

        private bool cedulaClienteExiste(int cedula)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.cedula == cedula)
                {
                    return true;
                }
            }
            return false;
        }

        private void botonBuscarCliente_Click(object sender, EventArgs e)
        {
            clienteCedula = GetCedulaCliente();

            if (cedulaClienteExiste(clienteCedula))
            {
                Cliente clienteBuscado = clientes.First(c => c.cedula == clienteCedula);

                SetNombreCliente(clienteBuscado.nombre);
                SetCorreoCliente(clienteBuscado.correo);
                SetEdadCliente(clienteBuscado.edad);
                SetResidenciaCliente(clienteBuscado.residencia);
            }
            else
            {
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botonEliminarCliente_Click(object sender, EventArgs e)
        {
            clienteCedula = GetCedulaCliente();

            if (cedulaClienteExiste(clienteCedula))
            {
                Cliente clienteAEliminar = clientes.First(c => c.cedula == clienteCedula);

                clientes.Remove(clienteAEliminar);
                HerramientasCsv.SobreescribirArchivo(rutaDeArchivoClientes, HerramientasCsv.BingdingListClientesALista(clientes));
                Console.WriteLine("Cliente eliminado");

                LimpiarCedulaCliente();
                LimpiarNombreCliente();
                LimpiarCorreoCliente();
                LimpiarEdadCliente();
                LimpiarResidenciaCliente();

                int[] idsMovimientosAEliminar = movimientos.Where(m => m.cedulaCliente == clienteCedula).Select(m => m.id).ToArray();

                foreach (int id in idsMovimientosAEliminar)
                {
                    Movimiento movimientoAEliminar = movimientos.First(m => m.id == id);
                    movimientos.Remove(movimientoAEliminar);
                }

                HerramientasCsv.SobreescribirArchivo(rutaDeArchivoMovimientos, HerramientasCsv.BingdingListMovimientosALista(movimientos));
                SetMontoTotal(ContarTotalMovimientos());
            }
            else
            {
                MessageBox.Show("El cliente no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void botonEditarCliente_Click(object sender, EventArgs e)
        {
            clienteCedula = GetCedulaCliente();

            if (!cedulaClienteExiste(clienteCedula))
            {
                MessageBox.Show("El cliente no existe, debe agregarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente clienteEditado = new Cliente(GetCedulaCliente(), GetNombreCliente(), GetCorreoCliente(), GetEdadCliente(), GetResidenciaCliente());

            clientes[clientes.IndexOf(clientes.First(c => c.cedula == clienteCedula))] = clienteEditado;
            HerramientasCsv.SobreescribirArchivo(rutaDeArchivoClientes, HerramientasCsv.BingdingListClientesALista(clientes));
        }

        #endregion

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Cierra la aplicación por completo
        }

        
    }
}
