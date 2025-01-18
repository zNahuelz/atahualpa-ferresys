namespace atahualpa_ferresys.Forms
{
    partial class frmProductManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManagement));
            this.gbProductList = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lbl_IDSearch = new System.Windows.Forms.Label();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnClearUpF = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbU_UnitType = new System.Windows.Forms.ComboBox();
            this.lblUnitT = new System.Windows.Forms.Label();
            this.lblSupp = new System.Windows.Forms.Label();
            this.cbU_Supplier = new System.Windows.Forms.ComboBox();
            this.cbU_Visible = new System.Windows.Forms.CheckBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtU_Stock = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.txtU_SellPrice = new System.Windows.Forms.TextBox();
            this.lblBP = new System.Windows.Forms.Label();
            this.txtU_BuyPrice = new System.Windows.Forms.TextBox();
            this.txtU_Desc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtU_Name = new System.Windows.Forms.TextBox();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.btnClearSvF = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.cbN_UnitType = new System.Windows.Forms.ComboBox();
            this.txtN_Desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbN_Supplier = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbN_Visible = new System.Windows.Forms.CheckBox();
            this.txtN_BuyPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN_Stock = new System.Windows.Forms.TextBox();
            this.txtN_SellPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.gbNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProductList
            // 
            this.gbProductList.Controls.Add(this.dgvProducts);
            this.gbProductList.Controls.Add(this.btnRefreshProducts);
            this.gbProductList.Controls.Add(this.btnSearchID);
            this.gbProductList.Controls.Add(this.txtSearchID);
            this.gbProductList.Controls.Add(this.lbl_IDSearch);
            this.gbProductList.Location = new System.Drawing.Point(12, 12);
            this.gbProductList.Name = "gbProductList";
            this.gbProductList.Size = new System.Drawing.Size(447, 781);
            this.gbProductList.TabIndex = 0;
            this.gbProductList.TabStop = false;
            this.gbProductList.Text = "ÚLTIMOS PRODUCTOS AGREGADOS";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(6, 67);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(433, 706);
            this.dgvProducts.TabIndex = 4;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.Image = global::atahualpa_ferresys.Properties.Resources.arrow_refresh_15732;
            this.btnRefreshProducts.Location = new System.Drawing.Point(396, 23);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(43, 38);
            this.btnRefreshProducts.TabIndex = 3;
            this.btnRefreshProducts.UseVisualStyleBackColor = true;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(257, 31);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(133, 23);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "BUSCAR";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(126, 31);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(125, 22);
            this.txtSearchID.TabIndex = 1;
            this.txtSearchID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchID_KeyPress);
            // 
            // lbl_IDSearch
            // 
            this.lbl_IDSearch.AutoSize = true;
            this.lbl_IDSearch.Location = new System.Drawing.Point(6, 34);
            this.lbl_IDSearch.Name = "lbl_IDSearch";
            this.lbl_IDSearch.Size = new System.Drawing.Size(114, 16);
            this.lbl_IDSearch.TabIndex = 0;
            this.lbl_IDSearch.Text = "ID BUSQUEDA:";
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnClearUpF);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnUpdate);
            this.gbEdit.Controls.Add(this.cbU_UnitType);
            this.gbEdit.Controls.Add(this.lblUnitT);
            this.gbEdit.Controls.Add(this.lblSupp);
            this.gbEdit.Controls.Add(this.cbU_Supplier);
            this.gbEdit.Controls.Add(this.cbU_Visible);
            this.gbEdit.Controls.Add(this.lblStock);
            this.gbEdit.Controls.Add(this.txtU_Stock);
            this.gbEdit.Controls.Add(this.lblSP);
            this.gbEdit.Controls.Add(this.txtU_SellPrice);
            this.gbEdit.Controls.Add(this.lblBP);
            this.gbEdit.Controls.Add(this.txtU_BuyPrice);
            this.gbEdit.Controls.Add(this.txtU_Desc);
            this.gbEdit.Controls.Add(this.lblDesc);
            this.gbEdit.Controls.Add(this.lblName);
            this.gbEdit.Controls.Add(this.txtU_Name);
            this.gbEdit.Location = new System.Drawing.Point(465, 12);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(603, 391);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "EDITAR PRODUCTO";
            // 
            // btnClearUpF
            // 
            this.btnClearUpF.Location = new System.Drawing.Point(503, 212);
            this.btnClearUpF.Name = "btnClearUpF";
            this.btnClearUpF.Size = new System.Drawing.Size(80, 66);
            this.btnClearUpF.TabIndex = 33;
            this.btnClearUpF.Text = "LIMPIAR";
            this.btnClearUpF.UseVisualStyleBackColor = true;
            this.btnClearUpF.Click += new System.EventHandler(this.btnClearUpF_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::atahualpa_ferresys.Properties.Resources._3592821_garbage_can_general_office_recycle_bin_rubbish_bin_trash_bin_trash_can_107760;
            this.btnDelete.Location = new System.Drawing.Point(503, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 66);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = global::atahualpa_ferresys.Properties.Resources.saveall_1204;
            this.btnUpdate.Location = new System.Drawing.Point(503, 28);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 66);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbU_UnitType
            // 
            this.cbU_UnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbU_UnitType.FormattingEnabled = true;
            this.cbU_UnitType.Location = new System.Drawing.Point(164, 347);
            this.cbU_UnitType.Name = "cbU_UnitType";
            this.cbU_UnitType.Size = new System.Drawing.Size(314, 24);
            this.cbU_UnitType.TabIndex = 30;
            // 
            // lblUnitT
            // 
            this.lblUnitT.AutoSize = true;
            this.lblUnitT.Location = new System.Drawing.Point(76, 343);
            this.lblUnitT.Name = "lblUnitT";
            this.lblUnitT.Size = new System.Drawing.Size(67, 32);
            this.lblUnitT.TabIndex = 29;
            this.lblUnitT.Text = "TIPO DE\r\nUNIDAD";
            // 
            // lblSupp
            // 
            this.lblSupp.AutoSize = true;
            this.lblSupp.Location = new System.Drawing.Point(41, 307);
            this.lblSupp.Name = "lblSupp";
            this.lblSupp.Size = new System.Drawing.Size(102, 16);
            this.lblSupp.TabIndex = 28;
            this.lblSupp.Text = "PROVEEDOR";
            // 
            // cbU_Supplier
            // 
            this.cbU_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbU_Supplier.FormattingEnabled = true;
            this.cbU_Supplier.Location = new System.Drawing.Point(164, 303);
            this.cbU_Supplier.Name = "cbU_Supplier";
            this.cbU_Supplier.Size = new System.Drawing.Size(314, 24);
            this.cbU_Supplier.TabIndex = 27;
            // 
            // cbU_Visible
            // 
            this.cbU_Visible.AutoSize = true;
            this.cbU_Visible.Checked = true;
            this.cbU_Visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbU_Visible.Location = new System.Drawing.Point(291, 268);
            this.cbU_Visible.Name = "cbU_Visible";
            this.cbU_Visible.Size = new System.Drawing.Size(82, 20);
            this.cbU_Visible.TabIndex = 26;
            this.cbU_Visible.Text = "VISIBLE";
            this.cbU_Visible.UseVisualStyleBackColor = true;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(86, 270);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(57, 16);
            this.lblStock.TabIndex = 25;
            this.lblStock.Text = "STOCK";
            this.lblStock.Click += new System.EventHandler(this.lblStock_Click);
            // 
            // txtU_Stock
            // 
            this.txtU_Stock.Location = new System.Drawing.Point(164, 267);
            this.txtU_Stock.Name = "txtU_Stock";
            this.txtU_Stock.Size = new System.Drawing.Size(93, 22);
            this.txtU_Stock.TabIndex = 24;
            this.txtU_Stock.Text = "0";
            this.txtU_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_Stock_KeyPress);
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(288, 212);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(63, 32);
            this.lblSP.TabIndex = 23;
            this.lblSP.Text = "PRECIO\r\nVENTA";
            // 
            // txtU_SellPrice
            // 
            this.txtU_SellPrice.Location = new System.Drawing.Point(385, 217);
            this.txtU_SellPrice.Name = "txtU_SellPrice";
            this.txtU_SellPrice.Size = new System.Drawing.Size(93, 22);
            this.txtU_SellPrice.TabIndex = 22;
            this.txtU_SellPrice.Text = "0.00";
            this.txtU_SellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_SellPrice_KeyPress);
            // 
            // lblBP
            // 
            this.lblBP.AutoSize = true;
            this.lblBP.Location = new System.Drawing.Point(72, 212);
            this.lblBP.Name = "lblBP";
            this.lblBP.Size = new System.Drawing.Size(71, 32);
            this.lblBP.TabIndex = 21;
            this.lblBP.Text = "PRECIO\r\nCOMPRA";
            // 
            // txtU_BuyPrice
            // 
            this.txtU_BuyPrice.Location = new System.Drawing.Point(164, 217);
            this.txtU_BuyPrice.Name = "txtU_BuyPrice";
            this.txtU_BuyPrice.Size = new System.Drawing.Size(93, 22);
            this.txtU_BuyPrice.TabIndex = 20;
            this.txtU_BuyPrice.Text = "0.00";
            this.txtU_BuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtU_BuyPrice_KeyPress);
            // 
            // txtU_Desc
            // 
            this.txtU_Desc.Location = new System.Drawing.Point(164, 67);
            this.txtU_Desc.Multiline = true;
            this.txtU_Desc.Name = "txtU_Desc";
            this.txtU_Desc.Size = new System.Drawing.Size(314, 121);
            this.txtU_Desc.TabIndex = 19;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(34, 67);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(109, 16);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "DESCRIPCIÓN";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 31);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 16);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "NOMBRE";
            // 
            // txtU_Name
            // 
            this.txtU_Name.Location = new System.Drawing.Point(164, 28);
            this.txtU_Name.Name = "txtU_Name";
            this.txtU_Name.Size = new System.Drawing.Size(314, 22);
            this.txtU_Name.TabIndex = 16;
            // 
            // gbNew
            // 
            this.gbNew.Controls.Add(this.btnClearSvF);
            this.gbNew.Controls.Add(this.btnSaveProduct);
            this.gbNew.Controls.Add(this.cbN_UnitType);
            this.gbNew.Controls.Add(this.txtN_Desc);
            this.gbNew.Controls.Add(this.label1);
            this.gbNew.Controls.Add(this.txtN_Name);
            this.gbNew.Controls.Add(this.label2);
            this.gbNew.Controls.Add(this.label7);
            this.gbNew.Controls.Add(this.cbN_Supplier);
            this.gbNew.Controls.Add(this.label6);
            this.gbNew.Controls.Add(this.cbN_Visible);
            this.gbNew.Controls.Add(this.txtN_BuyPrice);
            this.gbNew.Controls.Add(this.label3);
            this.gbNew.Controls.Add(this.label5);
            this.gbNew.Controls.Add(this.txtN_Stock);
            this.gbNew.Controls.Add(this.txtN_SellPrice);
            this.gbNew.Controls.Add(this.label4);
            this.gbNew.Location = new System.Drawing.Point(465, 409);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(603, 384);
            this.gbNew.TabIndex = 2;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "NUEVO PRODUCTO";
            // 
            // btnClearSvF
            // 
            this.btnClearSvF.Location = new System.Drawing.Point(503, 123);
            this.btnClearSvF.Name = "btnClearSvF";
            this.btnClearSvF.Size = new System.Drawing.Size(80, 66);
            this.btnClearSvF.TabIndex = 47;
            this.btnClearSvF.Text = "LIMPIAR";
            this.btnClearSvF.UseVisualStyleBackColor = true;
            this.btnClearSvF.Click += new System.EventHandler(this.btnClearSvF_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Image = global::atahualpa_ferresys.Properties.Resources.saveall_1204;
            this.btnSaveProduct.Location = new System.Drawing.Point(503, 29);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(80, 66);
            this.btnSaveProduct.TabIndex = 46;
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // cbN_UnitType
            // 
            this.cbN_UnitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbN_UnitType.FormattingEnabled = true;
            this.cbN_UnitType.Location = new System.Drawing.Point(164, 348);
            this.cbN_UnitType.Name = "cbN_UnitType";
            this.cbN_UnitType.Size = new System.Drawing.Size(314, 24);
            this.cbN_UnitType.TabIndex = 45;
            // 
            // txtN_Desc
            // 
            this.txtN_Desc.Location = new System.Drawing.Point(164, 68);
            this.txtN_Desc.Multiline = true;
            this.txtN_Desc.Name = "txtN_Desc";
            this.txtN_Desc.Size = new System.Drawing.Size(314, 121);
            this.txtN_Desc.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 44;
            this.label1.Text = "TIPO DE\r\nUNIDAD";
            // 
            // txtN_Name
            // 
            this.txtN_Name.Location = new System.Drawing.Point(164, 29);
            this.txtN_Name.Name = "txtN_Name";
            this.txtN_Name.Size = new System.Drawing.Size(314, 22);
            this.txtN_Name.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "PROVEEDOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "NOMBRE";
            // 
            // cbN_Supplier
            // 
            this.cbN_Supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbN_Supplier.FormattingEnabled = true;
            this.cbN_Supplier.Location = new System.Drawing.Point(164, 304);
            this.cbN_Supplier.Name = "cbN_Supplier";
            this.cbN_Supplier.Size = new System.Drawing.Size(314, 24);
            this.cbN_Supplier.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "DESCRIPCIÓN";
            // 
            // cbN_Visible
            // 
            this.cbN_Visible.AutoSize = true;
            this.cbN_Visible.Checked = true;
            this.cbN_Visible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbN_Visible.Location = new System.Drawing.Point(291, 269);
            this.cbN_Visible.Name = "cbN_Visible";
            this.cbN_Visible.Size = new System.Drawing.Size(82, 20);
            this.cbN_Visible.TabIndex = 41;
            this.cbN_Visible.Text = "VISIBLE";
            this.cbN_Visible.UseVisualStyleBackColor = true;
            // 
            // txtN_BuyPrice
            // 
            this.txtN_BuyPrice.Location = new System.Drawing.Point(164, 218);
            this.txtN_BuyPrice.Name = "txtN_BuyPrice";
            this.txtN_BuyPrice.Size = new System.Drawing.Size(93, 22);
            this.txtN_BuyPrice.TabIndex = 35;
            this.txtN_BuyPrice.Text = "0.00";
            this.txtN_BuyPrice.TextChanged += new System.EventHandler(this.txtN_BuyPrice_TextChanged);
            this.txtN_BuyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_BuyPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "STOCK";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 32);
            this.label5.TabIndex = 36;
            this.label5.Text = "PRECIO\r\nCOMPRA";
            // 
            // txtN_Stock
            // 
            this.txtN_Stock.Location = new System.Drawing.Point(164, 268);
            this.txtN_Stock.Name = "txtN_Stock";
            this.txtN_Stock.Size = new System.Drawing.Size(93, 22);
            this.txtN_Stock.TabIndex = 39;
            this.txtN_Stock.Text = "0";
            this.txtN_Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_Stock_KeyPress);
            // 
            // txtN_SellPrice
            // 
            this.txtN_SellPrice.Location = new System.Drawing.Point(385, 218);
            this.txtN_SellPrice.Name = "txtN_SellPrice";
            this.txtN_SellPrice.Size = new System.Drawing.Size(93, 22);
            this.txtN_SellPrice.TabIndex = 37;
            this.txtN_SellPrice.Text = "0.00";
            this.txtN_SellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_SellPrice_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 32);
            this.label4.TabIndex = 38;
            this.label4.Text = "PRECIO\r\nVENTA";
            // 
            // frmProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 805);
            this.Controls.Add(this.gbNew);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbProductList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductManagement";
            this.Text = "PRODUCTOS - GESTIONAR";
            this.Load += new System.EventHandler(this.frmProductManagement_Load);
            this.gbProductList.ResumeLayout(false);
            this.gbProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbNew.ResumeLayout(false);
            this.gbNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductList;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.GroupBox gbNew;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lbl_IDSearch;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ComboBox cbU_UnitType;
        private System.Windows.Forms.Label lblUnitT;
        private System.Windows.Forms.Label lblSupp;
        private System.Windows.Forms.ComboBox cbU_Supplier;
        private System.Windows.Forms.CheckBox cbU_Visible;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtU_Stock;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.TextBox txtU_SellPrice;
        private System.Windows.Forms.Label lblBP;
        private System.Windows.Forms.TextBox txtU_BuyPrice;
        private System.Windows.Forms.TextBox txtU_Desc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtU_Name;
        private System.Windows.Forms.ComboBox cbN_UnitType;
        private System.Windows.Forms.TextBox txtN_Desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbN_Supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbN_Visible;
        private System.Windows.Forms.TextBox txtN_BuyPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN_Stock;
        private System.Windows.Forms.TextBox txtN_SellPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearUpF;
        private System.Windows.Forms.Button btnClearSvF;
        private System.Windows.Forms.Button btnSaveProduct;
    }
}