using System.Collections.Generic;
using System.Linq;
using Stimulsoft.Report.Dictionary;


namespace ANBAR
{
	public partial class ReportForm : Infrastructure.BaseForm
	{
		public ReportForm() : base()
		{
			InitializeComponent();
		}

		#region Properties
		public string Buyer { get; set; }
		public string Date { get; set; }
		public string CellPhone { get; set; }
		public string Address { get; set; }

		//-----CustomerOrder filed
		public string CommodityName { get; set; }
		public string OrderAmuont { get; set; }
		public string Unit { get; set; }
		public string Price { get; set; }
		public string TotalPrice { get; set; }
		#endregion /Properties

		//==================================================

		#region ReportForm_Load
		private void ReportForm_Load(object sender, System.EventArgs e)
		{
			StiDataSource dataSource;
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.CustomerOrder> customerOrders = null;


				customerOrders =
					databaseContext.CustomerOrders
					.Where(current => current.BuyerName.Contains(buyerNameTextBox.Text))
					.OrderBy(current => current.BuyerName)
					.ToList();

				orderDataGridView.DataSource = customerOrders;

				orderDataGridView.AutoResizeColumns
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
		#endregion /ReportForm_Load

		//==================================================

		#region OrderLoad
		public void OrderLoad()
		{
			orderDataGridView.ReadOnly = true;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.CustomerOrder> customerOrders = null;

				customerOrders =
					databaseContext.CustomerOrders
					.OrderBy(current => current.CommodityName)
					.ToList();

				orderDataGridView.DataSource = customerOrders;

				orderDataGridView.AutoResizeColumns
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
		#endregion /OrderLoad

		//==================================================

		#region BuyerNameTextBox_TextChanged
		private void BuyerNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			buyerNameTextBox.Text = Infrastructure.Utility.FixText(buyerNameTextBox.Text);

			Buyer = buyerNameTextBox.Text;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.CustomerOrder> customerOrders = null;


				customerOrders =
					databaseContext.CustomerOrders
					.Where(current => current.BuyerName.Contains(buyerNameTextBox.Text))
					.OrderBy(current => current.BuyerName)
					.ToList();

				orderDataGridView.DataSource = customerOrders;

				orderDataGridView.AutoResizeColumns
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

		#endregion /BuyerNameTextBox_TextChanged

		//==================================================

		#region OrderDateMaskedBox_MaskInputRejected
		private void OrderDateMaskedBox_MaskInputRejected(object sender, System.Windows.Forms.MaskInputRejectedEventArgs e)
		{
			Date = orderDateMaskedBox.Text;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.CustomerOrder> customerOrders = null;

				customerOrders =
						databaseContext.CustomerOrders
						.Where(current => current.OrderDate.Contains(orderDateMaskedBox.Text))
						.OrderBy(current => current.CommodityName)
						.ToList();

				orderDataGridView.DataSource = customerOrders;

				orderDataGridView.AutoResizeColumns
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

		#endregion /OrderDateMaskedBox_MaskInputRejected

		#region OrderDateMaskedBox_TextChanged
		private void OrderDateMaskedBox_TextChanged(object sender, System.EventArgs e)
		{
			Date = orderDateMaskedBox.Text;

			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				System.Collections.Generic.List<Models.CustomerOrder> customerOrders = null;

				customerOrders =
					databaseContext.CustomerOrders
					.Where(current => current.OrderDate.Contains(buyerNameTextBox.Text))
					.OrderBy(current => current.OrderDate)
					.ToList();

				orderDataGridView.DataSource = customerOrders;

				orderDataGridView.AutoResizeColumns
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
		#endregion /OrderDateMaskedBox_TextChanged

		//==================================================

		#region PrintFactorButton_Click
		private void PrintFactorButton_Click(object sender, System.EventArgs e)
		{
			StiVariable buyerName = new StiVariable("CustomerOrder", "Buyer_Name", typeof(string), Buyer, false);
			stiReport1.Dictionary.Variables.Add(buyerName);

			StiVariable orderDate = new StiVariable("CustomerOrder", "Date", typeof(string), Date, false);
			stiReport1.Dictionary.Variables.Add(orderDate);

			StiVariable cellPhone = new StiVariable("CustomerOrder", "Cell_Phone", typeof(string), CellPhone, false);
			stiReport1.Dictionary.Variables.Add(cellPhone);

			StiVariable addreess = new StiVariable("CustomerOrder", "Address", typeof(string), Address, false);
			stiReport1.Dictionary.Variables.Add(addreess);

			//List<Models.CustomerOrder> customerOrders = new List<Models.CustomerOrder>();
			//customerOrders.Clear();

			//for (int row = 0; row < orderDataGridView.RowCount-1; row++)
			//{
			//	//CommodityName = orderDataGridView.Rows[row].Cells[0].Value.ToString();
			//	//OrderAmuont = orderDataGridView.Rows[row].Cells[1].Value.ToString();
			//	//Unit = orderDataGridView.Rows[row].Cells[2].Value.ToString();
			//	//Price = orderDataGridView.Rows[row].Cells[3].Value.ToString();
			//	//TotalPrice = orderDataGridView.Rows[row].Cells[5].Value.ToString();
			//}



			//System.Windows.Forms.MessageBox.Show(orderDataGridView.RowCount.ToString());
			//System.Windows.Forms.MessageBox.Show(orderDataGridView.ColumnCount.ToString());

			stiReport1.Show();

		}

		#endregion /PrintFactorButton_Click

		private void CellPhoneMaskedBox_TextChanged(object sender, System.EventArgs e)
		{
			CellPhone = cellPhoneMaskedBox.Text;
		}

		private void AddressTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Address = addressTextBox.Text;
		}

		private void OrderDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			}

			System.Windows.Forms.MessageBox.Show("Row= " + e.RowIndex + " " + "Column= " + e.ColumnIndex);
		}
	}
}
