
namespace GestionNegocio
{
    partial class PantallaDeBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeBienvenida));
            textoBienvenida = new Label();
            imageList1 = new ImageList(components);
            subText1 = new Label();
            nombreNegocio = new TextBox();
            selectorColor = new ComboBox();
            botonBienvenida = new Button();
            iconoNegocioMaterial = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconoNegocioMaterial).BeginInit();
            SuspendLayout();
            // 
            // textoBienvenida
            // 
            textoBienvenida.Anchor = AnchorStyles.Top;
            textoBienvenida.AutoSize = true;
            textoBienvenida.Font = new Font("SchulVokalDotless", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoBienvenida.ForeColor = Color.FromArgb(64, 64, 64);
            textoBienvenida.ImageAlign = ContentAlignment.TopCenter;
            textoBienvenida.ImageList = imageList1;
            textoBienvenida.Location = new Point(463, 189);
            textoBienvenida.Name = "textoBienvenida";
            textoBienvenida.Size = new Size(227, 41);
            textoBienvenida.TabIndex = 0;
            textoBienvenida.Text = "Bienvenido";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "store_90dp_434343_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // subText1
            // 
            subText1.Anchor = AnchorStyles.Top;
            subText1.AutoSize = true;
            subText1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subText1.ForeColor = Color.FromArgb(64, 64, 64);
            subText1.Location = new Point(263, 250);
            subText1.Name = "subText1";
            subText1.Size = new Size(627, 31);
            subText1.TabIndex = 1;
            subText1.Text = "Configuremos tu negocio! (Podras cambiar esto mas tarde)";
            // 
            // nombreNegocio
            // 
            nombreNegocio.Anchor = AnchorStyles.Top;
            nombreNegocio.BorderStyle = BorderStyle.FixedSingle;
            nombreNegocio.Location = new Point(441, 352);
            nombreNegocio.Name = "nombreNegocio";
            nombreNegocio.PlaceholderText = "Nombre del negocio";
            nombreNegocio.Size = new Size(270, 27);
            nombreNegocio.TabIndex = 2;
            // 
            // selectorColor
            // 
            selectorColor.Anchor = AnchorStyles.Top;
            selectorColor.ForeColor = Color.DimGray;
            selectorColor.FormattingEnabled = true;
            selectorColor.Items.AddRange(new object[] { "Azul", "Verde", "Amarillo", "Naranja", "Rojo", "Violeta", "Negro", "Gris" });
            selectorColor.Location = new Point(441, 412);
            selectorColor.Name = "selectorColor";
            selectorColor.Size = new Size(270, 28);
            selectorColor.TabIndex = 3;
            selectorColor.Text = "Tema de color";
            selectorColor.SelectedIndexChanged += selectorColor_SelectedItemChanged;
            // 
            // botonBienvenida
            // 
            botonBienvenida.Anchor = AnchorStyles.Top;
            botonBienvenida.BackColor = SystemColors.ControlLightLight;
            botonBienvenida.ForeColor = SystemColors.ActiveCaptionText;
            botonBienvenida.Location = new Point(503, 509);
            botonBienvenida.Name = "botonBienvenida";
            botonBienvenida.Size = new Size(141, 43);
            botonBienvenida.TabIndex = 4;
            botonBienvenida.Text = "Aceptar";
            botonBienvenida.UseVisualStyleBackColor = false;
            botonBienvenida.Click += botonBienvenida_Click;
            // 
            // iconoNegocioMaterial
            // 
            iconoNegocioMaterial.Anchor = AnchorStyles.Top;
            iconoNegocioMaterial.Image = Properties.Resources.store_20dp_434343_FILL0_wght400_GRAD0_opsz20;
            iconoNegocioMaterial.Location = new Point(527, 100);
            iconoNegocioMaterial.Name = "iconoNegocioMaterial";
            iconoNegocioMaterial.Size = new Size(80, 80);
            iconoNegocioMaterial.SizeMode = PictureBoxSizeMode.AutoSize;
            iconoNegocioMaterial.TabIndex = 5;
            iconoNegocioMaterial.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(24, 675);
            label1.Name = "label1";
            label1.Size = new Size(225, 20);
            label1.TabIndex = 6;
            label1.Text = "Ver. Beta 0.0.2. Miguel Arismendi";
            // 
            // PantallaDeBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 719);
            Controls.Add(label1);
            Controls.Add(iconoNegocioMaterial);
            Controls.Add(botonBienvenida);
            Controls.Add(selectorColor);
            Controls.Add(nombreNegocio);
            Controls.Add(subText1);
            Controls.Add(textoBienvenida);
            Name = "PantallaDeBienvenida";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)iconoNegocioMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoBienvenida;
        private Label subText1;
        private TextBox nombreNegocio;
        private ComboBox selectorColor;
        private Button botonBienvenida;
        private ImageList imageList1;
        private PictureBox iconoNegocioMaterial;

        // getters

        public string GetItemTextoSelectorColor()
        {
            if (selectorColor.SelectedItem != null)
            {
                return selectorColor.SelectedItem.ToString();
            }
            else
            {
                return "";
            }
        }

        // setters
        public void SetColorBotonBienvenida(Color colorFondo, Color colorTexto)
        {
            botonBienvenida.BackColor = colorFondo;
            botonBienvenida.ForeColor = colorTexto;
        }

        public void SetColorTextoBienvenida(Color colorTexto)
        {
            textoBienvenida.ForeColor = colorTexto;
        }

        public string GetNombreNegocio()
        {
            return nombreNegocio.Text;
        }

        private Label label1;
    }
}
