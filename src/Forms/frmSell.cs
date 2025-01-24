using atahualpa_ferresys.Services;
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
    public partial class frmSell : Form
    {
        private readonly ProductService _productService = new ProductService(Tools.API_URL, Tools.JWT_TOKEN);
        private string Keyword = "";
        private int SelectedProductID = 0;
        public List<Tools.ProductHelper> cart = new List<Tools.ProductHelper>();
        private AddToCart frmAddToCart;
        public frmSell()
        {
            InitializeComponent();
        }

        private void frmSell_Load(object sender, EventArgs e)
        {
            FillSearchCriteria();
            FillProductsTable(0);
        }

        public void AddToCart(object sender,Tools.ProductHelper product)
        {
            cart.Add(product);
            dgvToSell.DataSource = cart;
            ConfigureCart(dgvToSell);
        }


        private async void FillProductsTable(int o)
        {
            try
            {
                List<Entities.Product> products = new List<Entities.Product>();
                switch (o)
                {
                    //Get All Products.
                    case 0:
                        products = await _productService.GetProducts();
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductList.DataSource = products;
                        ConfigureTable(dgvProductList);
                        break;
                    //Get Products By Name.
                    case 1:
                        products = await _productService.GetProductsByName(Keyword);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductList.DataSource = products;
                        ConfigureTable(dgvProductList);
                        if(dgvProductList.Rows.Count <= 0)
                        {
                            MessageBox.Show($"Producto: {Keyword} no encontrado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnRefresh.PerformClick();
                        }
                        break;
                    //Get Product By Id.
                    case 2:
                        Entities.Product product = new Entities.Product();
                        product = await _productService.GetProductById(Tools.TryParseInt(Keyword));
                        if (product.Name != "")
                        {
                            products.Add(product);
                        }
                        dgvProductList.DataSource = products;
                        ConfigureTable(dgvProductList);
                        break;
                    default:
                        goto case 0;

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    MessageBox.Show($"Producto de ID: {Keyword} no encontrado.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRefresh.PerformClick();
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
        }

        private void FillSearchCriteria()
        {
            cbSearchCriteria.DataSource = Tools.SellFormSearchCriteria;
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[12].Visible = false;

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 280;
            dgv.Columns[4].Width = 60;
            dgv.Columns[5].Width = 60;
            dgv.Columns[11].Width = 112;

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[4].HeaderText = "PRECIO";
            dgv.Columns[5].HeaderText = "STOCK";
            dgv.Columns[11].HeaderText = "UNIDAD";
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchCriteria.SelectedIndex == 0)
            {
                Tools.EnableDigits(sender, e);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtKeyword.Text.Length >= 1)
            {
                Keyword = txtKeyword.Text.Trim();
                switch (cbSearchCriteria.SelectedIndex)
                {
                    case 0:
                        FillProductsTable(2);
                        break;
                    case 1:
                        FillProductsTable(1);
                        break;
                    default: goto case 0;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKeyword.Text = "";
            cbSearchCriteria.SelectedIndex = 0;
            FillProductsTable(0);
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProductList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProductList.CurrentRow.Selected = true;
                SelectedProductID = Tools.TryParseInt(dgvProductList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
            }
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProductList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProductList.CurrentRow.Selected = true;
                SelectedProductID = Tools.TryParseInt(dgvProductList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                Tools.ProductHelper product = new Tools.ProductHelper(SelectedProductID,
                    dgvProductList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Tools.TryParseDouble(dgvProductList.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    Tools.TryParseInt(dgvProductList.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    dgvProductList.Rows[e.RowIndex].Cells[11].Value.ToString(),
                    0);

                frmAddToCart = new AddToCart(product);
                frmAddToCart.Owner = this;
                frmAddToCart.ProductAdded += AddToCart;
                frmAddToCart.ShowDialog();
            }
        }

        private void ConfigureCart(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[3].HeaderText = "PRECIO";
            dgv.Columns[5].HeaderText = "CANTIDAD";
            dgv.Columns[6].HeaderText = "SUBTOTAL";

            dgv.Columns[2].Visible = false;
            dgv.Columns[4].Visible = false;

        }
    }
}
