namespace ANBAR
{
	partial class CommodityStockForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.textLabel = new Mbb.Windows.Forms.Label();
			this.myDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commodityPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.searchPurchaseDateMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.searchPurchaseDateLabel = new Mbb.Windows.Forms.Label();
			this.searchCommodityNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.searchCommodityNameLabel = new Mbb.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
			this.searchGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// textLabel
			// 
			this.textLabel.AutoSize = true;
			this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.textLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.textLabel.Location = new System.Drawing.Point(149, 13);
			this.textLabel.Name = "textLabel";
			this.textLabel.Size = new System.Drawing.Size(345, 39);
			this.textLabel.TabIndex = 1;
			this.textLabel.Text = "لیست کالاهای موجود در انبار";
			// 
			// myDataGridView
			// 
			this.myDataGridView.AllowUserToAddRows = false;
			this.myDataGridView.AllowUserToDeleteRows = false;
			this.myDataGridView.AutoGenerateColumns = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityNameDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.commodityPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
			this.myDataGridView.DataSource = this.commodityBindingSource;
			this.myDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.myDataGridView.Location = new System.Drawing.Point(0, 149);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.ReadOnly = true;
			this.myDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.myDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.myDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.myDataGridView.Size = new System.Drawing.Size(643, 324);
			this.myDataGridView.TabIndex = 0;
			// 
			// commodityNameDataGridViewTextBoxColumn
			// 
			this.commodityNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
			this.commodityNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
			this.commodityNameDataGridViewTextBoxColumn.MaxInputLength = 50;
			this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
			this.commodityNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// purchaseDateDataGridViewTextBoxColumn
			// 
			this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
			this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "تاریخ خرید کالا";
			this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
			this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "تعداد";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			this.unitDataGridViewTextBoxColumn.HeaderText = "واحد";
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			this.unitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// commodityPriceDataGridViewTextBoxColumn
			// 
			this.commodityPriceDataGridViewTextBoxColumn.DataPropertyName = "CommodityPrice";
			this.commodityPriceDataGridViewTextBoxColumn.HeaderText = "قیمت کالا";
			this.commodityPriceDataGridViewTextBoxColumn.Name = "commodityPriceDataGridViewTextBoxColumn";
			this.commodityPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "قیمت کل";
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// commodityBindingSource
			// 
			this.commodityBindingSource.DataSource = typeof(Models.Commodity);
			// 
			// searchGroupBox
			// 
			this.searchGroupBox.Controls.Add(this.searchPurchaseDateMaskedBox);
			this.searchGroupBox.Controls.Add(this.searchPurchaseDateLabel);
			this.searchGroupBox.Controls.Add(this.searchCommodityNameTextBox);
			this.searchGroupBox.Controls.Add(this.searchCommodityNameLabel);
			this.searchGroupBox.Location = new System.Drawing.Point(15, 66);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.Size = new System.Drawing.Size(616, 77);
			this.searchGroupBox.TabIndex = 3;
			this.searchGroupBox.TabStop = false;
			// 
			// searchPurchaseDateMaskedBox
			// 
			this.searchPurchaseDateMaskedBox.Location = new System.Drawing.Point(6, 45);
			this.searchPurchaseDateMaskedBox.Mask = "0000/00/00";
			this.searchPurchaseDateMaskedBox.Name = "searchPurchaseDateMaskedBox";
			this.searchPurchaseDateMaskedBox.Size = new System.Drawing.Size(543, 22);
			this.searchPurchaseDateMaskedBox.TabIndex = 10;
			this.searchPurchaseDateMaskedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.searchPurchaseDateMaskedBox.TextChanged += new System.EventHandler(this.SearchPurchaseDateMaskedBox_TextChanged);
			// 
			// searchPurchaseDateLabel
			// 
			this.searchPurchaseDateLabel.AutoSize = true;
			this.searchPurchaseDateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchPurchaseDateLabel.Location = new System.Drawing.Point(555, 48);
			this.searchPurchaseDateLabel.Name = "searchPurchaseDateLabel";
			this.searchPurchaseDateLabel.Size = new System.Drawing.Size(55, 13);
			this.searchPurchaseDateLabel.TabIndex = 9;
			this.searchPurchaseDateLabel.Text = "&تاریخ خرید";
			// 
			// searchCommodityNameTextBox
			// 
			this.searchCommodityNameTextBox.ForeColor = System.Drawing.Color.Gray;
			this.searchCommodityNameTextBox.Location = new System.Drawing.Point(6, 17);
			this.searchCommodityNameTextBox.Name = "searchCommodityNameTextBox";
			this.searchCommodityNameTextBox.Size = new System.Drawing.Size(543, 22);
			this.searchCommodityNameTextBox.TabIndex = 8;
			this.searchCommodityNameTextBox.Text = "نام کالا را وارد نمایید...";
			this.searchCommodityNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchCommodityNameTextBox_MouseClick);
			this.searchCommodityNameTextBox.TextChanged += new System.EventHandler(this.SearchCommodityNameTextBox_TextChanged);
			this.searchCommodityNameTextBox.Enter += new System.EventHandler(this.SearchCommodityNameTextBox_Enter);
			this.searchCommodityNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCommodityNameTextBox_KeyPress);
			this.searchCommodityNameTextBox.Leave += new System.EventHandler(this.SearchCommodityNameTextBox_Leave);
			// 
			// searchCommodityNameLabel
			// 
			this.searchCommodityNameLabel.AutoSize = true;
			this.searchCommodityNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchCommodityNameLabel.Location = new System.Drawing.Point(571, 26);
			this.searchCommodityNameLabel.Name = "searchCommodityNameLabel";
			this.searchCommodityNameLabel.Size = new System.Drawing.Size(39, 13);
			this.searchCommodityNameLabel.TabIndex = 7;
			this.searchCommodityNameLabel.Text = "&نام کالا";
			// 
			// CommodityStockForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 473);
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.textLabel);
			this.Controls.Add(this.myDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MinimumSize = new System.Drawing.Size(16, 435);
			this.Name = "CommodityStockForm";
			this.Text = "انبار";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommodityStockForm_FormClosed);
			this.Load += new System.EventHandler(this.CommodityStockForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
			this.searchGroupBox.ResumeLayout(false);
			this.searchGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Mbb.Windows.Forms.Label textLabel;
		public Mbb.Windows.Forms.DataGridView myDataGridView;
		private System.Windows.Forms.BindingSource commodityBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.GroupBox searchGroupBox;
		private Mbb.Windows.Forms.MaskedBox searchPurchaseDateMaskedBox;
		private Mbb.Windows.Forms.Label searchPurchaseDateLabel;
		private Mbb.Windows.Forms.TextBox searchCommodityNameTextBox;
		private Mbb.Windows.Forms.Label searchCommodityNameLabel;
	}
}