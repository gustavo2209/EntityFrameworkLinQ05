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
    public partial class ProductosUpd : Form
    {

        private Form1 form1;
        private NumberFormatInfo nfi;

        public ProductosUpd()
        {
            InitializeComponent();
        }

        public ProductosUpd(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = ",";
            nfi.NumberDecimalSeparator = ".";
        }

        private void ProductosUpd_Load(object sender, EventArgs e)
        {
            using (var db = new ModelCV())
            {
                var query = from prod in db.productos
                            select new
                            {
                                idproducto = prod.idproducto,
                                producto = prod.titulo,
                                precioCompra = prod.precioCompra
                            };

                cboProducto.DataSource = query.ToList();
                cboProducto.ValueMember = "idproducto";
                cboProducto.DisplayMember = "producto";
            }

            PintaDatos();
        }

        private void PintaDatos()
        {
            int idproducto = Convert.ToInt32(cboProducto.SelectedValue);

            using (var db = new ModelCV())
            {
                var query = from prod in db.productos
                            where prod.idproducto == idproducto
                            select new
                            {
                                producto = prod.titulo,
                                precioCompra = prod.precioCompra
                            };

                foreach (var fil in query)
                {
                    txtUpdProducto.Text = fil.producto;
                    txtPrecioUpd.Text = fil.precioCompra.ToString();
                }
            }
        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PintaDatos();
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            using (var db = new ModelCV())
            {
                double precioCompra = Convert.ToDouble(txtPrecioUpd.Text);
                double precioVenta = precioCompra * 1.2;
                int idproducto = Convert.ToInt32(cboProducto.SelectedValue.ToString());

                var producto = db.productos.Find(idproducto);
                producto.titulo = txtUpdProducto.Text;
                producto.precioCompra = Convert.ToDecimal(precioCompra.ToString("#,###.00", nfi));
                producto.precioVenta = Convert.ToDecimal(precioVenta.ToString("#,###.00", nfi));

                db.SaveChanges();

                MessageBox.Show("Producto actualizado correctamente");

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
}
