namespace CorsaSimulator
{
    partial class ventanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            panelFondo = new Panel();
            panelCambios = new Panel();
            palancaEnReversa = new Label();
            PalancaEn4 = new Label();
            palancaEn2 = new Label();
            palancaEn5 = new Label();
            palancaEn3 = new Label();
            palancaEn1 = new Label();
            palancaEnNeutro = new Label();
            velocidadR = new Label();
            velocidad4 = new Label();
            velocidad2 = new Label();
            velocidad5 = new Label();
            velocidad3 = new Label();
            velocidad1 = new Label();
            guiaPalanca = new PictureBox();
            panelControlRadio = new Panel();
            radioTexto = new Label();
            botonAnterior = new Button();
            botonSiguiente = new Button();
            botonPlayPausa = new Button();
            panelInfoRadio = new Panel();
            panelFondo2 = new Panel();
            indicadorReversa = new Label();
            velocimetro = new Label();
            progressBarVelocidad = new ProgressBar();
            panelVelocimetro = new Panel();
            labelFelchaIzquierda = new Label();
            labelFlechaDerecha = new Label();
            botonLucesR = new Button();
            botonLuces = new Button();
            botonLucesL = new Button();
            croche = new Button();
            freno = new Button();
            acelerador = new Button();
            botonEncendido = new Button();
            voltantePng = new PictureBox();
            pictureBox1 = new PictureBox();
            tipPalanca = new ToolTip(components);
            corsaVistaSuperior = new PictureBox();
            imagenParabrisasCentro = new PictureBox();
            gifHumo = new PictureBox();
            lucesFrontalesDer = new PictureBox();
            lucesFrontalesIzq = new PictureBox();
            lucesTraserasDer = new PictureBox();
            lucesTraserasIzq = new PictureBox();
            imagenParabrisasDerecha = new PictureBox();
            imagenParabrisasIzquierda = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panelFondo.SuspendLayout();
            panelCambios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guiaPalanca).BeginInit();
            panelControlRadio.SuspendLayout();
            panelFondo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)voltantePng).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)corsaVistaSuperior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenParabrisasCentro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gifHumo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lucesFrontalesDer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lucesFrontalesIzq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lucesTraserasDer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lucesTraserasIzq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenParabrisasDerecha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenParabrisasIzquierda).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFondo.BackColor = Color.FromArgb(64, 64, 64);
            panelFondo.Controls.Add(label1);
            panelFondo.Controls.Add(panelCambios);
            panelFondo.Controls.Add(panelControlRadio);
            panelFondo.Controls.Add(panelFondo2);
            panelFondo.Location = new Point(-1, 311);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(992, 474);
            panelFondo.TabIndex = 0;
            // 
            // panelCambios
            // 
            panelCambios.BackColor = Color.FromArgb(48, 48, 48);
            panelCambios.Controls.Add(palancaEnReversa);
            panelCambios.Controls.Add(PalancaEn4);
            panelCambios.Controls.Add(palancaEn2);
            panelCambios.Controls.Add(palancaEn5);
            panelCambios.Controls.Add(palancaEn3);
            panelCambios.Controls.Add(palancaEn1);
            panelCambios.Controls.Add(palancaEnNeutro);
            panelCambios.Controls.Add(velocidadR);
            panelCambios.Controls.Add(velocidad4);
            panelCambios.Controls.Add(velocidad2);
            panelCambios.Controls.Add(velocidad5);
            panelCambios.Controls.Add(velocidad3);
            panelCambios.Controls.Add(velocidad1);
            panelCambios.Controls.Add(guiaPalanca);
            panelCambios.Location = new Point(491, 114);
            panelCambios.Name = "panelCambios";
            panelCambios.Size = new Size(232, 320);
            panelCambios.TabIndex = 2;
            // 
            // palancaEnReversa
            // 
            palancaEnReversa.AutoSize = true;
            palancaEnReversa.BackColor = Color.Silver;
            palancaEnReversa.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            palancaEnReversa.Location = new Point(173, 221);
            palancaEnReversa.Name = "palancaEnReversa";
            palancaEnReversa.Size = new Size(44, 50);
            palancaEnReversa.TabIndex = 12;
            palancaEnReversa.Text = "R";
            palancaEnReversa.Visible = false;
            // 
            // PalancaEn4
            // 
            PalancaEn4.AutoSize = true;
            PalancaEn4.BackColor = Color.Silver;
            PalancaEn4.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PalancaEn4.Location = new Point(97, 221);
            PalancaEn4.Name = "PalancaEn4";
            PalancaEn4.Size = new Size(42, 50);
            PalancaEn4.TabIndex = 11;
            PalancaEn4.Text = "4";
            PalancaEn4.Visible = false;
            // 
            // palancaEn2
            // 
            palancaEn2.AutoSize = true;
            palancaEn2.BackColor = Color.Silver;
            palancaEn2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            palancaEn2.Location = new Point(16, 221);
            palancaEn2.Name = "palancaEn2";
            palancaEn2.Size = new Size(42, 50);
            palancaEn2.TabIndex = 10;
            palancaEn2.Text = "2";
            palancaEn2.Visible = false;
            // 
            // palancaEn5
            // 
            palancaEn5.AutoSize = true;
            palancaEn5.BackColor = Color.Silver;
            palancaEn5.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            palancaEn5.Location = new Point(171, 68);
            palancaEn5.Name = "palancaEn5";
            palancaEn5.Size = new Size(42, 50);
            palancaEn5.TabIndex = 9;
            palancaEn5.Text = "5";
            palancaEn5.Visible = false;
            // 
            // palancaEn3
            // 
            palancaEn3.AutoSize = true;
            palancaEn3.BackColor = Color.Silver;
            palancaEn3.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            palancaEn3.Location = new Point(97, 68);
            palancaEn3.Name = "palancaEn3";
            palancaEn3.Size = new Size(42, 50);
            palancaEn3.TabIndex = 8;
            palancaEn3.Text = "3";
            palancaEn3.Visible = false;
            // 
            // palancaEn1
            // 
            palancaEn1.AutoSize = true;
            palancaEn1.BackColor = Color.Silver;
            palancaEn1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            palancaEn1.Location = new Point(16, 68);
            palancaEn1.Name = "palancaEn1";
            palancaEn1.Size = new Size(42, 50);
            palancaEn1.TabIndex = 7;
            palancaEn1.Text = "1";
            palancaEn1.Visible = false;
            // 
            // palancaEnNeutro
            // 
            palancaEnNeutro.AutoSize = true;
            palancaEnNeutro.BackColor = Color.Silver;
            palancaEnNeutro.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            palancaEnNeutro.Location = new Point(97, 138);
            palancaEnNeutro.Name = "palancaEnNeutro";
            palancaEnNeutro.Size = new Size(50, 50);
            palancaEnNeutro.TabIndex = 2;
            palancaEnNeutro.Text = "N";
            // 
            // velocidadR
            // 
            velocidadR.AutoSize = true;
            velocidadR.BackColor = Color.Transparent;
            velocidadR.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            velocidadR.ForeColor = SystemColors.AppWorkspace;
            velocidadR.Location = new Point(180, 233);
            velocidadR.Name = "velocidadR";
            velocidadR.Size = new Size(35, 38);
            velocidadR.TabIndex = 6;
            velocidadR.Text = "R";
            // 
            // velocidad4
            // 
            velocidad4.AutoSize = true;
            velocidad4.BackColor = Color.Transparent;
            velocidad4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            velocidad4.ForeColor = SystemColors.AppWorkspace;
            velocidad4.Location = new Point(103, 233);
            velocidad4.Name = "velocidad4";
            velocidad4.Size = new Size(33, 38);
            velocidad4.TabIndex = 5;
            velocidad4.Text = "4";
            // 
            // velocidad2
            // 
            velocidad2.AutoSize = true;
            velocidad2.BackColor = Color.Transparent;
            velocidad2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            velocidad2.ForeColor = SystemColors.AppWorkspace;
            velocidad2.Location = new Point(20, 233);
            velocidad2.Name = "velocidad2";
            velocidad2.Size = new Size(33, 38);
            velocidad2.TabIndex = 1;
            velocidad2.Text = "2";
            // 
            // velocidad5
            // 
            velocidad5.AutoSize = true;
            velocidad5.BackColor = Color.Transparent;
            velocidad5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            velocidad5.ForeColor = SystemColors.AppWorkspace;
            velocidad5.Location = new Point(180, 57);
            velocidad5.Name = "velocidad5";
            velocidad5.Size = new Size(33, 38);
            velocidad5.TabIndex = 4;
            velocidad5.Text = "5";
            // 
            // velocidad3
            // 
            velocidad3.AutoSize = true;
            velocidad3.BackColor = Color.Transparent;
            velocidad3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            velocidad3.ForeColor = SystemColors.AppWorkspace;
            velocidad3.Location = new Point(103, 57);
            velocidad3.Name = "velocidad3";
            velocidad3.Size = new Size(33, 38);
            velocidad3.TabIndex = 3;
            velocidad3.Text = "3";
            // 
            // velocidad1
            // 
            velocidad1.AutoSize = true;
            velocidad1.BackColor = Color.Transparent;
            velocidad1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            velocidad1.ForeColor = SystemColors.AppWorkspace;
            velocidad1.Location = new Point(20, 57);
            velocidad1.Name = "velocidad1";
            velocidad1.Size = new Size(33, 38);
            velocidad1.TabIndex = 2;
            velocidad1.Text = "1";
            // 
            // guiaPalanca
            // 
            guiaPalanca.Image = (Image)resources.GetObject("guiaPalanca.Image");
            guiaPalanca.Location = new Point(9, 87);
            guiaPalanca.Name = "guiaPalanca";
            guiaPalanca.Size = new Size(220, 158);
            guiaPalanca.SizeMode = PictureBoxSizeMode.Zoom;
            guiaPalanca.TabIndex = 2;
            guiaPalanca.TabStop = false;
            // 
            // panelControlRadio
            // 
            panelControlRadio.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelControlRadio.BackColor = Color.FromArgb(32, 32, 32);
            panelControlRadio.Controls.Add(radioTexto);
            panelControlRadio.Controls.Add(botonAnterior);
            panelControlRadio.Controls.Add(botonSiguiente);
            panelControlRadio.Controls.Add(botonPlayPausa);
            panelControlRadio.Controls.Add(panelInfoRadio);
            panelControlRadio.Location = new Point(491, 21);
            panelControlRadio.Name = "panelControlRadio";
            panelControlRadio.Size = new Size(434, 75);
            panelControlRadio.TabIndex = 3;
            // 
            // radioTexto
            // 
            radioTexto.AutoSize = true;
            radioTexto.BackColor = Color.DarkOliveGreen;
            radioTexto.Location = new Point(75, 26);
            radioTexto.Name = "radioTexto";
            radioTexto.Size = new Size(0, 20);
            radioTexto.TabIndex = 2;
            // 
            // botonAnterior
            // 
            botonAnterior.BackColor = Color.FromArgb(224, 224, 224);
            botonAnterior.FlatStyle = FlatStyle.Popup;
            botonAnterior.Location = new Point(324, 15);
            botonAnterior.Name = "botonAnterior";
            botonAnterior.Size = new Size(42, 43);
            botonAnterior.TabIndex = 2;
            botonAnterior.Text = "|◀";
            botonAnterior.UseVisualStyleBackColor = false;
            botonAnterior.Click += botonAnterior_Click;
            // 
            // botonSiguiente
            // 
            botonSiguiente.BackColor = Color.FromArgb(224, 224, 224);
            botonSiguiente.FlatStyle = FlatStyle.Popup;
            botonSiguiente.Location = new Point(372, 15);
            botonSiguiente.Name = "botonSiguiente";
            botonSiguiente.Size = new Size(42, 43);
            botonSiguiente.TabIndex = 1;
            botonSiguiente.Text = "▶|";
            botonSiguiente.UseVisualStyleBackColor = false;
            botonSiguiente.Click += botonSiguiente_Click;
            // 
            // botonPlayPausa
            // 
            botonPlayPausa.BackColor = Color.FromArgb(224, 224, 224);
            botonPlayPausa.FlatStyle = FlatStyle.Popup;
            botonPlayPausa.Location = new Point(16, 15);
            botonPlayPausa.Name = "botonPlayPausa";
            botonPlayPausa.Size = new Size(42, 43);
            botonPlayPausa.TabIndex = 0;
            botonPlayPausa.Text = "▶||";
            botonPlayPausa.UseVisualStyleBackColor = false;
            botonPlayPausa.Click += botonPlayPausa_Click;
            // 
            // panelInfoRadio
            // 
            panelInfoRadio.BackColor = Color.DarkOliveGreen;
            panelInfoRadio.Location = new Point(64, 15);
            panelInfoRadio.Name = "panelInfoRadio";
            panelInfoRadio.Size = new Size(254, 43);
            panelInfoRadio.TabIndex = 2;
            // 
            // panelFondo2
            // 
            panelFondo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelFondo2.BackColor = Color.FromArgb(32, 32, 32);
            panelFondo2.Controls.Add(indicadorReversa);
            panelFondo2.Controls.Add(velocimetro);
            panelFondo2.Controls.Add(progressBarVelocidad);
            panelFondo2.Controls.Add(panelVelocimetro);
            panelFondo2.Controls.Add(labelFelchaIzquierda);
            panelFondo2.Controls.Add(labelFlechaDerecha);
            panelFondo2.Controls.Add(botonLucesR);
            panelFondo2.Controls.Add(botonLuces);
            panelFondo2.Controls.Add(botonLucesL);
            panelFondo2.Controls.Add(croche);
            panelFondo2.Controls.Add(freno);
            panelFondo2.Controls.Add(acelerador);
            panelFondo2.Controls.Add(botonEncendido);
            panelFondo2.Controls.Add(voltantePng);
            panelFondo2.Location = new Point(-3, 23);
            panelFondo2.Name = "panelFondo2";
            panelFondo2.Size = new Size(476, 448);
            panelFondo2.TabIndex = 0;
            // 
            // indicadorReversa
            // 
            indicadorReversa.AutoSize = true;
            indicadorReversa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            indicadorReversa.ForeColor = Color.Coral;
            indicadorReversa.Location = new Point(125, 17);
            indicadorReversa.Name = "indicadorReversa";
            indicadorReversa.Size = new Size(19, 20);
            indicadorReversa.TabIndex = 11;
            indicadorReversa.Text = "R";
            indicadorReversa.Visible = false;
            // 
            // velocimetro
            // 
            velocimetro.AutoSize = true;
            velocimetro.BackColor = Color.Transparent;
            velocimetro.Font = new Font("Segoe UI", 8F);
            velocimetro.ForeColor = SystemColors.ButtonHighlight;
            velocimetro.Location = new Point(245, 19);
            velocimetro.Name = "velocimetro";
            velocimetro.Size = new Size(42, 19);
            velocimetro.TabIndex = 9;
            velocimetro.Text = "Km/h";
            // 
            // progressBarVelocidad
            // 
            progressBarVelocidad.ForeColor = SystemColors.ControlDarkDark;
            progressBarVelocidad.Location = new Point(150, 13);
            progressBarVelocidad.Maximum = 180;
            progressBarVelocidad.Name = "progressBarVelocidad";
            progressBarVelocidad.Size = new Size(89, 29);
            progressBarVelocidad.TabIndex = 2;
            // 
            // panelVelocimetro
            // 
            panelVelocimetro.BackColor = Color.FromArgb(64, 64, 64);
            panelVelocimetro.Location = new Point(150, 13);
            panelVelocimetro.Name = "panelVelocimetro";
            panelVelocimetro.Size = new Size(168, 31);
            panelVelocimetro.TabIndex = 10;
            // 
            // labelFelchaIzquierda
            // 
            labelFelchaIzquierda.AutoSize = true;
            labelFelchaIzquierda.BackColor = Color.DarkGray;
            labelFelchaIzquierda.Font = new Font("Segoe UI", 16F);
            labelFelchaIzquierda.Location = new Point(128, 172);
            labelFelchaIzquierda.Name = "labelFelchaIzquierda";
            labelFelchaIzquierda.Size = new Size(36, 37);
            labelFelchaIzquierda.TabIndex = 8;
            labelFelchaIzquierda.Text = "H";
            // 
            // labelFlechaDerecha
            // 
            labelFlechaDerecha.AutoSize = true;
            labelFlechaDerecha.BackColor = Color.DarkGray;
            labelFlechaDerecha.Font = new Font("Segoe UI", 16F);
            labelFlechaDerecha.Location = new Point(312, 172);
            labelFlechaDerecha.Name = "labelFlechaDerecha";
            labelFlechaDerecha.Size = new Size(33, 37);
            labelFlechaDerecha.TabIndex = 7;
            labelFlechaDerecha.Text = "K";
            // 
            // botonLucesR
            // 
            botonLucesR.BackColor = Color.FromArgb(64, 64, 64);
            botonLucesR.FlatStyle = FlatStyle.Popup;
            botonLucesR.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonLucesR.ForeColor = SystemColors.Control;
            botonLucesR.Location = new Point(70, 144);
            botonLucesR.Name = "botonLucesR";
            botonLucesR.Size = new Size(30, 39);
            botonLucesR.TabIndex = 7;
            botonLucesR.Text = "R";
            botonLucesR.UseVisualStyleBackColor = false;
            botonLucesR.Click += botonLucesR_Click;
            // 
            // botonLuces
            // 
            botonLuces.BackColor = Color.FromArgb(64, 64, 64);
            botonLuces.FlatStyle = FlatStyle.Popup;
            botonLuces.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonLuces.ForeColor = SystemColors.Control;
            botonLuces.Location = new Point(33, 70);
            botonLuces.Name = "botonLuces";
            botonLuces.Size = new Size(67, 68);
            botonLuces.TabIndex = 5;
            botonLuces.Text = "💡";
            botonLuces.UseVisualStyleBackColor = false;
            botonLuces.Click += botonLuces_Click;
            // 
            // botonLucesL
            // 
            botonLucesL.BackColor = Color.FromArgb(64, 64, 64);
            botonLucesL.FlatStyle = FlatStyle.Popup;
            botonLucesL.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            botonLucesL.ForeColor = SystemColors.Control;
            botonLucesL.Location = new Point(33, 144);
            botonLucesL.Name = "botonLucesL";
            botonLucesL.Size = new Size(30, 39);
            botonLucesL.TabIndex = 6;
            botonLucesL.Text = "L";
            botonLucesL.UseVisualStyleBackColor = false;
            botonLucesL.Click += botonLucesL_Click;
            // 
            // croche
            // 
            croche.BackColor = SystemColors.ControlDark;
            croche.FlatStyle = FlatStyle.Flat;
            croche.Font = new Font("Segoe UI", 24F);
            croche.Location = new Point(207, 350);
            croche.Name = "croche";
            croche.Size = new Size(55, 75);
            croche.TabIndex = 4;
            croche.Text = "C";
            croche.UseVisualStyleBackColor = false;
            // 
            // freno
            // 
            freno.BackColor = SystemColors.ControlDark;
            freno.FlatStyle = FlatStyle.Flat;
            freno.Font = new Font("Segoe UI", 24F);
            freno.Location = new Point(284, 350);
            freno.Name = "freno";
            freno.Size = new Size(55, 75);
            freno.TabIndex = 3;
            freno.Text = "J";
            freno.UseVisualStyleBackColor = false;
            // 
            // acelerador
            // 
            acelerador.BackColor = SystemColors.ControlDark;
            acelerador.FlatStyle = FlatStyle.Flat;
            acelerador.Font = new Font("Segoe UI", 24F);
            acelerador.Location = new Point(361, 312);
            acelerador.Name = "acelerador";
            acelerador.Size = new Size(55, 113);
            acelerador.TabIndex = 2;
            acelerador.Text = "U";
            acelerador.UseVisualStyleBackColor = false;
            // 
            // botonEncendido
            // 
            botonEncendido.BackColor = Color.FromArgb(64, 64, 64);
            botonEncendido.FlatStyle = FlatStyle.Popup;
            botonEncendido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonEncendido.ForeColor = SystemColors.Control;
            botonEncendido.Location = new Point(373, 70);
            botonEncendido.Name = "botonEncendido";
            botonEncendido.Size = new Size(67, 68);
            botonEncendido.TabIndex = 1;
            botonEncendido.Text = "ON / OFF";
            botonEncendido.UseVisualStyleBackColor = false;
            botonEncendido.Click += botonEncendido_Click;
            // 
            // voltantePng
            // 
            voltantePng.BackColor = Color.Transparent;
            voltantePng.BackgroundImageLayout = ImageLayout.None;
            voltantePng.Image = (Image)resources.GetObject("voltantePng.Image");
            voltantePng.Location = new Point(-11, -19);
            voltantePng.Name = "voltantePng";
            voltantePng.Size = new Size(499, 400);
            voltantePng.SizeMode = PictureBoxSizeMode.Zoom;
            voltantePng.TabIndex = 2;
            voltantePng.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonShadow;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1048, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(277, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // corsaVistaSuperior
            // 
            corsaVistaSuperior.Image = (Image)resources.GetObject("corsaVistaSuperior.Image");
            corsaVistaSuperior.Location = new Point(1048, 220);
            corsaVistaSuperior.Name = "corsaVistaSuperior";
            corsaVistaSuperior.Size = new Size(274, 476);
            corsaVistaSuperior.SizeMode = PictureBoxSizeMode.Zoom;
            corsaVistaSuperior.TabIndex = 2;
            corsaVistaSuperior.TabStop = false;
            // 
            // imagenParabrisasCentro
            // 
            imagenParabrisasCentro.BackColor = Color.FromArgb(64, 64, 64);
            imagenParabrisasCentro.Image = (Image)resources.GetObject("imagenParabrisasCentro.Image");
            imagenParabrisasCentro.Location = new Point(-1, -3);
            imagenParabrisasCentro.Name = "imagenParabrisasCentro";
            imagenParabrisasCentro.Size = new Size(992, 328);
            imagenParabrisasCentro.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenParabrisasCentro.TabIndex = 3;
            imagenParabrisasCentro.TabStop = false;
            // 
            // gifHumo
            // 
            gifHumo.Image = (Image)resources.GetObject("gifHumo.Image");
            gifHumo.Location = new Point(1182, 680);
            gifHumo.Name = "gifHumo";
            gifHumo.Size = new Size(64, 75);
            gifHumo.SizeMode = PictureBoxSizeMode.Zoom;
            gifHumo.TabIndex = 4;
            gifHumo.TabStop = false;
            gifHumo.Visible = false;
            // 
            // lucesFrontalesDer
            // 
            lucesFrontalesDer.Image = (Image)resources.GetObject("lucesFrontalesDer.Image");
            lucesFrontalesDer.Location = new Point(1241, 167);
            lucesFrontalesDer.Name = "lucesFrontalesDer";
            lucesFrontalesDer.Size = new Size(42, 87);
            lucesFrontalesDer.SizeMode = PictureBoxSizeMode.Zoom;
            lucesFrontalesDer.TabIndex = 5;
            lucesFrontalesDer.TabStop = false;
            lucesFrontalesDer.Visible = false;
            // 
            // lucesFrontalesIzq
            // 
            lucesFrontalesIzq.BackColor = Color.Transparent;
            lucesFrontalesIzq.BackgroundImageLayout = ImageLayout.None;
            lucesFrontalesIzq.Image = (Image)resources.GetObject("lucesFrontalesIzq.Image");
            lucesFrontalesIzq.Location = new Point(1084, 167);
            lucesFrontalesIzq.Name = "lucesFrontalesIzq";
            lucesFrontalesIzq.Size = new Size(42, 87);
            lucesFrontalesIzq.SizeMode = PictureBoxSizeMode.Zoom;
            lucesFrontalesIzq.TabIndex = 6;
            lucesFrontalesIzq.TabStop = false;
            lucesFrontalesIzq.Visible = false;
            // 
            // lucesTraserasDer
            // 
            lucesTraserasDer.Image = (Image)resources.GetObject("lucesTraserasDer.Image");
            lucesTraserasDer.Location = new Point(1241, 675);
            lucesTraserasDer.Name = "lucesTraserasDer";
            lucesTraserasDer.Size = new Size(34, 64);
            lucesTraserasDer.SizeMode = PictureBoxSizeMode.Zoom;
            lucesTraserasDer.TabIndex = 7;
            lucesTraserasDer.TabStop = false;
            lucesTraserasDer.Visible = false;
            // 
            // lucesTraserasIzq
            // 
            lucesTraserasIzq.Image = (Image)resources.GetObject("lucesTraserasIzq.Image");
            lucesTraserasIzq.Location = new Point(1105, 677);
            lucesTraserasIzq.Name = "lucesTraserasIzq";
            lucesTraserasIzq.Size = new Size(34, 64);
            lucesTraserasIzq.SizeMode = PictureBoxSizeMode.Zoom;
            lucesTraserasIzq.TabIndex = 8;
            lucesTraserasIzq.TabStop = false;
            lucesTraserasIzq.Visible = false;
            // 
            // imagenParabrisasDerecha
            // 
            imagenParabrisasDerecha.BackColor = Color.FromArgb(64, 64, 64);
            imagenParabrisasDerecha.Image = (Image)resources.GetObject("imagenParabrisasDerecha.Image");
            imagenParabrisasDerecha.Location = new Point(-1, 0);
            imagenParabrisasDerecha.Name = "imagenParabrisasDerecha";
            imagenParabrisasDerecha.Size = new Size(992, 321);
            imagenParabrisasDerecha.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenParabrisasDerecha.TabIndex = 9;
            imagenParabrisasDerecha.TabStop = false;
            // 
            // imagenParabrisasIzquierda
            // 
            imagenParabrisasIzquierda.BackColor = Color.FromArgb(64, 64, 64);
            imagenParabrisasIzquierda.Image = (Image)resources.GetObject("imagenParabrisasIzquierda.Image");
            imagenParabrisasIzquierda.Location = new Point(-1, 0);
            imagenParabrisasIzquierda.Name = "imagenParabrisasIzquierda";
            imagenParabrisasIzquierda.Size = new Size(992, 321);
            imagenParabrisasIzquierda.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenParabrisasIzquierda.TabIndex = 10;
            imagenParabrisasIzquierda.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(795, 441);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 4;
            label1.Text = "Miguel Arismendi 31348551";
            // 
            // ventanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1385, 781);
            Controls.Add(lucesTraserasIzq);
            Controls.Add(lucesTraserasDer);
            Controls.Add(lucesFrontalesIzq);
            Controls.Add(lucesFrontalesDer);
            Controls.Add(gifHumo);
            Controls.Add(corsaVistaSuperior);
            Controls.Add(pictureBox1);
            Controls.Add(panelFondo);
            Controls.Add(imagenParabrisasCentro);
            Controls.Add(imagenParabrisasDerecha);
            Controls.Add(imagenParabrisasIzquierda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Name = "ventanaPrincipal";
            Text = "Form1";
            KeyDown += ventanaPrincipal_KeyDown;
            KeyUp += ventanaPrincipal_KeyUp;
            panelFondo.ResumeLayout(false);
            panelFondo.PerformLayout();
            panelCambios.ResumeLayout(false);
            panelCambios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guiaPalanca).EndInit();
            panelControlRadio.ResumeLayout(false);
            panelControlRadio.PerformLayout();
            panelFondo2.ResumeLayout(false);
            panelFondo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)voltantePng).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)corsaVistaSuperior).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenParabrisasCentro).EndInit();
            ((System.ComponentModel.ISupportInitialize)gifHumo).EndInit();
            ((System.ComponentModel.ISupportInitialize)lucesFrontalesDer).EndInit();
            ((System.ComponentModel.ISupportInitialize)lucesFrontalesIzq).EndInit();
            ((System.ComponentModel.ISupportInitialize)lucesTraserasDer).EndInit();
            ((System.ComponentModel.ISupportInitialize)lucesTraserasIzq).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenParabrisasDerecha).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenParabrisasIzquierda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFondo;
        private Panel panelFondo2;
        private Button botonEncendido;
        private PictureBox pictureBox1;
        private PictureBox voltantePng;
        private Panel panelControlRadio;
        private Button botonPlayPausa;
        private Button botonSiguiente;
        private Label radioTexto;
        private Button botonAnterior;
        private Panel panelInfoRadio;
        private Button acelerador;
        private Button croche;
        private Button freno;
        private Panel panelCambios;
        private PictureBox guiaPalanca;
        private Label velocidad1;
        private Label velocidad3;
        private Label palancaEnNeutro;
        private Label palancaEn5;
        private Label palancaEn3;
        private Label palancaEn1;
        private Label palancaEnReversa;
        private Label PalancaEn4;
        private Label palancaEn2;
        private Label velocidadR;
        private Label velocidad4;
        private Label velocidad2;
        private Label velocidad5;
        private Button botonLuces;
        private Button button4;
        private Button botonLucesL;
        private Button botonLucesR;
        private Label labelFelchaIzquierda;
        private Label labelFlechaDerecha;
        private ProgressBar progressBarVelocidad;
        private ToolTip tipPalanca;
        private PictureBox corsaVistaSuperior;
        private PictureBox imagenParabrisasCentro;
        private PictureBox gifHumo;
        private PictureBox lucesFrontalesDer;
        private PictureBox lucesFrontalesIzq;
        private PictureBox lucesTraserasDer;
        private PictureBox lucesTraserasIzq;
        private PictureBox imagenParabrisasDerecha;
        private PictureBox imagenParabrisasIzquierda;
        private Panel panelVelocimetro;
        private Label velocimetro;
        private System.Windows.Forms.Timer timer1;
        private Label indicadorReversa;

        public void SetColorPanelInfoRadio(Color color)
        {
            panelInfoRadio.BackColor = color;
        }
        public void SetColorFondoTextoRadio(Color color)
        {
            radioTexto.BackColor = color;
        }
        public void SetTextoRadio(string texto)
        {
            radioTexto.Text = texto;
        }
        public void SetColorBotonLuces(Color color)
        {
            botonLuces.BackColor = color;
        }
        public void SetColorBotonEncendido(Color color)
        {
            botonEncendido.BackColor = color;
        }
        public void SetVisibleHumo(bool visibilidad)
        {
            gifHumo.Visible = visibilidad;
        }
        public void SetVisibleLucesFrontales(bool visibilidad)
        {
            lucesFrontalesDer.Visible = visibilidad;
            lucesFrontalesIzq.Visible = visibilidad;
        }
        public void SetVisibleLuzDeCurceIzq(bool visibilidad)
        {
            lucesTraserasIzq.Visible = visibilidad;
        }
        public void SetVisibleLuzDeCurceDer(bool visibilidad)
        {
            lucesTraserasDer.Visible = visibilidad;
        }
        public void SetColorTextoLuzCruceIzq(Color color)
        {
            botonLucesL.ForeColor = color;
        }
        public void SetColorTextoLuzCruceDer(Color color)
        {
            botonLucesR.ForeColor = color;
        }
        public void SetActivadoLuzCruceIzq(bool activado)
        {
            botonLucesL.Enabled = activado;
        }
        public void SetActivadoLuzCruceDer(bool activado)
        {
            botonLucesR.Enabled = activado;
        }
        public void SetVisibilidadesPalanca(bool R, bool N, bool uno, bool dos, bool tres, bool cuatro, bool cinco)
        {
            palancaEnReversa.Visible = R;
            palancaEnNeutro.Visible = N;
            palancaEn1.Visible = uno;
            palancaEn2.Visible = dos;
            palancaEn3.Visible = tres;
            PalancaEn4.Visible = cuatro;
            palancaEn5.Visible = cinco;
        }
        public void SetValorProgressBarVelocidad(int valor)
        {
            progressBarVelocidad.Value = valor;
        }
        public void SetActivadoCroche(bool activado)
        {
            croche.Enabled = activado;
        }
        public void SetColorCroche(Color color)
        {
            croche.BackColor = color;
        }
        public void SetActivadoAcelerado(bool activado)
        {
            acelerador.Enabled = activado;
        }
        public void SetColorAcelerador(Color color)
        {
            acelerador.BackColor = color;
        }
        public void SetVelocimetroValor(string velocidad)
        {
            velocimetro.Text = velocidad + " Km/h";
        }
        public void TraerParabrisasIZquieroAlFrente()
        {
            imagenParabrisasIzquierda.BringToFront();
        }
        public void TraerParabrisasDerechoAlFrente()
        {
            imagenParabrisasDerecha.BringToFront();
        }
        public void TraerParabrisasCentroAlFrente()
        {
            imagenParabrisasCentro.BringToFront();
        }
        public void SetColorFreno(Color color)
        {
            freno.BackColor = color;
        }
        public void SetActivadoFreno(bool activado)
        {
            freno.Enabled = activado;
        }
        public void MostrarIndicadorReversa(bool mostrar)
        {
            indicadorReversa.Visible = mostrar;
        }

        private Label label1;
    }
}
