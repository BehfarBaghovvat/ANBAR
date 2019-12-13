namespace ANBAR
{
    partial class ReportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
			this.orderDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commodityUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commodityPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buyerNameLabel = new Mbb.Windows.Forms.Label();
			this.buyerNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.orderDateMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.orderDateLabel = new Mbb.Windows.Forms.Label();
			this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("orderDataGridView", this.orderDataGridView);
			this.stiReportDataSource3 = new Stimulsoft.Report.Design.StiReportDataSource("buyerNameTextBox", this.buyerNameTextBox);
			this.stiReportDataSource9 = new Stimulsoft.Report.Design.StiReportDataSource("buyerNameTextBox", this.buyerNameTextBox);
			this.stiReportDataSource10 = new Stimulsoft.Report.Design.StiReportDataSource("orderDateMaskedBox", this.orderDateMaskedBox);
			this.label1 = new Mbb.Windows.Forms.Label();
			this.cellPhoneMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.addressTextBox = new Mbb.Windows.Forms.TextBox();
			this.printFactorButton = new Mbb.Windows.Forms.Button();
			this.stiReport1 = new Stimulsoft.Report.StiReport();
			this.stiReportDataSource11 = new Stimulsoft.Report.Design.StiReportDataSource("buyerNameTextBox", this.buyerNameTextBox);
			this.stiReportDataSource12 = new Stimulsoft.Report.Design.StiReportDataSource("orderDateMaskedBox", this.orderDateMaskedBox);
			this.stiReportDataSource13 = new Stimulsoft.Report.Design.StiReportDataSource("cellPhoneMaskedBox", this.cellPhoneMaskedBox);
			this.stiReportDataSource14 = new Stimulsoft.Report.Design.StiReportDataSource("addressTextBox", this.addressTextBox);
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// orderDataGridView
			// 
			this.orderDataGridView.AllowUserToDeleteRows = false;
			this.orderDataGridView.AutoGenerateColumns = false;
			this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityNameDataGridViewTextBoxColumn,
            this.orderAmountDataGridViewTextBoxColumn,
            this.commodityUnitDataGridViewTextBoxColumn,
            this.commodityPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
			this.orderDataGridView.DataSource = this.customerOrderBindingSource;
			this.orderDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.orderDataGridView.Location = new System.Drawing.Point(0, 195);
			this.orderDataGridView.Name = "orderDataGridView";
			this.orderDataGridView.ReadOnly = true;
			this.orderDataGridView.Size = new System.Drawing.Size(572, 313);
			this.orderDataGridView.TabIndex = 0;
			this.orderDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDataGridView_CellDoubleClick);
			// 
			// commodityNameDataGridViewTextBoxColumn
			// 
			this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
			this.commodityNameDataGridViewTextBoxColumn.HeaderText = "نام کالا";
			this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
			this.commodityNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderAmountDataGridViewTextBoxColumn
			// 
			this.orderAmountDataGridViewTextBoxColumn.DataPropertyName = "OrderAmount";
			this.orderAmountDataGridViewTextBoxColumn.HeaderText = "مقدار سفارش";
			this.orderAmountDataGridViewTextBoxColumn.Name = "orderAmountDataGridViewTextBoxColumn";
			this.orderAmountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// commodityUnitDataGridViewTextBoxColumn
			// 
			this.commodityUnitDataGridViewTextBoxColumn.DataPropertyName = "CommodityUnit";
			this.commodityUnitDataGridViewTextBoxColumn.HeaderText = "واحد";
			this.commodityUnitDataGridViewTextBoxColumn.Name = "commodityUnitDataGridViewTextBoxColumn";
			this.commodityUnitDataGridViewTextBoxColumn.ReadOnly = true;
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
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "جمع کل";
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			this.totalPriceDataGridViewTextBoxColumn.Width = 130;
			// 
			// customerOrderBindingSource
			// 
			this.customerOrderBindingSource.DataSource = typeof(Models.CustomerOrder);
			// 
			// buyerNameLabel
			// 
			this.buyerNameLabel.AutoSize = true;
			this.buyerNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.buyerNameLabel.Location = new System.Drawing.Point(12, 15);
			this.buyerNameLabel.Name = "buyerNameLabel";
			this.buyerNameLabel.Size = new System.Drawing.Size(54, 13);
			this.buyerNameLabel.TabIndex = 1;
			this.buyerNameLabel.Text = "نام مشتری";
			// 
			// buyerNameTextBox
			// 
			this.buyerNameTextBox.Location = new System.Drawing.Point(86, 12);
			this.buyerNameTextBox.MaxLength = 25;
			this.buyerNameTextBox.Name = "buyerNameTextBox";
			this.buyerNameTextBox.Size = new System.Drawing.Size(128, 22);
			this.buyerNameTextBox.TabIndex = 2;
			this.buyerNameTextBox.TextChanged += new System.EventHandler(this.BuyerNameTextBox_TextChanged);
			// 
			// orderDateMaskedBox
			// 
			this.orderDateMaskedBox.Location = new System.Drawing.Point(86, 40);
			this.orderDateMaskedBox.Mask = "0000/00/00";
			this.orderDateMaskedBox.Name = "orderDateMaskedBox";
			this.orderDateMaskedBox.Size = new System.Drawing.Size(128, 22);
			this.orderDateMaskedBox.TabIndex = 3;
			this.orderDateMaskedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.orderDateMaskedBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.OrderDateMaskedBox_MaskInputRejected);
			this.orderDateMaskedBox.TextChanged += new System.EventHandler(this.OrderDateMaskedBox_TextChanged);
			// 
			// orderDateLabel
			// 
			this.orderDateLabel.AutoSize = true;
			this.orderDateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.orderDateLabel.Location = new System.Drawing.Point(12, 43);
			this.orderDateLabel.Name = "orderDateLabel";
			this.orderDateLabel.Size = new System.Drawing.Size(68, 13);
			this.orderDateLabel.TabIndex = 4;
			this.orderDateLabel.Text = "تاریخ سفارش";
			// 
			// stiReportDataSource1
			// 
			this.stiReportDataSource1.Item = this.orderDataGridView;
			this.stiReportDataSource1.Name = "orderDataGridView";
			// 
			// stiReportDataSource3
			// 
			this.stiReportDataSource3.Item = this.buyerNameTextBox;
			this.stiReportDataSource3.Name = "buyerNameTextBox";
			// 
			// stiReportDataSource9
			// 
			this.stiReportDataSource9.Item = this.buyerNameTextBox;
			this.stiReportDataSource9.Name = "buyerNameTextBox";
			// 
			// stiReportDataSource10
			// 
			this.stiReportDataSource10.Item = this.orderDateMaskedBox;
			this.stiReportDataSource10.Name = "orderDateMaskedBox";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "شماره موبایل";
			// 
			// cellPhoneMaskedBox
			// 
			this.cellPhoneMaskedBox.Location = new System.Drawing.Point(86, 68);
			this.cellPhoneMaskedBox.Mask = "0000-000-0000";
			this.cellPhoneMaskedBox.Name = "cellPhoneMaskedBox";
			this.cellPhoneMaskedBox.Size = new System.Drawing.Size(128, 22);
			this.cellPhoneMaskedBox.TabIndex = 7;
			this.cellPhoneMaskedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.cellPhoneMaskedBox.TextChanged += new System.EventHandler(this.CellPhoneMaskedBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "آدرس";
			// 
			// addressTextBox
			// 
			this.addressTextBox.Location = new System.Drawing.Point(86, 96);
			this.addressTextBox.MaxLength = 500;
			this.addressTextBox.Multiline = true;
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.addressTextBox.Size = new System.Drawing.Size(251, 70);
			this.addressTextBox.TabIndex = 9;
			this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
			// 
			// printFactorButton
			// 
			this.printFactorButton.Location = new System.Drawing.Point(451, 166);
			this.printFactorButton.Name = "printFactorButton";
			this.printFactorButton.Size = new System.Drawing.Size(109, 23);
			this.printFactorButton.TabIndex = 10;
			this.printFactorButton.Text = "چاپ فاکتور";
			this.printFactorButton.UseVisualStyleBackColor = true;
			this.printFactorButton.Click += new System.EventHandler(this.PrintFactorButton_Click);
			// 
			// stiReport1
			// 
			this.stiReport1.CookieContainer = null;
			this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
			this.stiReport1.Key = "d086e5ca18504289aa82c45bb787f6a3";
			this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
			this.stiReport1.ReportAlias = "Report";
			this.stiReport1.ReportDataSources.Add(this.stiReportDataSource11);
			this.stiReport1.ReportDataSources.Add(this.stiReportDataSource12);
			this.stiReport1.ReportDataSources.Add(this.stiReportDataSource13);
			this.stiReport1.ReportDataSources.Add(this.stiReportDataSource14);
			this.stiReport1.ReportGuid = "6d122cf342d74a049deb102d5df7592e";
			this.stiReport1.ReportName = "Report";
			this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
			this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
			this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
			this.stiReport1.StoreImagesInResources = true;
			this.stiReport1.UseProgressInThread = false;
			// 
			// stiReportDataSource11
			// 
			this.stiReportDataSource11.Item = this.buyerNameTextBox;
			this.stiReportDataSource11.Name = "buyerNameTextBox";
			// 
			// stiReportDataSource12
			// 
			this.stiReportDataSource12.Item = this.orderDateMaskedBox;
			this.stiReportDataSource12.Name = "orderDateMaskedBox";
			// 
			// stiReportDataSource13
			// 
			this.stiReportDataSource13.Item = this.cellPhoneMaskedBox;
			this.stiReportDataSource13.Name = "cellPhoneMaskedBox";
			// 
			// stiReportDataSource14
			// 
			this.stiReportDataSource14.Item = this.addressTextBox;
			this.stiReportDataSource14.Name = "addressTextBox";
			// 
			// ReportForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 508);
			this.Controls.Add(this.printFactorButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.addressTextBox);
			this.Controls.Add(this.cellPhoneMaskedBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.orderDateLabel);
			this.Controls.Add(this.buyerNameLabel);
			this.Controls.Add(this.orderDateMaskedBox);
			this.Controls.Add(this.buyerNameTextBox);
			this.Controls.Add(this.orderDataGridView);
			this.MaximumSize = new System.Drawing.Size(588, 547);
			this.MinimumSize = new System.Drawing.Size(588, 547);
			this.Name = "ReportForm";
			this.Text = "گزارش سفارش";
			this.Load += new System.EventHandler(this.ReportForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerOrderBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.BindingSource customerOrderBindingSource;
		public Mbb.Windows.Forms.DataGridView orderDataGridView;
		private Mbb.Windows.Forms.Label buyerNameLabel;
		private Mbb.Windows.Forms.Label orderDateLabel;
		public Mbb.Windows.Forms.TextBox buyerNameTextBox;
		public Mbb.Windows.Forms.MaskedBox orderDateMaskedBox;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource2;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource3;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource4;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource5;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource6;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource7;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource8;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource9;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource10;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.MaskedBox cellPhoneMaskedBox;
		private Mbb.Windows.Forms.Label label2;
		public Mbb.Windows.Forms.TextBox addressTextBox;
		private Mbb.Windows.Forms.Button printFactorButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderAmountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityUnitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private Stimulsoft.Report.StiReport stiReport1;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource11;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource12;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource13;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource14;
	}
}