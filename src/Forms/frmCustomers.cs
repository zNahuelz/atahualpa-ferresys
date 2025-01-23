using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Entities.Validation;
using atahualpa_ferresys.Model;
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
    public partial class frmCustomers : Form
    {
        private string Keyword = "";
        private int SelectedCustomerID = 0;
        private bool CustomersLoaded = false;
        private readonly CustomerService _customerService = new CustomerService(Tools.API_URL, Tools.JWT_TOKEN);

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            FillSearchCriteria();
            FillCustomers(0);
        }

        private async void FillCustomers(int o)
        {
            try
            {
                List<Customer> customers = new List<Customer>();
                Customer customer = new Customer();
                switch (o)
                {
                    case 0:
                        customers = await _customerService.GetCustomers();
                        dgvCustomers.DataSource = customers;
                        CustomersLoaded = true;
                        ConfigureTable(dgvCustomers);
                        break;
                    case 1: //By DNI
                        customers.Clear();
                        customer = await _customerService.GetCustomerByDni(Keyword);
                        if (customer.Name != "")
                        {
                            customers.Add(customer);
                        }
                        dgvCustomers.DataSource = customers;
                        ConfigureTable(dgvCustomers);
                        break;
                    case 2: //By ID
                        customers.Clear();
                        customer = await _customerService.GetCustomerById(Tools.TryParseInt(Keyword));
                        if (customer.Name != "")
                        {
                            customers.Add(customer);
                        }
                        dgvCustomers.DataSource = customers;
                        ConfigureTable(dgvCustomers);
                        break;
                    default: goto case 0;
                }
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("404"))
                {
                    MessageBox.Show("Ups! Cliente no encontrado. Vuelva a intentarlo.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            cbSearchType.DataSource = Tools.CustomerSearchCriteria;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnN_Clear.Enabled = false;
            Customer customer = new Customer(
                txtN_Name.Text,
                txtN_Surname.Text,
                txtN_DNI.Text,
                txtN_Address.Text,
                txtN_Phone.Text,
                txtN_Email.Text
            );

            CustomerValidator validator = new CustomerValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(customer);
            if (results.IsValid)
            {
                try
                {
                    var newCustomer = await _customerService.CreateCustomer(customer);
                    if (newCustomer.Content.ReadAsStringAsync().Result.ToString().Contains("The dni has already been taken"))
                    {
                        MessageBox.Show("Error! El DNI ingresado ya pertenece a un cliente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRefresh.PerformClick();
                        btnSave.Enabled = true;
                        btnN_Clear.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente guardado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnN_Clear.PerformClick();
                        btnRefresh.PerformClick();
                        btnSave.Enabled = true;
                        btnN_Clear.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnN_Clear.PerformClick();
                    btnRefresh.PerformClick();
                    btnSave.Enabled = true;
                    btnN_Clear.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRefresh.PerformClick();
                btnSave.Enabled = true;
                btnN_Clear.Enabled = true;
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnU_Clear.Enabled = false;
            btnDelete.Enabled = false;
            Customer customer = new Customer(
                txtU_Name.Text,
                txtU_Surname.Text,
                txtU_DNI.Text,
                txtU_Address.Text,
                txtU_Phone.Text,
                txtU_Email.Text
            );

            CustomerValidator validator = new CustomerValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(customer);
            if (results.IsValid)
            {
                try
                {
                    var updateCustomer = await _customerService.UpdateCustomer(customer, SelectedCustomerID);
                    if (updateCustomer.Content.ReadAsStringAsync().Result.ToString().Contains("dni"))
                    {
                        MessageBox.Show("Ups! El DNI ingresado ya pertenece a un cliente.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRefresh.PerformClick();
                        btnUpdate.Enabled = true;
                        btnU_Clear.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cliente actualizado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRefresh.PerformClick();
                        btnUpdate.Enabled = true;
                        btnU_Clear.Enabled = true;
                        btnDelete.Enabled = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRefresh.PerformClick();
                    btnUpdate.Enabled = true;
                    btnU_Clear.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRefresh.PerformClick();
                btnUpdate.Enabled = true;
                btnU_Clear.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"¿Esta seguro de eliminar el siguiente cliente?\n ID: {SelectedCustomerID.ToString()} \n NOMBRE: {txtU_Name.Text}",
            "CONSULTA",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                try
                {
                    var deleteProduct = await _customerService.DeleteCustomer(SelectedCustomerID);
                    MessageBox.Show("Cliente eliminado con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRefresh.PerformClick();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("404") || ex.Message.Contains("500"))
                    {
                        MessageBox.Show($"Cliente de ID: {SelectedCustomerID.ToString()} no encontrado.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnRefresh.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = null;
            FillCustomers(0);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Keyword = txtKeyword.Text;
            switch (cbSearchType.SelectedIndex)
            {
                case 0:
                    FillCustomers(1);
                    txtKeyword.Clear();
                    break;
                case 1:
                    FillCustomers(2);
                    txtKeyword.Clear();
                    break;
                default: goto case 0;
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvCustomers.CurrentRow.Selected = true;
                SelectedCustomerID = Tools.TryParseInt(dgvCustomers.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtU_Name.Text = dgvCustomers.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtU_Surname.Text = dgvCustomers.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtU_DNI.Text = dgvCustomers.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtU_Address.Text = dgvCustomers.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtU_Phone.Text = dgvCustomers.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
                txtU_Email.Text = dgvCustomers.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            }
        }

        private void btnU_Clear_Click(object sender, EventArgs e)
        {
            dgvCustomers.ClearSelection();
            SelectedCustomerID = 0;
            foreach (Control c in tpEdit.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }
        private void btnN_Clear_Click(object sender, EventArgs e)
        {
            foreach (Control c in tpNew.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Text = "";
                }
            }
        }

        private void txtU_DNI_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtU_Phone_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtN_DNI_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtN_Phone_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void txtKeyword_KeyPress(object sender, KeyPressEventArgs e) { EnableDigits(sender, e); }
        private void EnableDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "APELLIDO";
            dgv.Columns[3].HeaderText = "DNI";
            dgv.Columns[4].HeaderText = "DIRECCIÓN";
            dgv.Columns[5].HeaderText = "TELÉFONO";
            dgv.Columns[6].HeaderText = "E-MAIL";

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 120;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 120;
            dgv.Columns[5].Width = 120;
            dgv.Columns[6].Width = 200;
        }

    }
}
