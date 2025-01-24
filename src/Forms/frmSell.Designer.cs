namespace atahualpa_ferresys.Forms
{
    partial class frmSell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSell));
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.gbCart = new System.Windows.Forms.GroupBox();
            this.dgvToSell = new System.Windows.Forms.DataGridView();
            this.gbExtra = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchCriteria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditPre = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubT = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.gbTools.SuspendLayout();
            this.gbCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToSell)).BeginInit();
            this.gbExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.GridColor = System.Drawing.Color.HotPink;
            this.dgvProductList.Location = new System.Drawing.Point(8, 123);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.Size = new System.Drawing.Size(607, 700);
            this.dgvProductList.TabIndex = 3;
            this.dgvProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellClick);
            this.dgvProductList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellDoubleClick);
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.label3);
            this.gbTools.Controls.Add(this.btnAddProduct);
            this.gbTools.Controls.Add(this.btnRefresh);
            this.gbTools.Controls.Add(this.btnSearch);
            this.gbTools.Controls.Add(this.txtKeyword);
            this.gbTools.Controls.Add(this.label2);
            this.gbTools.Controls.Add(this.cbSearchCriteria);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Controls.Add(this.dgvProductList);
            this.gbTools.Location = new System.Drawing.Point(13, 13);
            this.gbTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTools.Name = "gbTools";
            this.gbTools.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTools.Size = new System.Drawing.Size(623, 831);
            this.gbTools.TabIndex = 4;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "PRODUCTOS DISPONIBLES";
            // 
            // gbCart
            // 
            this.gbCart.Controls.Add(this.btnRemove);
            this.gbCart.Controls.Add(this.btnEditPre);
            this.gbCart.Controls.Add(this.dgvToSell);
            this.gbCart.Location = new System.Drawing.Point(643, 13);
            this.gbCart.Name = "gbCart";
            this.gbCart.Size = new System.Drawing.Size(525, 525);
            this.gbCart.TabIndex = 5;
            this.gbCart.TabStop = false;
            this.gbCart.Text = "CARRITO DE COMPRA";
            // 
            // dgvToSell
            // 
            this.dgvToSell.AllowUserToAddRows = false;
            this.dgvToSell.AllowUserToDeleteRows = false;
            this.dgvToSell.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvToSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToSell.GridColor = System.Drawing.Color.HotPink;
            this.dgvToSell.Location = new System.Drawing.Point(7, 22);
            this.dgvToSell.Margin = new System.Windows.Forms.Padding(4);
            this.dgvToSell.Name = "dgvToSell";
            this.dgvToSell.ReadOnly = true;
            this.dgvToSell.Size = new System.Drawing.Size(511, 425);
            this.dgvToSell.TabIndex = 4;
            // 
            // gbExtra
            // 
            this.gbExtra.Controls.Add(this.lblTotal);
            this.gbExtra.Controls.Add(this.lblIGV);
            this.gbExtra.Controls.Add(this.lblSubT);
            this.gbExtra.Location = new System.Drawing.Point(643, 544);
            this.gbExtra.Name = "gbExtra";
            this.gbExtra.Size = new System.Drawing.Size(525, 301);
            this.gbExtra.TabIndex = 6;
            this.gbExtra.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSQUEDA";
            // 
            // cbSearchCriteria
            // 
            this.cbSearchCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchCriteria.FormattingEnabled = true;
            this.cbSearchCriteria.Location = new System.Drawing.Point(104, 28);
            this.cbSearchCriteria.Name = "cbSearchCriteria";
            this.cbSearchCriteria.Size = new System.Drawing.Size(208, 24);
            this.cbSearchCriteria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "CRITERIO";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(104, 67);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(208, 22);
            this.txtKeyword.TabIndex = 7;
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::atahualpa_ferresys.Properties.Resources.delete_delete_exit_1577;
            this.btnRemove.Location = new System.Drawing.Point(101, 454);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 61);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEditPre
            // 
            this.btnEditPre.Image = global::atahualpa_ferresys.Properties.Resources.edit_validated256_25237;
            this.btnEditPre.Location = new System.Drawing.Point(7, 454);
            this.btnEditPre.Name = "btnEditPre";
            this.btnEditPre.Size = new System.Drawing.Size(88, 61);
            this.btnEditPre.TabIndex = 11;
            this.btnEditPre.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = global::atahualpa_ferresys.Properties.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335;
            this.btnAddProduct.Location = new System.Drawing.Point(506, 28);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(88, 61);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::atahualpa_ferresys.Properties.Resources.arrow_refresh_157322;
            this.btnRefresh.Location = new System.Drawing.Point(412, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 61);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::atahualpa_ferresys.Properties.Resources.xmag_search_find_export_locate_59841;
            this.btnSearch.Location = new System.Drawing.Point(318, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 61);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSubT
            // 
            this.lblSubT.AutoSize = true;
            this.lblSubT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubT.Location = new System.Drawing.Point(6, 18);
            this.lblSubT.Name = "lblSubT";
            this.lblSubT.Size = new System.Drawing.Size(138, 25);
            this.lblSubT.TabIndex = 0;
            this.lblSubT.Text = "SUBTOTAL:";
            // 
            // lblIGV
            // 
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(87, 53);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(57, 25);
            this.lblIGV.TabIndex = 1;
            this.lblIGV.Text = "IGV:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(52, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 25);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "TOTAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(180, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "* Doble click para añadir productos *";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 857);
            this.Controls.Add(this.gbExtra);
            this.Controls.Add(this.gbCart);
            this.Controls.Add(this.gbTools);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSell";
            this.Text = "NUEVA VENTA";
            this.Load += new System.EventHandler(this.frmSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            this.gbCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToSell)).EndInit();
            this.gbExtra.ResumeLayout(false);
            this.gbExtra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.GroupBox gbCart;
        private System.Windows.Forms.DataGridView dgvToSell;
        private System.Windows.Forms.GroupBox gbExtra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearchCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditPre;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblSubT;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
    }
}