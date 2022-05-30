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
    public partial class ReporteCXP : Form
    {

        private Form1 form1;
        private DataTable table;

        public ReporteCXP()
        {
            InitializeComponent();
        }

        public ReporteCXP(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;

            table = new DataTable();
        }

        private void ReporteCXP_Load(object sender, EventArgs e)
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

        private DataTable CreaGrilla(string[] titulos)
        {
            DataTable tabla = new DataTable();

            foreach (string t in titulos)
            {
                tabla.Columns.Add(t, System.Type.GetType("System.String"));
            }
            return tabla;
        }

        public void Consulta()
        {
            using (var db = new ModelCV())
            {
                var idproducto = Convert.ToInt32(cboProducto.SelectedValue);
                DataTable table = CreaGrilla(new string[] { "ID", "Producto", "Cantidad Comprada" });

                var query = from p in db.productos
                            join m in db.movimientos on p.idproducto equals m.idproducto
                            where p.idproducto == idproducto && m.cantidad > 0
                            select new
                            {
                                idproducto = p.idproducto,
                                producto = p.titulo,
                                cantVendida = m.cantidad
                            };

                foreach (var n in query)
                {
                    table.Rows.Add(n.idproducto, n.producto, n.cantVendida);
                }

                dgvResultado.DataSource = table;

                dgvResultado.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns["Producto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvResultado.Columns["Cantidad Comprada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }
    }
}
