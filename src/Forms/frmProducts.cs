using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Services;
using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace atahualpa_ferresys.Forms
{
    public partial class frmProducts : Form
    {
        public string TextoBusqueda = "";
        private readonly ProductService _productService = new ProductService(Tools.API_URL,Tools.JWT_TOKEN);
        public frmProducts()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            FillProductsTable(0);
            if(dgvProductos.Rows.Count > 0 ) { lblError.Visible = false; }
            cbOpBuscar.DataSource = Tools.ListadoBusquedaProductos;
        }

        private async void FillProductsTable(int o)
        {
            try
            {
                List<Product> products = new List<Product>();
                switch (o)
                {
                    //Get All Products.
                    case 0:
                        products = await _productService.GetProducts();
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductos.DataSource = products;
                        lblError.Visible = false;
                        ConfigureTable(dgvProductos);
                    break;
                    //Get Products By Name.
                    case 1:
                        products = await _productService.GetProductsByName(TextoBusqueda);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        break;
                    //Get Products By Description
                    case 2:
                        products = await _productService.GetProductsByDescription(TextoBusqueda);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        break;
                    //Get Products By Date
                    case 3:
                        break;
                    //Get Products By Unit Type.
                    case 4:
                        break;
                    //Get Product By Id.
                    case 5:
                        Product product = new Product();
                        product = await _productService.GetProductById(Int32.Parse(TextoBusqueda));
                        if(product.Name != "")
                        {
                            products.Add(product);
                        }
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        break;
                    default:
                        break;

                }
            }
            catch(Exception ex)
            {
                if(ex.Message.Contains("404"))
                {
                    lblError.Show();
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[10].Visible = false;

            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 350;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 90;
            dgv.Columns[5].Width = 70;
            dgv.Columns[7].Width = 135;
            dgv.Columns[9].Width = 150;

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgv.Columns[3].HeaderText = "PRECIO COMPRA";
            dgv.Columns[4].HeaderText = "PRECIO VENTA";
            dgv.Columns[5].HeaderText = "STOCK";
            dgv.Columns[7].HeaderText = "PROVEEDOR";
            dgv.Columns[9].HeaderText = "FECHA INGRESO";
            dgv.Columns[11].HeaderText = "UNIDAD";
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProductos.CurrentRow.Selected = true;
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvProductos.Rows.Count <= 0)
            {
                lblError.Visible = true;
            }
            else { lblError.Visible = false; }
            switch (cbOpBuscar.SelectedIndex)
            {
                case 0:
                    //Nombre
                    TextoBusqueda = txtBusqueda.Text.Trim();
                    if (TextoBusqueda == "" || TextoBusqueda == " ") { btnResetear.PerformClick(); }
                    else
                    {
                        dgvProductos.DataSource = null;
                        FillProductsTable(1);
                    }
                    break;
                case 1:
                    //Descripción
                    TextoBusqueda = txtBusqueda.Text.Trim();
                    if (TextoBusqueda == "" || TextoBusqueda == " ") { btnResetear.PerformClick(); }
                    else
                    {
                        dgvProductos.DataSource = null;
                        FillProductsTable(2);
                    }
                    break;
                case 2: break;
                case 3: break;
                case 4:
                    //Por ID
                    if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        BeginInvoke((Action)(() =>
                        {
                            dgvProductos.DataSource = null;
                            TextoBusqueda = txtBusqueda.Text;
                            if (TextoBusqueda.Length >= 1)
                            {
                                FillProductsTable(5);
                            }
                        }));
                    }
                    break;
                default: break;
            }
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            FillProductsTable(0);
            txtBusqueda.Clear();
            cbOpBuscar.SelectedIndex = 0;
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
            FillProductsTable(0);
        }

    }
}
