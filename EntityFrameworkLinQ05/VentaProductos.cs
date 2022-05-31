using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

namespace EntityFrameworkLinQ05
{
    public partial class VentaProductos : Form
    {

        private Form1 form1;
        private NumberFormatInfo nfi;
        private DataTable table;

        public VentaProductos()
        {
            InitializeComponent();
        }

        public VentaProductos(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ",";
            nfi.NumberDecimalSeparator = ".";

            table = new DataTable();
        }

        private void VentaProductos_Load(object sender, EventArgs e)
        {
            using (var db = new ModelCV())
            {
                var query = from prod in db.productos
                            select new
                            {
                                idproducto = prod.idproducto,
                                producto = prod.titulo
                            };

                cboProducto.DataSource = query.ToList();
                cboProducto.ValueMember = "idproducto";
                cboProducto.DisplayMember = "producto";
            }
            txtTotal.Text = "0.00";

            table.Columns.Add("ID", System.Type.GetType("System.Int32"));
            table.Columns.Add("Producto", System.Type.GetType("System.String"));
            table.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            table.Columns.Add("Precio Compra", System.Type.GetType("System.String"));
            table.Columns.Add("SubTotal", System.Type.GetType("System.String"));

            dgvProductos.DataSource = table;

            txtCantidad.Focus();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var db = new ModelCV())
            {
                double total = 0;
                int idproducto = Convert.ToInt32(cboProducto.SelectedValue.ToString());
                var producto = db.productos.Find(idproducto);
                var subtotal = Convert.ToDouble(producto.precioCompra) * Convert.ToInt32(txtCantidad.Text);

                table.Rows.Add(cboProducto.SelectedValue, cboProducto.Text, Convert.ToInt32(txtCantidad.Text), producto.precioCompra.ToString("#,###.00", nfi), subtotal.ToString("#,###", nfi));

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    total += Convert.ToInt32(row.Cells["SubTotal"].Value);
                }

                txtTotal.Text = total.ToString("#,###.00", nfi);
                txtCantidad.Text = "";
                txtCantidad.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (var db = new ModelCV())
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    var cantidad = "-" + row.Cells["Cantidad"].Value;
                    var mov = new movimientos
                    {
                        idproducto = Convert.ToInt32(row.Cells["ID"].Value),
                        cantidad = Convert.ToInt32(cantidad)
                    };
                    db.movimientos.Add(mov);
                    db.SaveChanges();

                    /* ACTUALIZACION STOCK */

                    var producto = db.productos.Find(Convert.ToInt32(row.Cells["ID"].Value));
                    int nuevoStock = Convert.ToInt32(producto.stock) - Convert.ToInt32(row.Cells["Cantidad"].Value);
                    producto.stock = nuevoStock;

                    db.SaveChanges();
                }
            }

            MessageBox.Show("Venta registrada correctamente");

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductosQry))
                {
                    ((ProductosQry)form).Consulta();
                    form.Activate();
                    form.BringToFront();
                }
            }

            this.Dispose();
        }
    }
}
