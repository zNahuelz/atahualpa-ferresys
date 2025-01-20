using atahualpa_ferresys.Entities;
using atahualpa_ferresys.Entities.Validation;
using atahualpa_ferresys.Services;
using atahualpa_ferresys.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace atahualpa_ferresys.Forms
{
    public partial class frmUnitType : Form
    {
        private readonly UnitTypeService _unitTypeService = new UnitTypeService(Tools.API_URL, Tools.JWT_TOKEN);
        private int SelectedUnitTypeID = 0;
        public frmUnitType()
        {
            InitializeComponent();
        }

        private void frmUnitType_Load(object sender, EventArgs e)
        {
            FillUnitTypes(0);
        }

        private async void FillUnitTypes(int o)
        {
            try
            {
                List<UnitType> unitTypes = new List<UnitType>();
                UnitType unitType = new UnitType();
                switch (o)
                {
                    case 0:
                        unitTypes = await _unitTypeService.GetUnitTypes();
                        dgvUnitTypes.DataSource = unitTypes;
                        ConfigureTable(dgvUnitTypes);
                        break;
                    case 1:
                        unitTypes = await _unitTypeService.GetUnitTypesByName(txtKeyword.Text);
                        dgvUnitTypes.DataSource = unitTypes;
                        ConfigureTable(dgvUnitTypes);
                        break;
                    case 2:
                        unitType = await _unitTypeService.GetUnitTypeById(Tools.TryParseInt(txtKeyword.Text));
                        unitTypes.Clear();
                        unitTypes.Add(unitType);
                        dgvUnitTypes.DataSource = unitTypes;
                        ConfigureTable(dgvUnitTypes);
                        break;
                    default: goto case 0;
                }
            }
            catch (Exception ex) 
            {
                if (ex.Message.Contains("404"))
                {
                    MessageBox.Show("Presentación no encontrada.","ADVERTENCIA",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnRefresh.PerformClick();
                }
                else
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    btnRefresh.PerformClick();
                }
            }
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnN_Clear.Enabled = false;
            UnitType unitType = new UnitType(txtN_Name.Text);

            UnitTypeValidator validator = new UnitTypeValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(unitType);
            if (results.IsValid)
            {
                try
                {
                    var createProduct = await _unitTypeService.CreateUnitType(unitType);
                    MessageBox.Show("Presentación creada con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = true;
                    btnN_Clear.Enabled = true;
                    btnRefresh.PerformClick();
                    btnN_Clear.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            UnitType unitType = new UnitType(txtU_Name.Text);

            UnitTypeValidator validator = new UnitTypeValidator();
            FluentValidation.Results.ValidationResult results = validator.Validate(unitType);
            if (results.IsValid)
            {
                try
                {
                    var createProduct = await _unitTypeService.UpdateUnitType(unitType, SelectedUnitTypeID);
                    MessageBox.Show($"Presentación de ID: {SelectedUnitTypeID} actualizada con éxito.", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnUpdate.Enabled = true;
                    btnU_Clear.Enabled = true;
                    btnRefresh.PerformClick();
                    btnU_Clear.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error interno del servidor, favor comunicarse con administración: {ex.Message}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnRefresh.PerformClick();
                    btnUpdate.Enabled = true;
                    btnU_Clear.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show($"Error! Debe llenar el formulario correctamente:\n {results.ToString()}", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btnRefresh.PerformClick();
                btnUpdate.Enabled = true;
                btnU_Clear.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Tools.IsNumeric(txtKeyword.Text))
            {
                FillUnitTypes(2);
            }
            else
            {
                FillUnitTypes(1);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtKeyword.Clear();
            FillUnitTypes(0);
        }



        private void btnU_Clear_Click(object sender, EventArgs e)
        {
            dgvUnitTypes.ClearSelection();
            txtU_Name.Text = "";
            SelectedUnitTypeID = 0;
        }

        private void btnN_Clear_Click(object sender, EventArgs e) { txtN_Name.Text = ""; }

        private void dgvUnitTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1 && dgvUnitTypes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvUnitTypes.CurrentRow.Selected = true;
                SelectedUnitTypeID = Tools.TryParseInt(dgvUnitTypes.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                txtU_Name.Text = dgvUnitTypes.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            }
        }

        private void ConfigureTable(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "ID";
            dgv.Columns[1].HeaderText = "NOMBRE";
            dgv.Columns[2].HeaderText = "CREADO";
            dgv.Columns[3].HeaderText = "ACTUALIZADO";


            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 240;
            dgv.Columns[2].Width = 150;
            dgv.Columns[3].Width = 150;
        }

    }
}
