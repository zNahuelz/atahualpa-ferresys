using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Entities.Validation;
using atahualpa_ferresys.Services;
using atahualpa_ferresys.Utils;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace atahualpa_ferresys.Forms
{
    public partial class frmProducts : Form
    {
        //TODO -> Revisar...
        public string TextoBusqueda = "";
        public int selectedUnitType = 0;
        public int unitTypeToSave = 0;
        public bool unitTypesLoaded = false;
        public bool supplierLoaded = false;
        public bool saveEnabled = true;
        public bool clearEnabled = true;
        private readonly ProductService _productService = new ProductService(Tools.API_URL,Tools.JWT_TOKEN);
        private readonly UnitTypeService _unitTypeService = new UnitTypeService(Tools.API_URL, Tools.JWT_TOKEN);
        private readonly SupplierService _supplierService = new SupplierService(Tools.API_URL, Tools.JWT_TOKEN);
        public frmProducts()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = saveEnabled;
            btnClear.Enabled = clearEnabled;
            FillUnitTypesCb();
            FillSuppliersCb();
            FillProductsTable(0);
            if(dgvProductos.Rows.Count > 0 ) { lblError.Visible = false; }
            cbOpBuscar.DataSource = Tools.ListadoBusquedaProductos;
        }

        private async void FillUnitTypesCb()
        {
            try
            {
                List<UnitType> unitTypes = new List<UnitType>();
                List<UnitType> unitTypesToSave = new List<UnitType>();
                unitTypes = await _unitTypeService.GetUnitTypes();
                unitTypesToSave = unitTypes;
                cbBusquedaAux.DataSource = unitTypes;
                cbBusquedaAux.DisplayMember = "Name";
                cbBusquedaAux.ValueMember = "Id";

                cbUnitType.DataSource = unitTypesToSave;
                cbUnitType.DisplayMember = "Name";
                cbUnitType.ValueMember = "Id";
                unitTypesLoaded = true;
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public async void FillSuppliersCb()
        {
            try
            {
                List<Supplier> suppliers = new List<Supplier>();
                suppliers = await _supplierService.GetSuppliers();
                cbSupplier.DataSource = suppliers;
                cbSupplier.DisplayMember = "Name";
                cbSupplier.ValueMember = "Id";
                supplierLoaded = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
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
                        dgvProductos.DataSource = products;
                        lblError.Visible = false;
                        ConfigureTable(dgvProductos);
                        ManageErrorLabel();
                    break;
                    //Get Products By Name.
                    case 1:
                        products = await _productService.GetProductsByName(TextoBusqueda);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        ManageErrorLabel();
                        break;
                    //Get Products By Description
                    case 2:
                        products = await _productService.GetProductsByDescription(TextoBusqueda);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        ManageErrorLabel();
                        break;
                    //Get Products By Date
                    case 3:
                        break;
                    //Get Products By Unit Type.
                    case 4:
                        products = await _productService.GetProductsByUnitType(selectedUnitType);
                        products.ForEach(p => {
                            p.UnitTypeName = p.UnitType.Name;
                        });
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        ManageErrorLabel();
                        break;
                    //Get Product By Id.
                    case 5:
                        Entities.Product product = new Entities.Product();
                        product = await _productService.GetProductById(Int32.Parse(TextoBusqueda));
                        if(product.Name != "")
                        {
                            products.Add(product);
                        }
                        dgvProductos.DataSource = products;
                        ConfigureTable(dgvProductos);
                        ManageErrorLabel();
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
            dgv.Columns[12].Visible = false;

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
            dgv.Columns[11].HeaderText = "PRESENTACIÓN";
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
            cbBusquedaAux.SelectedIndex = 0;
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

        private void cbBusquedaAux_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(unitTypesLoaded)
            {
                selectedUnitType = Int32.Parse(cbBusquedaAux.SelectedValue.ToString());
                FillProductsTable(4);
            }
        }

        private void ManageErrorLabel()
        {
            if (dgvProductos.Rows.Count >= 1)
            {
                lblError.Visible = false;
            }
            else { lblError.Visible = true; }
        }

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            saveEnabled = false;
            clearEnabled = false;
            Entities.Product product = new Entities.Product(txtPName.Text,
                txtPDesc.Text,
                Tools.TryParseDouble(txtBuyPrice.Text),
                Tools.TryParseDouble(txtSellPrice.Text),
                Tools.TryParseInt(txtStock.Text),
                cbVisible.Checked,
                Tools.TryParseInt(cbSupplier.SelectedValue.ToString()),
                Tools.TryParseInt(cbUnitType.SelectedValue.ToString()));

            ProductValidator validator = new ProductValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(product);
            if(results.IsValid)
            {
                try
                {
                    var createProduct = await _productService.CreateProduct(product);
                    MessageBox.Show(createProduct.ToString());
                  
                }
                catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
            }
            else
            {
                MessageBox.Show(results.ToString(),"ALERTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void txtBuyPrice_KeyPress(object sender, KeyPressEventArgs e) { EnableDecimals(sender, e); }


        private void txtSellPrice_KeyPress(object sender, KeyPressEventArgs e) { EnableDecimals(sender, e); }


        private void txtStock_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }


        private void EnableDecimals(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void EnableDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbUnitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (unitTypesLoaded)
            {
                unitTypeToSave = Int32.Parse(cbUnitType.SelectedValue.ToString());
            }
        }

        private void tcProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tcProductos.SelectedIndex.Equals(0))
            {
                btnResetear.PerformClick();
            }
        }
    }
}
