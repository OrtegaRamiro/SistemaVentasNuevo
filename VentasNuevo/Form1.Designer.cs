
namespace VentasNuevo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tcTodo = new System.Windows.Forms.TabControl();
            this.tcVentas = new System.Windows.Forms.TabPage();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.tbMosTotal2 = new System.Windows.Forms.TextBox();
            this.tbMosCambio = new System.Windows.Forms.TextBox();
            this.tbMosTotal = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.Cambio = new System.Windows.Forms.TextBox();
            this.tbMosPago = new System.Windows.Forms.TextBox();
            this.IVA = new System.Windows.Forms.TextBox();
            this.TotalIVA = new System.Windows.Forms.TextBox();
            this.Pago = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPro = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescPreVen = new System.Windows.Forms.TextBox();
            this.txtDescPreCom = new System.Windows.Forms.TextBox();
            this.txtProDesc = new System.Windows.Forms.TextBox();
            this.txtDesCant = new System.Windows.Forms.TextBox();
            this.txtProNom = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCant = new System.Windows.Forms.Label();
            this.lblPreCom = new System.Windows.Forms.Label();
            this.lblPreVen = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clmIdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPreDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStoDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepartamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTodo.SuspendLayout();
            this.tcVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTodo
            // 
            this.tcTodo.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTodo.Controls.Add(this.tcVentas);
            this.tcTodo.Controls.Add(this.tabPage2);
            this.tcTodo.Controls.Add(this.tabPage1);
            this.tcTodo.Location = new System.Drawing.Point(0, 141);
            this.tcTodo.Multiline = true;
            this.tcTodo.Name = "tcTodo";
            this.tcTodo.SelectedIndex = 0;
            this.tcTodo.Size = new System.Drawing.Size(1166, 507);
            this.tcTodo.TabIndex = 0;
            // 
            // tcVentas
            // 
            this.tcVentas.Controls.Add(this.btnAgregar);
            this.tcVentas.Controls.Add(this.btnCobrar);
            this.tcVentas.Controls.Add(this.tbMosTotal2);
            this.tcVentas.Controls.Add(this.tbMosCambio);
            this.tcVentas.Controls.Add(this.tbMosTotal);
            this.tcVentas.Controls.Add(this.txtIVA);
            this.tcVentas.Controls.Add(this.Cambio);
            this.tcVentas.Controls.Add(this.tbMosPago);
            this.tcVentas.Controls.Add(this.IVA);
            this.tcVentas.Controls.Add(this.TotalIVA);
            this.tcVentas.Controls.Add(this.Pago);
            this.tcVentas.Controls.Add(this.Total);
            this.tcVentas.Controls.Add(this.lblCantidad);
            this.tcVentas.Controls.Add(this.lblPro);
            this.tcVentas.Controls.Add(this.tbCantidad);
            this.tcVentas.Controls.Add(this.tbProducto);
            this.tcVentas.Controls.Add(this.dataGridView1);
            this.tcVentas.Location = new System.Drawing.Point(4, 4);
            this.tcVentas.Name = "tcVentas";
            this.tcVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tcVentas.Size = new System.Drawing.Size(1158, 481);
            this.tcVentas.TabIndex = 0;
            this.tcVentas.Text = "Ventas";
            this.tcVentas.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(146, 226);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCobrar.Location = new System.Drawing.Point(910, 411);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 15;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // tbMosTotal2
            // 
            this.tbMosTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMosTotal2.Location = new System.Drawing.Point(541, 411);
            this.tbMosTotal2.Name = "tbMosTotal2";
            this.tbMosTotal2.ReadOnly = true;
            this.tbMosTotal2.Size = new System.Drawing.Size(100, 20);
            this.tbMosTotal2.TabIndex = 14;
            // 
            // tbMosCambio
            // 
            this.tbMosCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMosCambio.Location = new System.Drawing.Point(753, 411);
            this.tbMosCambio.Name = "tbMosCambio";
            this.tbMosCambio.ReadOnly = true;
            this.tbMosCambio.Size = new System.Drawing.Size(100, 20);
            this.tbMosCambio.TabIndex = 13;
            // 
            // tbMosTotal
            // 
            this.tbMosTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMosTotal.Location = new System.Drawing.Point(328, 411);
            this.tbMosTotal.Name = "tbMosTotal";
            this.tbMosTotal.ReadOnly = true;
            this.tbMosTotal.Size = new System.Drawing.Size(100, 20);
            this.tbMosTotal.TabIndex = 12;
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIVA.Location = new System.Drawing.Point(434, 411);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 11;
            // 
            // Cambio
            // 
            this.Cambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cambio.Location = new System.Drawing.Point(752, 385);
            this.Cambio.Name = "Cambio";
            this.Cambio.ReadOnly = true;
            this.Cambio.Size = new System.Drawing.Size(100, 20);
            this.Cambio.TabIndex = 10;
            this.Cambio.Text = "Cambio:";
            // 
            // tbMosPago
            // 
            this.tbMosPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMosPago.Location = new System.Drawing.Point(647, 411);
            this.tbMosPago.Name = "tbMosPago";
            this.tbMosPago.Size = new System.Drawing.Size(100, 20);
            this.tbMosPago.TabIndex = 9;
            this.tbMosPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMosPago_KeyPress);
            // 
            // IVA
            // 
            this.IVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.IVA.Location = new System.Drawing.Point(434, 385);
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Size = new System.Drawing.Size(100, 20);
            this.IVA.TabIndex = 8;
            this.IVA.Text = "IVA:";
            // 
            // TotalIVA
            // 
            this.TotalIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalIVA.Location = new System.Drawing.Point(540, 385);
            this.TotalIVA.Name = "TotalIVA";
            this.TotalIVA.ReadOnly = true;
            this.TotalIVA.Size = new System.Drawing.Size(100, 20);
            this.TotalIVA.TabIndex = 7;
            this.TotalIVA.Text = "Total con IVA:";
            // 
            // Pago
            // 
            this.Pago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pago.BackColor = System.Drawing.SystemColors.Control;
            this.Pago.Location = new System.Drawing.Point(646, 385);
            this.Pago.Name = "Pago";
            this.Pago.ReadOnly = true;
            this.Pago.Size = new System.Drawing.Size(100, 20);
            this.Pago.TabIndex = 6;
            this.Pago.Text = "Pago Con:";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total.Location = new System.Drawing.Point(328, 385);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(100, 20);
            this.Total.TabIndex = 5;
            this.Total.Text = "Total:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(88, 183);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPro
            // 
            this.lblPro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPro.AutoSize = true;
            this.lblPro.Location = new System.Drawing.Point(85, 156);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(53, 13);
            this.lblPro.TabIndex = 3;
            this.lblPro.Text = "Producto:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCantidad.Location = new System.Drawing.Point(146, 177);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(100, 20);
            this.tbCantidad.TabIndex = 2;
            this.tbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCantidad_KeyPress);
            // 
            // tbProducto
            // 
            this.tbProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbProducto.Location = new System.Drawing.Point(146, 150);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.Size = new System.Drawing.Size(100, 20);
            this.tbProducto.TabIndex = 1;
            this.tbProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProducto_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmProducto,
            this.clmPrecio,
            this.clmCantidad});
            this.dataGridView1.Location = new System.Drawing.Point(328, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(621, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowValidated);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.dgvProductos);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1158, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtDescPreVen);
            this.panel1.Controls.Add(this.txtDescPreCom);
            this.panel1.Controls.Add(this.txtProDesc);
            this.panel1.Controls.Add(this.txtDesCant);
            this.panel1.Controls.Add(this.txtProNom);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblCant);
            this.panel1.Controls.Add(this.lblPreCom);
            this.panel1.Controls.Add(this.lblPreVen);
            this.panel1.Controls.Add(this.lblProducto);
            this.panel1.Location = new System.Drawing.Point(814, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 460);
            this.panel1.TabIndex = 2;
            // 
            // txtDescPreVen
            // 
            this.txtDescPreVen.Location = new System.Drawing.Point(89, 213);
            this.txtDescPreVen.Name = "txtDescPreVen";
            this.txtDescPreVen.ReadOnly = true;
            this.txtDescPreVen.Size = new System.Drawing.Size(100, 20);
            this.txtDescPreVen.TabIndex = 9;
            // 
            // txtDescPreCom
            // 
            this.txtDescPreCom.Location = new System.Drawing.Point(89, 187);
            this.txtDescPreCom.Name = "txtDescPreCom";
            this.txtDescPreCom.ReadOnly = true;
            this.txtDescPreCom.Size = new System.Drawing.Size(100, 20);
            this.txtDescPreCom.TabIndex = 8;
            // 
            // txtProDesc
            // 
            this.txtProDesc.Location = new System.Drawing.Point(33, 93);
            this.txtProDesc.Name = "txtProDesc";
            this.txtProDesc.ReadOnly = true;
            this.txtProDesc.Size = new System.Drawing.Size(193, 20);
            this.txtProDesc.TabIndex = 7;
            // 
            // txtDesCant
            // 
            this.txtDesCant.Location = new System.Drawing.Point(89, 161);
            this.txtDesCant.Name = "txtDesCant";
            this.txtDesCant.ReadOnly = true;
            this.txtDesCant.Size = new System.Drawing.Size(100, 20);
            this.txtDesCant.TabIndex = 6;
            // 
            // txtProNom
            // 
            this.txtProNom.Location = new System.Drawing.Point(89, 15);
            this.txtProNom.Name = "txtProNom";
            this.txtProNom.ReadOnly = true;
            this.txtProNom.Size = new System.Drawing.Size(100, 20);
            this.txtProNom.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(30, 77);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(30, 161);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(52, 13);
            this.lblCant.TabIndex = 3;
            this.lblCant.Text = "Cantidad:";
            // 
            // lblPreCom
            // 
            this.lblPreCom.AutoSize = true;
            this.lblPreCom.Location = new System.Drawing.Point(4, 190);
            this.lblPreCom.Name = "lblPreCom";
            this.lblPreCom.Size = new System.Drawing.Size(79, 13);
            this.lblPreCom.TabIndex = 2;
            this.lblPreCom.Text = "Precio Compra:";
            // 
            // lblPreVen
            // 
            this.lblPreVen.AutoSize = true;
            this.lblPreVen.Location = new System.Drawing.Point(12, 216);
            this.lblPreVen.Name = "lblPreVen";
            this.lblPreVen.Size = new System.Drawing.Size(71, 13);
            this.lblPreVen.TabIndex = 1;
            this.lblPreVen.Text = "Precio Venta:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(30, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdDesc,
            this.clmProductos,
            this.clmConDesc,
            this.clmPreDesc,
            this.clmStoDesc});
            this.dgvProductos.Location = new System.Drawing.Point(289, 6);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(519, 460);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIDCategoria,
            this.clmDepartamentos});
            this.dataGridView2.Location = new System.Drawing.Point(43, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(240, 460);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart2);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 481);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(80, 34);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(75, 92);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(162, 33);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 92);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.Location = new System.Drawing.Point(244, 32);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 92);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(550, 475);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            this.chart2.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(553, 3);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(602, 475);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // clmIdDesc
            // 
            this.clmIdDesc.DataPropertyName = "Producto";
            this.clmIdDesc.HeaderText = "ID";
            this.clmIdDesc.Name = "clmIdDesc";
            this.clmIdDesc.ReadOnly = true;
            this.clmIdDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmProductos
            // 
            this.clmProductos.DataPropertyName = "nombre";
            this.clmProductos.HeaderText = "Productos";
            this.clmProductos.Name = "clmProductos";
            this.clmProductos.ReadOnly = true;
            this.clmProductos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmConDesc
            // 
            this.clmConDesc.DataPropertyName = "Contenido";
            this.clmConDesc.HeaderText = "Contenido";
            this.clmConDesc.Name = "clmConDesc";
            this.clmConDesc.ReadOnly = true;
            this.clmConDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPreDesc
            // 
            this.clmPreDesc.DataPropertyName = "Precio";
            this.clmPreDesc.HeaderText = "Precio";
            this.clmPreDesc.Name = "clmPreDesc";
            this.clmPreDesc.ReadOnly = true;
            this.clmPreDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmStoDesc
            // 
            this.clmStoDesc.DataPropertyName = "Stock";
            this.clmStoDesc.HeaderText = "Stock";
            this.clmStoDesc.Name = "clmStoDesc";
            this.clmStoDesc.ReadOnly = true;
            this.clmStoDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmIDCategoria
            // 
            this.clmIDCategoria.DataPropertyName = "nombre";
            this.clmIDCategoria.HeaderText = "ID";
            this.clmIDCategoria.Name = "clmIDCategoria";
            this.clmIDCategoria.ReadOnly = true;
            // 
            // clmDepartamentos
            // 
            this.clmDepartamentos.DataPropertyName = "idcategoria";
            this.clmDepartamentos.HeaderText = "Departamento";
            this.clmDepartamentos.Name = "clmDepartamentos";
            this.clmDepartamentos.ReadOnly = true;
            this.clmDepartamentos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            this.clmProducto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmPrecio
            // 
            this.clmPrecio.HeaderText = "Precio";
            this.clmPrecio.Name = "clmPrecio";
            this.clmPrecio.ReadOnly = true;
            this.clmPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 648);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.tcTodo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcTodo.ResumeLayout(false);
            this.tcVentas.ResumeLayout(false);
            this.tcVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTodo;
        private System.Windows.Forms.TabPage tcVentas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox tbMosTotal2;
        private System.Windows.Forms.TextBox tbMosCambio;
        private System.Windows.Forms.TextBox tbMosTotal;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox Cambio;
        private System.Windows.Forms.TextBox tbMosPago;
        private System.Windows.Forms.TextBox IVA;
        private System.Windows.Forms.TextBox TotalIVA;
        private System.Windows.Forms.TextBox Pago;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescPreVen;
        private System.Windows.Forms.TextBox txtDescPreCom;
        private System.Windows.Forms.TextBox txtProDesc;
        private System.Windows.Forms.TextBox txtDesCant;
        private System.Windows.Forms.TextBox txtProNom;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Label lblPreCom;
        private System.Windows.Forms.Label lblPreVen;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmConDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStoDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartamentos;
    }
}

