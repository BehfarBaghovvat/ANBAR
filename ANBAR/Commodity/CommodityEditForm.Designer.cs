namespace ANBAR
{
	partial class CommodityEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommodityEditForm));
			this.addPicturelinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.buttonGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.informationCommodityGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.newDateButton = new Mbb.Windows.Forms.Button();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.descriptionLabel = new Mbb.Windows.Forms.Label();
			this.purchaseDateLabel = new Mbb.Windows.Forms.Label();
			this.purchaseDateMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.selleryNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.quantityTextBox = new Mbb.Windows.Forms.TextBox();
			this.selleryNameLabel = new Mbb.Windows.Forms.Label();
			this.currencyLabel1 = new Mbb.Windows.Forms.Label();
			this.commodityPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.unitPriceLabel = new Mbb.Windows.Forms.Label();
			this.quantityLabel = new Mbb.Windows.Forms.Label();
			this.unitComboBox = new Mbb.Windows.Forms.ComboBox();
			this.commodityNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.nameCommodityLabel = new Mbb.Windows.Forms.Label();
			this.deletePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.pictureGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.commodityImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.commodityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.buttonGroupBox.SuspendLayout();
			this.informationCommodityGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.deletePicturBox)).BeginInit();
			this.pictureGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.commodityImagePicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// addPicturelinkLabel
			// 
			this.addPicturelinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addPicturelinkLabel.AutoSize = true;
			this.addPicturelinkLabel.ForeColor = System.Drawing.SystemColors.Window;
			this.addPicturelinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.addPicturelinkLabel.LinkColor = System.Drawing.SystemColors.Window;
			this.addPicturelinkLabel.Location = new System.Drawing.Point(355, 174);
			this.addPicturelinkLabel.Name = "addPicturelinkLabel";
			this.addPicturelinkLabel.Size = new System.Drawing.Size(67, 13);
			this.addPicturelinkLabel.TabIndex = 1;
			this.addPicturelinkLabel.TabStop = true;
			this.addPicturelinkLabel.Text = "افزودن عکس";
			this.addPicturelinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.addPicturelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddPicturelinkLabel_LinkClicked);
			// 
			// buttonGroupBox
			// 
			this.buttonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGroupBox.Controls.Add(this.resetButton);
			this.buttonGroupBox.Controls.Add(this.saveButton);
			this.buttonGroupBox.ForeColor = System.Drawing.SystemColors.Window;
			this.buttonGroupBox.Location = new System.Drawing.Point(314, 199);
			this.buttonGroupBox.Name = "buttonGroupBox";
			this.buttonGroupBox.Size = new System.Drawing.Size(148, 217);
			this.buttonGroupBox.TabIndex = 3;
			this.buttonGroupBox.TabStop = false;
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.resetButton.ForeColor = System.Drawing.Color.SlateBlue;
			this.resetButton.Location = new System.Drawing.Point(6, 111);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(136, 23);
			this.resetButton.TabIndex = 1;
			this.resetButton.Text = "&حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.ForeColor = System.Drawing.Color.SlateBlue;
			this.saveButton.Location = new System.Drawing.Point(6, 82);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(136, 23);
			this.saveButton.TabIndex = 0;
			this.saveButton.Text = "&ذخیره";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// informationCommodityGroupBox
			// 
			this.informationCommodityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.informationCommodityGroupBox.Controls.Add(this.newDateButton);
			this.informationCommodityGroupBox.Controls.Add(this.descriptionTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.descriptionLabel);
			this.informationCommodityGroupBox.Controls.Add(this.purchaseDateLabel);
			this.informationCommodityGroupBox.Controls.Add(this.purchaseDateMaskedBox);
			this.informationCommodityGroupBox.Controls.Add(this.selleryNameTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.quantityTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.selleryNameLabel);
			this.informationCommodityGroupBox.Controls.Add(this.currencyLabel1);
			this.informationCommodityGroupBox.Controls.Add(this.commodityPriceTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.unitPriceLabel);
			this.informationCommodityGroupBox.Controls.Add(this.quantityLabel);
			this.informationCommodityGroupBox.Controls.Add(this.unitComboBox);
			this.informationCommodityGroupBox.Controls.Add(this.commodityNameTextBox);
			this.informationCommodityGroupBox.Controls.Add(this.nameCommodityLabel);
			this.informationCommodityGroupBox.ForeColor = System.Drawing.SystemColors.Window;
			this.informationCommodityGroupBox.Location = new System.Drawing.Point(11, 12);
			this.informationCommodityGroupBox.Name = "informationCommodityGroupBox";
			this.informationCommodityGroupBox.Size = new System.Drawing.Size(290, 404);
			this.informationCommodityGroupBox.TabIndex = 1;
			this.informationCommodityGroupBox.TabStop = false;
			this.informationCommodityGroupBox.Text = "مشخصات کالا";
			// 
			// newDateButton
			// 
			this.newDateButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.newDateButton.Location = new System.Drawing.Point(13, 75);
			this.newDateButton.Name = "newDateButton";
			this.newDateButton.Size = new System.Drawing.Size(79, 23);
			this.newDateButton.TabIndex = 14;
			this.newDateButton.Text = "ام&روز";
			this.newDateButton.UseVisualStyleBackColor = true;
			this.newDateButton.Click += new System.EventHandler(this.NewDateButton_Click);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(13, 161);
			this.descriptionTextBox.MaxLength = 10000;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(191, 231);
			this.descriptionTextBox.TabIndex = 13;
			this.descriptionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(232, 162);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(51, 13);
			this.descriptionLabel.TabIndex = 12;
			this.descriptionLabel.Text = "ت&وضیحات";
			// 
			// purchaseDateLabel
			// 
			this.purchaseDateLabel.AutoSize = true;
			this.purchaseDateLabel.Location = new System.Drawing.Point(210, 80);
			this.purchaseDateLabel.Name = "purchaseDateLabel";
			this.purchaseDateLabel.Size = new System.Drawing.Size(74, 13);
			this.purchaseDateLabel.TabIndex = 4;
			this.purchaseDateLabel.Text = "&تاریخ خرید کالا";
			// 
			// purchaseDateMaskedBox
			// 
			this.purchaseDateMaskedBox.Location = new System.Drawing.Point(98, 77);
			this.purchaseDateMaskedBox.Mask = "0000/00/00";
			this.purchaseDateMaskedBox.Name = "purchaseDateMaskedBox";
			this.purchaseDateMaskedBox.Size = new System.Drawing.Size(106, 22);
			this.purchaseDateMaskedBox.TabIndex = 5;
			this.purchaseDateMaskedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// selleryNameTextBox
			// 
			this.selleryNameTextBox.Location = new System.Drawing.Point(13, 49);
			this.selleryNameTextBox.MaxLength = 45;
			this.selleryNameTextBox.Name = "selleryNameTextBox";
			this.selleryNameTextBox.Size = new System.Drawing.Size(191, 22);
			this.selleryNameTextBox.TabIndex = 3;
			// 
			// quantityTextBox
			// 
			this.quantityTextBox.HideSelection = false;
			this.quantityTextBox.Location = new System.Drawing.Point(137, 104);
			this.quantityTextBox.MaxLength = 10;
			this.quantityTextBox.Name = "quantityTextBox";
			this.quantityTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.quantityTextBox.Size = new System.Drawing.Size(66, 22);
			this.quantityTextBox.TabIndex = 7;
			this.quantityTextBox.Text = "0";
			this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.quantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
			this.quantityTextBox.Leave += new System.EventHandler(this.QuantityTextBox_Leave);
			// 
			// selleryNameLabel
			// 
			this.selleryNameLabel.AutoSize = true;
			this.selleryNameLabel.Location = new System.Drawing.Point(220, 52);
			this.selleryNameLabel.Name = "selleryNameLabel";
			this.selleryNameLabel.Size = new System.Drawing.Size(64, 13);
			this.selleryNameLabel.TabIndex = 2;
			this.selleryNameLabel.Text = "نام &فروشنده";
			// 
			// currencyLabel1
			// 
			this.currencyLabel1.AutoSize = true;
			this.currencyLabel1.Location = new System.Drawing.Point(13, 136);
			this.currencyLabel1.Name = "currencyLabel1";
			this.currencyLabel1.Size = new System.Drawing.Size(33, 13);
			this.currencyLabel1.TabIndex = 11;
			this.currencyLabel1.Text = "تومان";
			// 
			// commodityPriceTextBox
			// 
			this.commodityPriceTextBox.Location = new System.Drawing.Point(52, 133);
			this.commodityPriceTextBox.MaxLength = 15;
			this.commodityPriceTextBox.Name = "commodityPriceTextBox";
			this.commodityPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.commodityPriceTextBox.Size = new System.Drawing.Size(152, 22);
			this.commodityPriceTextBox.TabIndex = 10;
			this.commodityPriceTextBox.Text = "0";
			this.commodityPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.commodityPriceTextBox.TextChanged += new System.EventHandler(this.CommodityPriceTextBox_TextChanged);
			this.commodityPriceTextBox.Leave += new System.EventHandler(this.CommodityPriceTextBox_Leave);
			// 
			// unitPriceLabel
			// 
			this.unitPriceLabel.AutoSize = true;
			this.unitPriceLabel.Location = new System.Drawing.Point(232, 136);
			this.unitPriceLabel.Name = "unitPriceLabel";
			this.unitPriceLabel.Size = new System.Drawing.Size(52, 13);
			this.unitPriceLabel.TabIndex = 9;
			this.unitPriceLabel.Text = "&قیمت کالا";
			// 
			// quantityLabel
			// 
			this.quantityLabel.AutoSize = true;
			this.quantityLabel.Location = new System.Drawing.Point(232, 108);
			this.quantityLabel.Name = "quantityLabel";
			this.quantityLabel.Size = new System.Drawing.Size(52, 13);
			this.quantityLabel.TabIndex = 6;
			this.quantityLabel.Text = "مق&دار کالا";
			// 
			// unitComboBox
			// 
			this.unitComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.unitComboBox.FormattingEnabled = true;
			this.unitComboBox.Items.AddRange(new object[] {
            "مثقال",
            "گرم",
            "کیلو گرم",
            "تن",
            "عدد",
            "کارتن",
            "بسته"});
			this.unitComboBox.Location = new System.Drawing.Point(13, 105);
			this.unitComboBox.Name = "unitComboBox";
			this.unitComboBox.Size = new System.Drawing.Size(118, 21);
			this.unitComboBox.TabIndex = 8;
			this.unitComboBox.Text = "واحد کالا...";
			this.unitComboBox.TextChanged += new System.EventHandler(this.UnitComboBox_TextChanged);
			this.unitComboBox.Leave += new System.EventHandler(this.UnitComboBox_Leave);
			// 
			// commodityNameTextBox
			// 
			this.commodityNameTextBox.Location = new System.Drawing.Point(13, 21);
			this.commodityNameTextBox.MaxLength = 50;
			this.commodityNameTextBox.Name = "commodityNameTextBox";
			this.commodityNameTextBox.Size = new System.Drawing.Size(191, 22);
			this.commodityNameTextBox.TabIndex = 1;
			// 
			// nameCommodityLabel
			// 
			this.nameCommodityLabel.AutoSize = true;
			this.nameCommodityLabel.Location = new System.Drawing.Point(245, 24);
			this.nameCommodityLabel.Name = "nameCommodityLabel";
			this.nameCommodityLabel.Size = new System.Drawing.Size(39, 13);
			this.nameCommodityLabel.TabIndex = 0;
			this.nameCommodityLabel.Text = "&نام کالا";
			// 
			// deletePicturBox
			// 
			this.deletePicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deletePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("deletePicturBox.Image")));
			this.deletePicturBox.Location = new System.Drawing.Point(439, 168);
			this.deletePicturBox.Name = "deletePicturBox";
			this.deletePicturBox.Size = new System.Drawing.Size(25, 25);
			this.deletePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.deletePicturBox.TabIndex = 9;
			this.deletePicturBox.TabStop = false;
			this.deletePicturBox.Visible = false;
			this.deletePicturBox.Click += new System.EventHandler(this.DeletePicturBox_Click);
			// 
			// pictureGroupBox
			// 
			this.pictureGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureGroupBox.Controls.Add(this.commodityImagePicturBox);
			this.pictureGroupBox.Location = new System.Drawing.Point(314, 12);
			this.pictureGroupBox.Name = "pictureGroupBox";
			this.pictureGroupBox.Size = new System.Drawing.Size(148, 149);
			this.pictureGroupBox.TabIndex = 4;
			this.pictureGroupBox.TabStop = false;
			// 
			// commodityImagePicturBox
			// 
			this.commodityImagePicturBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("commodityImagePicturBox.BackgroundImage")));
			this.commodityImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.commodityImagePicturBox.Location = new System.Drawing.Point(6, 14);
			this.commodityImagePicturBox.Name = "commodityImagePicturBox";
			this.commodityImagePicturBox.Size = new System.Drawing.Size(136, 128);
			this.commodityImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.commodityImagePicturBox.TabIndex = 8;
			this.commodityImagePicturBox.TabStop = false;
			// 
			// commodityBindingSource
			// 
			this.commodityBindingSource.DataSource = typeof(Models.Commodity);
			// 
			// CommodityEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(474, 426);
			this.Controls.Add(this.pictureGroupBox);
			this.Controls.Add(this.deletePicturBox);
			this.Controls.Add(this.addPicturelinkLabel);
			this.Controls.Add(this.buttonGroupBox);
			this.Controls.Add(this.informationCommodityGroupBox);
			this.MaximumSize = new System.Drawing.Size(1100, 600);
			this.MinimumSize = new System.Drawing.Size(490, 465);
			this.Name = "CommodityEditForm";
			this.Text = "ویرایش کالا";
			this.Load += new System.EventHandler(this.CommodityEditForm_Load);
			this.buttonGroupBox.ResumeLayout(false);
			this.informationCommodityGroupBox.ResumeLayout(false);
			this.informationCommodityGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.deletePicturBox)).EndInit();
			this.pictureGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.commodityImagePicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.commodityBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.PicturBox deletePicturBox;
		private Mbb.Windows.Forms.LinkLabel addPicturelinkLabel;
		private Mbb.Windows.Forms.GroupBox buttonGroupBox;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.GroupBox informationCommodityGroupBox;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.Label descriptionLabel;
		private Mbb.Windows.Forms.Label purchaseDateLabel;
		private Mbb.Windows.Forms.MaskedBox purchaseDateMaskedBox;
		private Mbb.Windows.Forms.TextBox selleryNameTextBox;
		private Mbb.Windows.Forms.TextBox quantityTextBox;
		private Mbb.Windows.Forms.Label selleryNameLabel;
		private Mbb.Windows.Forms.Label currencyLabel1;
		private Mbb.Windows.Forms.TextBox commodityPriceTextBox;
		private Mbb.Windows.Forms.Label unitPriceLabel;
		private Mbb.Windows.Forms.Label quantityLabel;
		private Mbb.Windows.Forms.TextBox commodityNameTextBox;
		private Mbb.Windows.Forms.Label nameCommodityLabel;
		private Mbb.Windows.Forms.ComboBox unitComboBox;
		private Mbb.Windows.Forms.GroupBox pictureGroupBox;
		private Mbb.Windows.Forms.PicturBox commodityImagePicturBox;
		private Mbb.Windows.Forms.Button newDateButton;
		private System.Windows.Forms.BindingSource commodityBindingSource;
	}
}