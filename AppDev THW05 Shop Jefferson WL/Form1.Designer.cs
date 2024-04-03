namespace AppDev_THW05_Shop_Jefferson_WL
{
    partial class JefferShop
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
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelDetail = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelNamaCategory = new System.Windows.Forms.Label();
            this.labelNamaDetail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxNamaCategory = new System.Windows.Forms.TextBox();
            this.tbxNama = new System.Windows.Forms.TextBox();
            this.tbxHarga = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnAddproduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnRemoveCategory = new System.Windows.Forms.Button();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(26, 25);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(103, 29);
            this.labelProduct.TabIndex = 0;
            this.labelProduct.Text = "Product";
            // 
            // labelDetail
            // 
            this.labelDetail.AutoSize = true;
            this.labelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetail.Location = new System.Drawing.Point(36, 361);
            this.labelDetail.Name = "labelDetail";
            this.labelDetail.Size = new System.Drawing.Size(94, 29);
            this.labelDetail.TabIndex = 1;
            this.labelDetail.Text = "Details";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(606, 25);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(118, 29);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "Category";
            // 
            // labelNamaCategory
            // 
            this.labelNamaCategory.AutoSize = true;
            this.labelNamaCategory.Location = new System.Drawing.Point(608, 304);
            this.labelNamaCategory.Name = "labelNamaCategory";
            this.labelNamaCategory.Size = new System.Drawing.Size(50, 16);
            this.labelNamaCategory.TabIndex = 3;
            this.labelNamaCategory.Text = "Nama :";
            // 
            // labelNamaDetail
            // 
            this.labelNamaDetail.AutoSize = true;
            this.labelNamaDetail.Location = new System.Drawing.Point(55, 396);
            this.labelNamaDetail.Name = "labelNamaDetail";
            this.labelNamaDetail.Size = new System.Drawing.Size(50, 16);
            this.labelNamaDetail.TabIndex = 4;
            this.labelNamaDetail.Text = "Nama :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Category :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Harga :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 490);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Stock :";
            // 
            // tbxNamaCategory
            // 
            this.tbxNamaCategory.Location = new System.Drawing.Point(664, 301);
            this.tbxNamaCategory.Name = "tbxNamaCategory";
            this.tbxNamaCategory.Size = new System.Drawing.Size(178, 22);
            this.tbxNamaCategory.TabIndex = 8;
     
            // 
            // tbxNama
            // 
            this.tbxNama.Location = new System.Drawing.Point(122, 393);
            this.tbxNama.Name = "tbxNama";
            this.tbxNama.Size = new System.Drawing.Size(412, 22);
            this.tbxNama.TabIndex = 9;
         
            // 
            // tbxHarga
            // 
            this.tbxHarga.Location = new System.Drawing.Point(122, 455);
            this.tbxHarga.Name = "tbxHarga";
            this.tbxHarga.Size = new System.Drawing.Size(149, 22);
            this.tbxHarga.TabIndex = 10;
            this.tbxHarga.TextChanged += new System.EventHandler(this.tbxHarga_TextChanged);
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(122, 490);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(149, 22);
            this.tbxStock.TabIndex = 11;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(297, 26);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(75, 23);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click_1);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(378, 26);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 13;
            this.btnFilter.Text = "Filter:";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(464, 25);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFilter.TabIndex = 14;
            this.comboBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFilter_SelectionChangeCommitted_1);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(122, 425);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(149, 24);
            this.comboBoxCategory.TabIndex = 15;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // btnAddproduct
            // 
            this.btnAddproduct.Location = new System.Drawing.Point(297, 463);
            this.btnAddproduct.Name = "btnAddproduct";
            this.btnAddproduct.Size = new System.Drawing.Size(75, 43);
            this.btnAddproduct.TabIndex = 16;
            this.btnAddproduct.Text = "Add\r\nProduct\r\n";
            this.btnAddproduct.UseVisualStyleBackColor = true;
            this.btnAddproduct.Click += new System.EventHandler(this.btnAddproduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(378, 463);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 43);
            this.btnEditProduct.TabIndex = 17;
            this.btnEditProduct.Text = "Edit\r\nProduct\r\n";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(459, 463);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(75, 43);
            this.btnRemoveProduct.TabIndex = 18;
            this.btnRemoveProduct.Text = "Remove\r\nProduct\r\n";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(664, 332);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(82, 44);
            this.btnAddCategory.TabIndex = 19;
            this.btnAddCategory.Text = "Add\r\nCategory\r\n";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(761, 332);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(81, 44);
            this.btnRemoveCategory.TabIndex = 20;
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.UseVisualStyleBackColor = true;
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(31, 65);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(554, 275);
            this.dataGridViewProduct.TabIndex = 21;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(611, 65);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 24;
            this.dataGridViewCategory.Size = new System.Drawing.Size(303, 203);
            this.dataGridViewCategory.TabIndex = 22;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // JefferShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 570);
            this.Controls.Add(this.dataGridViewCategory);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.btnRemoveCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddproduct);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.tbxStock);
            this.Controls.Add(this.tbxHarga);
            this.Controls.Add(this.tbxNama);
            this.Controls.Add(this.tbxNamaCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelNamaDetail);
            this.Controls.Add(this.labelNamaCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDetail);
            this.Controls.Add(this.labelProduct);
            this.Name = "JefferShop";
            this.Text = "Jeffer Shop";
            this.Load += new System.EventHandler(this.JefferShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelDetail;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelNamaCategory;
        private System.Windows.Forms.Label labelNamaDetail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxNamaCategory;
        private System.Windows.Forms.TextBox tbxNama;
        private System.Windows.Forms.TextBox tbxHarga;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnAddproduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnRemoveCategory;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
    }
}

