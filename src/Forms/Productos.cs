using atahualpa_ferresys.Model;
using atahualpa_ferresys.Utils;
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
        public string TextoBusqueda = "";
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = LlenarProductos(0);
            ConfigurarTabla(dgvProductos);
            if(dgvProductos.Rows.Count > 0 ) { lblError.Visible = false; }
            cbOpBuscar.DataSource = Tools.ListadoBusquedaProductos;
        }

        private List<FrontProducto> LlenarProductos(int e)
        {
            switch (e)
            {
                case 0:
                    try
                    {
                        using (ATAHUALPA_DBAEntities db = new ATAHUALPA_DBAEntities())
                        {
                            var sql = (from i in db.PRODUCTO
                                       select new FrontProducto
                                       {
                                           ID_PROD = i.ID_PROD,
                                           NOMBRE = i.NOMBRE,
                                           DESCRIPCION = i.DESCRIPCION,
                                           PRECIO_COMP = i.PRECIO_COMP,
                                           PRECIO_VENT = i.PRECIO_VENT,
                                           STOCK = i.STOCK,
                                           FECHA_INGRESO = i.FECHA_INGRESO,
                                           TIPO_UNIDAD = i.TIPO_UNIDAD.NOMBRE,
                                           PROVEEDOR = i.PROVEEDOR.NOMBRE,
                                           ACTIVO = i.ACTIVO
                                       }).ToList();
                            return sql;
                        }
                    }
                    catch (Exception) { MessageBox.Show("Error! Conexión con base de datos fallida."); return null; }
                case 1:
                    try
                    {
                        using (ATAHUALPA_DBAEntities db = new ATAHUALPA_DBAEntities())
                        {
                            var sql = (from i in db.PRODUCTO
                                       where i.NOMBRE.Contains(TextoBusqueda)
                                       select new FrontProducto
                                       {
                                           ID_PROD = i.ID_PROD,
                                           NOMBRE = i.NOMBRE,
                                           DESCRIPCION = i.DESCRIPCION,
                                           PRECIO_COMP = i.PRECIO_COMP,
                                           PRECIO_VENT = i.PRECIO_VENT,
                                           STOCK = i.STOCK,
                                           FECHA_INGRESO = i.FECHA_INGRESO,
                                           TIPO_UNIDAD = i.TIPO_UNIDAD.NOMBRE,
                                           PROVEEDOR = i.PROVEEDOR.NOMBRE,
                                           ACTIVO = i.ACTIVO
                                       }).ToList();
                            return sql;
                        }
                    }
                    catch (Exception) { MessageBox.Show("Error! Conexión con base de datos fallida."); return null; }
                case 2:
                    try
                    {
                        using (ATAHUALPA_DBAEntities db = new ATAHUALPA_DBAEntities())
                        {
                            var sql = (from i in db.PRODUCTO
                                       where i.DESCRIPCION.Contains(TextoBusqueda)
                                       select new FrontProducto
                                       {
                                           ID_PROD = i.ID_PROD,
                                           NOMBRE = i.NOMBRE,
                                           DESCRIPCION = i.DESCRIPCION,
                                           PRECIO_COMP = i.PRECIO_COMP,
                                           PRECIO_VENT = i.PRECIO_VENT,
                                           STOCK = i.STOCK,
                                           FECHA_INGRESO = i.FECHA_INGRESO,
                                           TIPO_UNIDAD = i.TIPO_UNIDAD.NOMBRE,
                                           PROVEEDOR = i.PROVEEDOR.NOMBRE,
                                           ACTIVO = i.ACTIVO
                                       }).ToList();
                            return sql;
                        }
                    }
                    catch (Exception) { MessageBox.Show("Error! Conexión con base de datos fallida."); return null; }
                case 3:
                    //Fecha de Ingreso..
                    try
                    {
                        using (ATAHUALPA_DBAEntities db = new ATAHUALPA_DBAEntities())
                        {
                            var sql = (from i in db.PRODUCTO select new FrontProducto
                                       {
                                           ID_PROD = i.ID_PROD,
                                           NOMBRE = i.NOMBRE,
                                           DESCRIPCION = i.DESCRIPCION,
                                           PRECIO_COMP = i.PRECIO_COMP,
                                           PRECIO_VENT = i.PRECIO_VENT,
                                           STOCK = i.STOCK,
                                           FECHA_INGRESO = i.FECHA_INGRESO,
                                           TIPO_UNIDAD = i.TIPO_UNIDAD.NOMBRE,
                                           PROVEEDOR = i.PROVEEDOR.NOMBRE,
                                           ACTIVO = i.ACTIVO
                                       }).ToList();
                            //TODO: Check!
                            sql.Where(i => Convert.ToDateTime(i.FECHA_INGRESO) == Convert.ToDateTime(dtpBusqueda.Value));
                            return sql;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Error! Conexión con base de datos fallida."+ex.ToString()); return null; }
                default: return null; 
            }
        }

        private void ConfigurarTabla(DataGridView dgv)
        {
            dgv.Columns[0].Width = 60;
            dgv.Columns[1].Width = 350;
            dgv.Columns[2].Width = 30;
            dgv.Columns[3].Width = 60;
            dgv.Columns[4].Width = 60;
            dgv.Columns[5].Width = 60;
            dgv.Columns[6].Width = 100;
            dgv.Columns[7].Width = 135;
            dgv.Columns[8].Width = 150;
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgv.Columns[3].HeaderText = "PRECIO COMPRA";
            dgv.Columns[4].HeaderText = "PRECIO VENTA";
            dgv.Columns[5].HeaderText = "STOCK";
            dgv.Columns[6].HeaderText = "FECHA INGRESO";
            dgv.Columns[7].HeaderText = "PRESENTACIÓN";
            dgv.Columns[8].HeaderText = "PROVEEDOR";
            dgv.Columns[9].HeaderText = "ACTIVO";
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.CurrentRow.Selected = true;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(cbOpBuscar.SelectedIndex)
            {
                case 0:
                    //Nombre
                    TextoBusqueda = txtBusqueda.Text.Trim();
                    if (TextoBusqueda == "" || TextoBusqueda == " ") { btnResetear.PerformClick(); }
                    else
                    {
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = LlenarProductos(1);
                        ConfigurarTabla(dgvProductos);
                        MostrarLabelError();
                    }
                    break;
                case 1:
                    //Descripción
                    TextoBusqueda = txtBusqueda.Text.Trim();
                    if (TextoBusqueda == "" || TextoBusqueda == " ") { btnResetear.PerformClick(); }
                    else
                    {
                        dgvProductos.DataSource = null;
                        dgvProductos.DataSource = LlenarProductos(2);
                        ConfigurarTabla(dgvProductos);
                        MostrarLabelError();
                    }
                    break;
                case 2: break;
                case 3: break;
                case 4:
                    //Por ID
                    break;
                default: break;
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = LlenarProductos(0);
            ConfigurarTabla(dgvProductos);
            txtBusqueda.Clear();
        }

        private void cbOpBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbOpBuscar.SelectedIndex)
            {
                case 0: 
                    txtBusqueda.Enabled = true;
                    cbBusquedaAux.Enabled = false;
                    dtpBusqueda.Enabled = false;
                    break;
                case 1: 
                    txtBusqueda.Enabled = true;
                    cbBusquedaAux.Enabled = false;
                    dtpBusqueda.Enabled = false;
                    break;
                case 2: 
                    txtBusqueda.Enabled = false;
                    cbBusquedaAux.Enabled = false;
                    dtpBusqueda.Enabled = true;
                    break;
                case 3: 
                    txtBusqueda.Enabled = false;
                    cbBusquedaAux.Enabled = true;
                    dtpBusqueda.Enabled = false;
                    break;
                case 4: 
                    txtBusqueda.Enabled = true;
                    cbBusquedaAux.Enabled = false;
                    dtpBusqueda.Enabled = false;
                    break;
                default: 
                    txtBusqueda.Enabled = true;
                    cbBusquedaAux.Enabled = false;
                    dtpBusqueda.Enabled = false;
                    break;
            }
        }

        private void dtpBusqueda_ValueChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = LlenarProductos(3);
            MostrarLabelError();
            //ConfigurarTabla(dgvProductos);
        }

        private void MostrarLabelError()
        {
            if (dgvProductos.Rows.Count <= 0) { lblError.Visible = true; } else { lblError.Visible = false; }
        }
    }
}
