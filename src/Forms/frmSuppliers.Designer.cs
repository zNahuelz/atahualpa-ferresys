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
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnU_Refresh = new System.Windows.Forms.Button();
            this.btnU_Search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnU_Clear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.chkU_Visible = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtU_Desc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtU_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtU_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtU_Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtU_RUC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtU_Name = new System.Windows.Forms.TextBox();
            this.tpAdd = new System.Windows.Forms.TabPage();
            this.gbNewSupplier = new System.Windows.Forms.GroupBox();
            this.btnN_Clear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtN_Desc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtN_Email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtN_Phone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtN_Address = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtN_RUC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtN_Name = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.gbTools.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.tpAdd.SuspendLayout();
            this.gbNewSupplier.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "CRITERIO";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // txtU_Name
            // 
            this.txtU_Name.Location = new System.Drawing.Point(6, 46);
            this.txtU_Name.MaxLength = 150;
            this.txtU_Name.Name = "txtU_Name";
            this.txtU_Name.Size = new System.Drawing.Size(242, 22);
            this.txtU_Name.TabIndex = 0;
            // 
            // tpAdd
            // 
            this.tpAdd.Controls.Add(this.gbNewSupplier);
            this.tpAdd.Location = new System.Drawing.Point(4, 25);
            this.tpAdd.Name = "tpAdd";
            this.tpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tpAdd.Size = new System.Drawing.Size(1185, 704);
            this.tpAdd.TabIndex = 1;
            this.tpAdd.Text = "NUEVO";
            this.tpAdd.UseVisualStyleBackColor = true;
            // 
            // gbNewSupplier
            // 
            this.gbNewSupplier.Controls.Add(this.btnN_Clear);
            this.gbNewSupplier.Controls.Add(this.btnSave);
            this.gbNewSupplier.Controls.Add(this.label9);
            this.gbNewSupplier.Controls.Add(this.txtN_Desc);
            this.gbNewSupplier.Controls.Add(this.label10);
            this.gbNewSupplier.Controls.Add(this.txtN_Email);
            this.gbNewSupplier.Controls.Add(this.label11);
            this.gbNewSupplier.Controls.Add(this.txtN_Phone);
            this.gbNewSupplier.Controls.Add(this.label12);
            this.gbNewSupplier.Controls.Add(this.txtN_Address);
            this.gbNewSupplier.Controls.Add(this.label13);
            this.gbNewSupplier.Controls.Add(this.txtN_RUC);
            this.gbNewSupplier.Controls.Add(this.label14);
            this.gbNewSupplier.Controls.Add(this.txtN_Name);
            this.gbNewSupplier.Location = new System.Drawing.Point(384, 6);
            this.gbNewSupplier.Name = "gbNewSupplier";
            this.gbNewSupplier.Size = new System.Drawing.Size(425, 692);
            this.gbNewSupplier.TabIndex = 1;
            this.gbNewSupplier.TabStop = false;
            // 
            // btnN_Clear
            // 
            this.btnN_Clear.Location = new System.Drawing.Point(97, 482);
            this.btnN_Clear.Name = "btnN_Clear";
            this.btnN_Clear.Size = new System.Drawing.Size(227, 32);
            this.btnN_Clear.TabIndex = 14;
            this.btnN_Clear.Text = "LIMPIAR";
            this.btnN_Clear.UseVisualStyleBackColor = true;
            this.btnN_Clear.Click += new System.EventHandler(this.btnN_Clear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 444);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "DESCRIPCIÓN";
            // 
            // txtN_Desc
            // 
            this.txtN_Desc.Location = new System.Drawing.Point(6, 361);
            this.txtN_Desc.MaxLength = 150;
            this.txtN_Desc.Multiline = true;
            this.txtN_Desc.Name = "txtN_Desc";
            this.txtN_Desc.Size = new System.Drawing.Size(409, 77);
            this.txtN_Desc.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "E-MAIL";
            // 
            // txtN_Email
            // 
            this.txtN_Email.Location = new System.Drawing.Point(6, 311);
            this.txtN_Email.MaxLength = 50;
            this.txtN_Email.Name = "txtN_Email";
            this.txtN_Email.Size = new System.Drawing.Size(409, 22);
            this.txtN_Email.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "TELÉFONO";
            // 
            // txtN_Phone
            // 
            this.txtN_Phone.Location = new System.Drawing.Point(6, 257);
            this.txtN_Phone.MaxLength = 15;
            this.txtN_Phone.Name = "txtN_Phone";
            this.txtN_Phone.Size = new System.Drawing.Size(409, 22);
            this.txtN_Phone.TabIndex = 6;
            this.txtN_Phone.TextChanged += new System.EventHandler(this.txtN_Phone_TextChanged);
            this.txtN_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_Phone_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "DIRECCIÓN";
            // 
            // txtN_Address
            // 
            this.txtN_Address.Location = new System.Drawing.Point(6, 152);
            this.txtN_Address.MaxLength = 100;
            this.txtN_Address.Multiline = true;
            this.txtN_Address.Name = "txtN_Address";
            this.txtN_Address.Size = new System.Drawing.Size(409, 77);
            this.txtN_Address.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "RUC";
            // 
            // txtN_RUC
            // 
            this.txtN_RUC.Location = new System.Drawing.Point(6, 100);
            this.txtN_RUC.MaxLength = 11;
            this.txtN_RUC.Name = "txtN_RUC";
            this.txtN_RUC.Size = new System.Drawing.Size(409, 22);
            this.txtN_RUC.TabIndex = 2;
            this.txtN_RUC.TextChanged += new System.EventHandler(this.txtN_RUC_TextChanged);
            this.txtN_RUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_RUC_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "NOMBRE";
            // 
            // txtN_Name
            // 
            this.txtN_Name.Location = new System.Drawing.Point(6, 46);
            this.txtN_Name.MaxLength = 150;
            this.txtN_Name.Name = "txtN_Name";
            this.txtN_Name.Size = new System.Drawing.Size(409, 22);
            this.txtN_Name.TabIndex = 0;
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar - Proveedores";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.tabMain.ResumeLayout(false);
            this.tpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.tpAdd.ResumeLayout(false);
            this.gbNewSupplier.ResumeLayout(false);
            this.gbNewSupplier.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbNewSupplier;
        private System.Windows.Forms.Button btnN_Clear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtN_Desc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtN_Email;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtN_Phone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtN_Address;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtN_RUC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtN_Name;
    }
}