using System.Globalization;

namespace GestionNegocio
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            nombreNegocio = new Label();
            controlPestanas = new TabControl();
            pestanaCobros = new TabPage();
            botonEliminarMovimiento = new Button();
            montoTotal = new Label();
            textoTotal = new Label();
            tablaDeMovimientos = new DataGridView();
            movimientoTextoRegistrar = new Label();
            movimientoBotonEgreso = new Button();
            movimientoBotonIngreso = new Button();
            movimientoMonto = new TextBox();
            movimientoTextoMonto = new Label();
            movimientoDescripcion = new TextBox();
            movimientoTextoDescripcion = new Label();
            pestanaInventario = new TabPage();
            botonEliminarProducto = new Button();
            tablaInventario = new DataGridView();
            botonAgregarProducto = new Button();
            descripcionProducto = new TextBox();
            marcaProducto = new TextBox();
            precioProducto = new TextBox();
            cantidadProducto = new TextBox();
            nombreProducto = new TextBox();
            pestanaFacturas = new TabPage();
            label1 = new Label();
            pestanaAjustes = new TabPage();
            label2 = new Label();
            controlPestanas.SuspendLayout();
            pestanaCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDeMovimientos).BeginInit();
            pestanaInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).BeginInit();
            pestanaFacturas.SuspendLayout();
            pestanaAjustes.SuspendLayout();
            SuspendLayout();
            // 
            // nombreNegocio
            // 
            nombreNegocio.AutoSize = true;
            nombreNegocio.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreNegocio.Location = new Point(12, 21);
            nombreNegocio.Name = "nombreNegocio";
            nombreNegocio.Size = new Size(408, 54);
            nombreNegocio.TabIndex = 0;
            nombreNegocio.Text = "Nombre Del Negocio";
            // 
            // controlPestanas
            // 
            controlPestanas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            controlPestanas.Controls.Add(pestanaCobros);
            controlPestanas.Controls.Add(pestanaInventario);
            controlPestanas.Controls.Add(pestanaFacturas);
            controlPestanas.Controls.Add(pestanaAjustes);
            controlPestanas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlPestanas.Location = new Point(12, 89);
            controlPestanas.Name = "controlPestanas";
            controlPestanas.RightToLeft = RightToLeft.No;
            controlPestanas.SelectedIndex = 0;
            controlPestanas.Size = new Size(1114, 602);
            controlPestanas.TabIndex = 1;
            // 
            // pestanaCobros
            // 
            pestanaCobros.BackColor = Color.White;
            pestanaCobros.Controls.Add(botonEliminarMovimiento);
            pestanaCobros.Controls.Add(montoTotal);
            pestanaCobros.Controls.Add(textoTotal);
            pestanaCobros.Controls.Add(tablaDeMovimientos);
            pestanaCobros.Controls.Add(movimientoTextoRegistrar);
            pestanaCobros.Controls.Add(movimientoBotonEgreso);
            pestanaCobros.Controls.Add(movimientoBotonIngreso);
            pestanaCobros.Controls.Add(movimientoMonto);
            pestanaCobros.Controls.Add(movimientoTextoMonto);
            pestanaCobros.Controls.Add(movimientoDescripcion);
            pestanaCobros.Controls.Add(movimientoTextoDescripcion);
            pestanaCobros.Location = new Point(4, 37);
            pestanaCobros.Name = "pestanaCobros";
            pestanaCobros.Padding = new Padding(3);
            pestanaCobros.Size = new Size(1106, 561);
            pestanaCobros.TabIndex = 0;
            pestanaCobros.Text = "Movimiento y cobro";
            // 
            // botonEliminarMovimiento
            // 
            botonEliminarMovimiento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarMovimiento.BackColor = Color.LightCoral;
            botonEliminarMovimiento.Font = new Font("Segoe UI", 12F);
            botonEliminarMovimiento.Location = new Point(850, 411);
            botonEliminarMovimiento.Name = "botonEliminarMovimiento";
            botonEliminarMovimiento.Size = new Size(137, 36);
            botonEliminarMovimiento.TabIndex = 12;
            botonEliminarMovimiento.Text = "Eliminar";
            botonEliminarMovimiento.UseVisualStyleBackColor = false;
            botonEliminarMovimiento.Click += botonEliminarMovimiento_Click;
            // 
            // montoTotal
            // 
            montoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            montoTotal.AutoSize = true;
            montoTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            montoTotal.Location = new Point(532, 405);
            montoTotal.Name = "montoTotal";
            montoTotal.Size = new Size(93, 41);
            montoTotal.TabIndex = 11;
            montoTotal.Text = "0.00$";
            // 
            // textoTotal
            // 
            textoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textoTotal.AutoSize = true;
            textoTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoTotal.Location = new Point(434, 405);
            textoTotal.Name = "textoTotal";
            textoTotal.Size = new Size(92, 41);
            textoTotal.TabIndex = 10;
            textoTotal.Text = "Total:";
            // 
            // tablaDeMovimientos
            // 
            tablaDeMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaDeMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaDeMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tablaDeMovimientos.DefaultCellStyle = dataGridViewCellStyle1;
            tablaDeMovimientos.Location = new Point(434, 86);
            tablaDeMovimientos.Name = "tablaDeMovimientos";
            tablaDeMovimientos.RowHeadersWidth = 51;
            tablaDeMovimientos.Size = new Size(553, 294);
            tablaDeMovimientos.TabIndex = 9;
            tablaDeMovimientos.CellFormatting += tablaDeMovimientos_CellFormatting;
            // 
            // movimientoTextoRegistrar
            // 
            movimientoTextoRegistrar.AutoSize = true;
            movimientoTextoRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movimientoTextoRegistrar.Location = new Point(50, 352);
            movimientoTextoRegistrar.Name = "movimientoTextoRegistrar";
            movimientoTextoRegistrar.Size = new Size(148, 28);
            movimientoTextoRegistrar.TabIndex = 8;
            movimientoTextoRegistrar.Text = "Registrar como";
            // 
            // movimientoBotonEgreso
            // 
            movimientoBotonEgreso.BackColor = Color.PaleVioletRed;
            movimientoBotonEgreso.Font = new Font("Segoe UI", 12F);
            movimientoBotonEgreso.Location = new Point(174, 393);
            movimientoBotonEgreso.Name = "movimientoBotonEgreso";
            movimientoBotonEgreso.Size = new Size(109, 53);
            movimientoBotonEgreso.TabIndex = 7;
            movimientoBotonEgreso.Text = "Egreso";
            movimientoBotonEgreso.UseVisualStyleBackColor = false;
            movimientoBotonEgreso.Click += movimientoBotonEgreso_Click;
            // 
            // movimientoBotonIngreso
            // 
            movimientoBotonIngreso.BackColor = Color.LightGreen;
            movimientoBotonIngreso.Font = new Font("Segoe UI", 12F);
            movimientoBotonIngreso.Location = new Point(50, 393);
            movimientoBotonIngreso.Name = "movimientoBotonIngreso";
            movimientoBotonIngreso.Size = new Size(109, 53);
            movimientoBotonIngreso.TabIndex = 6;
            movimientoBotonIngreso.Text = "Ingreso";
            movimientoBotonIngreso.UseVisualStyleBackColor = false;
            movimientoBotonIngreso.Click += movimientoBotonIngreso_Click;
            // 
            // movimientoMonto
            // 
            movimientoMonto.BorderStyle = BorderStyle.FixedSingle;
            movimientoMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoMonto.Location = new Point(50, 289);
            movimientoMonto.Name = "movimientoMonto";
            movimientoMonto.PlaceholderText = "000,000.00";
            movimientoMonto.Size = new Size(276, 34);
            movimientoMonto.TabIndex = 5;
            // 
            // movimientoTextoMonto
            // 
            movimientoTextoMonto.AutoSize = true;
            movimientoTextoMonto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movimientoTextoMonto.Location = new Point(50, 245);
            movimientoTextoMonto.Name = "movimientoTextoMonto";
            movimientoTextoMonto.Size = new Size(104, 28);
            movimientoTextoMonto.TabIndex = 4;
            movimientoTextoMonto.Text = "Monto ($)";
            // 
            // movimientoDescripcion
            // 
            movimientoDescripcion.BorderStyle = BorderStyle.FixedSingle;
            movimientoDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoDescripcion.Location = new Point(50, 104);
            movimientoDescripcion.Multiline = true;
            movimientoDescripcion.Name = "movimientoDescripcion";
            movimientoDescripcion.Size = new Size(276, 117);
            movimientoDescripcion.TabIndex = 3;
            // 
            // movimientoTextoDescripcion
            // 
            movimientoTextoDescripcion.AutoSize = true;
            movimientoTextoDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movimientoTextoDescripcion.Location = new Point(50, 60);
            movimientoTextoDescripcion.Name = "movimientoTextoDescripcion";
            movimientoTextoDescripcion.Size = new Size(117, 28);
            movimientoTextoDescripcion.TabIndex = 2;
            movimientoTextoDescripcion.Text = "Descripcion";
            // 
            // pestanaInventario
            // 
            pestanaInventario.Controls.Add(botonEliminarProducto);
            pestanaInventario.Controls.Add(tablaInventario);
            pestanaInventario.Controls.Add(botonAgregarProducto);
            pestanaInventario.Controls.Add(descripcionProducto);
            pestanaInventario.Controls.Add(marcaProducto);
            pestanaInventario.Controls.Add(precioProducto);
            pestanaInventario.Controls.Add(cantidadProducto);
            pestanaInventario.Controls.Add(nombreProducto);
            pestanaInventario.Location = new Point(4, 37);
            pestanaInventario.Name = "pestanaInventario";
            pestanaInventario.Padding = new Padding(3);
            pestanaInventario.Size = new Size(1106, 561);
            pestanaInventario.TabIndex = 1;
            pestanaInventario.Text = "Inventario";
            pestanaInventario.UseVisualStyleBackColor = true;
            // 
            // botonEliminarProducto
            // 
            botonEliminarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarProducto.BackColor = Color.LightCoral;
            botonEliminarProducto.Font = new Font("Segoe UI", 12F);
            botonEliminarProducto.Location = new Point(946, 501);
            botonEliminarProducto.Name = "botonEliminarProducto";
            botonEliminarProducto.Size = new Size(137, 36);
            botonEliminarProducto.TabIndex = 7;
            botonEliminarProducto.Text = "Eliminar";
            botonEliminarProducto.UseVisualStyleBackColor = false;
            botonEliminarProducto.Click += botonEliminarProducto_Click;
            // 
            // tablaInventario
            // 
            tablaInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tablaInventario.DefaultCellStyle = dataGridViewCellStyle2;
            tablaInventario.Location = new Point(20, 175);
            tablaInventario.Name = "tablaInventario";
            tablaInventario.RowHeadersWidth = 51;
            tablaInventario.Size = new Size(1063, 290);
            tablaInventario.TabIndex = 6;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Location = new Point(527, 74);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(178, 71);
            botonAgregarProducto.TabIndex = 5;
            botonAgregarProducto.Text = "Agregar";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += botonAgregarProducto_Click;
            // 
            // descripcionProducto
            // 
            descripcionProducto.BorderStyle = BorderStyle.FixedSingle;
            descripcionProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descripcionProducto.Location = new Point(20, 74);
            descripcionProducto.Multiline = true;
            descripcionProducto.Name = "descripcionProducto";
            descripcionProducto.PlaceholderText = "Descripcion";
            descripcionProducto.Size = new Size(480, 71);
            descripcionProducto.TabIndex = 4;
            // 
            // marcaProducto
            // 
            marcaProducto.BorderStyle = BorderStyle.FixedSingle;
            marcaProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marcaProducto.Location = new Point(516, 23);
            marcaProducto.Name = "marcaProducto";
            marcaProducto.PlaceholderText = "Marca";
            marcaProducto.Size = new Size(189, 34);
            marcaProducto.TabIndex = 3;
            // 
            // precioProducto
            // 
            precioProducto.BorderStyle = BorderStyle.FixedSingle;
            precioProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precioProducto.Location = new Point(379, 23);
            precioProducto.Name = "precioProducto";
            precioProducto.PlaceholderText = "*Precio ($)";
            precioProducto.Size = new Size(121, 34);
            precioProducto.TabIndex = 2;
            // 
            // cantidadProducto
            // 
            cantidadProducto.BorderStyle = BorderStyle.FixedSingle;
            cantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadProducto.Location = new Point(250, 23);
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.PlaceholderText = "*Cantidad";
            cantidadProducto.Size = new Size(112, 34);
            cantidadProducto.TabIndex = 1;
            // 
            // nombreProducto
            // 
            nombreProducto.BorderStyle = BorderStyle.FixedSingle;
            nombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreProducto.Location = new Point(20, 23);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.PlaceholderText = "*Nombre del producto";
            nombreProducto.Size = new Size(207, 34);
            nombreProducto.TabIndex = 0;
            // 
            // pestanaFacturas
            // 
            pestanaFacturas.Controls.Add(label1);
            pestanaFacturas.Location = new Point(4, 37);
            pestanaFacturas.Name = "pestanaFacturas";
            pestanaFacturas.Size = new Size(1106, 561);
            pestanaFacturas.TabIndex = 2;
            pestanaFacturas.Text = "Facturas";
            pestanaFacturas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(473, 262);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 0;
            label1.Text = "Proximamente";
            // 
            // pestanaAjustes
            // 
            pestanaAjustes.Controls.Add(label2);
            pestanaAjustes.Location = new Point(4, 37);
            pestanaAjustes.Name = "pestanaAjustes";
            pestanaAjustes.Size = new Size(1106, 561);
            pestanaAjustes.TabIndex = 3;
            pestanaAjustes.Text = "Ajustes";
            pestanaAjustes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 253);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 1;
            label2.Text = "Proximamente";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 703);
            Controls.Add(controlPestanas);
            Controls.Add(nombreNegocio);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            controlPestanas.ResumeLayout(false);
            pestanaCobros.ResumeLayout(false);
            pestanaCobros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDeMovimientos).EndInit();
            pestanaInventario.ResumeLayout(false);
            pestanaInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).EndInit();
            pestanaFacturas.ResumeLayout(false);
            pestanaFacturas.PerformLayout();
            pestanaAjustes.ResumeLayout(false);
            pestanaAjustes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //
        // Elementos principales
        //
        private Label nombreNegocio;
        private TabControl controlPestanas;
        private TabPage pestanaCobros;
        private TabPage pestanaInventario;
        private TabPage pestanaAjustes;
        private TabPage pestanaFacturas;

        public void SetColorNombreNegocio(Color colorFondo, Color colorTexto)
        {
            nombreNegocio.BackColor = colorFondo;
            nombreNegocio.ForeColor = colorTexto;
        }
        public void SetNombreNegocio(string nombre)
        {
            nombreNegocio.Text = nombre;
        }

        //
        // Pestana movimientos y cobros
        //
        private TextBox movimientoMonto;
        private Label movimientoTextoMonto;
        private TextBox movimientoDescripcion;
        private Label movimientoTextoDescripcion;
        private Label movimientoTextoRegistrar;
        private Button movimientoBotonEgreso;
        private Button movimientoBotonIngreso;
        private DataGridView tablaDeMovimientos;
        private Label montoTotal;
        private Label textoTotal;

        // setters 
        public void LimpiarMonto()
        {
            movimientoMonto.Clear();
        }
        public void LimpiarDescripcion()
        {
            movimientoDescripcion.Clear();
        }
        public void SetColorTextoTotal(Color colorFondo, Color colorTexto)
        {
            textoTotal.BackColor = colorFondo;
            textoTotal.ForeColor = colorTexto;
        }
        public void SetMontoTotal(String total)
        {
            montoTotal.Text = total;
        }

        // getters
        public string GetDescripcionMovimiento()
        {
            return movimientoDescripcion.Text.Trim();
        }
        public string GetMovimientoTextoMonto()
        {
            return movimientoMonto.Text.Trim();
        }
        public DataGridView GetTablaDeMovimientos()
        {
            return tablaDeMovimientos;
        }

        //
        // Pestana inventario
        //
        private TextBox nombreProducto;
        private TextBox cantidadProducto;
        private TextBox marcaProducto;
        private TextBox precioProducto;
        private TextBox descripcionProducto;
        private Button botonAgregarProducto;
        private DataGridView tablaInventario;
        private Button botonEliminarProducto;

        // getters
        public string GetNombreProducto()
        {
            return nombreProducto.Text.Trim();
        }
        public int GetCantidadProducto()
        {
            int cantidad;

            if (int.TryParse(cantidadProducto.Text.Trim(), out cantidad))
            {
                return cantidad;
            }
            else
            {
                MessageBox.Show("Introduzca una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public decimal GetPrecioProducto()
        {
            decimal precio;

            if (decimal.TryParse(cantidadProducto.Text.Trim(), out precio))
            {
                return precio;
            }
            else
            {
                MessageBox.Show("Introduzca un precio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public string GetMarcaProdudcto()
        {
            return marcaProducto.Text.Trim();
        }
        public string GetDescripcionProducto()
        {
            return descripcionProducto.Text.Trim();
        }
        public DataGridView GetTablaInventario()
        {
            return tablaInventario;
        }

        // setters
        public void SetColorBotonAgregar(Color colorFondo, Color colorTexto)
        {
            botonAgregarProducto.BackColor = colorFondo;
            botonAgregarProducto.ForeColor = colorTexto;
        }
        public void LimpiarNombreProducto()
        {
            nombreProducto.Clear();
        }
        public void LimpiarCantidadProducto()
        {
            cantidadProducto.Clear();
        }
        public void LimpiarPrecioProducto()
        {
            precioProducto.Clear();
        }
        public void LimpiarMarcaProducto()
        {
            marcaProducto.Clear();
        }
        public void LimpiarDescripcionProducto()
        {
            descripcionProducto.Clear();
        }

        private Button botonEliminarMovimiento;
        private Label label1;
        private Label label2;
    }
}