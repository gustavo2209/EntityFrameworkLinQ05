using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkLinQ05
{
    public partial class Form1 : Form
    {

        private ProductosQry productosQry;
        private ProductosUpd productosUpd;
        private CompraProductos compraProductos;
        private VentaProductos ventaProductos;
        private ReporteProdStock reporteProdStock;
        private ReporteVXP reporteVXP;

        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductosQry))
                {
                    form.Activate();
                    return;
                }
            }

            productosQry = new ProductosQry(this);
            productosQry.MdiParent = this;
            productosQry.Show();
            productosQry.BringToFront();
        }

        private void retirarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool msg = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductosQry))
                {
                    productosQry = (ProductosQry)form;
                    productosQry.Activate();
                    productosQry.RetirarFila();

                    msg = false;
                    break;
                }
                else
                {
                    msg = true;
                }
            }

            if (msg)
            {
                MessageBox.Show("Para retirar active el formulario de NUEVO PRODUCTO");
            }
        }

        private void actualizarDatosDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ProductosUpd))
                {
                    form.Activate();
                    return;
                }
            }

            productosUpd = new ProductosUpd(this);
            productosUpd.MdiParent = this;
            productosUpd.Show();
            productosUpd.BringToFront();
        }

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(CompraProductos))
                {
                    form.Activate();
                    return;
                }
            }

            compraProductos = new CompraProductos(this);
            compraProductos.MdiParent = this;
            compraProductos.Show();
            compraProductos.BringToFront();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(VentaProductos))
                {
                    form.Activate();
                    return;
                }
            }

            ventaProductos = new VentaProductos(this);
            ventaProductos.MdiParent = this;
            ventaProductos.Show();
            ventaProductos.BringToFront();
        }

        private void productosYStocksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ReporteProdStock))
                {
                    form.Activate();
                    return;
                }
            }

            reporteProdStock = new ReporteProdStock(this);
            reporteProdStock.MdiParent = this;
            reporteProdStock.Show();
            reporteProdStock.BringToFront();
        }

        private void ventasXProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ReporteVXP))
                {
                    form.Activate();
                    return;
                }
            }

            reporteVXP = new ReporteVXP(this);
            reporteVXP.MdiParent = this;
            reporteVXP.Show();
            reporteVXP.BringToFront();
        }
    }
}
