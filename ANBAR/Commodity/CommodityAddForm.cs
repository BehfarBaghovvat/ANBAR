using System.Linq;
using System.Drawing;
using Stimulsoft.Report;
using Mbb.Windows.Forms;

namespace ANBAR
{
	public partial class CommodityAddForm : Infrastructure.BaseForm
	{
		public CommodityAddForm()
		{
			InitializeComponent();
		}

		#region Properties

		public CommodityStockForm MyCommodityStockForm;
		//-----
		public string CommodityName { get; set; }
		//-----
		public string PurchaseDate { get; set; }
		//-----
		public decimal Quantity { get; set; }
		//-----
		public decimal CommodityPrice { get; set; }
		//-----
		public decimal TotalPrice { get; set; }
		//-----
		public string CommodityPicture { get; set; }
		//-----
		public CommodityAddForm(CommodityStockForm stockForm)
		{
			MyCommodityStockForm = stockForm;
		}
		#endregion /Properties

		#region  CommodityAddForm

		#region CommodityAddForm_Load
		private void CommodityAddForm_Load(object sender, System.EventArgs e)
		{

		}
		#endregion /CommodityAddForm_Load

		#region CommodityAddForm_FormClosed
		private void CommodityAddForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			this.Hide();
		}
		#endregion /CommodityAddForm_FormClosed

		#endregion / CommodityAddForm

		#region AllClear
		public void AllClear()
		{
			commodityNameTextBox.Clear();
			commodityImagePicturBox.Image = null;
			CommodityPicture = string.Empty;
			commodityImagePicturBox.BackgroundImage = Properties.Resources.icons8_box_100;
			commodityImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			deletePicturBox.Visible = false;
			selleryNameTextBox.Clear();
			purchaseDateMaskedBox.Clear();
			PurchaseDate = string.Empty;
			quantityTextBox.Text = "0";
			Quantity = 0;
			unitComboBox.Text = "واحد کالا...";
			commodityPriceTextBox.Text = "0";
			CommodityPrice = 0;
			totalPriceTextBox.Text = "0";
			descriptionTextBox.Clear();

		}
		#endregion /AllClear

		#region CommodityNameTextBox_TextChanged
		private void CommodityNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			CommodityName = commodityNameTextBox.Text;
		}
		#endregion /CommodityNameTextBox_TextChanged

		#region PurchaseDateMaskedBox_TextChanged
		private void PurchaseDateMaskedBox_TextChanged(object sender, System.EventArgs e)
		{
			PurchaseDate = purchaseDateMaskedBox.Text;
		}
		#endregion /PurchaseDateMaskedBox_TextChanged

		#region ToDayButton_Click
		private void ToDayButton_Click(object sender, System.EventArgs e)
		{
			purchaseDateMaskedBox.Text =
				Infrastructure.Utility.ShowWithOutNameMonthPersianCalenda(System.DateTime.Now).ToString();

			PurchaseDate =
				Infrastructure.Utility.ShowWithOutNameMonthPersianCalenda(System.DateTime.Now).ToString();
		}
		#endregion /ToDayButton_Click

		#region Quantity

		#region QuantityTextBox_TextChanged
		private void QuantityTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(quantityTextBox.Text))
			{
				Quantity = 0;
				quantityTextBox.Text = "0";
				quantityTextBox.Focus();
				return;
			}
			else
			{
				Quantity = decimal.Parse(quantityTextBox.Text);
			}
			if (unitComboBox.Text == "تن")
			{
				Quantity *= 1000;
			}
			TotalPrice = Infrastructure.Utility.Payment(quatity: Quantity, price: CommodityPrice);

			totalPriceTextBox.Text = TotalPrice.ToString("#,0");
		}
		#endregion /QuantityTextBox_TextChanged

		#region QuantityTextBox_KeyPress
		private void QuantityTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			//----------درج اعداد اعشاری با نماد / در کنترل---------
			char ch = e.KeyChar;

			if (ch == 47 && quantityTextBox.Text.IndexOf('/') != -1)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsDigit(ch) && ch != 8 && ch != 47)
			{
				e.Handled = true;
			}
		}
		#endregion /QuantityTextBox_KeyPress

		#endregion /Quantity

		#region UnitComboBox_SelectedValueChanged
		private void UnitComboBox_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (unitComboBox.SelectedIndex == 3)
			{
				Quantity *= 1000;
			}
			else
			{
				Quantity = decimal.Parse(quantityTextBox.Text);
			}

			TotalPrice = Infrastructure.Utility.Payment(quatity: Quantity, price: CommodityPrice);

			totalPriceTextBox.Text = TotalPrice.ToString("#,0");
		}

		#endregion /UnitComboBox_SelectedValueChanged

		#region CommodityPrice

		#region CommodityPriceTextBox_TextChanged
		private void CommodityPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(commodityPriceTextBox.Text))
			{
				CommodityPrice = 0;
				commodityPriceTextBox.Text = "0";
				commodityPriceTextBox.Focus();

				return;
			}

			else
			{
				CommodityPrice = decimal.Parse(commodityPriceTextBox.Text);
			}

			TotalPrice = Infrastructure.Utility.Payment(quatity: Quantity, price: CommodityPrice);

			totalPriceTextBox.Text = TotalPrice.ToString("#,0");
		}
		#endregion /CommodityPriceTextBox_TextChanged

		#region CommodityPriceTextBox_KeyPress
		private void CommodityPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//----------درج فقط عدد در کنترل---------
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion /CommodityPriceTextBox_KeyPress

		#endregion /CommodityPrice

		#region TotalPriceTextBox_TextChanged
		private void TotalPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{

		}
		#endregion /TotalPriceTextBox_TextChanged

		#region AddPicturelinkLabel_LinkClicked
		private void AddPicturelinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPEP (*.jpg)|*.jpg|" +
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

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				// **************************************************
				// Validation
				// **************************************************

				string errorMessage = string.Empty;

				if (string.IsNullOrWhiteSpace(CommodityName))
				{
					errorMessage =
						"تکمیل فیلد نام کالا اجباری است!";

					commodityNameTextBox.Clear();
				}

				if (string.IsNullOrWhiteSpace(CommodityPicture))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"انتخاب عکس برای کالا اجباری است!";

					CommodityPicture = string.Empty;
				}

				if (string.IsNullOrWhiteSpace(PurchaseDate))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}

					errorMessage +=
						"تکمیل فیلد تاریخ خرید اجباری است!";

					purchaseDateMaskedBox.Clear();
				}

				if (quantityTextBox.Text == "0")
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}

					errorMessage +=
						"تکمیل فیلد مقدار کالا اجباری است!";

					quantityTextBox.Text = "0";
				}

				if (unitComboBox.SelectedIndex == -1)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"تکمیل فیلد واحد شمارش اجباری است!";
				}

				if (commodityPriceTextBox.Text == "0")
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"تکمیل فیلد قیمت کالا اجباری است!";

					commodityPriceTextBox.Text = "0";
				}

				//*********

				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(commodityNameTextBox.Text))
					{
						commodityNameTextBox.Focus();
					}

					else if (string.IsNullOrWhiteSpace(PurchaseDate))
					{
						purchaseDateMaskedBox.Focus();
					}

					else if (Quantity == 0)
					{
						quantityTextBox.Focus();
					}

					else if (unitComboBox.SelectedIndex == -1)
					{
						unitComboBox.Focus();
					}

					else if (CommodityPrice == 0)
					{
						commodityPriceTextBox.Focus();
					}

					else if (string.IsNullOrWhiteSpace(CommodityPicture))
					{
						System.Windows.Forms.OpenFileDialog openFileDialog =
							new System.Windows.Forms.OpenFileDialog
							{
								Filter = "JPEP (*.jpg)|*.jpg|" +
									"PNG (*.png)|*.png|" +
									"BMP (*.bmp)|*.bmp",
								Title = "بارگذاری تصویر کالا",
							};

						if (openFileDialog.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
						{
							CommodityPicture = openFileDialog.FileName;

							commodityImagePicturBox.Image = Image.FromFile(CommodityPicture);
							deletePicturBox.Visible = true;
						}
					}

					Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

					return;
				}

				//*****

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage
					(text: "کالای مورد نظر ثبت گردد؟",
					captiopn: "ثبت کالا",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);


				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Commodity commodity =
					databaseContext.Commodities
					.Where(current => string.Compare(current.CommodityName, CommodityName, true) == 0)
					.FirstOrDefault();

					if (commodity != null)
					{
						errorMessage =
							"کالای مورد نظر در انبار موجود می باشد.";

						Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

						commodityNameTextBox.Focus();

						return;
					}

					commodity = new Models.Commodity
					{
						CommodityName = CommodityName,
						SelleryName = selleryNameTextBox.Text,
						PurchaseDate = purchaseDateMaskedBox.Text,
						Quantity = quantityTextBox.Text,
						Unit = unitComboBox.Text,
						CommodityPrice = commodityPriceTextBox.Text,
						TotalPrice = TotalPrice.ToString(),
						Description = descriptionTextBox.Text,
						CommodityPictur = System.IO.File.ReadAllBytes(CommodityPicture),
					};

					databaseContext.Commodities.Add(commodity);
					databaseContext.SaveChanges();

					//----- این خط کد باعث میشه بعد از ثبت کالا اطلاعات در فرم انبار نمایش داده بشه
					if (MainForm.commodityStockForm != null)
					{
						MainForm.commodityStockForm.CommodityLoader();
					}
					//-----

					Mbb.Windows.Forms.MessageBox.Message("اطلاعات با موفقیت ذخیره گردید");

					AllClear();
				}
			}
			catch (System.Exception ex)
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage(ex.Message);
			}
		}


		#endregion /SaveButton_Click

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetButton_Click

		#region StockButton_Click
		private void StockButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /StockButton_Click

		#region ExitButton_Click
		private void ExitButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitButton_Click
	}
}
