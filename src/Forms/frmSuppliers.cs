using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Entities.Validation;
using atahualpa_ferresys.Services;
using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class frmSuppliers : Form
    {
        private readonly SupplierService _supplierService = new SupplierService(Tools.API_URL, Tools.JWT_TOKEN);
        private bool SuppliersLoaded = false;
        private string Keyword = "";
        private int SelectedSupplierID = 0;
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            FillSearchTypeCB();
            FillSuppliersList(0);
        }
        private void FillSearchTypeCB()
        {
            cbSearchType.DataSource = Tools.SupplierSearchCriteria;
        }

        private async void FillSuppliersList(int o)
        {
            try
            {
                List<Supplier> suppliers = new List<Supplier>();
                Supplier supplier = new Supplier();
                switch (o)
                {
                    case 0:
                        suppliers = await _supplierService.GetSuppliers();
                        dgvSuppliers.DataSource = suppliers;
                        SuppliersLoaded = true;
                        ConfigureTable(dgvSuppliers);
                        break;
                    case 1: //By ID
                        supplier = await _supplierService.GetSupplierById(Tools.TryParseInt(txtKeyword.Text));
                        dgvSuppliers.DataSource = null;
                        suppliers.Clear();
                        suppliers.Add(supplier);
                        dgvSuppliers.DataSource = suppliers;
                        ConfigureTable(dgvSuppliers);
                        break;
                    case 2: //By RUC
                        supplier = await _supplierService.GetSupplierByRuc(txtKeyword.Text);
                        dgvSuppliers.DataSource = null;
                        suppliers.Clear();
                        suppliers.Add(supplier);
                        dgvSuppliers.DataSource = suppliers;
                        ConfigureTable(dgvSuppliers);
                        break;
                    case 3: //By Name
                        suppliers = await _supplierService.GetSuppliersByName(txtKeyword.Text);
                        dgvSuppliers.DataSource = null;
                        dgvSuppliers.DataSource = suppliers;
                        ConfigureTable(dgvSuppliers);
                        break;
                    case 4: //By Email
                        supplier = await _supplierService.GetSupplierByEmail(txtKeyword.Text);
                        dgvSuppliers.DataSource = null;
                        suppliers.Clear();
                        suppliers.Add(supplier);
                        dgvSuppliers.DataSource = suppliers;
                        ConfigureTable(dgvSuppliers);
                        break;
                    default: goto case 0;
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    MessageBox.Show("Proveedor no encontrado.", "INFORMACIÓN");
                    btnU_Refresh.PerformClick();
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[7].Visible = false;

            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "RUC";
            dgv.Columns[3].HeaderText = "DIRECCIÓN";
            dgv.Columns[4].HeaderText = "TELÉFONO";
            dgv.Columns[5].HeaderText = "E-MAIL";
            dgv.Columns[6].HeaderText = "DESCRIPCIÓN";
            
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 180;
            dgv.Columns[2].Width = 110;
            dgv.Columns[3].Width = 180;
            dgv.Columns[4].Width = 110;
            dgv.Columns[5].Width = 180;
            dgv.Columns[6].Width = 80;
        }

        private void btnU_Refresh_Click(object sender, EventArgs e)
        {
            dgvSuppliers.DataSource = null;
            txtKeyword.Text = "";
            FillSuppliersList(0);
        }

        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchType.SelectedIndex == 0 || cbSearchType.SelectedIndex == 1)
            {
                EnableDigits(sender, e);
            }
        }

        private void txtU_RUC_KeyPress(object sender, KeyPressEventArgs e){ EnableDigits(sender,e); }
        private void txtU_Phone_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }

        private void EnableDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbSearchType_SelectedIndexChanged(object sender, EventArgs e) { txtKeyword.Clear(); }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvSuppliers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSuppliers.CurrentRow.Selected = true;
                SelectedSupplierID = Tools.TryParseInt(dgvSuppliers.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtU_Name.Text = dgvSuppliers.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtU_RUC.Text = dgvSuppliers.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtU_Address.Text = dgvSuppliers.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtU_Phone.Text = dgvSuppliers.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtU_Email.Text = dgvSuppliers.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtU_Desc.Text = dgvSuppliers.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
                chkU_Visible.Checked = (bool)dgvSuppliers.Rows[e.RowIndex].Cells[7].Value;
            }
        }

        private void btnU_Clear_Click(object sender, EventArgs e)
        {
            SelectedSupplierID = 0;
            dgvSuppliers.ClearSelection();
            txtU_Name.Text = "";
            txtU_RUC.Text = "";
            txtU_Address.Text = "";
            txtU_Phone.Text = "";
            txtU_Email.Text = "";
            txtU_Desc.Text = "";
            chkU_Visible.Checked = true;
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnU_Clear.Enabled = false;
            btnDelete.Enabled = false;
            Supplier supplier = new Supplier(
                txtU_Name.Text,
                txtU_RUC.Text,
                txtU_Address.Text,
                txtU_Phone.Text,
                txtU_Email.Text,
                txtU_Desc.Text,
                chkU_Visible.Checked
            );

            SupplierValidator validator = new SupplierValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(supplier);
            if (results.IsValid)
            {
                try
                {
                    var updateSupplier = await _supplierService.UpdateSupplier(supplier, SelectedSupplierID);
                    MessageBox.Show("Proveedor actualizado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnU_Refresh.PerformClick();
                    btnUpdate.Enabled = true;
                    btnU_Clear.Enabled = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnU_Refresh.PerformClick();
                    btnUpdate.Enabled = true;
                    btnU_Clear.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnU_Refresh.PerformClick();
                btnUpdate.Enabled = true;
                btnU_Clear.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"¿Esta seguro de eliminar el siguiente proveedor?\n ID: {SelectedSupplierID.ToString()} \n NOMBRE: {txtU_Name.Text}",
            "CONSULTA",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    var deleteSupplier = await _supplierService.DeleteSupplier(SelectedSupplierID);
                    MessageBox.Show("Proveedor eliminado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnU_Refresh.PerformClick();
                    btnU_Clear.PerformClick();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("404") || ex.Message.Contains("500"))
                    {
                        MessageBox.Show($"Producto de ID: {SelectedSupplierID.ToString()} no encontrado.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnU_Refresh.PerformClick();
                        btnU_Clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btnU_Search_Click(object sender, EventArgs e)
        {
            switch (cbSearchType.SelectedIndex)
            {
                case 0: FillSuppliersList(1); break;
                case 1: FillSuppliersList(2); break;
                case 2: FillSuppliersList(3); break;
                case 3: FillSuppliersList(4); break;
                default: goto case 0;
            }
        }

        private void txtN_RUC_TextChanged(object sender, EventArgs e) {  } //Nothing.
        private void txtN_Phone_TextChanged(object sender, EventArgs e) {  }
        private void txtN_RUC_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtN_Phone_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }

        private void btnN_Clear_Click(object sender, EventArgs e)
        {
            foreach(Control c in gbNewSupplier.Controls)
            {
                if(c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnN_Clear.Enabled = false;
            Supplier supplier = new Supplier(
                txtN_Name.Text,
                txtN_RUC.Text,
                txtN_Address.Text,
                txtN_Phone.Text,
                txtN_Email.Text,
                txtN_Desc.Text,
                true
            );
            if (txtN_Desc.Text.Length <= 3) { supplier.Description = "PROVEEDOR GENERAL"; }
            SupplierValidator validator = new SupplierValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(supplier);
            if (results.IsValid)
            {
                try
                {
                    var createSupplier = await _supplierService.CreateSupplier(supplier);
                    MessageBox.Show("Proveedor creado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = true;
                    btnN_Clear.Enabled = true;
                    btnN_Clear.PerformClick();
                    btnU_Refresh.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnU_Refresh.PerformClick();
                    btnSave.Enabled = true;
                    btnN_Clear.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnSave.Enabled = true;
                btnN_Clear.Enabled = true;
            }
        }
    }
}
