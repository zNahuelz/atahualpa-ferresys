namespace atahualpa_ferresys.Forms
{
    partial class frmCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEdit = new System.Windows.Forms.TabPage();
            this.tpNew = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtU_Name = new System.Windows.Forms.TextBox();
            this.txtU_Surname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtU_DNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtU_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtU_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtU_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnU_Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnN_Clear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtN_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtN_Phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtN_Address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtN_DNI = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtN_Surname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtN_Name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbTools.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpEdit.SuspendLayout();
            this.tpNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.GridColor = System.Drawing.Color.HotPink;
            this.dgvCustomers.Location = new System.Drawing.Point(12, 132);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(708, 613);
            this.dgvCustomers.TabIndex = 2;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.btnRefresh);
            this.gbTools.Controls.Add(this.btnSearch);
            this.gbTools.Controls.Add(this.txtKeyword);
            this.gbTools.Controls.Add(this.label8);
            this.gbTools.Controls.Add(this.cbSearchType);
            this.gbTools.Controls.Add(this.label7);
            this.gbTools.Location = new System.Drawing.Point(12, 12);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(708, 114);
            this.gbTools.TabIndex = 3;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "HERRAMIENTAS";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpEdit);
            this.tcMain.Controls.Add(this.tpNew);
            this.tcMain.Location = new System.Drawing.Point(726, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(342, 733);
            this.tcMain.TabIndex = 4;
            // 
            // tpEdit
            // 
            this.tpEdit.Controls.Add(this.btnDelete);
            this.tpEdit.Controls.Add(this.btnU_Clear);
            this.tpEdit.Controls.Add(this.btnUpdate);
            this.tpEdit.Controls.Add(this.txtU_Email);
            this.tpEdit.Controls.Add(this.label6);
            this.tpEdit.Controls.Add(this.txtU_Phone);
            this.tpEdit.Controls.Add(this.label5);
            this.tpEdit.Controls.Add(this.txtU_Address);
            this.tpEdit.Controls.Add(this.label4);
            this.tpEdit.Controls.Add(this.txtU_DNI);
            this.tpEdit.Controls.Add(this.label3);
            this.tpEdit.Controls.Add(this.txtU_Surname);
            this.tpEdit.Controls.Add(this.label2);
            this.tpEdit.Controls.Add(this.txtU_Name);
            this.tpEdit.Controls.Add(this.label1);
            this.tpEdit.Location = new System.Drawing.Point(4, 25);
            this.tpEdit.Name = "tpEdit";
            this.tpEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tpEdit.Size = new System.Drawing.Size(334, 704);
            this.tpEdit.TabIndex = 0;
            this.tpEdit.Text = "EDITAR";
            this.tpEdit.UseVisualStyleBackColor = true;
            // 
            // tpNew
            // 
            this.tpNew.Controls.Add(this.btnN_Clear);
            this.tpNew.Controls.Add(this.btnSave);
            this.tpNew.Controls.Add(this.txtN_Email);
            this.tpNew.Controls.Add(this.label9);
            this.tpNew.Controls.Add(this.txtN_Phone);
            this.tpNew.Controls.Add(this.label10);
            this.tpNew.Controls.Add(this.txtN_Address);
            this.tpNew.Controls.Add(this.label11);
            this.tpNew.Controls.Add(this.txtN_DNI);
            this.tpNew.Controls.Add(this.label12);
            this.tpNew.Controls.Add(this.txtN_Surname);
            this.tpNew.Controls.Add(this.label13);
            this.tpNew.Controls.Add(this.txtN_Name);
            this.tpNew.Controls.Add(this.label14);
            this.tpNew.Location = new System.Drawing.Point(4, 25);
            this.tpNew.Name = "tpNew";
            this.tpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpNew.Size = new System.Drawing.Size(334, 704);
            this.tpNew.TabIndex = 1;
            this.tpNew.Text = "NUEVO";
            this.tpNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // txtU_Name
            // 
            this.txtU_Name.Location = new System.Drawing.Point(9, 39);
            this.txtU_Name.MaxLength = 30;
            this.txtU_Name.Name = "txtU_Name";
            this.txtU_Name.Size = new System.Drawing.Size(319, 22);
            this.txtU_Name.TabIndex = 1;
            // 
            // txtU_Surname
            // 
            this.txtU_Surname.Location = new System.Drawing.Point(9, 95);
            this.txtU_Surname.MaxLength = 30;
            this.txtU_Surname.Name = "txtU_Surname";
            this.txtU_Surname.Size = new System.Drawing.Size(319, 22);
            this.txtU_Surname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDO";
            // 
            // txtU_DNI
            // 
            this.txtU_DNI.Location = new System.Drawing.Point(9, 146);
            this.txtU_DNI.MaxLength = 8;
            this.txtU_DNI.Name = "txtU_DNI";
            this.txtU_DNI.Size = new System.Drawing.Size(319, 22);
            this.txtU_DNI.TabIndex = 5;
            this.txtU_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_DNI_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // txtU_Address
            // 
            this.txtU_Address.Location = new System.Drawing.Point(9, 198);
            this.txtU_Address.MaxLength = 100;
            this.txtU_Address.Name = "txtU_Address";
            this.txtU_Address.Size = new System.Drawing.Size(319, 22);
            this.txtU_Address.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "DIRECCIÓN";
            // 
            // txtU_Phone
            // 
            this.txtU_Phone.Location = new System.Drawing.Point(9, 247);
            this.txtU_Phone.MaxLength = 9;
            this.txtU_Phone.Name = "txtU_Phone";
            this.txtU_Phone.Size = new System.Drawing.Size(319, 22);
            this.txtU_Phone.TabIndex = 9;
            this.txtU_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_Phone_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "TELÉFONO";
            // 
            // txtU_Email
            // 
            this.txtU_Email.Location = new System.Drawing.Point(9, 299);
            this.txtU_Email.MaxLength = 50;
            this.txtU_Email.Name = "txtU_Email";
            this.txtU_Email.Size = new System.Drawing.Size(319, 22);
            this.txtU_Email.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-MAIL";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(9, 339);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(319, 37);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnU_Clear
            // 
            this.btnU_Clear.Location = new System.Drawing.Point(9, 424);
            this.btnU_Clear.Name = "btnU_Clear";
            this.btnU_Clear.Size = new System.Drawing.Size(319, 37);
            this.btnU_Clear.TabIndex = 13;
            this.btnU_Clear.Text = "LIMPIAR";
            this.btnU_Clear.UseVisualStyleBackColor = true;
            this.btnU_Clear.Click += new System.EventHandler(this.btnU_Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "BUSQUEDA";
            // 
            // cbSearchType
            // 
            this.cbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Location = new System.Drawing.Point(103, 21);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(190, 24);
            this.cbSearchType.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "CRITERIO";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(103, 61);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(190, 22);
            this.txtKeyword.TabIndex = 3;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::atahualpa_ferresys.Properties.Resources.arrow_refresh_157321;
            this.btnRefresh.Location = new System.Drawing.Point(400, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 65);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::atahualpa_ferresys.Properties.Resources.xmag_search_find_export_locate_5984;
            this.btnSearch.Location = new System.Drawing.Point(310, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 65);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnN_Clear
            // 
            this.btnN_Clear.Location = new System.Drawing.Point(9, 379);
            this.btnN_Clear.Name = "btnN_Clear";
            this.btnN_Clear.Size = new System.Drawing.Size(319, 37);
            this.btnN_Clear.TabIndex = 27;
            this.btnN_Clear.Text = "LIMPIAR";
            this.btnN_Clear.UseVisualStyleBackColor = true;
            this.btnN_Clear.Click += new System.EventHandler(this.btnN_Clear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 37);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtN_Email
            // 
            this.txtN_Email.Location = new System.Drawing.Point(9, 296);
            this.txtN_Email.MaxLength = 50;
            this.txtN_Email.Name = "txtN_Email";
            this.txtN_Email.Size = new System.Drawing.Size(319, 22);
            this.txtN_Email.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "E-MAIL";
            // 
            // txtN_Phone
            // 
            this.txtN_Phone.Location = new System.Drawing.Point(9, 244);
            this.txtN_Phone.MaxLength = 9;
            this.txtN_Phone.Name = "txtN_Phone";
            this.txtN_Phone.Size = new System.Drawing.Size(319, 22);
            this.txtN_Phone.TabIndex = 23;
            this.txtN_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_Phone_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "TELÉFONO";
            // 
            // txtN_Address
            // 
            this.txtN_Address.Location = new System.Drawing.Point(9, 195);
            this.txtN_Address.MaxLength = 100;
            this.txtN_Address.Name = "txtN_Address";
            this.txtN_Address.Size = new System.Drawing.Size(319, 22);
            this.txtN_Address.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "DIRECCIÓN";
            // 
            // txtN_DNI
            // 
            this.txtN_DNI.Location = new System.Drawing.Point(9, 143);
            this.txtN_DNI.MaxLength = 8;
            this.txtN_DNI.Name = "txtN_DNI";
            this.txtN_DNI.Size = new System.Drawing.Size(319, 22);
            this.txtN_DNI.TabIndex = 19;
            this.txtN_DNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_DNI_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "DNI";
            // 
            // txtN_Surname
            // 
            this.txtN_Surname.Location = new System.Drawing.Point(9, 92);
            this.txtN_Surname.MaxLength = 30;
            this.txtN_Surname.Name = "txtN_Surname";
            this.txtN_Surname.Size = new System.Drawing.Size(319, 22);
            this.txtN_Surname.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "APELLIDO";
            // 
            // txtN_Name
            // 
            this.txtN_Name.Location = new System.Drawing.Point(9, 36);
            this.txtN_Name.MaxLength = 30;
            this.txtN_Name.Name = "txtN_Name";
            this.txtN_Name.Size = new System.Drawing.Size(319, 22);
            this.txtN_Name.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 16);
            this.label14.TabIndex = 14;
            this.label14.Text = "NOMBRE";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(9, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(319, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1080, 757);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar - Clientes";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpEdit.ResumeLayout(false);
            this.tpEdit.PerformLayout();
            this.tpNew.ResumeLayout(false);
            this.tpNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEdit;
        private System.Windows.Forms.TabPage tpNew;
        private System.Windows.Forms.TextBox txtU_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtU_DNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtU_Surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtU_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtU_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtU_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnU_Clear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnN_Clear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtN_Email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtN_Phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtN_Address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtN_DNI;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtN_Surname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtN_Name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDelete;
    }
}