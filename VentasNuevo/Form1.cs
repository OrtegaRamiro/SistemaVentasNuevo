using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VentasNuevo.ValBD;

namespace VentasNuevo
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-74BBU83\\SQLEXPRESS ; Initial Catalog=VENTAS ; integrated security = true");

        float suma = 0;
        double TotalC = 0;
        string valorCelda2;
        string valorCelda;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarItems();
        }

        private void cargarItems()
        {
            centrarColumnas(dataGridView1);
            centrarColumnas(dataGridView2);
            centrarColumnas(dgvProductos);

            AlternarColorDGV(dataGridView1);
            llenarTablaProductos();
            QuitarColumnaUno();
            tamTextBox();
            VentasTotalesGRA();
            VentasTotalesCAT();
            Prueba();
            cargardgvRepor();
            GraficaReportes();
            CombCategorias();
            lblUsuario();
            comboBox1.SelectedIndex = 0;
            cbCategoria.SelectedIndex = 0;
        }

        /*-------------------------ALTERNAR COLORES EN DATAGRIDVIEWS-------------------------*/
        private void AlternarColorDGV(DataGridView dgv)
        {
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
        }

        /*-------------------------BOTON DE VENTAS-------------------------*/
        private void btnVentas_Click(object sender, EventArgs e)
        {
            tcTodo.SelectedIndex = 0;
        }

        /*-------------------------BOTON DE PRODUCTOS-------------------------*/
        private void btnProductos_Click(object sender, EventArgs e)
        {
            tcTodo.SelectedIndex = 1;
            dataGridView2.CurrentCell.Selected = false;
            dgvProductos.ClearSelection();
        }

        /*-------------------------BOTON DE ADMIN-------------------------*/
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            tcTodo.SelectedIndex = 2;

        }

        /*-------------------------BOTON DE REPORTES-------------------------*/
        private void btnReporte_Click(object sender, EventArgs e)
        {
            cargardgvRepor();
            GraficaReportes();

            tcTodo.SelectedIndex = 3;
            if(dgvProductos.Rows.Count == 0)
            {

            }
            else
            {
                dgvReportes.CurrentCell.Selected = false;
                dgvReportes.ClearSelection();
            }
            //dgvReportes.CurrentCell.Selected = false;
            //  dgvReportes.ClearSelection();
        }

        /*-------------------------BOTON DE CORTE-------------------------*/
        private void btnCorte_Click(object sender, EventArgs e)
        {
            llenarDGVCorte();
            sumaVentas();
            tcTodo.SelectedIndex = 4;
            if (dgvCorte.Rows.Count == 0)
            {

            }
            else
            {
                llenarDGVCorte();
                /*dgvCorte.CurrentCell.Selected = false;
                dgvCorte.ClearSelection();*/
            }
        }

        private void FechaCorte()
        {
            var Fecha = DateTime.Now.ToString("yyyyMMdd hh:mm:ss");
            string fec = "insert into FechaCorte VALUES @FECHA";

            SqlCommand cmd = new SqlCommand(fec, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        /*-------------------------BOTON QUE AGREGA COSAS QUE SE COMPRARAN-------------------------*/

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (comprobar() == false)
                AgregarCarrito();
        }

        /*-------------------------FUNCION PARA AGREGAR COSAS AL CARRITO-------------------------*/
        private void AgregarCarrito()
        {
            conexion.Close();
            if (string.IsNullOrEmpty(tbProducto.Text))
            {
                MessageBox.Show("Campo de Producto VACIO");
            }
            else if (string.IsNullOrEmpty(tbCantidad.Text))
            {
                MessageBox.Show("Campo de Cantidad VACIO");
            }
            else
            {
                try
                {
                    String com = "Select Producto, Nombre, Precio from Productos where Producto = @idProducto";

                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(com, conexion))
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dataGridView1);

                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@idProducto", tbProducto.Text);
                        cmd.ExecuteNonQuery();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DataRow row = dt.Rows[0];
                        var f = fila.Cells[3].Value = tbCantidad.Text;
                        dataGridView1.Rows.Add(row["Producto"].ToString(), row["Nombre"].ToString(), row["Precio"].ToString(), f.ToString());
                    }
                    conexion.Close();
                    SumaTotal();
                    dataGridView1.CurrentCell.Selected = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
            }
        }

        /*-------------------------FUNCION PARA COMPROBAR REPETICIONES EN DGV-------------------------*/
        private bool comprobar()
        {

            bool existe = false;

            if (dataGridView1.RowCount > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == Convert.ToInt32(tbProducto.Text))
                    {
                        MessageBox.Show("EL PRODUCTO YA EXISTE");
                        existe = true;
                        break;
                    }
                }
            }
            return existe;
        }
        /*-------------------------SUMA TOTAL DE LA COMPRA-------------------------*/
        private void SumaTotal()
        {
            TotalC = 0;
            double iva = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TotalC = (Convert.ToDouble(row.Cells["clmPrecio"].Value) * Convert.ToDouble(row.Cells["clmCantidad"].Value) + TotalC);
            }

            iva = TotalC * 0.16;
            tbMosTotal.Text = TotalC.ToString();

            TotalC = TotalC + iva;


            txtIVA.Text = iva.ToString("0.00", CultureInfo.InvariantCulture);
            tbMosTotal2.Text = TotalC.ToString("0.00", CultureInfo.InvariantCulture);
        }

        /*-------------------------MOSTRAR CAMBIO EN TEXTBOX-------------------------*/
        private void pagoTotal()
        {
            double Pago = Convert.ToDouble(tbMosPago.Text);
            double res = Pago - TotalC;
            tbMosCambio.Text = res.ToString("0.00", CultureInfo.InvariantCulture);
        }

        /*-------------------------AGREGAR INTER COBRO A BD-------------------------*/
        private void InterBD(int val1, int val2, float val3)
        {
            String Inter = "INSERT INTO Inter (Producto, idCobro,Cantidad, TotalPre, Fecha) VALUES (@idProducto, @idCobro, @Cantidad, @TotalPre,GETDATE())";

            int id = 0;
            id = valorIDCobro(id);
            SqlCommand cmd = new SqlCommand(Inter, conexion);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idCobro", id);
            cmd.Parameters.AddWithValue("@idProducto", val1);
            cmd.Parameters.AddWithValue("@Cantidad", val2);
            cmd.Parameters.AddWithValue("@TotalPre", val3);
            VentaTotal(val1, val2);
            cmd.ExecuteNonQuery();
        }

        /*-------------------------AGREGAR COBRO NORMAL A BD-------------------------*/
        private void CobroBD(float Iva, float total)
        {
            String Cobranza = "INSERT INTO Cobranza (Fecha, IVA, Total, idUsuario) VALUES (GETDATE(), @Iva, @Total,@Usuario)";

            SqlCommand cmd = new SqlCommand(Cobranza, conexion);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Iva", Iva);
            cmd.Parameters.AddWithValue("@Total", total);
            cmd.Parameters.AddWithValue("@Usuario", LoginCache.idUsuario);

            cmd.ExecuteNonQuery();


        }

        /*-------------------------MODIFICACION DE ID EN TABLA COBRO DE BD-------------------------*/
        private int valorIDCobro(int val1)
        {
            String query = "SELECT TOP 1 idCobro FROM Cobranza ORDER BY idCobro DESC";
            SqlCommand cmd = new SqlCommand(query, conexion);
            object valor = cmd.ExecuteScalar();
            if (valor != null)
            {
                val1 = Convert.ToInt32(valor);
            }
            return val1;
        }

        /*-------------------------ACTUALIZACION DE VENTAS TOTALES DE PRODUCTOS-------------------------*/
        private void VentaTotal(int val1, int val2)
        {
            String SumarVenTotal = "Update Productos Set VentasTotales = VentasTotales + @Cantidad WHERE Producto = @idProducto";
            SqlCommand cmd = new SqlCommand(SumarVenTotal, conexion);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idProducto", val1);
            cmd.Parameters.AddWithValue("@Cantidad", val2);
            cmd.ExecuteNonQuery();
        }

        /*-------------------------BOTON DE COBRO-------------------------*/
        private void btnCobrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbMosPago.Text))
            {
                MessageBox.Show("INGRESE EL PAGO");
            }
            else if (float.Parse(tbMosPago.Text) < float.Parse(tbMosTotal2.Text))
            {
                MessageBox.Show("El pago es menor al TOTAL");
            }
            else
            {
                conexion.Close();
                conexion.Open();
                pagoTotal();
                MessageBox.Show("PAGO REALIZADO CON EXTIO");
                CobroBD(float.Parse(txtIVA.Text), float.Parse(tbMosTotal2.Text));

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    float PrecTotal = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);

                    InterBD(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value), PrecTotal);
                    RestarStock(Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value), Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value));

                }
                conexion.Close();
                dataGridView1.Rows.Clear();
               // Application.Restart();
            }
        }

        /*-------------------------RESTA STOCK AL COBRAR, DEPENDIENDO LA CANTIDAD-------------------------*/
        private void RestarStock(int val1, int val2)
        {
            String restarStock = "Update Productos Set Stock = Stock - @Cantidad WHERE Producto = @idProducto";
            SqlCommand cmd = new SqlCommand(restarStock, conexion);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idProducto", val1);
            cmd.Parameters.AddWithValue("@Cantidad", val2);
            cmd.ExecuteNonQuery();
        }


        /*-------------------------FUNCION PARA AGREGAR DATOS A DATAGRIDVIEW DE PRODUCTOS EN SU RESPECTIVA CATEGORIA DESDE LA BD-------------------------*/
        private void llenarTablaProductos()
        {

            String com = "Select idcategoria, nombre from Categoria";


            conexion.Open();
            using (SqlCommand cmd = new SqlCommand(com, conexion))
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridView2);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

                conexion.Close();
            }
        }

        /*EVENTO PARA MODIFICAR CANTIDAD DE PRODUCTOS EN EL CARRITO*/
        private void dataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            SumaTotal();
        }

        /*-------------------------EVENTO AL HACER CLICK EN CUALQUIER FILA DE LA TABLA QUE MUESTRA CATEGORIAS DE PRODUCTOS-------------------------*/
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else { 

                try
                {
                    limpiarTXBox();
                    comboBox1.SelectedIndex = 0;
                   
                    //  string valorCelda = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    valorCelda = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                    RecargarDGV();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RecargarDGV()
        {
            conexion.Open();
            string selPro = "Select Producto, nombre, Contenido, Precio, Stock from Productos Where idCategoria = @id";
           // string valorCelda = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();

            using (SqlCommand cmd = new SqlCommand(selPro, conexion))
            {

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvProductos);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", valorCelda);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProductos.DataSource = dt;

                dgvProductos.CurrentCell.Selected = false;

                conexion.Close();
            }
        }
        /*-------------------------EVENTO AL HACER CLICK EN CUALQUIER FILA DE LA TABLA QUE MUESTRA LOS PRODUCTOS EN BASE A LA CATEGORIA-------------------------*/
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else { 
                try
                {
                    comboBox1.SelectedIndex = 0;
                    valorCelda2 = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string selPro = "Select Producto, nombre, idCategoria, Contenido, PrecioCompra, Precio, Stock from Productos Where Producto = @id";

                    conexion.Open();
                    SqlCommand comando = new SqlCommand(selPro, conexion);
                    comando.Parameters.AddWithValue("@id", valorCelda2);
                    SqlDataReader registro = comando.ExecuteReader();

                    if (registro.Read())
                    {
                        txtDescID.Text = registro["Producto"].ToString();
                        txtProNom.Text = registro["nombre"].ToString();
                        txtDescCat.Text = registro["idCategoria"].ToString();
                        txtProCont.Text = registro["Contenido"].ToString();
                        txtDesCant.Text = registro["Stock"].ToString();
                        txtDescPreCom.Text = registro["PrecioCompra"].ToString();
                        txtDescPreVen.Text = registro["Precio"].ToString();

                    }

                    conexion.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        /*-------------------------RESTRINGIR CARCATERES EN TEXTBOX-------------------------*/

        private void restringirTBox(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        /*-------------------------RESTRICCION EN TEXTBOX------------------------*/

        private void tbProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            restringirTBox(e);
        }

        /*-------------------------RESTRICCION EN TEXTBOX------------------------*/
        private void tbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            restringirTBox(e);
        }

        /*-------------------------RESTRICCION EN TEXTBOX------------------------*/
        private void tbMosPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            restringirTBox(e);
        }

        /*-------------------------CENTRAR COLUMNAS DE DATAGRIDVIEWS-----------------------*/
        private void centrarColumnas(DataGridView dgv)
        {
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        /*-------------------------ELIMINAR PRIMERA COLUMNA DE DATAGRIDVIEW ------------------------*/
        private void QuitarColumnaUno()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dgvProductos.RowHeadersVisible = false;
            dgvReportes.RowHeadersVisible = false;
        }

        /*-------------------------LIMPIAR TEXTBOX EN VENTAS------------------------*/
        private void limpiarTXBox()
        {
            txtProNom.Text = "";
            txtProCont.Text = "";
            txtDesCant.Text = "";
            txtDescPreCom.Text = "";
            txtDescPreVen.Text = "";
        }

        /*-------------------------TEXTBOX MÁS GRANDE-------------------------*/
        private void tamTextBox(){
            txtProCont.AutoSize = false;
            txtProCont.Size = new Size(250, 45);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        /*-------------------------OBTENCION DE 5 PRODUCTOS MAS VENDIDOS------------------------*/
        private void VentasTotalesGRA()
        {
            string VenTotales = "Select TOP 5 Nombre, Contenido, VentasTotales FROM Productos ORDER BY VentasTotales DESC";
            SqlDataAdapter da = new SqlDataAdapter(VenTotales, conexion);
            DataTable dt = new DataTable();
            DataRow dr;
            da.Fill(dt);
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chart1.Titles.Add("Productos mas vendidos");
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    Series series = chart1.Series.Add(dr.ItemArray[0].ToString()+" "+dr.ItemArray[1]);
                   series.Points.Add(Convert.ToDouble(dr.ItemArray[2]));
                }
            }
        }

        /*-------------------------GRAFICA VENTAS MENSUALES------------------------*/
        private void VentasTotalesCAT()
        {
            conexion.Open();
            string VenTotales = "SELECT DATENAME(MONTH, DATEADD(MONTH, MONTH(Fecha),-1)) as Mes, sum(Total) AS Total FROM Cobranza WHERE YEAR(FECHA) = YEAR(GETDATE()) GROUP BY YEAR(Fecha), MONTH(Fecha) ORDER BY  Mes ;";
            ArrayList Mes = new ArrayList();
            ArrayList Total = new ArrayList();

            SqlCommand cmd = new SqlCommand(VenTotales, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Mes.Add(dr.GetString(0));
                Total.Add(dr.GetDecimal(1));
            }
            chart2.Series[0].Points.DataBindXY(Mes, Total);
            conexion.Close();
        }

        /*-------------------------GRAFICA QUE MUESTRA VENTAS TOTALES POR CATEGORIA------------------------*/
        private void Prueba()
        {
            conexion.Open();
            string VenTotales = "SELECT c.nombre, sum(p.VentasTotales) FROM Productos p join Categoria c ON c.idCategoria = p.idCategoria GROUP BY c.nombre;";

            ArrayList Categoria = new ArrayList();
            ArrayList Total = new ArrayList();

            SqlCommand cmd = new SqlCommand(VenTotales, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria.Add(dr.GetString(0));
                Total.Add(dr.GetInt32(1));
            }
            chart3.Series[0].Points.DataBindXY(Categoria, Total);
            conexion.Close();
        }


        /*-------------------------OPCIONES DE COMBOBOX------------------------*/
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                DeshabTextBox();
            }
            if(comboBox1.SelectedIndex == 1)
            {
                habTextBox();
                int id = 0;
                /* id = valorIDProducto(id) + 1;
                 txtDescID.Text = id.ToString();*/
                txtDescID.Text = valorIDProducto(id).ToString();
            }
        }

        /*-------------------------HABILITAR ESCRITURA EN TEXTBOXS------------------------*/
        private void habTextBox()
        {
            limpTXB2();
            btnDescAgregar.Enabled = true;

            txtProNom.ReadOnly = false;
            txtProCont.ReadOnly = false;
            txtDesCant.ReadOnly = false;
            txtDescPreCom.ReadOnly = false;
            txtDescPreVen.ReadOnly = false;
            cbCategoria.Enabled = true;
        }

        /*-------------------------DESHABILITAR ESCRITURA EN TEXTBOXS------------------------*/
        private void DeshabTextBox()
        {

            limpTXB2();
            txtProNom.ReadOnly = true;
            txtProCont.ReadOnly = true;
            txtDesCant.ReadOnly = true;
            txtDescPreCom.ReadOnly = true;
            txtDescPreVen.ReadOnly = true;
            txtDescCat.ReadOnly = true;
            btnDescAgregar.Enabled = false;
            cbCategoria.Enabled = false;
        }

        /*-------------------------LIMPIAR TEXTBOXS EN APARTADO DE PRODUCTOS------------------------*/
        private void limpTXB2()
        {
            txtProNom.Text = "";
            txtProCont.Text = "";
            txtDesCant.Text = "";
            txtDescPreCom.Text = "";
            txtDescPreVen.Text = "";
            txtDescCat.Text = "";
            txtDescID.Text = "";
        }

        /*-------------------------AGREGA NUEVO PRODUCTO EN EL APARTADO DE PRODUCTOS------------------------*/
        private void btnDescAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescID.Text) || string.IsNullOrEmpty(txtProNom.Text) || string.IsNullOrEmpty(txtDescCat.Text) || string.IsNullOrEmpty(txtProCont.Text) || string.IsNullOrEmpty(txtDesCant.Text) || string.IsNullOrEmpty(txtDescPreCom.Text) || string.IsNullOrEmpty(txtDescPreVen.Text))
            {
                MessageBox.Show("Llene todos los campos necesarios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Insertar = "INSERT INTO Productos (Producto, idCategoria, Nombre, PrecioCompra, Precio, Contenido, VentasTotales, Stock) VALUES (@idProducto,@idCategoria,@nombre,@PrecioCompra,@Precio,@Contenido,@VentasTotales,@Stock)";
                int id = 0;
                id = valorIDProducto(id);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(Insertar, conexion);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idProducto", id);
                cmd.Parameters.AddWithValue("@idCategoria", Convert.ToInt32(txtDescCat.Text));
                cmd.Parameters.AddWithValue("@nombre", txtProNom.Text);
                cmd.Parameters.AddWithValue("@PrecioCompra", float.Parse(txtDescPreCom.Text));
                cmd.Parameters.AddWithValue("@Precio", float.Parse(txtDescPreVen.Text));
                cmd.Parameters.AddWithValue("@Contenido", txtProCont.Text);
                cmd.Parameters.AddWithValue("@VentasTotales", 0);
                cmd.Parameters.AddWithValue("@Stock", Convert.ToInt32(txtDesCant.Text));
                cmd.ExecuteNonQuery();
                conexion.Close();
                limpTXB2();
                MessageBox.Show("PRODUCTO AGREGADO CORRECTAMENTE");
                RecargarDGV();

                id +=1;
                txtDescID.Text = id.ToString();
            }
        }
        private void CombCategorias()
        {
            try
            {
                string cat = "SELECT nombre FROM Categoria";
                conexion.Open();

                SqlCommand cmd = new SqlCommand(cat, conexion);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbCategoria.Items.Add(dr["nombre"].ToString());
                }
                conexion.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(""+ex.ToString());
            }
        }

        /*-------------------------MODIFICACION ID DE LA TABLA DE PRODUCTOS------------------------*/
        private int valorIDProducto(int val1=0)
        {
            conexion.Open();
            String query = "SELECT TOP 1 Producto FROM Productos ORDER BY Producto DESC";
            SqlCommand cmd = new SqlCommand(query, conexion);
            object valor = cmd.ExecuteScalar();
            if (valor != null)
            {
                val1 = Convert.ToInt32(valor);
            }
            conexion.Close();
            return val1+1;
        }

        /*-------------------------MUESTRA EL TOTAL DE VENTAS AL MES EN DATAGRIDVIEW------------------------*/
        private void cargardgvRepor()
        {
            string reporte = "SELECT YEAR(Fecha) AS año, DATENAME(MONTH, DATEADD(MONTH, MONTH(Fecha),-1)) AS Mes, sum(Total) AS Total FROM Cobranza WHERE YEAR(FECHA) = YEAR(GETDATE()) GROUP BY YEAR(Fecha), MONTH(Fecha) ORDER BY  YEAR(Fecha), MONTH(FECHA) ASC;";

            conexion.Open();
            using (SqlCommand cmd = new SqlCommand(reporte, conexion))
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvReportes);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReportes.DataSource = dt;
                conexion.Close();
            }
        }

        /*-------------------------TOTAL DE VENTAS AL MES EN FORMATO GRAFICO------------------------*/
        private void GraficaReportes()
        {
            conexion.Open();
            string VenTotales = "SELECT DATENAME(MONTH, DATEADD(MONTH, MONTH(Fecha),-1)) as Mes, sum(Total) AS Total FROM Cobranza WHERE YEAR(FECHA) = YEAR(GETDATE()) GROUP BY YEAR(Fecha), MONTH(Fecha) ORDER BY  YEAR(Fecha), MONTH(FECHA) ASC;";
            ArrayList Mes = new ArrayList();
            ArrayList Total = new ArrayList();

            SqlCommand cmd = new SqlCommand(VenTotales, conexion);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Mes.Add(dr.GetString(0));
                Total.Add(dr.GetDecimal(1));
            }
            chartReport.Series[0].Points.DataBindXY(Mes, Total);
            conexion.Close();
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategoria.SelectedIndex == 0)
            {
                txtDescCat.Text = "";
            }
            int seleccionado = cbCategoria.SelectedIndex;
            //string seleccionado = cbCategoria.SelectedIndex.ToString();
            string nombre = "SELECT idCategoria FROM Categoria WHERE idCategoria = @Categoria";


            conexion.Open();
            SqlCommand cmd = new SqlCommand(nombre, conexion);
            cmd.Parameters.AddWithValue("@Categoria",seleccionado);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtDescCat.Text = Convert.ToString(dr.GetInt32(0));
            }
            conexion.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            actEstado();
            Application.Exit();
        }

        private void btnTerminarCorte_Click(object sender, EventArgs e)
        {
            Corte();
            actEstado();
            Login login = new Login();
            login.Show();
            this.Hide();
            
        }
        private void actEstado()
        {
            string act = "UPDATE Usuario SET Estado = 0, FechaEnt = NULL WHERE nomUsuario = @nomUser";

            conexion.Open();
            SqlCommand cmd = new SqlCommand(act, conexion);
            cmd.Parameters.AddWithValue("@nomUser", lblLogUser.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            conexion.Close();
        }
        private void lblUsuario()
        {
            lblLogUser.Text = LoginCache.nomUsuario;
            lblNombreDelUsuario.Text = "Bienvenido "+LoginCache.nombre + " " + LoginCache.Apepa + " " + LoginCache.ApeMat;
            lblUsuCort.Text = LoginCache.nombre + " " + LoginCache.Apepa + " " + LoginCache.ApeMat;
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyyMMdd hh:mm:ss");
            //lblFecha.Text = DateTime.Now.ToLongDateString();
        }
        private void llenarDGVCorte()
        {
            conexion.Open();
            string corte = "SELECT i.Producto AS Producto, p.nombre, SUM(i.Cantidad) AS CantidadTotal, SUM(i.TotalPre) AS PRECIOTOTAL FROM Inter i INNER JOIN Usuario u ON Fecha BETWEEN u.FechaEnt AND i.Fecha INNER JOIN Productos p ON i.Producto = p.Producto GROUP BY i.Producto, p.nombre;";

            using (SqlCommand cmd = new SqlCommand(corte, conexion))
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvCorte);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCorte.DataSource = dt;
                conexion.Close();
            }
        }
        private void sumaVentas()
        {
            string totCaja = "SELECT SUM(i.TotalPre) AS SUMA FROM Inter i INNER JOIN Usuario u ON Fecha BETWEEN u.FechaEnt AND i.Fecha;";

            conexion.Open();

            using(SqlCommand cmd = new SqlCommand(totCaja, conexion))
            {
                txtVenCort.Text = Convert.ToString(cmd.ExecuteScalar());

                conexion.Close();
            }


           // txtCaja.Text = interCorte.TotalVenta.ToString();
        }

        private void Corte()
        {
            string corte = "INSERT INTO Corte (idUsuario, Total, FechaCorte, EnCaja) VALUES (@idUser,@Total,GETDATE(),@Caja);";

            SqlCommand cmd = new SqlCommand(corte, conexion);
            cmd.CommandType = CommandType.Text;


            cmd.Parameters.AddWithValue("@idUser", LoginCache.idUsuario);
            cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtVenCort.Text));
            cmd.Parameters.AddWithValue("@Caja", Convert.ToDecimal(txtCaja.Text));
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();

        }
    }
}
