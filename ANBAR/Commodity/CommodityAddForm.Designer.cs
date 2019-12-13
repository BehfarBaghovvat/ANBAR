namespace ANBAR
{
	partial class CommodityAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommodityAddForm));
			this.buttonGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.exitButton = new Mbb.Windows.Forms.Button();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.quantityTextBox = new Mbb.Windows.Forms.TextBox();
			this.addPicturelinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.informationCommodityGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.currentDayButton = new Mbb.Windows.Forms.Button();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.descriptionLabel = new Mbb.Windows.Forms.Label();
			this.purchaseDateLabel = new Mbb.Windows.Forms.Label();
			this.purchaseDateMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.selleryNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.selleryNameLabel = new Mbb.Windows.Forms.Label();
			this.currencylabel2 = new Mbb.Windows.Forms.Label();
			this.totalPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.totalPriceLabel = new Mbb.Windows.Forms.Label();
			this.currencyLabel1 = new Mbb.Windows.Forms.Label();
			this.commodityPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.unitPriceLabel = new Mbb.Windows.Forms.Label();
			this.quantityLabel = new Mbb.Windows.Forms.Label();
			this.unitComboBox = new Mbb.Windows.Forms.ComboBox();
			this.commodityNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.nameCommodityLabel = new Mbb.Windows.Forms.Label();
			this.deletePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.groupBox = new Mbb.Windows.Forms.GroupBox();
			this.commodityImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.buttonGroupBox.SuspendLayout();
			this.informationCommodityGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.deletePicturBox)).BeginInit();
			this.groupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.commodityImagePicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonGroupBox
			// 
			this.buttonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGroupBox.Controls.Add(this.exitButton);
			this.buttonGroupBox.Controls.Add(this.resetButton);
			this.buttonGroupBox.Controls.Add(this.saveButton);
			this.buttonGroupBox.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonGroupBox.Location = new System.Drawing.Point(308, 260);
			this.buttonGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonGroupBox.Name = "buttonGroupBox";
			this.buttonGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonGroupBox.Size = new System.Drawing.Size(148, 313);
			this.buttonGroupBox.TabIndex = 2;
			this.buttonGroupBox.TabStop = false;
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.ForeColor = System.Drawing.Color.SlateBlue;
			this.exitButton.Location = new System.Drawing.Point(6, 179);
			this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(136, 30);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "&خروج";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.resetButton.ForeColor = System.Drawing.Color.SlateBlue;
			this.resetButton.Location = new System.Drawing.Point(6, 141);
			this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(136, 30);
			this.resetButton.TabIndex = 1;
			this.resetButton.Text = "&حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.saveButton.ForeColor = System.Drawing.Color.SlateBlue;
			this.saveButton.Location = new System.Drawing.Point(6, 103);
			this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(136, 30);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "&ذخیره";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// quantityTextBox
			// 
			this.quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.quantityTextBox.HideSelection = false;
			this.quantityTextBox.Location = new System.Drawing.Point(137, 136);
			this.quantityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.quantityTextBox.MaxLength = 10;
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.quantityTextBox.Size = new System.Drawing.Size(66, 25);
			this.quantityTextBox.TabIndex = 8;
			this.quantityTextBox.Text = "0";
			this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.quantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
			this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QuantityTextBox_KeyPress);
			// 
			// addPicturelinkLabel
			// 
			this.addPicturelinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addPicturelinkLabel.AutoSize = true;
			this.addPicturelinkLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.addPicturelinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.addPicturelinkLabel.LinkColor = System.Drawing.SystemColors.Window;
			this.addPicturelinkLabel.Location = new System.Drawing.Point(349, 228);
			this.addPicturelinkLabel.Name = "addPicturelinkLabel";
			this.addPicturelinkLabel.Size = new System.Drawing.Size(65, 17);
			this.addPicturelinkLabel.TabIndex = 1;
			this.addPicturelinkLabel.TabStop = true;
			this.addPicturelinkLabel.Text = "افزودن عکس";
			this.addPicturelinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.addPicturelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPicturelinkLabel_LinkClicked);
			// 
			// informationCommodityGroupBox
			// 
			this.informationCommodityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.informationCommodityGroupBox.Controls.Add(this.currentDayButton);
			this.informationCommodityGroupBox.Controls.Add(this.descriptionTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.descriptionLabel);
			this.informationCommodityGroupBox.Controls.Add(this.purchaseDateLabel);
			this.informationCommodityGroupBox.Controls.Add(this.purchaseDateMaskedBox);
			this.informationCommodityGroupBox.Controls.Add(this.selleryNameTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.quantityTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.selleryNameLabel);
			this.informationCommodityGroupBox.Controls.Add(this.currencylabel2);
			this.informationCommodityGroupBox.Controls.Add(this.totalPriceTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.totalPriceLabel);
			this.informationCommodityGroupBox.Controls.Add(this.currencyLabel1);
			this.informationCommodityGroupBox.Controls.Add(this.commodityPriceTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.unitPriceLabel);
			this.informationCommodityGroupBox.Controls.Add(this.quantityLabel);
			this.informationCommodityGroupBox.Controls.Add(this.unitComboBox);
			this.informationCommodityGroupBox.Controls.Add(this.commodityNameTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.nameCommodityLabel);
			this.informationCommodityGroupBox.ForeColor = System.Drawing.SystemColors.Window;
			this.informationCommodityGroupBox.Location = new System.Drawing.Point(12, 16);
			this.informationCommodityGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.informationCommodityGroupBox.Name = "informationCommodityGroupBox";
			this.informationCommodityGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.informationCommodityGroupBox.Size = new System.Drawing.Size(290, 557);
			this.informationCommodityGroupBox.TabIndex = 0;
			this.informationCommodityGroupBox.TabStop = false;
			this.informationCommodityGroupBox.Text = "مشخصات کالا";
			// 
			// currentDayButton
			// 
			this.currentDayButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.currentDayButton.Location = new System.Drawing.Point(13, 101);
			this.currentDayButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.currentDayButton.Name = "currentDayButton";
			this.currentDayButton.Size = new System.Drawing.Size(75, 30);
			this.currentDayButton.TabIndex = 6;
			this.currentDayButton.Text = "ام&روز";
			this.currentDayButton.UseVisualStyleBackColor = true;
			this.currentDayButton.Click += new System.EventHandler(this.ToDayButton_Click);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(13, 247);
			this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.descriptionTextBox.MaxLength = 10000;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(191, 301);
			this.descriptionTextBox.TabIndex = 17;
			this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(233, 251);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(51, 17);
			this.descriptionLabel.TabIndex = 16;
			this.descriptionLabel.Text = "ت&وضیحات";
			// 
			// purchaseDateLabel
			// 
			this.purchaseDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.purchaseDateLabel.AutoSize = true;
			this.purchaseDateLabel.Location = new System.Drawing.Point(210, 105);
			this.purchaseDateLabel.Name = "purchaseDateLabel";
			this.purchaseDateLabel.Size = new System.Drawing.Size(75, 17);
			this.purchaseDateLabel.TabIndex = 4;
			this.purchaseDateLabel.Text = "&تاریخ خرید کالا";
			// 
			// purchaseDateMaskedBox
			// 
			this.purchaseDateMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.purchaseDateMaskedBox.Location = new System.Drawing.Point(94, 101);
			this.purchaseDateMaskedBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.purchaseDateMaskedBox.Mask = "0000/00/00";
			this.purchaseDateMaskedBox.Name = "purchaseDateMaskedBox";
			this.purchaseDateMaskedBox.Size = new System.Drawing.Size(110, 25);
			this.purchaseDateMaskedBox.TabIndex = 5;
			this.purchaseDateMaskedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.purchaseDateMaskedBox.TextChanged += new System.EventHandler(this.PurchaseDateMaskedBox_TextChanged);
			// 
			// selleryNameTextBox
			// 
			this.selleryNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.selleryNameTextBox.Location = new System.Drawing.Point(13, 64);
			this.selleryNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.selleryNameTextBox.MaxLength = 20;
			this.selleryNameTextBox.Name = "selleryNameTextBox";
			this.selleryNameTextBox.Size = new System.Drawing.Size(191, 25);
			this.selleryNameTextBox.TabIndex = 3;
			// 
			// selleryNameLabel
			// 
			this.selleryNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.selleryNameLabel.AutoSize = true;
			this.selleryNameLabel.Location = new System.Drawing.Point(220, 68);
			this.selleryNameLabel.Name = "selleryNameLabel";
			this.selleryNameLabel.Size = new System.Drawing.Size(58, 17);
			this.selleryNameLabel.TabIndex = 2;
			this.selleryNameLabel.Text = "نام &فروشنده";
			// 
			// currencylabel2
			// 
			this.currencylabel2.AutoSize = true;
			this.currencylabel2.Location = new System.Drawing.Point(13, 214);
			this.currencylabel2.Name = "currencylabel2";
			this.currencylabel2.Size = new System.Drawing.Size(34, 17);
			this.currencylabel2.TabIndex = 15;
			this.currencylabel2.Text = "تومان";
			// 
			// totalPriceTextBox
			// 
			this.totalPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.totalPriceTextBox.Location = new System.Drawing.Point(52, 211);
			this.totalPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.totalPriceTextBox.MaxLength = 20;
			this.totalPriceTextBox.Name = "totalPriceTextBox";
			this.totalPriceTextBox.ReadOnly = true;
			this.totalPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.totalPriceTextBox.Size = new System.Drawing.Size(152, 25);
			this.totalPriceTextBox.TabIndex = 14;
			this.totalPriceTextBox.Text = "0";
			this.totalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.totalPriceTextBox.TextChanged += new System.EventHandler(this.TotalPriceTextBox_TextChanged);
			// 
			// totalPriceLabel
			// 
			this.totalPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.totalPriceLabel.AutoSize = true;
			this.totalPriceLabel.Location = new System.Drawing.Point(243, 214);
			this.totalPriceLabel.Name = "totalPriceLabel";
			this.totalPriceLabel.Size = new System.Drawing.Size(43, 17);
			this.totalPriceLabel.TabIndex = 13;
			this.totalPriceLabel.Text = "&جمع کل";
			// 
			// currencyLabel1
			// 
			this.currencyLabel1.AutoSize = true;
			this.currencyLabel1.Location = new System.Drawing.Point(13, 178);
			this.currencyLabel1.Name = "currencyLabel1";
			this.currencyLabel1.Size = new System.Drawing.Size(34, 17);
			this.currencyLabel1.TabIndex = 12;
			this.currencyLabel1.Text = "تومان";
			// 
			// commodityPriceTextBox
			// 
			this.commodityPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.commodityPriceTextBox.Location = new System.Drawing.Point(52, 174);
			this.commodityPriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.commodityPriceTextBox.MaxLength = 15;
			this.commodityPriceTextBox.Name = "commodityPriceTextBox";
			this.commodityPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.commodityPriceTextBox.Size = new System.Drawing.Size(152, 25);
			this.commodityPriceTextBox.TabIndex = 11;
			this.commodityPriceTextBox.Text = "0";
			this.commodityPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.commodityPriceTextBox.TextChanged += new System.EventHandler(this.CommodityPriceTextBox_TextChanged);
			this.commodityPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CommodityPriceTextBox_KeyPress);
			// 
			// unitPriceLabel
			// 
			this.unitPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.unitPriceLabel.AutoSize = true;
			this.unitPriceLabel.Location = new System.Drawing.Point(232, 178);
			this.unitPriceLabel.Name = "unitPriceLabel";
			this.unitPriceLabel.Size = new System.Drawing.Size(50, 17);
			this.unitPriceLabel.TabIndex = 10;
			this.unitPriceLabel.Text = "&قیمت کالا";
			// 
			// quantityLabel
			// 
			this.quantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.quantityLabel.AutoSize = true;
			this.quantityLabel.Location = new System.Drawing.Point(232, 141);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(49, 17);
			this.quantityLabel.TabIndex = 7;
			this.quantityLabel.Text = "مق&دار کالا";
			// 
			// unitComboBox
			// 
			this.unitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.unitComboBox.FormattingEnabled = true;
			this.unitComboBox.Items.AddRange(new object[] {
            "مثقال",
            "گرم",
            "کیلوگرم",
            "تن",
            "عدد",
            "کارتن",
            "بسته"});
			this.unitComboBox.Location = new System.Drawing.Point(13, 137);
			this.unitComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.unitComboBox.Name = "unitComboBox";
			this.unitComboBox.Size = new System.Drawing.Size(118, 25);
			this.unitComboBox.TabIndex = 9;
			this.unitComboBox.Text = "واحد کالا...";
			this.unitComboBox.SelectedValueChanged += new System.EventHandler(this.UnitComboBox_SelectedValueChanged);
			// 
			// commodityNameTextBox
			// 
			this.commodityNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.commodityNameTextBox.Location = new System.Drawing.Point(13, 27);
			this.commodityNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.commodityNameTextBox.MaxLength = 50;
			this.commodityNameTextBox.Name = "commodityNameTextBox";
			this.commodityNameTextBox.Size = new System.Drawing.Size(191, 25);
			this.commodityNameTextBox.TabIndex = 1;
			this.commodityNameTextBox.TextChanged += new System.EventHandler(this.CommodityNameTextBox_TextChanged);
			// 
			// nameCommodityLabel
			// 
			this.nameCommodityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nameCommodityLabel.AutoSize = true;
			this.nameCommodityLabel.Location = new System.Drawing.Point(245, 31);
			this.nameCommodityLabel.Name = "nameCommodityLabel";
			this.nameCommodityLabel.Size = new System.Drawing.Size(37, 17);
			this.nameCommodityLabel.TabIndex = 0;
			this.nameCommodityLabel.Text = "&نام کالا";
			// 
			// deletePicturBox
			// 
			this.deletePicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deletePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePicturBox.Image")));
			this.deletePicturBox.Location = new System.Drawing.Point(433, 220);
			this.deletePicturBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.deletePicturBox.Name = "deletePicturBox";
			this.deletePicturBox.Size = new System.Drawing.Size(25, 33);
			this.deletePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.deletePicturBox.TabIndex = 4;
			this.deletePicturBox.TabStop = false;
			this.deletePicturBox.Visible = false;
			this.deletePicturBox.Click += new System.EventHandler(this.DeletePicturBox_Click);
			// 
			// groupBox
			// 
			this.groupBox.Controls.Add(this.commodityImagePicturBox);
			this.groupBox.Location = new System.Drawing.Point(308, 16);
			this.groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox.Name = "groupBox";
			this.groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox.Size = new System.Drawing.Size(150, 195);
			this.groupBox.TabIndex = 5;
			this.groupBox.TabStop = false;
			// 
			// commodityImagePicturBox
			// 
			this.commodityImagePicturBox.BackgroundImage = global::ANBAR.Properties.Resources.icons8_box1_100;
			this.commodityImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.commodityImagePicturBox.Location = new System.Drawing.Point(6, 16);
			this.commodityImagePicturBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.commodityImagePicturBox.Name = "commodityImagePicturBox";
			this.commodityImagePicturBox.Size = new System.Drawing.Size(138, 171);
			this.commodityImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.commodityImagePicturBox.TabIndex = 19;
			this.commodityImagePicturBox.TabStop = false;
			// 
			// CommodityAddForm
			// 
			this.AcceptButton = this.saveButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SlateBlue;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(484, 639);
			this.Controls.Add(this.groupBox);
			this.Controls.Add(this.deletePicturBox);
			this.Controls.Add(this.addPicturelinkLabel);
			this.Controls.Add(this.buttonGroupBox);
			this.Controls.Add(this.informationCommodityGroupBox);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximumSize = new System.Drawing.Size(600, 785);
			this.MinimumSize = new System.Drawing.Size(484, 639);
			this.Name = "CommodityAddForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "افزودن کالا";
			this.Load += new System.EventHandler(this.CommodityAddForm_Load);
			this.buttonGroupBox.ResumeLayout(false);
			this.informationCommodityGroupBox.ResumeLayout(false);
			this.informationCommodityGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.deletePicturBox)).EndInit();
			this.groupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.commodityImagePicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.GroupBox informationCommodityGroupBox;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.Label descriptionLabel;
		private Mbb.Windows.Forms.Label purchaseDateLabel;
		private Mbb.Windows.Forms.MaskedBox purchaseDateMaskedBox;
		private Mbb.Windows.Forms.TextBox selleryNameTextBox;
		private Mbb.Windows.Forms.Label selleryNameLabel;
		private Mbb.Windows.Forms.Label currencylabel2;
		private Mbb.Windows.Forms.TextBox totalPriceTextBox;
		private Mbb.Windows.Forms.Label totalPriceLabel;
		private Mbb.Windows.Forms.Label currencyLabel1;
		private Mbb.Windows.Forms.TextBox commodityPriceTextBox;
		private Mbb.Windows.Forms.Label unitPriceLabel;
		private Mbb.Windows.Forms.Label quantityLabel;
		private Mbb.Windows.Forms.ComboBox unitComboBox;
		private Mbb.Windows.Forms.TextBox commodityNameTextBox;
		private Mbb.Windows.Forms.Label nameCommodityLabel;
		private Mbb.Windows.Forms.LinkLabel addPicturelinkLabel;
		private Mbb.Windows.Forms.GroupBox buttonGroupBox;
		private Mbb.Windows.Forms.Button exitButton;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.Button currentDayButton;
		private Mbb.Windows.Forms.PicturBox deletePicturBox;
		private Mbb.Windows.Forms.TextBox quantityTextBox;
		private Mbb.Windows.Forms.GroupBox groupBox;
		private Mbb.Windows.Forms.PicturBox commodityImagePicturBox;
	}
}