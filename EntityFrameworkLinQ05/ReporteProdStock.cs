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
    public partial class ReporteProdStock : Form
    {

        private Form1 form1;
        private DataTable table;

        public ReporteProdStock()
        {
            InitializeComponent();
        }

        public ReporteProdStock(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            table = new DataTable();
        }

        private void ReporteProdStock_Load(object sender, EventArgs e)
        {
            PintaGrilla();
        }

        private void PintaGrilla()
        {
            using (var db = new ModelCV())
            {
                DataTable table = CreaGrilla(new string[] { "ID", "Producto", "Stock" });

                var query = from n in db.productos select n;

                foreach (var n in query)
                {
                    table.Rows.Add(n.idproducto, n.titulo, n.stock);
                }

                dgvReporte01.DataSource = table;

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
    }
}
