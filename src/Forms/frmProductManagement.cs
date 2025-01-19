using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Entities.Validation;
using atahualpa_ferresys.Services;
using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class frmProductManagement : Form
    {
        private readonly ProductService _productService = new ProductService(Tools.API_URL, Tools.JWT_TOKEN);
        private readonly UnitTypeService _unitTypeService = new UnitTypeService(Tools.API_URL, Tools.JWT_TOKEN);
        private readonly SupplierService _supplierService = new SupplierService(Tools.API_URL, Tools.JWT_TOKEN);
        private bool UnitTypesLoaded = false;
        private bool ProductsLoaded = false;
        private bool SuppliersLoaded = false;
        private int SelectedProductID = 0;

        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            FillProductsTable(0);
            FillUnitTypes();
            FillSuppliers();
        }

        private async void FillProductsTable(int o)
        {
            try
            {
                List<Entities.Product> products = new List<Entities.Product>();
                switch (o)
                {
                    case 0:
                        
                        products = await _productService.GetProducts();
                        products.ForEach(p =>
                        {
                            p.UnitTypeName = p.UnitType.Name;
                            p.UnitTypeId = p.UnitType.Id;
                        });
                        dgvProducts.DataSource = products;
                        ConfigureTable(dgvProducts);

                        ProductsLoaded = true;
                        break;
                    case 1:
                        products.Clear();
                        Entities.Product product = new Entities.Product();
                        product = await _productService.GetProductById(Tools.TryParseInt(txtSearchID.Text));
                        if (product.Name != "")
                        {
                            products.Add(product);
                        }
                        dgvProducts.DataSource = products;
                        ConfigureTable(dgvProducts);
                        break;
                    default: goto case 0;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    MessageBox.Show($"Producto de ID: {txtSearchID.Text} no encontrado.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRefreshProducts.PerformClick();
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

                cbU_UnitType.DataSource = new List<UnitType>(unitTypes);
                cbN_UnitType.DataSource = new List<UnitType>(unitTypes);
                cbU_UnitType.DisplayMember = "Name";
                cbN_UnitType.DisplayMember = "Name";
                cbU_UnitType.ValueMember = "Id";
                cbN_UnitType.ValueMember = "Id";

                UnitTypesLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void FillSuppliers()
        {
            try
            {
                List<Supplier> suppliers = new List<Supplier>();
                suppliers = await _supplierService.GetSuppliers();

                cbU_Supplier.DataSource = new List<Supplier>(suppliers);
                cbN_Supplier.DataSource = new List<Supplier>(suppliers);

                cbU_Supplier.DisplayMember = "Name";
                cbN_Supplier.DisplayMember = "Name";
                cbU_Supplier.ValueMember = "Id";
                cbN_Supplier.ValueMember= "Id";

                SuppliersLoaded = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void btnSaveProduct_Click(object sender, EventArgs e)
        {
            btnSaveProduct.Enabled = false;
            btnClearSvF.Enabled = false;
            Entities.Product product = new Entities.Product(txtN_Name.Text,
                txtN_Desc.Text,
                Tools.TryParseDouble(txtN_BuyPrice.Text),
                Tools.TryParseDouble(txtN_SellPrice.Text),
                Tools.TryParseInt(txtN_Stock.Text),
                cbN_Visible.Checked,
                Tools.TryParseInt(cbN_Supplier.SelectedValue.ToString()),
                Tools.TryParseInt(cbN_UnitType.SelectedValue.ToString()));

            ProductValidator validator = new ProductValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(product);
            if (results.IsValid)
            {
                try
                {
                    var createProduct = await _productService.CreateProduct(product);
                    MessageBox.Show("Producto creado con éxito.","INFORMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnSaveProduct.Enabled = true;
                    btnClearSvF.Enabled = true;
                    btnRefreshProducts.PerformClick();
                    btnClearSvF.PerformClick();
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}","ALERTA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    btnRefreshProducts.PerformClick();
                    btnSaveProduct.Enabled = true;
                    btnClearSvF.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRefreshProducts.PerformClick();
                btnSaveProduct.Enabled = true;
                btnClearSvF.Enabled = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnClearUpF.Enabled = false;
            btnDelete.Enabled = false;
            Entities.Product product = new Entities.Product(txtU_Name.Text,
                txtU_Desc.Text,
                Tools.TryParseDouble(txtU_BuyPrice.Text),
                Tools.TryParseDouble(txtU_SellPrice.Text),
                Tools.TryParseInt(txtU_Stock.Text),
                cbU_Visible.Checked,
                Tools.TryParseInt(cbU_Supplier.SelectedValue.ToString()),
                Tools.TryParseInt(cbU_UnitType.SelectedValue.ToString()));

            ProductValidator validator = new ProductValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(product);
            if (results.IsValid)
            {
                try
                {
                    var updateProduct = await _productService.UpdateProduct(product, SelectedProductID);
                    MessageBox.Show("Producto actualizado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefreshProducts.PerformClick();
                    btnUpdate.Enabled = true;
                    btnClearUpF.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRefreshProducts.PerformClick();
                    btnUpdate.Enabled = true;
                    btnClearUpF.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRefreshProducts.PerformClick();
                btnUpdate.Enabled = true;
                btnClearUpF.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                $"¿Esta seguro de eliminar el siguiente producto?\n ID: {SelectedProductID.ToString()} \n NOMBRE: {txtU_Name.Text}",
                "CONSULTA",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    var deleteProduct = await _productService.DeleteProduct(SelectedProductID);
                    MessageBox.Show("Producto eliminado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefreshProducts.PerformClick();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("404") || ex.Message.Contains("500"))
                    {
                        MessageBox.Show($"Producto de ID: {SelectedProductID.ToString()} no encontrado.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnRefreshProducts.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
            txtSearchID.Text = "";
            FillProductsTable(0);
            dgvProducts.ClearSelection();
        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvProducts.CurrentRow.Selected = true;
                SelectedProductID = Tools.TryParseInt(dgvProducts.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtU_Name.Text = dgvProducts.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtU_Desc.Text = dgvProducts.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtU_BuyPrice.Text = Tools.TryParseDouble(dgvProducts.Rows[e.RowIndex].Cells[3].FormattedValue.ToString()).ToString();
                txtU_SellPrice.Text = Tools.TryParseDouble(dgvProducts.Rows[e.RowIndex].Cells[4].FormattedValue.ToString()).ToString();
                txtU_Stock.Text = Tools.TryParseInt(dgvProducts.Rows[e.RowIndex].Cells[5].FormattedValue.ToString()).ToString();
                cbU_Visible.Checked = (bool)dgvProducts.Rows[e.RowIndex].Cells[6].Value;
                cbU_UnitType.SelectedValue = Tools.TryParseInt(dgvProducts.Rows[e.RowIndex].Cells[12].FormattedValue.ToString());
                cbU_Supplier.SelectedValue = Tools.TryParseInt(dgvProducts.Rows[e.RowIndex].Cells[7].FormattedValue.ToString());
            }
        }

        private void ClearUpdateForm()
        {
            txtU_Name.Text = "";
            txtU_Desc.Text = "";
            txtU_BuyPrice.Text = "0.00";
            txtU_SellPrice.Text = "0.00";
            txtU_Stock.Text = "0";
            cbU_Visible.Checked = true;
            cbU_UnitType.SelectedIndex = 0;    
            cbU_Supplier.SelectedIndex = 0;
            dgvProducts.ClearSelection();
        }

        private void ClearNewForm()
        {
            txtN_Name.Text = "";
            txtN_Desc.Text = "";
            txtN_BuyPrice.Text = "0.00";
            txtN_SellPrice.Text = "0.00";
            txtN_Stock.Text = "0";
            cbN_Visible.Checked = true;
            cbN_UnitType.SelectedIndex = 0;
            cbN_Supplier.SelectedIndex = 0;
            dgvProducts.ClearSelection();
        }


        private void btnClearUpF_Click(object sender, EventArgs e)
        {
            ClearUpdateForm();
        }

        private void btnClearSvF_Click(object sender, EventArgs e)
        {
            ClearNewForm();
        }

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            FillProductsTable(1);
        }

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

        private void txtU_BuyPrice_KeyPress(object sender, KeyPressEventArgs e) { EnableDecimals(sender, e); }
        private void txtU_SellPrice_KeyPress(object sender, KeyPressEventArgs e) { EnableDecimals(sender, e); }
        private void txtN_BuyPrice_KeyPress(object sender, KeyPressEventArgs e) { EnableDecimals(sender, e); }
        private void txtN_SellPrice_KeyPress(object sender, KeyPressEventArgs e) { EnableDecimals(sender, e); }
        private void txtU_Stock_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtN_Stock_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtSearchID_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }

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
        private void lblStock_Click(object sender, EventArgs e) { } //Nothing.
        private void txtN_BuyPrice_TextChanged(object sender, EventArgs e) { } //Nothing lol
    }
}
