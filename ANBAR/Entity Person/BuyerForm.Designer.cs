namespace ANBAR.Client
{
	partial class BuyerForm
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
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.myDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.searchFullNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.searchFullNameLabel = new Mbb.Windows.Forms.Label();
			this.searchGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.searchAddressTextBox = new Mbb.Windows.Forms.TextBox();
			this.searchCellPhonrMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.searchPhoneMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.searchAddressLabel = new Mbb.Windows.Forms.Label();
			this.searchCellPhonrLabel = new Mbb.Windows.Forms.Label();
			this.searchPhoneLabel = new Mbb.Windows.Forms.Label();
			this.buyerGroupBox = new Mbb.Windows.Forms.GroupBox();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.addressTextBox = new Mbb.Windows.Forms.TextBox();
			this.cellphoneMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.lastNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.firstNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.phoneMaskedBox = new Mbb.Windows.Forms.MaskedBox();
			this.descriptionLabel = new Mbb.Windows.Forms.Label();
			this.addressLabel = new Mbb.Windows.Forms.Label();
			this.cellPhonelabel = new Mbb.Windows.Forms.Label();
			this.phoneLabel = new Mbb.Windows.Forms.Label();
			this.lastNameLabel = new Mbb.Windows.Forms.Label();
			this.firstNameLabel = new Mbb.Windows.Forms.Label();
			this.editButton = new Mbb.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			this.searchGroupBox.SuspendLayout();
			this.buyerGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.saveButton.Location = new System.Drawing.Point(30, 426);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(110, 23);
			this.saveButton.TabIndex = 14;
			this.saveButton.Text = "&ثبت مشتری";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// myDataGridView
			// 
			this.myDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGridView.Location = new System.Drawing.Point(289, 173);
			this.myDataGridView.Name = "myDataGridView";
			this.myDataGridView.Size = new System.Drawing.Size(386, 276);
			this.myDataGridView.TabIndex = 16;
			// 
			// searchFullNameTextBox
			// 
			this.searchFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchFullNameTextBox.Location = new System.Drawing.Point(6, 21);
			this.searchFullNameTextBox.Name = "searchFullNameTextBox";
			this.searchFullNameTextBox.Size = new System.Drawing.Size(274, 22);
			this.searchFullNameTextBox.TabIndex = 18;
			// 
			// searchFullNameLabel
			// 
			this.searchFullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchFullNameLabel.AutoSize = true;
			this.searchFullNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchFullNameLabel.Location = new System.Drawing.Point(286, 26);
			this.searchFullNameLabel.Name = "searchFullNameLabel";
			this.searchFullNameLabel.Size = new System.Drawing.Size(94, 13);
			this.searchFullNameLabel.TabIndex = 17;
			this.searchFullNameLabel.Text = " نا&م و نام خانوادگی";
			// 
			// searchGroupBox
			// 
			this.searchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchGroupBox.Controls.Add(this.searchAddressTextBox);
			this.searchGroupBox.Controls.Add(this.searchCellPhonrMaskedBox);
			this.searchGroupBox.Controls.Add(this.searchPhoneMaskedBox);
			this.searchGroupBox.Controls.Add(this.searchAddressLabel);
			this.searchGroupBox.Controls.Add(this.searchCellPhonrLabel);
			this.searchGroupBox.Controls.Add(this.searchPhoneLabel);
			this.searchGroupBox.Controls.Add(this.searchFullNameTextBox);
			this.searchGroupBox.Controls.Add(this.searchFullNameLabel);
			this.searchGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchGroupBox.Location = new System.Drawing.Point(289, 12);
			this.searchGroupBox.Name = "searchGroupBox";
			this.searchGroupBox.Size = new System.Drawing.Size(386, 149);
			this.searchGroupBox.TabIndex = 19;
			this.searchGroupBox.TabStop = false;
			this.searchGroupBox.Text = "جستجوی خریدار";
			// 
			// searchAddressTextBox
			// 
			this.searchAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchAddressTextBox.Location = new System.Drawing.Point(6, 104);
			this.searchAddressTextBox.Name = "searchAddressTextBox";
			this.searchAddressTextBox.Size = new System.Drawing.Size(274, 22);
			this.searchAddressTextBox.TabIndex = 28;
			// 
			// searchCellPhonrMaskedBox
			// 
			this.searchCellPhonrMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchCellPhonrMaskedBox.Location = new System.Drawing.Point(6, 76);
			this.searchCellPhonrMaskedBox.Name = "searchCellPhonrMaskedBox";
			this.searchCellPhonrMaskedBox.Size = new System.Drawing.Size(274, 22);
			this.searchCellPhonrMaskedBox.TabIndex = 27;
			// 
			// searchPhoneMaskedBox
			// 
			this.searchPhoneMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.searchPhoneMaskedBox.Location = new System.Drawing.Point(6, 48);
			this.searchPhoneMaskedBox.Name = "searchPhoneMaskedBox";
			this.searchPhoneMaskedBox.Size = new System.Drawing.Size(274, 22);
			this.searchPhoneMaskedBox.TabIndex = 26;
			// 
			// searchAddressLabel
			// 
			this.searchAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchAddressLabel.AutoSize = true;
			this.searchAddressLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchAddressLabel.Location = new System.Drawing.Point(347, 108);
			this.searchAddressLabel.Name = "searchAddressLabel";
			this.searchAddressLabel.Size = new System.Drawing.Size(33, 13);
			this.searchAddressLabel.TabIndex = 25;
			this.searchAddressLabel.Text = "آ&درس";
			// 
			// searchCellPhonrLabel
			// 
			this.searchCellPhonrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchCellPhonrLabel.AutoSize = true;
			this.searchCellPhonrLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchCellPhonrLabel.Location = new System.Drawing.Point(323, 80);
			this.searchCellPhonrLabel.Name = "searchCellPhonrLabel";
			this.searchCellPhonrLabel.Size = new System.Drawing.Size(57, 13);
			this.searchCellPhonrLabel.TabIndex = 24;
			this.searchCellPhonrLabel.Text = "تل&فن همراه";
			// 
			// searchPhoneLabel
			// 
			this.searchPhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.searchPhoneLabel.AutoSize = true;
			this.searchPhoneLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.searchPhoneLabel.Location = new System.Drawing.Point(328, 52);
			this.searchPhoneLabel.Name = "searchPhoneLabel";
			this.searchPhoneLabel.Size = new System.Drawing.Size(52, 13);
			this.searchPhoneLabel.TabIndex = 23;
			this.searchPhoneLabel.Text = "ت&لفن ثابت";
			// 
			// buyerGroupBox
			// 
			this.buyerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buyerGroupBox.Controls.Add(this.descriptionTextBox);
			this.buyerGroupBox.Controls.Add(this.addressTextBox);
			this.buyerGroupBox.Controls.Add(this.cellphoneMaskedBox);
			this.buyerGroupBox.Controls.Add(this.lastNameTextBox);
			this.buyerGroupBox.Controls.Add(this.firstNameTextBox);
			this.buyerGroupBox.Controls.Add(this.phoneMaskedBox);
			this.buyerGroupBox.Controls.Add(this.descriptionLabel);
			this.buyerGroupBox.Controls.Add(this.addressLabel);
			this.buyerGroupBox.Controls.Add(this.cellPhonelabel);
			this.buyerGroupBox.Controls.Add(this.phoneLabel);
			this.buyerGroupBox.Controls.Add(this.lastNameLabel);
			this.buyerGroupBox.Controls.Add(this.firstNameLabel);
			this.buyerGroupBox.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.buyerGroupBox.Location = new System.Drawing.Point(12, 12);
			this.buyerGroupBox.Name = "buyerGroupBox";
			this.buyerGroupBox.Size = new System.Drawing.Size(271, 408);
			this.buyerGroupBox.TabIndex = 20;
			this.buyerGroupBox.TabStop = false;
			this.buyerGroupBox.Text = "اطلاعات خریدار";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(7, 161);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(172, 236);
			this.descriptionTextBox.TabIndex = 23;
			// 
			// addressTextBox
			// 
			this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addressTextBox.Location = new System.Drawing.Point(7, 133);
			this.addressTextBox.Name = "addressTextBox";
			this.addressTextBox.Size = new System.Drawing.Size(172, 22);
			this.addressTextBox.TabIndex = 22;
			// 
			// cellphoneMaskedBox
			// 
			this.cellphoneMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cellphoneMaskedBox.Location = new System.Drawing.Point(6, 105);
			this.cellphoneMaskedBox.Name = "cellphoneMaskedBox";
			this.cellphoneMaskedBox.Size = new System.Drawing.Size(172, 22);
			this.cellphoneMaskedBox.TabIndex = 21;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lastNameTextBox.Location = new System.Drawing.Point(7, 49);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(172, 22);
			this.lastNameTextBox.TabIndex = 20;
			this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.firstNameTextBox.Location = new System.Drawing.Point(6, 21);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(172, 22);
			this.firstNameTextBox.TabIndex = 19;
			this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
			// 
			// phoneMaskedBox
			// 
			this.phoneMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneMaskedBox.Location = new System.Drawing.Point(6, 77);
			this.phoneMaskedBox.Name = "phoneMaskedBox";
			this.phoneMaskedBox.Size = new System.Drawing.Size(172, 22);
			this.phoneMaskedBox.TabIndex = 18;
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.descriptionLabel.Location = new System.Drawing.Point(213, 164);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(51, 13);
			this.descriptionLabel.TabIndex = 17;
			this.descriptionLabel.Text = "&توضیحات";
			// 
			// addressLabel
			// 
			this.addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.addressLabel.AutoSize = true;
			this.addressLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.addressLabel.Location = new System.Drawing.Point(232, 136);
			this.addressLabel.Name = "addressLabel";
			this.addressLabel.Size = new System.Drawing.Size(33, 13);
			this.addressLabel.TabIndex = 16;
			this.addressLabel.Text = "&آدرس";
			// 
			// cellPhonelabel
			// 
			this.cellPhonelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cellPhonelabel.AutoSize = true;
			this.cellPhonelabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.cellPhonelabel.Location = new System.Drawing.Point(208, 108);
			this.cellPhonelabel.Name = "cellPhonelabel";
			this.cellPhonelabel.Size = new System.Drawing.Size(57, 13);
			this.cellPhonelabel.TabIndex = 15;
			this.cellPhonelabel.Text = "تلفن &همراه";
			// 
			// phoneLabel
			// 
			this.phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.phoneLabel.AutoSize = true;
			this.phoneLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.phoneLabel.Location = new System.Drawing.Point(213, 80);
			this.phoneLabel.Name = "phoneLabel";
			this.phoneLabel.Size = new System.Drawing.Size(52, 13);
			this.phoneLabel.TabIndex = 14;
			this.phoneLabel.Text = "تلفن &ثابت";
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.lastNameLabel.Location = new System.Drawing.Point(199, 52);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(66, 13);
			this.lastNameLabel.TabIndex = 13;
			this.lastNameLabel.Text = "نام &خانوادگی";
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.firstNameLabel.Location = new System.Drawing.Point(245, 28);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(20, 13);
			this.firstNameLabel.TabIndex = 12;
			this.firstNameLabel.Text = "&نام";
			// 
			// editButton
			// 
			this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.editButton.Location = new System.Drawing.Point(146, 426);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(110, 23);
			this.editButton.TabIndex = 15;
			this.editButton.Text = "&ویرایش";
			this.editButton.UseVisualStyleBackColor = true;
			// 
			// BuyerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.buyerGroupBox);
			this.Controls.Add(this.searchGroupBox);
			this.Controls.Add(this.myDataGridView);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.saveButton);
			this.MaximumSize = new System.Drawing.Size(850, 600);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "BuyerForm";
			this.Text = "ثبت افراد خریدار";
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			this.searchGroupBox.ResumeLayout(false);
			this.searchGroupBox.PerformLayout();
			this.buyerGroupBox.ResumeLayout(false);
			this.buyerGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.DataGridView myDataGridView;
		private Mbb.Windows.Forms.TextBox searchFullNameTextBox;
		private Mbb.Windows.Forms.Label searchFullNameLabel;
		private Mbb.Windows.Forms.GroupBox searchGroupBox;
		private Mbb.Windows.Forms.TextBox searchAddressTextBox;
		private Mbb.Windows.Forms.MaskedBox searchCellPhonrMaskedBox;
		private Mbb.Windows.Forms.MaskedBox searchPhoneMaskedBox;
		private Mbb.Windows.Forms.Label searchAddressLabel;
		private Mbb.Windows.Forms.Label searchCellPhonrLabel;
		private Mbb.Windows.Forms.Label searchPhoneLabel;
		private Mbb.Windows.Forms.GroupBox buyerGroupBox;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.TextBox addressTextBox;
		private Mbb.Windows.Forms.MaskedBox cellphoneMaskedBox;
		private Mbb.Windows.Forms.TextBox lastNameTextBox;
		private Mbb.Windows.Forms.TextBox firstNameTextBox;
		private Mbb.Windows.Forms.MaskedBox phoneMaskedBox;
		private Mbb.Windows.Forms.Label descriptionLabel;
		private Mbb.Windows.Forms.Label addressLabel;
		private Mbb.Windows.Forms.Label cellPhonelabel;
		private Mbb.Windows.Forms.Label phoneLabel;
		private Mbb.Windows.Forms.Label lastNameLabel;
		private Mbb.Windows.Forms.Label firstNameLabel;
		private Mbb.Windows.Forms.Button editButton;
	}
}