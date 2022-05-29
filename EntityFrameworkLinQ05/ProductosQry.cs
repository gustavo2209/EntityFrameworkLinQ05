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
    public partial class ProductosQry : Form
    {

        private Form1 form1;
        private NumberFormatInfo nfi;

        public ProductosQry()
        {
            InitializeComponent();
        }

        public ProductosQry(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ",";
            nfi.NumberDecimalSeparator = ".";

            Consulta();
        }

        private void Consulta()
        {
            using (var db = new ModelCV())
            {
                DataTable table = CreaGrilla(new string[] { "ID", "Producto", "Stock", "Precio Compra", "Precio Venta" });

                var query = from n in db.productos select n;

                foreach (var n in query)
                {
                    table.Rows.Add(n.idproducto, n.titulo, n.stock, n.precioCompra, n.precioVenta);
                }

                dgvProductos.DataSource = table;

                dgvProductos.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProductos.Columns["Stock"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductos.Columns["Precio Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvProductos.Columns["Precio Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private DataTable CreaGrilla(string[] titulos)
        {
            DataTable tabla = new DataTable();

            foreach (string t in titulos)
            {
                tabla.Columns.Add(t, System.Type.GetType("System.String"));
            }
            return tabla;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (var db = new ModelCV())
            {
                double precioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                double precioVenta = precioCompra * 1.2;
                var producto = new productos { titulo = txtProducto.Text, stock = 0, precioCompra = Convert.ToDecimal(precioCompra.ToString("#,###.00", nfi)), precioVenta = Convert.ToDecimal(precioVenta.ToString("#,###.00", nfi)) };
                db.productos.Add(producto);
                db.SaveChanges();

                MessageBox.Show("Registro grabado correctamente");

                Consulta();

                txtProducto.Text = "";
                txtPrecioCompra.Text = "";
                txtProducto.Focus();
            }
        }

        public void RetirarFila()
        {
            DataGridViewSelectedRowCollection selectedRowCollection = dgvProductos.SelectedRows;

            if (selectedRowCollection.Count > 0)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de retirar este registro?", "Confirmar Retiro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    int idproducto = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value.ToString());

                    using (var db = new ModelCV())
                    {
                        var producto = db.productos.Find(idproducto);
                        db.productos.Remove(producto);
                        db.SaveChanges();

                        MessageBox.Show("Producto eliminado correctamente");

                        Consulta();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione fila a retirar");
            }
        }
    }
}
