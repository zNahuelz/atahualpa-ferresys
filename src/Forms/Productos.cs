using atahualpa_ferresys.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = LlenarProductos();
            ConfigurarTabla(dgvProductos);
            if(dgvProductos.Rows.Count > 0 ) { lblError.Visible = false; }
        }

        private List<PRODUCTO> LlenarProductos()
        {
            try
            {
                using(ATAHUALPA_DBAEntities db = new ATAHUALPA_DBAEntities())
                {
                    var sql = (from i in db.PRODUCTO select i).ToList();
                    return sql;
                }
            }
            catch (Exception) { MessageBox.Show("Error! Conexión con base de datos fallida."); throw; }
        }

        private void ConfigurarTabla(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgv.Columns[3].HeaderText = "PRECIO COMPRA";
            dgv.Columns[4].HeaderText = "PRECIO VENTA";
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].HeaderText = "PRESENTACIÓN";
            dgv.Columns[8].HeaderText = "FECHA INGRESO";
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 350;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.CurrentRow.Selected = true;
        }
    }
}
