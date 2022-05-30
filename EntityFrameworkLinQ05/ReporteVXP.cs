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
    public partial class ReporteVXP : Form
    {

        private Form1 form1;
        private DataTable table;

        public ReporteVXP()
        {
            InitializeComponent();
        }

        public ReporteVXP(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            table = new DataTable();
        }

        private void ReporteVXP_Load(object sender, EventArgs e)
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
        }
    }
}
