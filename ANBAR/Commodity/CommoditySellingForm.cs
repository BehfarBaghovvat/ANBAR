using System.Drawing;
using System.Linq;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
namespace ANBAR
{
	public partial class CommoditySellingForm : Infrastructure.BaseForm
	{
		public CommoditySellingForm()
		{
			InitializeComponent();
		}

		#region Properties
		public static ReportForm reportForm = null;

		public string CommodityName { get; set; }
		//-----
		public string CommodityImage { get; set; }
		//-----
		public decimal OrderAmount { get; set; }
		//-----
		public decimal OriginalValue { get; set; }
		//-----
		public string FirstUnit { get; set; }
		public string SecondeUnit { get; set; }
		public string EntryUnit { get; set; }
		//-----
		public decimal CommodityPrice { get; set; }
		//-----
		public decimal TotalPrice { get; set; }
		//-----
		public decimal FinalValue { get; set; }
		public string FinalUnit { get; set; }
		//-----
		public string BuyerName { get; set; }
		//-----
		public string OrderDate { get; set; }
		//-----
		public string CellPhone { get; set; }
		//-----
		public string Phone { get; set; }
		//-----
		public string Address { get; set; }
		//-----
		public string Description { get; set; }

		#endregion /Properties

		#region CommoditySellingForm

		#region CommoditySellingForm_Load
		private void CommoditySellingForm_Load(object sender, System.EventArgs e)
		{
			CommodityLoader();
		}
		#endregion /CommoditySellingForm_Load

		#region CommoditySellingForm_FormClosed
		private void CommoditySellingForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			Hide();
		}

		#endregion /CommoditySellingForm_FormClosed

		#endregion CommoditySellingForm

		#region CommodityNameTextBox_TextChanged
		private void CommodityNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			CommodityName = commodityNameTextBox.Text;
		}
		#endregion /CommodityNameTextBox_TextChanged

		#region QuantityTextBox_Leave
		private void QuantityTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(quantityTextBox.Text,"0")==0)
			{
				return;
			}
			if (unitComboBox.Text == "تن" || unitComboBox.Text == "کیلوگرم" || unitComboBox.Text == "گرم")
			{
				CommodityWeight(firstUnit: FirstUnit, secondUnit: SecondeUnit, commodityQuantity: OriginalValue, commodityEntry: OrderAmount);

				TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
				totalPriceTextBox.Text = TotalPrice.ToString("#,0");
			}
			else
			{
				if (OriginalValue < OrderAmount)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("مقدار سفارش از میزان موجودی انبار بیشتر است!");

					OrderAmount = 0;
					quantityTextBox.Text = "0";
					quantityTextBox.Focus();
				}
				else
				{
					FinalValue = OriginalValue - OrderAmount;

					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
			}
		}
		#endregion /QuantityTextBox_Leave

		#region QuantityTextBox

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

		#region QuantityTextBox_TextChanged
		private void QuantityTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(quantityTextBox.Text))
			{
				OrderAmount = 0;
			}

			else if (quantityTextBox.Text == "-")
			{
				quantityTextBox.Text = "0";
				quantityTextBox.Focus();

				return;
			}
			else
			{
				OrderAmount = decimal.Parse(quantityTextBox.Text);

				if (unitComboBox.Text == "تن" || unitComboBox.Text == "کیلوگرم" || unitComboBox.Text == "گرم")
				{
					Calculat(EntryUnit);
				}
			}

			TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);

			totalPriceTextBox.Text = TotalPrice.ToString("#,0");


		}

		#endregion /QuantityTextBox_TextChanged

		#endregion /QuantityTextBox

		#region UnitComboBox_TextChanged
		private void UnitComboBox_TextChanged(object sender, System.EventArgs e)
		{
			SecondeUnit = unitComboBox.Text;
			EntryUnit = unitComboBox.Text;

			if (EntryUnit == "تن" || EntryUnit == "کیلوگرم" || EntryUnit == "گرم")
			{
				Calculat(EntryUnit);
			}
			else
			{
				if (OrderAmount < 1)
				{
					OrderAmount *= 1000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
				else if (OrderAmount > 1000)
				{

					OrderAmount /= 1000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
				else
				{
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
			}
		}
		#endregion /UnitComboBox_TextChanged

		#region CommodityPriceTextBox

		#region CommodityPriceTextBox_KeyPress
		private void CommodityPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//----------درج فقط عدد در کنترل---------
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion CommodityPriceTextBox_KeyPress

		#region CommodityPriceTextBox_TextChanged
		private void CommodityPriceTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(commodityPriceTextBox.Text))
			{
				CommodityPrice = 0;
			}
			else if (commodityPriceTextBox.Text == "-")
			{
				commodityPriceTextBox.Text = "0";
				commodityPriceTextBox.Focus();

				return;
			}
			else
			{
				CommodityPrice = decimal.Parse(commodityPriceTextBox.Text);
			}

			TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);

			totalPriceTextBox.Text = TotalPrice.ToString("#,0");
		}

		#endregion /CommodityPriceTextBox_TextChanged

		#endregion /CommodityPriceTextBox

		#region OrderButton_Click
		private void OrderButton_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;

			#region Save to stock
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//==========
				// Validation
				//==========

				string errorMessage = string.Empty;

				if (OrderAmount == 0)
				{
					errorMessage =
						"وارد کردن مقدار سفارش الزامی است!";

					quantityTextBox.Text = "0";
				}

				if (CommodityPrice == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"وارد کردن قیمت کالا الزامی است!";

					commodityPriceTextBox.Text = "0";
				}

				if (errorMessage != string.Empty)
				{
					if (quantityTextBox.Text == "0")
					{
						quantityTextBox.Focus();
					}

					else if (commodityPriceTextBox.Text == "0")
					{
						commodityPriceTextBox.Focus();
					}

					Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

					return;
				}

				if (unitComboBox.Text == "تن" || unitComboBox.Text == "کیلوگرم" || unitComboBox.Text == "گرم")
				{
					CommodityWeight(firstUnit: FirstUnit, secondUnit: SecondeUnit, commodityQuantity: OriginalValue, commodityEntry: OrderAmount);
				}

				else
				{
					FinalUnit = unitComboBox.Text;
				}

				System.Windows.Forms.DialogResult dialogResult =
				 System.Windows.Forms.MessageBox.Show(text: "آیا سفارش ثبت گردد؟",
				 caption: "ثبت سفارش",
				 buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				 icon: System.Windows.Forms.MessageBoxIcon.Question,
				 defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				 options: System.Windows.Forms.MessageBoxOptions.RightAlign | System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Commodity commodity =
						databaseContext.Commodities
						.Where(current => string.Compare(current.CommodityName, CommodityName, true) == 0)
						.FirstOrDefault();

					commodity.Quantity = FinalValue.ToString();
					commodity.Unit = FinalUnit;

					databaseContext.SaveChanges();

					CommodityLoader();

					//-----All possible changes to the database will be displayed in the StockForm
					if (MainForm.commodityStockForm != null)
					{
						MainForm.commodityStockForm.CommodityLoader();
					}
					//-----

					CustomerOrderRegister();

					Mbb.Windows.Forms.MessageBox.Message("ثبت سفارش انجام شد.");
				}
				else
				{
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
			#endregion Save to stock
			//**************************************************
		}
		#endregion /OrderButton_Click

		#region SearchCommodityNameTextBox
		//-----
		#region SearchCommodityNameTextBox_TextChanged
		private void SearchCommodityNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			searchCommodityNameTextBox.Text = Infrastructure.Utility.FixText(searchCommodityNameTextBox.Text);

			if (searchCommodityNameTextBox.Text.Contains("نام کالا را وارد نمایید..."))
			{
				return;
			}

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.Commodity> commodities = null;

				if (searchCommodityNameTextBox.Text == string.Empty)
				{
					commodities =
						databaseContext.Commodities
						.OrderBy(current => current.CommodityName)
						.ToList();
				}
				else
				{
					commodities =
						databaseContext.Commodities
						.Where(current => current.CommodityName.Contains(searchCommodityNameTextBox.Text))
						.OrderBy(current => current.CommodityName)
						.ToList();
				}

				myDataGridView.DataSource = commodities;

				myDataGridView.AutoResizeColumns
					(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);

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
		#endregion /SearchCommodityNameTextBox_TextChanged
		//==================================================
		#region SearchCommodityNameTextBox_KeyPress
		private void SearchCommodityNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			searchCommodityNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
			if (searchCommodityNameTextBox.Text.Contains("نام کالا را وارد نمایید..."))
			{
				searchCommodityNameTextBox.Clear();
			}
		}
		#endregion /SearchCommodityNameTextBox_KeyPress
		//==================================================
		#region SearchCommodityNameTextBox_Enter
		private void SearchCommodityNameTextBox_Enter(object sender, System.EventArgs e)
		{
			searchCommodityNameTextBox.Focus();
			searchCommodityNameTextBox.Select(0, 0);
		}
		#endregion /SearchCommodityNameTextBox_Enter
		//==================================================
		#region SearchCommodityNameTextBox_MouseClick
		private void SearchCommodityNameTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			searchCommodityNameTextBox.Focus();
			searchCommodityNameTextBox.Select(0, 0);

			CommodityName = string.Empty;
		}
		#endregion /SearchCommodityNameTextBox_MouseClick
		//==================================================
		#region SearchCommodityNameTextBox_Leave
		private void SearchCommodityNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (searchCommodityNameTextBox.Text == string.Empty)
			{
				searchCommodityNameTextBox.Text = "نام کالا را وارد نمایید...";
				searchCommodityNameTextBox.ForeColor = System.Drawing.Color.Gray;
			}

			CommodityName = string.Empty;
		}
		#endregion /SearchCommodityNameTextBox_Leave
		//-----
		#endregion /SearchCommodityNameTextBox

		#region MyDataGridView_CellDoubleClick
		private void MyDataGridView_CellDoubleClick
			(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DatabaseContext databaseContext = new Models.DatabaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			commodityNameTextBox.Text = myDataGridView.CurrentRow.Cells[0].Value.ToString();
			//-----
			#region For Load Picture From DataGridView

			//*****برای بارگذاری تصویر از جدول داده ها

			var byteImage = (byte[])myDataGridView.CurrentRow.Cells[6].Value;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				commodityImagePicturBox.Image = System.Drawing.Image.FromStream(ms);
			}

			//*****برای بارگذاری تصویر از جدوال داده ها

			#endregion /For Load Picture From DataGridView
			//-----

			OriginalValue = decimal.Parse(myDataGridView.CurrentRow.Cells[1].Value.ToString());
			FirstUnit = myDataGridView.CurrentRow.Cells[2].Value.ToString();
			SecondeUnit = myDataGridView.CurrentRow.Cells[2].Value.ToString();

			//quantityTextBox.Text = myDataGridView.CurrentRow.Cells[1].Value.ToString();
			unitComboBox.Text = myDataGridView.CurrentRow.Cells[2].Value.ToString();

			commodityPriceTextBox.Text = myDataGridView.CurrentRow.Cells[3].Value.ToString();

			//quantityTextBox.Focus();
		}

		#endregion /MyDataGridView_CellDoubleClick

		#region ToDayButton_Click
		private void ToDayButton_Click(object sender, System.EventArgs e)
		{
			orderDateMaskedBox.Text =
				Infrastructure.Utility.ShowWithOutNameMonthPersianCalenda(System.DateTime.Now).ToString();
		}

		#endregion /ToDayButton_Click

		#region Other Codes

		#region CommodityLoader
		public void CommodityLoader()
		{
			myDataGridView.ReadOnly = true;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.Commodity> commodities = null;

				commodities =
					databaseContext.Commodities
					.OrderBy(current => current.CommodityName)
					.ToList();

				myDataGridView.DataSource = commodities;

				myDataGridView.AutoResizeColumns
					(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
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

		#endregion /CommodityLoader

		#region AllClear
		/// <summary>
		/// .همه کنترلها به حالت اول باز میگردند
		/// </summary>
		public void AllClear()
		{
			commodityNameTextBox.Clear();
			commodityImagePicturBox.Image = null;
			CommodityImage = string.Empty;
			commodityImagePicturBox.BackgroundImage = Properties.Resources.icons8_box_100;
			commodityImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			quantityTextBox.Text = "0";
			unitComboBox.Text = "مثقال";
			commodityPriceTextBox.Text = "0";
			CommodityPrice = 0;
			totalPriceTextBox.Text = "0";
			TotalPrice = 0;
		}
		#endregion /AllClear 

		#region CustomerOrderRegister
		public void CustomerOrderRegister()
		{
			Models.DatabaseContext databaseContext = null;
			//-----Customer order registration
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string errorMessage = string.Empty;

				if (BuyerName == string.Empty)
				{
					errorMessage =
						"وارد کردن نام مشترک الزامی است!";
					buyerNameTextBox.Clear();
				}

				if (OrderDate == string.Empty)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage =
						"وارد کردن تاریخ سفارش الزامی است";
					orderDateMaskedBox.Clear();
				}

				if (CellPhone == string.Empty)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}

					errorMessage =
						"وارد کردن شماره همراه الزامی است!";
					cellPhoneMaskedBox.Clear();
				}

				if (Address == string.Empty)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine;
					}

					errorMessage =
						"وارد کردن آدرس مشترک جهت ارسال کالا الزامی است!";
					addressTextBox.Clear();
				}

				if (errorMessage != string.Empty)
				{
					if (buyerNameTextBox.Text == string.Empty)
					{
						buyerNameTextBox.Focus();
					}

					if (orderDateMaskedBox.Text == string.Empty)
					{
						orderDateMaskedBox.Focus();
					}

					if (cellPhoneMaskedBox.Text == string.Empty)
					{
						cellPhoneMaskedBox.Focus();
					}

					if (addressTextBox.Text == string.Empty)
					{
						addressTextBox.Focus();
					}

					Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

					return;
				}

				Models.CustomerOrder customerOrder = new Models.CustomerOrder
				{
					CommodityName = CommodityName,
					OrderAmount = OrderAmount.ToString(),
					CommodityUnit = FinalUnit,
					CommodityPrice = CommodityPrice.ToString(),
					TotalPrice = TotalPrice.ToString(),
					BuyerName = BuyerName,
					OrderDate = OrderDate,
					CellPhone = CellPhone,
					Phone = Phone,
					Address = Address,
					Description = Description,
				};

				databaseContext.CustomerOrders.Add(customerOrder);
				databaseContext.SaveChanges();
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
			//-----Customer order registration
		}
		#endregion /CustomerOrderRegister

		#endregion /Other Codes

		#region ShowDocumentButton_Click
		private void ShowDocumentButton_Click(object sender, System.EventArgs e)
		{
			buyerNameTextBox.Text = Infrastructure.Utility.FixText(buyerNameTextBox.Text);

			if (reportForm == null || reportForm.IsDisposed == true)
			{
				reportForm =
					new ReportForm();
			}
			reportForm.buyerNameTextBox.Text = BuyerName;

			//Models.DatabaseContext databaseContext = null;

			//try
			//{
			//	databaseContext =
			//		new Models.DatabaseContext();

			//	System.Collections.Generic.List<Models.CustomerOrder> customerOrders = null;

			//	if (reportForm.buyerNameTextBox.Text == string.Empty)
			//	{
			//		customerOrders =
			//			databaseContext.CustomerOrders
			//			.OrderBy(current => current.BuyerName)
			//			.ToList()
			//			;
			//	}
			//}
			//catch (System.Exception ex)
			//{

			//	Mbb.Windows.Forms.MessageBox.ErrorMessage(ex.Message);
			//}

			reportForm.Show();
		}
		#endregion /ShowDocumentButton_Click

		#region BuyerNameTextBox_TextChanged
		private void BuyerNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			BuyerName = buyerNameTextBox.Text;
		}
		#endregion /BuyerNameTextBox_TextChanged

		#region OrderDateMaskedBox_TextChanged
		private void OrderDateMaskedBox_TextChanged(object sender, System.EventArgs e)
		{
			OrderDate = orderDateMaskedBox.Text;
		}
		#endregion OrderDateMaskedBox_TextChanged

		#region CellPhoneMaskedBox_TextChanged
		private void CellPhoneMaskedBox_TextChanged(object sender, System.EventArgs e)
		{
			CellPhone = cellPhoneMaskedBox.Text;
		}
		#endregion /CellPhoneMaskedBox_TextChanged

		#region PhonNumberMaskedBox_TextChanged
		private void PhonNumberMaskedBox_TextChanged(object sender, System.EventArgs e)
		{
			Phone = phonNumberMaskedBox.Text;
		}
		#endregion /PhonNumberMaskedBox_TextChanged

		#region AddressTextBox_TextChanged
		private void AddressTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Address = addressTextBox.Text;
		}
		#endregion /AddressTextBox_TextChanged

		#region DescriptionTextBox_TextChanged
		private void DescriptionTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Description = descriptionTextBox.Text;
		}
		#endregion /DescriptionTextBox_TextChanged

		#region Functions
		//-----
		#region Calculat
		public void Calculat(string unit)
		{
			if (unit == "گرم")
			{
				if (OrderAmount > 1000)
				{
					OrderAmount /= 1000000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
				else
				{
					OrderAmount /= 1000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
			}

			else if (unit == "تن")
			{
				if (OrderAmount < 1)
				{
					OrderAmount *= 1000000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
				else
				{
					OrderAmount *= 1000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
			}

			else if (unit == "کیلوگرم")
			{
				if (OrderAmount < 1)
				{
					OrderAmount *= 1000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
				else if (OrderAmount > 1000)
				{

					OrderAmount /= 1000;
					TotalPrice = Infrastructure.Utility.Payment(quatity: OrderAmount, price: CommodityPrice);
					totalPriceTextBox.Text = TotalPrice.ToString("#,0");
				}
			}
		}

		#endregion /Calculat

		#region CommodityWeight
		public void CommodityWeight
			(string firstUnit, string secondUnit, decimal commodityQuantity, decimal commodityEntry)
		{
			#region Ton Unit
			//****************************************Ton Unit****************************************************
			if (firstUnit == "تن" && secondUnit == "تن")
			{
				//commodityEntry *= 1000;

				if (commodityQuantity == 0)
				{
					commodityQuantity = OriginalValue * 1000;
				}
				else if (commodityQuantity > 0)
				{
					commodityQuantity *= 1000;
				}

				if (commodityQuantity < commodityEntry)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("مقدار سفارش بیشتر از موجودی انبار است!");

					return;
				}

				FinalValue = (commodityQuantity - commodityEntry);

				if (FinalValue < 1)
				{
					string result = null;
					result = (FinalValue *= 1000).ToString();
					if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 5));
					}
					else if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Substring(0, 3));
					}

					FinalUnit = "گرم";
				}

				else if (FinalValue < 1000)
				{
					string result = null;

					if (FinalValue.ToString().Contains('/'))
					{
						result = FinalValue.ToString();
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/')));
					}
					else
					{
						FinalValue = decimal.Parse(FinalValue.ToString().Substring(0, 3));
					}

					FinalUnit = "کیلوگرم";
				}

				else
				{
					string result = (FinalValue /= 1000).ToString();

					if (result.EndsWith("/0"))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 3));
					}

					FinalUnit = "تن";
				}

				commodityEntry = 0;
				commodityQuantity = 0;
				

				return;
			}

			//****************************************************************************************************
			else if (firstUnit == "تن" && secondUnit == "کیلوگرم")
			{

				if (commodityQuantity == 0)
				{
					commodityQuantity = OriginalValue * 1000;
				}
				else if (commodityQuantity > 0)
				{
					commodityQuantity *= 1000;
				}

				if (commodityQuantity < commodityEntry)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("مقدار سفارش بیشتر از موجودی انبار است!");

					return;
				}

				FinalValue = (commodityQuantity - commodityEntry);

				if (FinalValue < 1)
				{
					string result = null;
					result = (FinalValue *= 1000).ToString();
					if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 5));
					}
					else if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Substring(0, 3));

					}

					FinalUnit = "گرم";
				}
				else if (FinalValue < 1000)
				{
					string result = null;

					if (FinalValue.ToString().Contains('/'))
					{
						result = FinalValue.ToString();
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/')));
					}
					else
					{
						FinalValue = decimal.Parse(FinalValue.ToString().Substring(0, 3));
					}

					FinalUnit = "کیلوگرم";
				}
				else
				{
					FinalValue /= 1000;
					FinalUnit = "تن";
				}

				commodityEntry = 0;
				commodityQuantity = 0;
				//FinalValue = 0;

				return;
			}

			//****************************************************************************************************
			else if (firstUnit == "تن" && secondUnit == "گرم")
			{
				if (commodityQuantity == 0)
				{
					commodityQuantity = OriginalValue * 1000000;
				}
				else if (commodityQuantity > 0)
				{
					commodityQuantity *= 1000000;
				}

				if (commodityQuantity < commodityEntry)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("در خواست بیشتر از موجودی است");

					return;
				}

				FinalValue = (commodityQuantity - commodityEntry);

				if (FinalValue < 1)
				{
					string result = null;
					result = (FinalValue *= 1000000).ToString();
					if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 5));
					}
					else if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Substring(0, 3));
					}

					FinalUnit = "گرم";
				}
				else if (FinalValue < 1000)
				{
					string result = null;

					if (FinalValue.ToString().Contains('/'))
					{
						result = FinalValue.ToString();
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/')));
					}
					else
					{
						FinalValue = decimal.Parse(FinalValue.ToString().Substring(0, 3));
					}

					FinalUnit = "کیلوگرم";
				}
				else
				{
					FinalValue /= 1000000;
					FinalUnit = "تن";
				}

				commodityEntry = 0;
				commodityQuantity = 0;

				return;
			}

			//**************************************End Ton Unit**************************************************
			#endregion /Ton Unit
			//****************************************************************************************************

			#region Kilogram Unit
			//*************************************Kilogram Unit**************************************************
			else if (firstUnit == "کیلوگرم" && secondUnit == "تن")
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage
					("مقدار سفارش بیشتر از موجودی انبار است!");

				return;
			}

			//****************************************************************************************************
			else if (firstUnit == "کیلوگرم" && secondUnit == "کیلوگرم")
			{
				commodityEntry *= 1000;

				if (commodityQuantity == 0)
				{
					commodityQuantity = OriginalValue * 1000;
				}
				else if (commodityQuantity > 0)
				{
					commodityQuantity *= 1000;
				}

				if (commodityQuantity < commodityEntry)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("مقدار سفارش بیشتر از موجودی انبار است!");

					return;
				}

				FinalValue = (commodityQuantity - commodityEntry);

				if (FinalValue == 0)
				{
					System.Windows.Forms.DialogResult dialogResult = System.Windows.Forms.MessageBox.Show
						(text: "موجودی صفر میشود. آیا سفارش را قبول میکنید؟",
						caption: "",
						buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
						defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
						icon: System.Windows.Forms.MessageBoxIcon.Warning,
						options: System.Windows.Forms.MessageBoxOptions.RightAlign |
						 System.Windows.Forms.MessageBoxOptions.RtlReading);
					if (dialogResult == System.Windows.Forms.DialogResult.Yes)
					{
						return;
					}
					else
					{
						quantityTextBox.Focus();
						return;
					}
				}

				if (FinalValue < 1000)
				{
					string result = null;

					if (FinalValue.ToString().Contains('/'))
					{
						result = FinalValue.ToString();
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/')));
					}
					else
					{
						FinalValue = decimal.Parse(FinalValue.ToString().Substring(0, 3));
					}

					FinalUnit = "گرم";
				}

				else
				{
					string result = (FinalValue /= 1000).ToString();

					if (result.EndsWith("/0"))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 3));
					}

					FinalUnit = "کیلوگرم";
				}

				commodityEntry = 0;
				commodityQuantity = 0;

				return;
			}

			//****************************************************************************************************
			else if (firstUnit == "کیلوگرم" && secondUnit == "گرم")
			{
				commodityEntry *= 1000;

				if (commodityQuantity == 0)
				{
					commodityQuantity = OriginalValue * 1000;
				}
				else if (commodityQuantity > 0)
				{
					commodityQuantity *= 1000;
				}

				if (commodityQuantity < commodityEntry)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("مقدار سفارش بیشتر از موجودی انبار است!");

					return;
				}

				FinalValue = (commodityQuantity - commodityEntry)/1000;

				if (FinalValue < 1)
				{
					string result = null;
					result = (FinalValue *= 1000).ToString();
					if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 5));
					}
					else if (result.Contains('/'))
					{
						FinalValue = decimal.Parse(result.Substring(0, 3));
					}

					FinalUnit = "گرم";
				}

				else if (FinalValue < 1000)
				{
					string result = null;

					if (FinalValue.ToString().Contains('/'))
					{
						result = FinalValue.ToString();
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/')));
					}
					else
					{
						FinalValue = decimal.Parse(FinalValue.ToString().Substring(0, 3));
					}

					FinalUnit = "کیلوگرم";
				}

				else
				{
					string result = (FinalValue /= 1000).ToString();

					if (result.EndsWith("/0"))
					{
						FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 3));
					}

					FinalUnit = "تن";
				}

				commodityEntry = 0;
				commodityQuantity = 0;

				return;
			}
			//*************************************End Kilogram Unit**************************************************
			#endregion /Kilogram Unit

			//****************************************************************************************************
			#region Gram Unit

			//***************************************Gram Unit****************************************************
			else if (firstUnit == "گرم" && secondUnit == "تن")
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage
					("مقدار سفارش بیشتر از موجودی انبار است!");

				return;
			}

			//****************************************************************************************************
			else if (firstUnit == "گرم" && secondUnit == "کیلوگرم")
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage
					("مقدار سفارش بیشتر از موجودی انبار است!");

				return;
			}

			//****************************************************************************************************
			else if (firstUnit == "گرم" && secondUnit == "گرم")
			{
				commodityEntry *= 1000;

				if (commodityQuantity == 0)
				{
					commodityQuantity = OriginalValue * 1000;
				}
				else if (commodityQuantity > 0)
				{
					commodityQuantity *= 1000;
				}

				if (commodityQuantity < commodityEntry)
				{
					Mbb.Windows.Forms.MessageBox.ErrorMessage
						("مقدار سفارش بیشتر از موجودی انبار است!");

					return;
				}

				FinalValue = (commodityQuantity - commodityEntry);

				string result = (FinalValue /= 1000).ToString();

				if (result.EndsWith("/0"))
				{
					FinalValue = decimal.Parse(result.Remove(result.LastIndexOf('/'), 3));
				}
				FinalUnit = "گرم";

				commodityEntry = 0;
				commodityQuantity = 0;

				return;
			}

			//***************************************End Gram Unit****************************************************
			#endregion /Gram Unit
		}

		#endregion /CommodityWeight 
		//-----
		#endregion /Functions

		
	}
}
