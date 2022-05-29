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
    }
}
