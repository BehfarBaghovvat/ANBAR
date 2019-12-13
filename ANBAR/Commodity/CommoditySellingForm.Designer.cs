namespace ANBAR
{
	partial class CommoditySellingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommoditySellingForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.myDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.commodityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commodityPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commodityPicturDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchCommodityNameLabel = new Mbb.Windows.Forms.Label();
			this.searchCommodityNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.BuyerProfileGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.toDayButton = new Mbb.Windows.Forms.Button();
			this.phonNumberMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.phoneNumberLabel = new Mbb.Windows.Forms.Label();
			this.cellPhoneMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.orderDateMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.addressTextBox = new Mbb.Windows.Forms.TextBox();
			this.addressLabel = new Mbb.Windows.Forms.Label();
			this.buyerNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.buyerNameLabel = new Mbb.Windows.Forms.Label();
			this.cellPhoneLabel = new Mbb.Windows.Forms.Label();
			this.orderDateLabel = new Mbb.Windows.Forms.Label();
			this.commodityProfileGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.unitComboBox = new Mbb.Windows.Forms.ComboBox();
			this.pictureGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.commodityImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.currencyLabel2 = new Mbb.Windows.Forms.Label();
			this.currencyLabel1 = new Mbb.Windows.Forms.Label();
			this.totalPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.totalPriceLabel = new Mbb.Windows.Forms.Label();
			this.commodityNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.commodityPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.commodityNameLabel = new Mbb.Windows.Forms.Label();
			this.commodityPriceLabel = new Mbb.Windows.Forms.Label();
			this.quantityLabel = new Mbb.Windows.Forms.Label();
			this.quantityTextBox = new Mbb.Windows.Forms.TextBox();
			this.stiReportDataSource4 = new Stimulsoft.Report.Design.StiReportDataSource("phonNumberMaskedBox", this.phonNumberMaskedBox);
			this.stiReportDataSource5 = new Stimulsoft.Report.Design.StiReportDataSource("cellPhoneMaskedBox", this.cellPhoneMaskedBox);
			this.stiReportDataSource6 = new Stimulsoft.Report.Design.StiReportDataSource("orderDateMaskedBox", this.orderDateMaskedBox);
			this.stiReportDataSource7 = new Stimulsoft.Report.Design.StiReportDataSource("addressTextBox", this.addressTextBox);
			this.stiReportDataSource8 = new Stimulsoft.Report.Design.StiReportDataSource("buyerNameTextBox", this.buyerNameTextBox);
			this.stiReportDataSource9 = new Stimulsoft.Report.Design.StiReportDataSource("unitComboBox", this.unitComboBox);
			this.stiReportDataSource10 = new Stimulsoft.Report.Design.StiReportDataSource("totalPriceTextBox", this.totalPriceTextBox);
			this.stiReportDataSource11 = new Stimulsoft.Report.Design.StiReportDataSource("commodityNameTextBox", this.commodityNameTextBox);
			this.stiReportDataSource12 = new Stimulsoft.Report.Design.StiReportDataSource("commodityPriceTextBox", this.commodityPriceTextBox);
			this.stiReportDataSource13 = new Stimulsoft.Report.Design.StiReportDataSource("quantityTextBox", this.quantityTextBox);
			this.stiReportDataSource1 = new Stimulsoft.Report.Design.StiReportDataSource("myDataGridView", this.myDataGridView);
			this.stiReportDataSource2 = new Stimulsoft.Report.Design.StiReportDataSource("CommoditySellingForm", this);
			this.stiReportDataSource3 = new Stimulsoft.Report.Design.StiReportDataSource("commodityNameTextBox", this.commodityNameTextBox);
			this.showDocumentButton = new Mbb.Windows.Forms.Button();
			this.orderButton = new Mbb.Windows.Forms.Button();
			this.searchGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.stiReport1 = new Stimulsoft.Report.StiReport();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
			this.BuyerProfileGroupBox.SuspendLayout();
			this.commodityProfileGroupBox.SuspendLayout();
			this.pictureGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.commodityImagePicturBox)).BeginInit();
			this.searchGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// myDataGridView
			// 
			this.myDataGridView.AllowUserToAddRows = false;
			this.myDataGridView.AllowUserToDeleteRows = false;
			resources.ApplyResources(this.myDataGridView, "myDataGridView");
			this.myDataGridView.AutoGenerateColumns = false;
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commodityNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.commodityPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.commodityPicturDataGridViewImageColumn});
			this.myDataGridView.DataSource = this.commodityBindingSource;
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.ReadOnly = true;
			this.myDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataGridView_CellDoubleClick);
			// 
			// commodityNameDataGridViewTextBoxColumn
			// 
			this.commodityNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.commodityNameDataGridViewTextBoxColumn.DataPropertyName = "CommodityName";
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.commodityNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
			resources.ApplyResources(this.commodityNameDataGridViewTextBoxColumn, "commodityNameDataGridViewTextBoxColumn");
			this.commodityNameDataGridViewTextBoxColumn.MaxInputLength = 50;
			this.commodityNameDataGridViewTextBoxColumn.Name = "commodityNameDataGridViewTextBoxColumn";
			this.commodityNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			resources.ApplyResources(this.quantityDataGridViewTextBoxColumn, "quantityDataGridViewTextBoxColumn");
			this.quantityDataGridViewTextBoxColumn.MaxInputLength = 5;
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// unitDataGridViewTextBoxColumn
			// 
			this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
			resources.ApplyResources(this.unitDataGridViewTextBoxColumn, "unitDataGridViewTextBoxColumn");
			this.unitDataGridViewTextBoxColumn.MaxInputLength = 15;
			this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
			this.unitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// commodityPriceDataGridViewTextBoxColumn
			// 
			this.commodityPriceDataGridViewTextBoxColumn.DataPropertyName = "CommodityPrice";
			resources.ApplyResources(this.commodityPriceDataGridViewTextBoxColumn, "commodityPriceDataGridViewTextBoxColumn");
			this.commodityPriceDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.commodityPriceDataGridViewTextBoxColumn.Name = "commodityPriceDataGridViewTextBoxColumn";
			this.commodityPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
			resources.ApplyResources(this.totalPriceDataGridViewTextBoxColumn, "totalPriceDataGridViewTextBoxColumn");
			this.totalPriceDataGridViewTextBoxColumn.MaxInputLength = 25;
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// commodityPicturDataGridViewImageColumn
			// 
			this.commodityPicturDataGridViewImageColumn.DataPropertyName = "CommodityPictur";
			resources.ApplyResources(this.commodityPicturDataGridViewImageColumn, "commodityPicturDataGridViewImageColumn");
			this.commodityPicturDataGridViewImageColumn.Name = "commodityPicturDataGridViewImageColumn";
			this.commodityPicturDataGridViewImageColumn.ReadOnly = true;
			// 
			// commodityBindingSource
			// 
			this.commodityBindingSource.DataSource = typeof(Models.Commodity);
			// 
			// searchCommodityNameLabel
			// 
			resources.ApplyResources(this.searchCommodityNameLabel, "searchCommodityNameLabel");
			this.searchCommodityNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchCommodityNameLabel.Name = "searchCommodityNameLabel";
			// 
			// searchCommodityNameTextBox
			// 
			this.searchCommodityNameTextBox.ForeColor = System.Drawing.Color.Gray;
			resources.ApplyResources(this.searchCommodityNameTextBox, "searchCommodityNameTextBox");
			this.searchCommodityNameTextBox.Name = "searchCommodityNameTextBox";
			this.searchCommodityNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchCommodityNameTextBox_MouseClick);
			this.searchCommodityNameTextBox.TextChanged += new System.EventHandler(this.SearchCommodityNameTextBox_TextChanged);
			this.searchCommodityNameTextBox.Enter += new System.EventHandler(this.SearchCommodityNameTextBox_Enter);
			this.searchCommodityNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchCommodityNameTextBox_KeyPress);
			this.searchCommodityNameTextBox.Leave += new System.EventHandler(this.SearchCommodityNameTextBox_Leave);
			// 
			// BuyerProfileGroupBox
			// 
			resources.ApplyResources(this.BuyerProfileGroupBox, "BuyerProfileGroupBox");
			this.BuyerProfileGroupBox.Controls.Add(this.descriptionTextBox);
			this.BuyerProfileGroupBox.Controls.Add(this.label1);
			this.BuyerProfileGroupBox.Controls.Add(this.toDayButton);
			this.BuyerProfileGroupBox.Controls.Add(this.phonNumberMaskedBox);
			this.BuyerProfileGroupBox.Controls.Add(this.phoneNumberLabel);
			this.BuyerProfileGroupBox.Controls.Add(this.cellPhoneMaskedBox);
			this.BuyerProfileGroupBox.Controls.Add(this.orderDateMaskedBox);
			this.BuyerProfileGroupBox.Controls.Add(this.addressTextBox);
			this.BuyerProfileGroupBox.Controls.Add(this.addressLabel);
			this.BuyerProfileGroupBox.Controls.Add(this.buyerNameTextBox);
			this.BuyerProfileGroupBox.Controls.Add(this.buyerNameLabel);
			this.BuyerProfileGroupBox.Controls.Add(this.cellPhoneLabel);
			this.BuyerProfileGroupBox.Controls.Add(this.orderDateLabel);
			this.BuyerProfileGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.BuyerProfileGroupBox.Name = "BuyerProfileGroupBox";
			this.BuyerProfileGroupBox.TabStop = false;
			// 
			// descriptionTextBox
			// 
			resources.ApplyResources(this.descriptionTextBox, "descriptionTextBox");
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// toDayButton
			// 
			this.toDayButton.ForeColor = System.Drawing.SystemColors.ControlText;
			resources.ApplyResources(this.toDayButton, "toDayButton");
			this.toDayButton.Name = "toDayButton";
			this.toDayButton.UseVisualStyleBackColor = true;
			this.toDayButton.Click += new System.EventHandler(this.ToDayButton_Click);
			// 
			// phonNumberMaskedBox
			// 
			resources.ApplyResources(this.phonNumberMaskedBox, "phonNumberMaskedBox");
			this.phonNumberMaskedBox.Name = "phonNumberMaskedBox";
			this.phonNumberMaskedBox.TextChanged += new System.EventHandler(this.PhonNumberMaskedBox_TextChanged);
			// 
			// phoneNumberLabel
			// 
			resources.ApplyResources(this.phoneNumberLabel, "phoneNumberLabel");
			this.phoneNumberLabel.Name = "phoneNumberLabel";
			// 
			// cellPhoneMaskedBox
			// 
			resources.ApplyResources(this.cellPhoneMaskedBox, "cellPhoneMaskedBox");
			this.cellPhoneMaskedBox.Name = "cellPhoneMaskedBox";
			this.cellPhoneMaskedBox.TextChanged += new System.EventHandler(this.CellPhoneMaskedBox_TextChanged);
			// 
			// orderDateMaskedBox
			// 
			resources.ApplyResources(this.orderDateMaskedBox, "orderDateMaskedBox");
			this.orderDateMaskedBox.Name = "orderDateMaskedBox";
			this.orderDateMaskedBox.TextChanged += new System.EventHandler(this.OrderDateMaskedBox_TextChanged);
			// 
			// addressTextBox
			// 
			resources.ApplyResources(this.addressTextBox, "addressTextBox");
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
			// 
			// addressLabel
			// 
			resources.ApplyResources(this.addressLabel, "addressLabel");
			this.addressLabel.Name = "addressLabel";
			// 
			// buyerNameTextBox
			// 
			resources.ApplyResources(this.buyerNameTextBox, "buyerNameTextBox");
			this.buyerNameTextBox.Name = "buyerNameTextBox";
			this.buyerNameTextBox.TextChanged += new System.EventHandler(this.BuyerNameTextBox_TextChanged);
			// 
			// buyerNameLabel
			// 
			resources.ApplyResources(this.buyerNameLabel, "buyerNameLabel");
			this.buyerNameLabel.Name = "buyerNameLabel";
			// 
			// cellPhoneLabel
			// 
			resources.ApplyResources(this.cellPhoneLabel, "cellPhoneLabel");
			this.cellPhoneLabel.Name = "cellPhoneLabel";
			// 
			// orderDateLabel
			// 
			resources.ApplyResources(this.orderDateLabel, "orderDateLabel");
			this.orderDateLabel.Name = "orderDateLabel";
			// 
			// commodityProfileGroupBox
			// 
			resources.ApplyResources(this.commodityProfileGroupBox, "commodityProfileGroupBox");
			this.commodityProfileGroupBox.Controls.Add(this.unitComboBox);
			this.commodityProfileGroupBox.Controls.Add(this.pictureGroupBox);
			this.commodityProfileGroupBox.Controls.Add(this.currencyLabel2);
			this.commodityProfileGroupBox.Controls.Add(this.currencyLabel1);
			this.commodityProfileGroupBox.Controls.Add(this.totalPriceTextBox);
			this.commodityProfileGroupBox.Controls.Add(this.totalPriceLabel);
			this.commodityProfileGroupBox.Controls.Add(this.commodityNameTextBox);
			this.commodityProfileGroupBox.Controls.Add(this.commodityPriceTextBox);
			this.commodityProfileGroupBox.Controls.Add(this.commodityNameLabel);
			this.commodityProfileGroupBox.Controls.Add(this.commodityPriceLabel);
			this.commodityProfileGroupBox.Controls.Add(this.quantityLabel);
			this.commodityProfileGroupBox.Controls.Add(this.quantityTextBox);
			this.commodityProfileGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.commodityProfileGroupBox.Name = "commodityProfileGroupBox";
			this.commodityProfileGroupBox.TabStop = false;
			// 
			// unitComboBox
			// 
			this.unitComboBox.FormattingEnabled = true;
			this.unitComboBox.Items.AddRange(new object[] {
            resources.GetString("unitComboBox.Items"),
            resources.GetString("unitComboBox.Items1"),
            resources.GetString("unitComboBox.Items2"),
            resources.GetString("unitComboBox.Items3"),
            resources.GetString("unitComboBox.Items4"),
            resources.GetString("unitComboBox.Items5"),
            resources.GetString("unitComboBox.Items6")});
			resources.ApplyResources(this.unitComboBox, "unitComboBox");
			this.unitComboBox.Name = "unitComboBox";
			this.unitComboBox.TextChanged += new System.EventHandler(this.UnitComboBox_TextChanged);
			// 
			// pictureGroupBox
			// 
			resources.ApplyResources(this.pictureGroupBox, "pictureGroupBox");
			this.pictureGroupBox.Controls.Add(this.commodityImagePicturBox);
			this.pictureGroupBox.Name = "pictureGroupBox";
			this.pictureGroupBox.TabStop = false;
			// 
			// commodityImagePicturBox
			// 
			resources.ApplyResources(this.commodityImagePicturBox, "commodityImagePicturBox");
			this.commodityImagePicturBox.Name = "commodityImagePicturBox";
			this.commodityImagePicturBox.TabStop = false;
			// 
			// currencyLabel2
			// 
			resources.ApplyResources(this.currencyLabel2, "currencyLabel2");
			this.currencyLabel2.Name = "currencyLabel2";
			// 
			// currencyLabel1
			// 
			resources.ApplyResources(this.currencyLabel1, "currencyLabel1");
			this.currencyLabel1.Name = "currencyLabel1";
			// 
			// totalPriceTextBox
			// 
			resources.ApplyResources(this.totalPriceTextBox, "totalPriceTextBox");
			this.totalPriceTextBox.Name = "totalPriceTextBox";
			// 
			// totalPriceLabel
			// 
			resources.ApplyResources(this.totalPriceLabel, "totalPriceLabel");
			this.totalPriceLabel.Name = "totalPriceLabel";
			// 
			// commodityNameTextBox
			// 
			resources.ApplyResources(this.commodityNameTextBox, "commodityNameTextBox");
			this.commodityNameTextBox.Name = "commodityNameTextBox";
			this.commodityNameTextBox.TextChanged += new System.EventHandler(this.CommodityNameTextBox_TextChanged);
			// 
			// commodityPriceTextBox
			// 
			resources.ApplyResources(this.commodityPriceTextBox, "commodityPriceTextBox");
			this.commodityPriceTextBox.Name = "commodityPriceTextBox";
			this.commodityPriceTextBox.TextChanged += new System.EventHandler(this.CommodityPriceTextBox_TextChanged);
			this.commodityPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommodityPriceTextBox_KeyPress);
			// 
			// commodityNameLabel
			// 
			resources.ApplyResources(this.commodityNameLabel, "commodityNameLabel");
			this.commodityNameLabel.Name = "commodityNameLabel";
			// 
			// commodityPriceLabel
			// 
			resources.ApplyResources(this.commodityPriceLabel, "commodityPriceLabel");
			this.commodityPriceLabel.Name = "commodityPriceLabel";
			// 
			// quantityLabel
			// 
			resources.ApplyResources(this.quantityLabel, "quantityLabel");
			this.quantityLabel.Name = "quantityLabel";
			// 
			// quantityTextBox
			// 
			resources.ApplyResources(this.quantityTextBox, "quantityTextBox");
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
			this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
			this.quantityTextBox.Leave += new System.EventHandler(this.QuantityTextBox_Leave);
			// 
			// stiReportDataSource4
			// 
			this.stiReportDataSource4.Item = this.phonNumberMaskedBox;
			this.stiReportDataSource4.Name = "phonNumberMaskedBox";
			// 
			// stiReportDataSource5
			// 
			this.stiReportDataSource5.Item = this.cellPhoneMaskedBox;
			this.stiReportDataSource5.Name = "cellPhoneMaskedBox";
			// 
			// stiReportDataSource6
			// 
			this.stiReportDataSource6.Item = this.orderDateMaskedBox;
			this.stiReportDataSource6.Name = "orderDateMaskedBox";
			// 
			// stiReportDataSource7
			// 
			this.stiReportDataSource7.Item = this.addressTextBox;
			this.stiReportDataSource7.Name = "addressTextBox";
			// 
			// stiReportDataSource8
			// 
			this.stiReportDataSource8.Item = this.buyerNameTextBox;
			this.stiReportDataSource8.Name = "buyerNameTextBox";
			// 
			// stiReportDataSource9
			// 
			this.stiReportDataSource9.Item = this.unitComboBox;
			this.stiReportDataSource9.Name = "unitComboBox";
			// 
			// stiReportDataSource10
			// 
			this.stiReportDataSource10.Item = this.totalPriceTextBox;
			this.stiReportDataSource10.Name = "totalPriceTextBox";
			// 
			// stiReportDataSource11
			// 
			this.stiReportDataSource11.Item = this.commodityNameTextBox;
			this.stiReportDataSource11.Name = "commodityNameTextBox";
			// 
			// stiReportDataSource12
			// 
			this.stiReportDataSource12.Item = this.commodityPriceTextBox;
			this.stiReportDataSource12.Name = "commodityPriceTextBox";
			// 
			// stiReportDataSource13
			// 
			this.stiReportDataSource13.Item = this.quantityTextBox;
			this.stiReportDataSource13.Name = "quantityTextBox";
			// 
			// stiReportDataSource1
			// 
			this.stiReportDataSource1.Item = this.myDataGridView;
			this.stiReportDataSource1.Name = "myDataGridView";
			// 
			// stiReportDataSource2
			// 
			this.stiReportDataSource2.Item = this;
			this.stiReportDataSource2.Name = "CommoditySellingForm";
			// 
			// stiReportDataSource3
			// 
			this.stiReportDataSource3.Item = this.commodityNameTextBox;
			this.stiReportDataSource3.Name = "commodityNameTextBox";
			// 
			// showDocumentButton
			// 
			resources.ApplyResources(this.showDocumentButton, "showDocumentButton");
			this.showDocumentButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.showDocumentButton.Name = "showDocumentButton";
			this.showDocumentButton.UseVisualStyleBackColor = true;
			this.showDocumentButton.Click += new System.EventHandler(this.ShowDocumentButton_Click);
			// 
			// orderButton
			// 
			resources.ApplyResources(this.orderButton, "orderButton");
			this.orderButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.orderButton.Name = "orderButton";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
			// 
			// searchGroupBox
			// 
			resources.ApplyResources(this.searchGroupBox, "searchGroupBox");
			this.searchGroupBox.Controls.Add(this.searchCommodityNameLabel);
			this.searchGroupBox.Controls.Add(this.searchCommodityNameTextBox);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.TabStop = false;
			// 
			// stiReport1
			// 
			this.stiReport1.CookieContainer = null;
			this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
			this.stiReport1.Key = "c196d6527d4e4bdd9bd338c778b181f3";
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
			this.stiReport1.ReportGuid = "e67c0d6252b0442492d101e3a4657f02";
			this.stiReport1.ReportName = "Report";
			this.stiReport1.ReportSource = null;
			this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Centimeters;
			this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
			this.stiReport1.StoreImagesInResources = true;
			this.stiReport1.UseProgressInThread = false;
			// 
			// CommoditySellingForm
			// 
			this.AcceptButton = this.orderButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.showDocumentButton);
			this.Controls.Add(this.orderButton);
			this.Controls.Add(this.BuyerProfileGroupBox);
			this.Controls.Add(this.commodityProfileGroupBox);
			this.Controls.Add(this.myDataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "CommoditySellingForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CommoditySellingForm_FormClosed);
			this.Load += new System.EventHandler(this.CommoditySellingForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
			this.BuyerProfileGroupBox.ResumeLayout(false);
			this.BuyerProfileGroupBox.PerformLayout();
			this.commodityProfileGroupBox.ResumeLayout(false);
			this.commodityProfileGroupBox.PerformLayout();
			this.pictureGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.commodityImagePicturBox)).EndInit();
			this.searchGroupBox.ResumeLayout(false);
			this.searchGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.DataGridView myDataGridView;
		private Mbb.Windows.Forms.Label searchCommodityNameLabel;
		private Mbb.Windows.Forms.TextBox searchCommodityNameTextBox;
		private Mbb.Windows.Forms.GroupBox BuyerProfileGroupBox;
		private Mbb.Windows.Forms.MaskedBox phonNumberMaskedBox;
		private Mbb.Windows.Forms.Label phoneNumberLabel;
		private Mbb.Windows.Forms.MaskedBox cellPhoneMaskedBox;
		private Mbb.Windows.Forms.TextBox addressTextBox;
		private Mbb.Windows.Forms.Label addressLabel;
		private Mbb.Windows.Forms.Label buyerNameLabel;
		private Mbb.Windows.Forms.Label cellPhoneLabel;
		private Mbb.Windows.Forms.Label orderDateLabel;
		private Mbb.Windows.Forms.GroupBox commodityProfileGroupBox;
		private Mbb.Windows.Forms.GroupBox pictureGroupBox;
		private Mbb.Windows.Forms.PicturBox commodityImagePicturBox;
		private Mbb.Windows.Forms.Label currencyLabel2;
		private Mbb.Windows.Forms.Label currencyLabel1;
		private Mbb.Windows.Forms.TextBox totalPriceTextBox;
		private Mbb.Windows.Forms.Label totalPriceLabel;
		private Mbb.Windows.Forms.TextBox commodityNameTextBox;
		private Mbb.Windows.Forms.TextBox commodityPriceTextBox;
		private Mbb.Windows.Forms.Label commodityNameLabel;
		private Mbb.Windows.Forms.Label commodityPriceLabel;
		private Mbb.Windows.Forms.Label quantityLabel;
		private Mbb.Windows.Forms.TextBox quantityTextBox;
		private Mbb.Windows.Forms.ComboBox unitComboBox;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource4;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource5;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource6;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource7;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource8;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource9;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource10;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource11;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource12;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource13;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource1;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource2;
		private Stimulsoft.Report.Design.StiReportDataSource stiReportDataSource3;
		private Mbb.Windows.Forms.Button orderButton;
		private Mbb.Windows.Forms.Button showDocumentButton;
		private Mbb.Windows.Forms.GroupBox searchGroupBox;
		private System.Windows.Forms.BindingSource commodityBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commodityPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn commodityPicturDataGridViewImageColumn;
		private Mbb.Windows.Forms.Button toDayButton;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.Label label1;
		private Stimulsoft.Report.StiReport stiReport1;
		public Mbb.Windows.Forms.MaskedBox orderDateMaskedBox;
		public Mbb.Windows.Forms.TextBox buyerNameTextBox;
	}
}