using GestionNegocio.MainClasses;
using GestionNegocio.UIclasses;

namespace GestionNegocio
{
    public partial class PantallaDeBienvenida : Form
    {
        private Negocio negocio;

        // paleta de colores del programa y diccionario de temas
        public PaletaDeColor coloresPrograma;
        private Dictionary<string, PaletaDeColor> temas = new Dictionary<string, PaletaDeColor>();

        public PantallaDeBienvenida()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // poblar diccionario con temas
            temas.Add("Azul", new PaletaDeColor("Azul", Color.FromArgb(0, 128, 255), Color.FromArgb(0, 153, 153), Color.FromArgb(255, 255, 255)));
            temas.Add("Verde", new PaletaDeColor("Verde", Color.FromArgb(0, 204, 102), Color.FromArgb(102, 204, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Amarillo", new PaletaDeColor("Amarillo", Color.FromArgb(204, 204, 0), Color.FromArgb(102, 102, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Naranja", new PaletaDeColor("Naranja", Color.FromArgb(255, 126, 0), Color.FromArgb(153, 76, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Rojo", new PaletaDeColor("Rojo", Color.FromArgb(204, 0, 0), Color.FromArgb(204, 0, 102), Color.FromArgb(255, 255, 255)));
            temas.Add("Violeta", new PaletaDeColor("Violeta", Color.FromArgb(102, 0, 204), Color.FromArgb(153, 0, 153), Color.FromArgb(255, 255, 255)));
            temas.Add("Negro", new PaletaDeColor("Negro", Color.FromArgb(32, 32, 32), Color.FromArgb(64, 64, 64), Color.FromArgb(255, 255, 255)));
            temas.Add("Gris", new PaletaDeColor("Gris", Color.FromArgb(96, 96, 96), Color.FromArgb(160, 160, 160), Color.FromArgb(255, 255, 255)));
        }

        string colorSeleccionado;
        private void selectorColor_SelectedItemChanged(object sender, EventArgs e)
        {
            colorSeleccionado = GetItemTextoSelectorColor();

            if (temas.ContainsKey(colorSeleccionado))
            {
                coloresPrograma = temas[colorSeleccionado];
                Console.WriteLine("Color establecido a " + colorSeleccionado);
            }
            else
            {
                coloresPrograma = temas["Gris"];
                Console.WriteLine("Color del tema establecido a color por defecto gris");
            }

            SetColorBotonBienvenida(coloresPrograma.colorPrincipal, coloresPrograma.colorTextos);
            SetColorTextoBienvenida(coloresPrograma.colorPrincipal);
            Console.WriteLine("Paleta de color cambiada a " + coloresPrograma.nombre);
        }

        private void botonBienvenida_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Boton bienvenida clickeado");

            // en caso de que jamas se toque el selector de tema
            colorSeleccionado = GetItemTextoSelectorColor();
            if (temas.ContainsKey(colorSeleccionado) == false)
            {
                coloresPrograma = temas["Gris"];
                Console.WriteLine("Color del tema establecido a color por defecto gris");
            }

            if (GetNombreNegocio() == "")
            {
                MessageBox.Show("El nombre no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                negocio = new Negocio(GetNombreNegocio());
                Console.WriteLine("Ventana de menu abierta");
                MenuPrincipal menuPrincipal = new MenuPrincipal(negocio, coloresPrograma);
                menuPrincipal.Show();

                this.Hide();
                Console.WriteLine("Ventana de bienvenida cerrada");
            }
        }
    }
}
