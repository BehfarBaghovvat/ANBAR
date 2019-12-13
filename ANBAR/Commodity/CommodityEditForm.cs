using System.Drawing;
using System.Linq;

namespace ANBAR
{
	public partial class CommodityEditForm : Infrastructure.BaseForm
	{
		public CommodityEditForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string CommodityName { get; set; }
		public string SelleryName { get; set; }
		public string CommodityPicture { get; set; }
		public byte[] CommodityPic { get; set; }
		public string PurchaseDate { get; set; }
		public decimal Quantity { get; set; }
		public decimal BackupQuantity { get; set; }
		public string Unit { get; set; }
		public decimal CommodityPrice { get; set; }
		public decimal BackupPrice { get; set; }
		public decimal TotalPrice { get; set; }
		public string Description { get; set; }

		public CommodityStockForm commodityStockForm { get; set; }

		#endregion /Properties

		#region CommodityEditForm_Load
		private void CommodityEditForm_Load(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				Models.Commodity commodity =
					databaseContext.Commodities
					.Where(current => string.Compare(current.CommodityName, CommodityName, true) == 0)
					.FirstOrDefault();

				if (commodity == null)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage("کالای مورد نظر حذف گردیده!");
				}

				commodityNameTextBox.Text = commodity.CommodityName;
				CommodityName = commodity.CommodityName;
				selleryNameTextBox.Text = commodity.SelleryName;
				SelleryName = commodity.SelleryName;

				#region Loaded Commodity Picture From DataBase
				//**********فراخوانی تصویر از بانک اطلاعاتی
				var byteImage = commodity.CommodityPictur;

				CommodityPic = commodity.CommodityPictur;
				using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
				{
					commodityImagePicturBox.Image = System.Drawing.Image.FromStream(ms);

				}
				deletePicturBox.Visible = true;
				//**********فراخوانی تصویر از بانک اطلاعاتی 
				#endregion /Loaded Commodity Picture From DataBase

				purchaseDateMaskedBox.Text = commodity.PurchaseDate;
				PurchaseDate = commodity.PurchaseDate;

				quantityTextBox.Text = commodity.Quantity;
				BackupQuantity = decimal.Parse(commodity.Quantity);

				unitComboBox.Text = commodity.Unit;
				Unit = commodity.Unit;

				commodityPriceTextBox.Text = commodity.CommodityPrice;
				BackupPrice = decimal.Parse(commodity.CommodityPrice);

				descriptionTextBox.Text = commodity.Description;
				Description = commodity.Description;
			}
			catch (System.Exception ex)
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
		#endregion /CommodityEditForm_Load

		#region NewDateButton_Click
		private void NewDateButton_Click(object sender, System.EventArgs e)
		{
			purchaseDateMaskedBox.Text =
				Infrastructure.Utility.ShowWithOutNameMonthPersianCalenda(System.DateTime.Now).ToString();
		}

		#endregion NewDateButton_Click

		#region AddPicturelinkLabel_LinkClicked
		private void AddPicturelinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPEP (*.jpeg , *.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "بارگذاری تصویر کالا",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				CommodityPicture = openFileDialog.FileName;

				commodityImagePicturBox.Image = Image.FromFile(CommodityPicture);
				deletePicturBox.Visible = true;
			}
		}
		#endregion /AddPicturelinkLabel_LinkClicked

		#region DeletePicturBox_Click
		private void DeletePicturBox_Click(object sender, System.EventArgs e)
		{
			if (string.Compare(CommodityPicture, string.Empty, false) != 0)
			{
				commodityImagePicturBox.Image = null;
				CommodityPicture = string.Empty;
				commodityImagePicturBox.BackgroundImage = Properties.Resources.icons8_box_100;
				commodityImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			}
			deletePicturBox.Visible = false;
		}
		#endregion /DeletePicturBox_Click

		#region UnitComboBox_TextChanged
		private void UnitComboBox_TextChanged(object sender, System.EventArgs e)
		{
			Unit = unitComboBox.Text;
		}
		#endregion UnitComboBox_TextChanged

		#region QuantityTextBox_TextChanged
		private void QuantityTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Quantity = decimal.Parse(quantityTextBox.Text);

			TotalPrice = Infrastructure.Utility.Payment(quatity: Quantity, price: CommodityPrice);
		}
		#endregion /QuantityTextBox_TextChanged

		#region CommodityPriceTextBox_TextChanged
		private void CommodityPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			CommodityPrice = decimal.Parse(commodityPriceTextBox.Text);

			TotalPrice = Infrastructure.Utility.Payment(quatity: Quantity, price: CommodityPrice);
		}
		#endregion CommodityPriceTextBox_TextChanged

		#region CommodityPriceTextBox_Leave
		private void CommodityPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (CommodityPrice == 0)
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage("مبلغ خود را وارد نمایید!");
			}
		}
		#endregion /CommodityPriceTextBox_Leave

		#region QuantityTextBox_Leave
		private void QuantityTextBox_Leave(object sender, System.EventArgs e)
		{
			if (Quantity < 100 && unitComboBox.Text == "گرم")
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage("!حداقل موجودی باید 100 گرم باشد");

				quantityTextBox.Focus();
				return;
			}
		}
		#endregion /QuantityTextBox_Leave

		#region UnitComboBox_Leave
		private void UnitComboBox_Leave(object sender, System.EventArgs e)
		{
			if (Quantity < 100 && unitComboBox.Text == "گرم")
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage("!حداقل موجودی باید 100 گرم باشد");

				quantityTextBox.Focus();

				return;
			}
		}
		#endregion /UnitComboBox_Leave

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//==========
				// Validation
				//==========

				System.Windows.Forms.DialogResult verifyEditing =
					System.Windows.Forms.MessageBox.Show
					(text: "ویرایش کالا را تایید میکنید؟",
					caption: "تایید ویرایش",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (verifyEditing == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Commodity commodity =
					databaseContext.Commodities
					.Where(current => string.Compare(current.CommodityName, CommodityName, true) == 0)
					.FirstOrDefault();

					commodity.CommodityName = commodityNameTextBox.Text;
					commodity.SelleryName = selleryNameTextBox.Text;

					#region Upload Picture in Database
					if (CommodityPicture != null)
					{
						//----------اگر فیلد CommodityPicture خالی نبود محتوای بیتی آن را خوانده و در فیلد بانک اطلاعاتی قرار بده.----------\\
						commodity.CommodityPictur = System.IO.File.ReadAllBytes(CommodityPicture);
						//--------------------------------------------------------------------------------\\
					}
					#endregion /Upload Picture in Database

					commodity.PurchaseDate = purchaseDateMaskedBox.Text;
					commodity.Unit = unitComboBox.Text;
					commodity.Quantity = quantityTextBox.Text;
					commodity.CommodityPrice = commodityPriceTextBox.Text;
					commodity.TotalPrice = TotalPrice.ToString();
					commodity.Description = descriptionTextBox.Text;

					databaseContext.SaveChanges();

					//*****
					commodityStockForm.CommodityLoader();
					//*****

					Mbb.Windows.Forms.MessageBox.Message("ویرایش انجام شد.");

					resetButton.Enabled = false;

					return;
				}
			}
			catch (System.Exception ex)
			{

				Mbb.Windows.Forms.MessageBox.ErrorMessage(ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
		#endregion /SaveButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			commodityNameTextBox.Text = CommodityName;
			selleryNameTextBox.Text = SelleryName;

			//***** Initial photo upload 
			var byteImage = CommodityPic;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				commodityImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
			}
			deletePicturBox.Visible = true;
			//***** Initial photo upload

			purchaseDateMaskedBox.Text = PurchaseDate;
			quantityTextBox.Text = BackupQuantity.ToString();
			unitComboBox.Text = Unit;
			commodityPriceTextBox.Text = BackupPrice.ToString();
			descriptionTextBox.Text = Description;
		}
		#endregion /ResetButton_Click
	}
}
