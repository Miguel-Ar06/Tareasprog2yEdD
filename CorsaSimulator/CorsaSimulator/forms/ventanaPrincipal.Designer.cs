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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaPrincipal));
            panelFondo = new Panel();
            panel1 = new Panel();
            panelFondo2 = new Panel();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            botonPlayPausa = new Button();
            botonSiguiente = new Button();
            botonAnterior = new Button();
            radioTexto = new Label();
            panel2 = new Panel();
            botonAcelerar = new Button();
            botonFrenar = new Button();
            button2 = new Button();
            panelFondo.SuspendLayout();
            panel1.SuspendLayout();
            panelFondo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFondo
            // 
            panelFondo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFondo.BackColor = Color.FromArgb(64, 64, 64);
            panelFondo.Controls.Add(panel1);
            panelFondo.Controls.Add(panelFondo2);
            panelFondo.Location = new Point(-1, 255);
            panelFondo.Name = "panelFondo";
            panelFondo.Size = new Size(1179, 474);
            panelFondo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(32, 32, 32);
            panel1.Controls.Add(radioTexto);
            panel1.Controls.Add(botonAnterior);
            panel1.Controls.Add(botonSiguiente);
            panel1.Controls.Add(botonPlayPausa);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(633, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 75);
            panel1.TabIndex = 3;
            // 
            // panelFondo2
            // 
            panelFondo2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelFondo2.BackColor = Color.FromArgb(32, 32, 32);
            panelFondo2.Controls.Add(button2);
            panelFondo2.Controls.Add(botonFrenar);
            panelFondo2.Controls.Add(botonAcelerar);
            panelFondo2.Controls.Add(button1);
            panelFondo2.Controls.Add(pictureBox2);
            panelFondo2.Location = new Point(-3, 23);
            panelFondo2.Name = "panelFondo2";
            panelFondo2.Size = new Size(476, 448);
            panelFondo2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(373, 70);
            button1.Name = "button1";
            button1.Size = new Size(67, 68);
            button1.TabIndex = 1;
            button1.Text = "ON / OFF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-23, -19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(499, 400);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(343, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
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
            // 
            // radioTexto
            // 
            radioTexto.AutoSize = true;
            radioTexto.BackColor = Color.PaleGreen;
            radioTexto.Location = new Point(75, 26);
            radioTexto.Name = "radioTexto";
            radioTexto.Size = new Size(181, 20);
            radioTexto.TabIndex = 2;
            radioTexto.Text = "Ninguna cancion sonando";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Location = new Point(64, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 43);
            panel2.TabIndex = 2;
            // 
            // botonAcelerar
            // 
            botonAcelerar.BackColor = SystemColors.ControlDark;
            botonAcelerar.FlatStyle = FlatStyle.Flat;
            botonAcelerar.Font = new Font("Segoe UI", 24F);
            botonAcelerar.Location = new Point(361, 312);
            botonAcelerar.Name = "botonAcelerar";
            botonAcelerar.Size = new Size(55, 113);
            botonAcelerar.TabIndex = 2;
            botonAcelerar.Text = "↑";
            botonAcelerar.UseVisualStyleBackColor = false;
            // 
            // botonFrenar
            // 
            botonFrenar.BackColor = SystemColors.ControlDark;
            botonFrenar.FlatStyle = FlatStyle.Flat;
            botonFrenar.Font = new Font("Segoe UI", 24F);
            botonFrenar.Location = new Point(284, 350);
            botonFrenar.Name = "botonFrenar";
            botonFrenar.Size = new Size(55, 75);
            botonFrenar.TabIndex = 3;
            botonFrenar.Text = "↓";
            botonFrenar.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 24F);
            button2.Location = new Point(207, 350);
            button2.Name = "button2";
            button2.Size = new Size(55, 75);
            button2.TabIndex = 4;
            button2.Text = "C";
            button2.UseVisualStyleBackColor = false;
            // 
            // ventanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1177, 725);
            Controls.Add(pictureBox1);
            Controls.Add(panelFondo);
            Name = "ventanaPrincipal";
            Text = "Form1";
            panelFondo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFondo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFondo;
        private Panel panelFondo2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button botonPlayPausa;
        private Button botonSiguiente;
        private Label radioTexto;
        private Button botonAnterior;
        private Panel panel2;
        private Button botonAcelerar;
        private Button button2;
        private Button botonFrenar;
    }
}
