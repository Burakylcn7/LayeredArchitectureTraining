namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.gbxTransactions = new System.Windows.Forms.GroupBox();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.txtAddProductName = new System.Windows.Forms.TextBox();
            this.txtAddUnitPrice = new System.Windows.Forms.TextBox();
            this.txtAddQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.txtAddStock = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.gbxTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.txtAra);
            this.gbxSearch.Controls.Add(this.cbxKategori);
            this.gbxSearch.Controls.Add(this.lblAra);
            this.gbxSearch.Controls.Add(this.lblKategori);
            this.gbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSearch.Location = new System.Drawing.Point(12, 18);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(895, 83);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(555, 29);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(315, 28);
            this.txtAra.TabIndex = 3;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // cbxKategori
            // 
            this.cbxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Location = new System.Drawing.Point(123, 29);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(315, 30);
            this.cbxKategori.TabIndex = 2;
            this.cbxKategori.SelectedIndexChanged += new System.EventHandler(this.cbxKategori_SelectedIndexChanged);
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(493, 34);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(56, 20);
            this.lblAra.TabIndex = 1;
            this.lblAra.Text = "Ara : ";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(20, 34);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(97, 20);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori : ";
            // 
            // dgwData
            // 
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Location = new System.Drawing.Point(12, 107);
            this.dgwData.Name = "dgwData";
            this.dgwData.RowHeadersWidth = 51;
            this.dgwData.RowTemplate.Height = 24;
            this.dgwData.Size = new System.Drawing.Size(895, 337);
            this.dgwData.TabIndex = 3;
            this.dgwData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwData_CellClick);
            // 
            // gbxTransactions
            // 
            this.gbxTransactions.Controls.Add(this.btnDelete);
            this.gbxTransactions.Controls.Add(this.btnUpdate);
            this.gbxTransactions.Controls.Add(this.btnAdd);
            this.gbxTransactions.Controls.Add(this.txtAddStock);
            this.gbxTransactions.Controls.Add(this.txtAddQuantityPerUnit);
            this.gbxTransactions.Controls.Add(this.txtAddUnitPrice);
            this.gbxTransactions.Controls.Add(this.txtAddProductName);
            this.gbxTransactions.Controls.Add(this.cbxAddCategory);
            this.gbxTransactions.Controls.Add(this.lblAddStock);
            this.gbxTransactions.Controls.Add(this.lblAddProductName);
            this.gbxTransactions.Controls.Add(this.lblAddUnitPrice);
            this.gbxTransactions.Controls.Add(this.lblAddQuantityPerUnit);
            this.gbxTransactions.Controls.Add(this.lblAddCategory);
            this.gbxTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxTransactions.Location = new System.Drawing.Point(12, 450);
            this.gbxTransactions.Name = "gbxTransactions";
            this.gbxTransactions.Size = new System.Drawing.Size(895, 161);
            this.gbxTransactions.TabIndex = 4;
            this.gbxTransactions.TabStop = false;
            this.gbxTransactions.Text = "Transactions";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddCategory.Location = new System.Drawing.Point(20, 77);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(97, 20);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Kategori : ";
            // 
            // lblAddQuantityPerUnit
            // 
            this.lblAddQuantityPerUnit.AutoSize = true;
            this.lblAddQuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddQuantityPerUnit.Location = new System.Drawing.Point(452, 77);
            this.lblAddQuantityPerUnit.Name = "lblAddQuantityPerUnit";
            this.lblAddQuantityPerUnit.Size = new System.Drawing.Size(119, 20);
            this.lblAddQuantityPerUnit.TabIndex = 2;
            this.lblAddQuantityPerUnit.Text = "Birim Adedi :";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddUnitPrice.Location = new System.Drawing.Point(20, 126);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(62, 20);
            this.lblAddUnitPrice.TabIndex = 3;
            this.lblAddUnitPrice.Text = "Fiyat :";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddProductName.Location = new System.Drawing.Point(20, 32);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(94, 20);
            this.lblAddProductName.TabIndex = 4;
            this.lblAddProductName.Text = "Ürün Adı :";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAddStock.Location = new System.Drawing.Point(452, 32);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(111, 20);
            this.lblAddStock.TabIndex = 5;
            this.lblAddStock.Text = "Stok Adedi :";
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(123, 72);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(315, 30);
            this.cbxAddCategory.TabIndex = 6;
            // 
            // txtAddProductName
            // 
            this.txtAddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddProductName.Location = new System.Drawing.Point(123, 27);
            this.txtAddProductName.Name = "txtAddProductName";
            this.txtAddProductName.Size = new System.Drawing.Size(315, 28);
            this.txtAddProductName.TabIndex = 4;
            // 
            // txtAddUnitPrice
            // 
            this.txtAddUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddUnitPrice.Location = new System.Drawing.Point(123, 121);
            this.txtAddUnitPrice.Name = "txtAddUnitPrice";
            this.txtAddUnitPrice.Size = new System.Drawing.Size(315, 28);
            this.txtAddUnitPrice.TabIndex = 7;
            // 
            // txtAddQuantityPerUnit
            // 
            this.txtAddQuantityPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddQuantityPerUnit.Location = new System.Drawing.Point(578, 72);
            this.txtAddQuantityPerUnit.Name = "txtAddQuantityPerUnit";
            this.txtAddQuantityPerUnit.Size = new System.Drawing.Size(292, 28);
            this.txtAddQuantityPerUnit.TabIndex = 8;
            // 
            // txtAddStock
            // 
            this.txtAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddStock.Location = new System.Drawing.Point(578, 27);
            this.txtAddStock.Name = "txtAddStock";
            this.txtAddStock.Size = new System.Drawing.Size(292, 28);
            this.txtAddStock.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(456, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 34);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(598, 119);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(737, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 34);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 642);
            this.Controls.Add(this.gbxTransactions);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.dgwData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.gbxTransactions.ResumeLayout(false);
            this.gbxTransactions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.GroupBox gbxTransactions;
        private System.Windows.Forms.TextBox txtAddStock;
        private System.Windows.Forms.TextBox txtAddQuantityPerUnit;
        private System.Windows.Forms.TextBox txtAddUnitPrice;
        private System.Windows.Forms.TextBox txtAddProductName;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblAddQuantityPerUnit;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}

