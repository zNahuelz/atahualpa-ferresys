using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Services;
using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms.Product
{
    public partial class frmProductList : Form
    {
        private string Keyword = "";
        private int SelectedUnitType = 0;
        private bool UnitTypesLoaded = false;
        private readonly ProductService _productService = new ProductService(Tools.API_URL, Tools.JWT_TOKEN);
        private readonly UnitTypeService _unitTypeService = new UnitTypeService(Tools.API_URL, Tools.JWT_TOKEN);
        private readonly SupplierService _supplierService = new SupplierService(Tools.API_URL, Tools.JWT_TOKEN);

        public frmProductList()
        {
            InitializeComponent();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            ManageLabel("Cargando productos...");
            FillSearchMode();
            FillUnitTypes();
            FillProductsTable(0);
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
                        dgvProducts.DataSource = products;
                        ConfigureTable(dgvProducts);
                        ManageLabel("Ups! Conexión fallida, vuelva a intentarlo.");
                        break;
                    //Get Products By Name.
                    case 1:
                        products = await _productService.GetProductsByName(Keyword);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProducts.DataSource = products;
                        ConfigureTable(dgvProducts);
                        ManageLabel("Ups! No se encontraron coincidencias con el nombre ingresado.");
                        break;
                    //Get Products By Description
                    case 2:
                        products = await _productService.GetProductsByDescription(Keyword);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProducts.DataSource = products;
                        ConfigureTable(dgvProducts);
                        ManageLabel("Ups! No se encontraron coincidencias con la descripción ingresada.");
                        break;
                    //Get Products By Date
                    case 3:
                        break;
                    //Get Products By Unit Type.
                    case 4:
                        products = await _productService.GetProductsByUnitType(SelectedUnitType);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProducts.DataSource = products;
                        ManageLabel("Ups! No se encontraron productos con la presentación seleccionada.");
                        break;
                    //Get Product By Id.
                    case 5:
                        Entities.Product product = new Entities.Product();
                        product = await _productService.GetProductById(Tools.TryParseInt(Keyword)); //TODO: Cambiar por TryParse.
                        if (product.Name != "")
                        {
                            products.Add(product);
                        }
                        dgvProducts.DataSource = products;
                        ConfigureTable(dgvProducts);
                        ManageLabel($"Ups! Producto de ID: {Keyword} no encontrado.");
                        break;
                    default:
                        goto case 0;

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    ManageLabel($"Ups! Producto no encontrado. Vuelva a intentarlo.");
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                
            }
        }

        private async void FillUnitTypes()
        {
            try
            {
                List<UnitType> unitTypes = new List<UnitType>();
                unitTypes = await _unitTypeService.GetUnitTypes();

                cbUnitType.DataSource = unitTypes;
                cbUnitType.DisplayMember = "Name";
                cbUnitType.ValueMember = "Id";

                UnitTypesLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void FillSearchMode()
        {
            cbSearchType.DataSource = Tools.ProductSearchCriteria;
        }

        private void cbSearchT_IndexChanged(object sender, EventArgs e)
        {
            switch (cbSearchType.SelectedIndex)
            {
                case 0: //By Name
                    txtKeyword.Enabled = true;
                    cbUnitType.Enabled = false;
                    dtpDate.Enabled = false;
                    break;
                case 1: //By Description
                    goto case 0;
                case 2: //By Id
                    goto case 0;
                case 3: //By presentation
                    txtKeyword.Enabled = false;
                    cbUnitType.Enabled = true;
                    dtpDate.Enabled = false;
                    break;
                case 4: //By date
                    txtKeyword.Enabled = false;
                    cbUnitType.Enabled = false;
                    dtpDate.Enabled = true;
                    break;
                default: goto case 0;

            }
        }

        private void txtKeyw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchType.SelectedIndex == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
            }
        }

        private void cbUnitT_IndexChanged(object sender, EventArgs e)
        {
            if (UnitTypesLoaded)
            {
                SelectedUnitType = Int32.Parse(cbUnitType.SelectedValue.ToString());
                FillProductsTable(4);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbSearchType.SelectedIndex)
            {
                case 0:
                    Keyword = txtKeyword.Text.Trim();
                    if (Keyword == "") { btnReset.PerformClick(); }
                    else
                    {
                        dgvProducts.DataSource = null;
                        FillProductsTable(1);
                    }
                    break;
                case 1:
                    Keyword = txtKeyword.Text.Trim();
                    if (Keyword == "") { btnReset.PerformClick(); }
                    else
                    {
                        dgvProducts.DataSource = null;
                        FillProductsTable(2);
                    }
                    break;
                case 2:
                     dgvProducts.DataSource = null;
                     Keyword = txtKeyword.Text.Trim();
                     if (Keyword.Length >= 1)
                     {
                        FillProductsTable(5);
                     }
                    break;
                case 3: break; //Nothing
                case 4: break; //By date.
                default: goto case 0;

            }
        }
        private void btnReset_Click(object sender, EventArgs e) //TODO: Filtra automaticamente por presentacion.
        {
            dgvProducts.DataSource = null;
            FillProductsTable(0);

            txtKeyword.Text = "";
            cbUnitType.SelectedIndex = 0;
            cbSearchType.SelectedIndex = 0;

        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[12].Visible = false;

            dgv.Columns[0].Width = 30;
            dgv.Columns[1].Width = 350;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 90;
            dgv.Columns[4].Width = 90;
            dgv.Columns[5].Width = 70;
            dgv.Columns[7].Width = 135;
            dgv.Columns[9].Width = 150;
            dgv.Columns[11].Width = 120;

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "DESCRIPCIÓN";
            dgv.Columns[3].HeaderText = "PRECIO COMPRA";
            dgv.Columns[4].HeaderText = "PRECIO VENTA";
            dgv.Columns[5].HeaderText = "STOCK";
            dgv.Columns[7].HeaderText = "PROVEEDOR";
            dgv.Columns[9].HeaderText = "FECHA INGRESO";
            dgv.Columns[11].HeaderText = "PRESENTACIÓN";
        }

        private void ManageLabel(string str)
        {
            lblMessage.Text = str;
            if (dgvProducts.Rows.Count <= 0)
            {
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Visible = false;
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts.CurrentRow.Selected = true;
        }
    }
}
