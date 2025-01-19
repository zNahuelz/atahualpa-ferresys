namespace atahualpa_ferresys.Forms
{
    partial class frmSuppliers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpList = new System.Windows.Forms.TabPage();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.txtU_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtU_RUC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtU_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtU_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtU_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtU_Desc = new System.Windows.Forms.TextBox();
            this.chkU_Visible = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnU_Clear = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnU_Search = new System.Windows.Forms.Button();
            this.btnU_Refresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tpList.SuspendLayout();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpList);
            this.tabMain.Controls.Add(this.tpAdd);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1193, 733);
            this.tabMain.TabIndex = 0;
            // 
            // tpList
            // 
            this.tpList.Controls.Add(this.dgvSuppliers);
            this.tpList.Controls.Add(this.gbTools);
            this.tpList.Location = new System.Drawing.Point(4, 25);
            this.tpList.Name = "tpList";
            this.tpList.Padding = new System.Windows.Forms.Padding(3);
            this.tpList.Size = new System.Drawing.Size(1185, 704);
            this.tpList.TabIndex = 0;
            this.tpList.Text = "LISTADO";
            this.tpList.UseVisualStyleBackColor = true;
            // 
            // tpAdd
            // 
            this.tpAdd.Location = new System.Drawing.Point(4, 25);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(1185, 704);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "NUEVO";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.btnDelete);
            this.gbTools.Controls.Add(this.gbSearch);
            this.gbTools.Controls.Add(this.btnU_Clear);
            this.gbTools.Controls.Add(this.btnUpdate);
            this.gbTools.Controls.Add(this.chkU_Visible);
            this.gbTools.Controls.Add(this.label6);
            this.gbTools.Controls.Add(this.txtU_Desc);
            this.gbTools.Controls.Add(this.label5);
            this.gbTools.Controls.Add(this.txtU_Email);
            this.gbTools.Controls.Add(this.label4);
            this.gbTools.Controls.Add(this.txtU_Phone);
            this.gbTools.Controls.Add(this.label3);
            this.gbTools.Controls.Add(this.txtU_Address);
            this.gbTools.Controls.Add(this.label2);
            this.gbTools.Controls.Add(this.txtU_RUC);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Controls.Add(this.txtU_Name);
            this.gbTools.Location = new System.Drawing.Point(925, 6);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(254, 692);
            this.gbTools.TabIndex = 0;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "HERRAMIENTAS";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.GridColor = System.Drawing.Color.HotPink;
            this.dgvSuppliers.Location = new System.Drawing.Point(6, 6);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.Size = new System.Drawing.Size(913, 692);
            this.dgvSuppliers.TabIndex = 2;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuppliers_CellClick);
            // 
            // txtU_Name
            // 
            this.txtU_Name.Location = new System.Drawing.Point(6, 46);
            this.txtU_Name.MaxLength = 150;
            this.txtU_Name.Name = "txtU_Name";
            this.txtU_Name.Size = new System.Drawing.Size(242, 22);
            this.txtU_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "RUC";
            // 
            // txtU_RUC
            // 
            this.txtU_RUC.Location = new System.Drawing.Point(6, 100);
            this.txtU_RUC.MaxLength = 11;
            this.txtU_RUC.Name = "txtU_RUC";
            this.txtU_RUC.Size = new System.Drawing.Size(242, 22);
            this.txtU_RUC.TabIndex = 2;
            this.txtU_RUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_RUC_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "DIRECCIÓN";
            // 
            // txtU_Address
            // 
            this.txtU_Address.Location = new System.Drawing.Point(6, 152);
            this.txtU_Address.MaxLength = 100;
            this.txtU_Address.Multiline = true;
            this.txtU_Address.Name = "txtU_Address";
            this.txtU_Address.Size = new System.Drawing.Size(242, 77);
            this.txtU_Address.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "TELÉFONO";
            // 
            // txtU_Phone
            // 
            this.txtU_Phone.Location = new System.Drawing.Point(6, 257);
            this.txtU_Phone.MaxLength = 15;
            this.txtU_Phone.Name = "txtU_Phone";
            this.txtU_Phone.Size = new System.Drawing.Size(242, 22);
            this.txtU_Phone.TabIndex = 6;
            this.txtU_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_Phone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-MAIL";
            // 
            // txtU_Email
            // 
            this.txtU_Email.Location = new System.Drawing.Point(6, 311);
            this.txtU_Email.MaxLength = 50;
            this.txtU_Email.Name = "txtU_Email";
            this.txtU_Email.Size = new System.Drawing.Size(242, 22);
            this.txtU_Email.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "DESCRIPCIÓN";
            // 
            // txtU_Desc
            // 
            this.txtU_Desc.Location = new System.Drawing.Point(6, 361);
            this.txtU_Desc.MaxLength = 150;
            this.txtU_Desc.Multiline = true;
            this.txtU_Desc.Name = "txtU_Desc";
            this.txtU_Desc.Size = new System.Drawing.Size(242, 77);
            this.txtU_Desc.TabIndex = 10;
            // 
            // chkU_Visible
            // 
            this.chkU_Visible.AutoSize = true;
            this.chkU_Visible.Checked = true;
            this.chkU_Visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkU_Visible.Location = new System.Drawing.Point(9, 444);
            this.chkU_Visible.Name = "chkU_Visible";
            this.chkU_Visible.Size = new System.Drawing.Size(82, 20);
            this.chkU_Visible.TabIndex = 12;
            this.chkU_Visible.Text = "VISIBLE";
            this.chkU_Visible.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 22);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnU_Clear
            // 
            this.btnU_Clear.Location = new System.Drawing.Point(6, 498);
            this.btnU_Clear.Name = "btnU_Clear";
            this.btnU_Clear.Size = new System.Drawing.Size(242, 22);
            this.btnU_Clear.TabIndex = 14;
            this.btnU_Clear.Text = "LIMPIAR";
            this.btnU_Clear.UseVisualStyleBackColor = true;
            this.btnU_Clear.Click += new System.EventHandler(this.btnU_Clear_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnU_Refresh);
            this.gbSearch.Controls.Add(this.btnU_Search);
            this.gbSearch.Controls.Add(this.label7);
            this.gbSearch.Controls.Add(this.txtKeyword);
            this.gbSearch.Controls.Add(this.cbSearchType);
            this.gbSearch.Location = new System.Drawing.Point(6, 526);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(242, 160);
            this.gbSearch.TabIndex = 15;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "BUSQUEDA";
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(6, 21);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(230, 24);
            this.cbSearchType.TabIndex = 0;
            this.cbSearchType.SelectedIndexChanged += new System.EventHandler(this.cbSearchType_SelectedIndexChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(6, 79);
            this.txtKeyword.MaxLength = 150;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(230, 22);
            this.txtKeyword.TabIndex = 16;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "CRITERIO";
            // 
            // btnU_Search
            // 
            this.btnU_Search.Location = new System.Drawing.Point(6, 107);
            this.btnU_Search.Name = "btnU_Search";
            this.btnU_Search.Size = new System.Drawing.Size(230, 22);
            this.btnU_Search.TabIndex = 16;
            this.btnU_Search.Text = "BUSCAR";
            this.btnU_Search.UseVisualStyleBackColor = true;
            this.btnU_Search.Click += new System.EventHandler(this.btnU_Search_Click);
            // 
            // btnU_Refresh
            // 
            this.btnU_Refresh.Location = new System.Drawing.Point(6, 132);
            this.btnU_Refresh.Name = "btnU_Refresh";
            this.btnU_Refresh.Size = new System.Drawing.Size(230, 22);
            this.btnU_Refresh.TabIndex = 17;
            this.btnU_Refresh.Text = "REFRESCAR";
            this.btnU_Refresh.UseVisualStyleBackColor = true;
            this.btnU_Refresh.Click += new System.EventHandler(this.btnU_Refresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::atahualpa_ferresys.Properties.Resources._3592821_garbage_can_general_office_recycle_bin_rubbish_bin_trash_bin_trash_can_107760__2_;
            this.btnDelete.Location = new System.Drawing.Point(163, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 48);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 757);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar - Proveedores";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.tabMain.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpList;
        private System.Windows.Forms.TabPage tpAdd;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtU_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtU_RUC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtU_Address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtU_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtU_Phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtU_Desc;
        private System.Windows.Forms.CheckBox chkU_Visible;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnU_Clear;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnU_Refresh;
        private System.Windows.Forms.Button btnU_Search;
        private System.Windows.Forms.Button btnDelete;
    }
}