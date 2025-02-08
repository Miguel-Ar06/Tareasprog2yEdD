namespace GestionNegocio
{
    public partial class PantallaDeBienvenida : Form
    {
        // paleta de colores del programa y diccionario de temas
        PaletaDeColor coloresPrograma;
        private Dictionary<string, PaletaDeColor> temas = new Dictionary<string, PaletaDeColor>();


        public PantallaDeBienvenida()
        {
            InitializeComponent();

            // poblar diccionario con temas
            temas.Add("Azul", new PaletaDeColor(Color.FromArgb(0, 128, 255), Color.FromArgb(51, 153, 153), Color.FromArgb(255, 255, 255)));
            temas.Add("Verde", new PaletaDeColor(Color.FromArgb(0, 153, 76), Color.FromArgb(0, 204, 102), Color.FromArgb(255, 255, 255)));
            temas.Add("Amarillo", new PaletaDeColor(Color.FromArgb(102, 102, 0), Color.FromArgb(204, 204, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Naranja", new PaletaDeColor(Color.FromArgb(153, 76, 0), Color.FromArgb(255, 128, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Rojo", new PaletaDeColor(Color.FromArgb(153, 0, 0), Color.FromArgb(255, 51, 51), Color.FromArgb(255, 255, 255)));
            temas.Add("Violeta", new PaletaDeColor(Color.FromArgb(76, 0, 153), Color.FromArgb(153, 51, 255), Color.FromArgb(255, 255, 255)));
            temas.Add("Negro", new PaletaDeColor(Color.FromArgb(32, 32, 32), Color.FromArgb(64, 64, 64), Color.FromArgb(255, 255, 255)));
            temas.Add("Gris", new PaletaDeColor(Color.FromArgb(96, 96, 96), Color.FromArgb(160, 160, 160), Color.FromArgb(255, 255, 255)));
        }

        private void selectorColor_SelectedItemChanged(object sender, EventArgs e)
        {
            string colorSeleccionado = GetItemTextoSelectorColor();

            if(temas.ContainsKey(colorSeleccionado))
            {
                coloresPrograma = temas[colorSeleccionado];
            }
            else
            {
                coloresPrograma = temas["Gris"];
            }

            SetColorBotonBienvenida(coloresPrograma.colorPrincipal, coloresPrograma.colorTextos);
            SetColorTextoBienvenida(coloresPrograma.colorPrincipal);
        }
    }

    public class PaletaDeColor
    {
        public Color colorPrincipal;
        public Color colorSecundario;
        public Color colorTextos;

        // constructor

        public PaletaDeColor(Color primario, Color secundario, Color textos)
        {
            this.colorPrincipal = primario;
            this.colorSecundario = secundario;
            this.colorTextos = textos;
        }

    }
}
