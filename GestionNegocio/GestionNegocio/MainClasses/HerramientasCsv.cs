using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace GestionNegocio.MainClasses
{
    internal class HerramientasCsv
    {
        public static List<string[]> LeerTodasLasLineas(string rutaArchivo)
        {
            List<string[]> lineas = new List<string[]>();
            StreamReader lector = new StreamReader(rutaArchivo);

            try
            {

                while (!lector.EndOfStream)
                {
                    string linea = lector.ReadLine();
                    string[] datos = linea.Split(',');
                    lineas.Add(datos);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al leer el archivo: " + error.Message);
                return null;
            }

            lector.Close();
            return lineas;
        }
        
        public static void SobreescribirArchivo(string rutaArchivo, List<string[]> lineas)
        {
            string archivoTemporal = "temp.csv";

            try
            {
                using (StreamWriter escritor = new StreamWriter(archivoTemporal))
                {
                    foreach (string[] linea in lineas)
                    {
                        string lineaFinal = string.Join(",", linea);
                        escritor.WriteLine(lineaFinal);
                    }
                }

                File.Delete(rutaArchivo);
                File.Move(archivoTemporal, rutaArchivo);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al escribir el archivo: " + error.Message);

                if (File.Exists(archivoTemporal))
                {
                    File.Delete(archivoTemporal);
                }
            }
        }

        public static bool EliminarLineaSoft(string rutaArchivo, int id)
        {
            List<string[]> lineas = LeerTodasLasLineas(rutaArchivo);

            try
            {
                for (int lineaActual = 0; lineaActual < lineas.Count; lineaActual++)
                {
                    if (int.Parse(lineas[lineaActual][0]) == id && lineas[lineaActual].Length > 0)
                    {
                        lineas[lineaActual][0] = "!" + lineas[lineaActual][0];
                        break;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al leer el archivo: " + error.Message);
                return false;
            }

            SobreescribirArchivo(rutaArchivo, lineas);
            return true;
        }

        public static BindingList<Movimiento> ListaStringsAMovimientos(List<string[]> lineas)
        {
            int id;
            decimal monto;
            string descripcion;
            string tipoDeMovimiento;
            string fecha;
            int cedulaCliente;
            string metodoDePago;
            bool ingreso;

            BindingList<Movimiento> movimientos = new BindingList<Movimiento>();

            foreach (string[] linea in lineas)
            { 
                if (linea[0][0] != '!' && int.TryParse(linea[0], out id))
                {
                    id = int.Parse(linea[0]);
                    monto = decimal.Parse(linea[3]);
                    descripcion = linea[6];
                    tipoDeMovimiento = linea[1];
                    fecha = linea[2];
                    cedulaCliente = int.Parse(linea[5]);
                    metodoDePago = linea[4];

                    if (linea[1] == "Ingreso")
                    {
                        ingreso = true;
                    }
                    else
                    {
                        ingreso = false;
                    }

                    Movimiento movimiento = new Movimiento(monto, descripcion, tipoDeMovimiento, ingreso, id, fecha, cedulaCliente, metodoDePago);
                    movimientos.Add(movimiento);
                }
            }

            return movimientos;
        }

        public static BindingList<Cliente> ListaStringsAClientes(List<string[]> lineas)
        {
            int cedula;
            string nombre;
            string correo;
            int edad;
            string residencia;

            BindingList<Cliente> clientes = new BindingList<Cliente>();

            foreach (string[] linea in lineas)
            {
                if (linea[0][0] != '!' && int.TryParse(linea[0], out cedula))
                {
                    cedula = int.Parse(linea[0]);
                    nombre = linea[1];
                    correo = linea[2];
                    edad = int.Parse(linea[3]);
                    residencia = linea[4];

                    Cliente cliente = new Cliente(cedula, nombre, correo, edad, residencia);
                    clientes.Add(cliente);
                }
            }

            return clientes;
        }

        public static void AgregarMovimiento(string rutaArchivo, Movimiento movimiento)
        {
            List<string[]> lineas = LeerTodasLasLineas(rutaArchivo);
            string[] nuevaLinea = new string[7];

            nuevaLinea[0] = movimiento.id.ToString();
            nuevaLinea[1] = movimiento.tipoDeMovimiento;
            nuevaLinea[2] = movimiento.fecha;
            nuevaLinea[3] = movimiento.monto.ToString();
            nuevaLinea[4] = movimiento.metodoDePago;
            nuevaLinea[5] = movimiento.cedulaCliente.ToString();
            nuevaLinea[6] = movimiento.descripcion;

            lineas.Add(nuevaLinea);
            SobreescribirArchivo(rutaArchivo, lineas);
        }

        public static void AgregarCliente(string rutaArchivo, Cliente cliente)
        {
            List<string[]> lineas = LeerTodasLasLineas(rutaArchivo);
            string[] nuevaLinea = new string[5];

            nuevaLinea[0] = cliente.cedula.ToString();
            nuevaLinea[1] = cliente.nombre;
            nuevaLinea[2] = cliente.correo;
            nuevaLinea[3] = cliente.edad.ToString();
            nuevaLinea[4] = cliente.residencia;

            lineas.Add(nuevaLinea);
            SobreescribirArchivo(rutaArchivo, lineas);
        }

        public static void SobreescribirLinea(string rutaArchivo, string id, string[] nuevaLinea)
        {
            List<string[]> lineas = LeerTodasLasLineas(rutaArchivo);

            try
            {
                for (int lineaActual = 0; lineaActual < lineas.Count; lineaActual++)
                {
                    if (lineas[lineaActual][0] == id && lineas[lineaActual].Length > 0)
                    {
                        lineas[lineaActual] = nuevaLinea;
                        break;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al leer el archivo: " + error.Message);
            }

            SobreescribirArchivo(rutaArchivo, lineas);
        }

        public static string[] MovimientoALinea(Movimiento movimiento)
        {
            string[] nuevaLinea = new string[7];

            nuevaLinea[0] = movimiento.id.ToString();
            nuevaLinea[1] = movimiento.tipoDeMovimiento;
            nuevaLinea[2] = movimiento.fecha;
            nuevaLinea[3] = movimiento.monto.ToString();
            nuevaLinea[4] = movimiento.metodoDePago;
            nuevaLinea[5] = movimiento.cedulaCliente.ToString();
            nuevaLinea[6] = movimiento.descripcion;

            return nuevaLinea;
        }

        public static string[] ClienteALinea(Cliente cliente)
        {
            string[] nuevaLinea = new string[5];

            nuevaLinea[0] = cliente.cedula.ToString();
            nuevaLinea[1] = cliente.nombre;
            nuevaLinea[2] = cliente.correo;
            nuevaLinea[3] = cliente.edad.ToString();
            nuevaLinea[4] = cliente.residencia;

            return nuevaLinea;
        }

        public static List<string[]> BingdingListMovimientosALista(BindingList<Movimiento> movimientos)
        {
            List<string[]> lineas = new List<string[]>();

            foreach (Movimiento movimiento in movimientos)
            {
                string[] nuevaLinea = new string[7];
                nuevaLinea[0] = movimiento.id.ToString();
                nuevaLinea[1] = movimiento.tipoDeMovimiento;
                nuevaLinea[2] = movimiento.fecha;
                nuevaLinea[3] = movimiento.monto.ToString();
                nuevaLinea[4] = movimiento.metodoDePago;
                nuevaLinea[5] = movimiento.cedulaCliente.ToString();
                nuevaLinea[6] = movimiento.descripcion;
                lineas.Add(nuevaLinea);
            }

            return lineas;
        }

        public static List<string[]> BingdingListClientesALista(BindingList<Cliente> clientes)
        {
            List<string[]> lineas = new List<string[]>();

            foreach (Cliente cliente in clientes)
            {
                string[] nuevaLinea = new string[5];
                nuevaLinea[0] = cliente.cedula.ToString();
                nuevaLinea[1] = cliente.nombre;
                nuevaLinea[2] = cliente.correo;
                nuevaLinea[3] = cliente.edad.ToString();
                nuevaLinea[4] = cliente.residencia;
                lineas.Add(nuevaLinea);
            }

            return lineas;
        }
    }
}
    