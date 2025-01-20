namespace atahualpa_ferresys.Forms
{
    partial class frmUnitType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnitType));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.gbNew = new System.Windows.Forms.GroupBox();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.dgvUnitTypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN_Name = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnN_Clear = new System.Windows.Forms.Button();
            this.btnU_Clear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtU_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbMain.SuspendLayout();
            this.gbNew.SuspendLayout();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.dgvUnitTypes);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(650, 737);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "LISTADO";
            // 
            // gbNew
            // 
            this.gbNew.Controls.Add(this.btnN_Clear);
            this.gbNew.Controls.Add(this.btnSave);
            this.gbNew.Controls.Add(this.txtN_Name);
            this.gbNew.Controls.Add(this.label1);
            this.gbNew.Location = new System.Drawing.Point(668, 12);
            this.gbNew.Name = "gbNew";
            this.gbNew.Size = new System.Drawing.Size(404, 200);
            this.gbNew.TabIndex = 1;
            this.gbNew.TabStop = false;
            this.gbNew.Text = "NUEVA";
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.btnRefresh);
            this.gbTools.Controls.Add(this.btnSearch);
            this.gbTools.Controls.Add(this.label3);
            this.gbTools.Controls.Add(this.txtKeyword);
            this.gbTools.Controls.Add(this.btnDelete);
            this.gbTools.Controls.Add(this.btnU_Clear);
            this.gbTools.Controls.Add(this.btnUpdate);
            this.gbTools.Controls.Add(this.label2);
            this.gbTools.Controls.Add(this.txtU_Name);
            this.gbTools.Location = new System.Drawing.Point(668, 218);
            this.gbTools.Name = "gbTools";
            this.gbTools.Size = new System.Drawing.Size(404, 258);
            this.gbTools.TabIndex = 2;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "HERRAMIENTAS";
            // 
            // dgvUnitTypes
            // 
            this.dgvUnitTypes.AllowUserToAddRows = false;
            this.dgvUnitTypes.AllowUserToDeleteRows = false;
            this.dgvUnitTypes.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvUnitTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnitTypes.GridColor = System.Drawing.Color.HotPink;
            this.dgvUnitTypes.Location = new System.Drawing.Point(6, 21);
            this.dgvUnitTypes.Name = "dgvUnitTypes";
            this.dgvUnitTypes.ReadOnly = true;
            this.dgvUnitTypes.Size = new System.Drawing.Size(638, 710);
            this.dgvUnitTypes.TabIndex = 2;
            this.dgvUnitTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnitTypes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // txtN_Name
            // 
            this.txtN_Name.Location = new System.Drawing.Point(9, 53);
            this.txtN_Name.MaxLength = 100;
            this.txtN_Name.Name = "txtN_Name";
            this.txtN_Name.Size = new System.Drawing.Size(389, 22);
            this.txtN_Name.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 89);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 44);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnN_Clear
            // 
            this.btnN_Clear.Location = new System.Drawing.Point(45, 139);
            this.btnN_Clear.Name = "btnN_Clear";
            this.btnN_Clear.Size = new System.Drawing.Size(166, 44);
            this.btnN_Clear.TabIndex = 3;
            this.btnN_Clear.Text = "LIMPIAR";
            this.btnN_Clear.UseVisualStyleBackColor = true;
            this.btnN_Clear.Click += new System.EventHandler(this.btnN_Clear_Click);
            // 
            // btnU_Clear
            // 
            this.btnU_Clear.Location = new System.Drawing.Point(45, 140);
            this.btnU_Clear.Name = "btnU_Clear";
            this.btnU_Clear.Size = new System.Drawing.Size(166, 44);
            this.btnU_Clear.TabIndex = 7;
            this.btnU_Clear.Text = "LIMPIAR";
            this.btnU_Clear.UseVisualStyleBackColor = true;
            this.btnU_Clear.Click += new System.EventHandler(this.btnU_Clear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(45, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 44);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "ACTUALIZAR";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtU_Name
            // 
            this.txtU_Name.Location = new System.Drawing.Point(9, 52);
            this.txtU_Name.MaxLength = 100;
            this.txtU_Name.Name = "txtU_Name";
            this.txtU_Name.Size = new System.Drawing.Size(389, 22);
            this.txtU_Name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::atahualpa_ferresys.Properties.Resources._3592821_garbage_can_general_office_recycle_bin_rubbish_bin_trash_bin_trash_can_107760;
            this.btnDelete.Location = new System.Drawing.Point(313, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 94);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::atahualpa_ferresys.Properties.Resources.arrow_refresh_15732;
            this.btnRefresh.Location = new System.Drawing.Point(243, 90);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 94);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOMBRE ó ID";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(9, 220);
            this.txtKeyword.MaxLength = 100;
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(241, 22);
            this.txtKeyword.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 220);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "BUSCAR";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::atahualpa_ferresys.Properties.Resources.computer_database;
            this.pictureBox1.Location = new System.Drawing.Point(899, 595);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmUnitType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.gbNew);
            this.Controls.Add(this.gbMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUnitType";
            this.Text = "PRESENTACIONES - GESTIONAR";
            this.Load += new System.EventHandler(this.frmUnitType_Load);
            this.gbMain.ResumeLayout(false);
            this.gbNew.ResumeLayout(false);
            this.gbNew.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnitTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.GroupBox gbNew;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.DataGridView dgvUnitTypes;
        private System.Windows.Forms.TextBox txtN_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnN_Clear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnU_Clear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtU_Name;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}