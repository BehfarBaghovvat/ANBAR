using System;
using System.Linq;
namespace ANBAR
{
	public partial class CommodityStockForm : Infrastructure.BaseForm
	{
		public CommodityStockForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string CommodityName { get; set; }
		public string PurchaseDate { get; set; }
		#endregion /Properties

		#region CommodityStockForm
		//-----
		#region CommodityStockForm_Load
		private void CommodityStockForm_Load(object sender, EventArgs e)
		{
			CommodityLoader();

			myDataGridView.CellDoubleClick += MyDataGridView_CellDoubleClick;
		}

		#endregion /CommodityStockForm_Load
		//==================================================
		#region CommodityStockForm_FormClosed
		private void CommodityStockForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			this.Hide();
		}
		#endregion /CommodityStockForm_FormClosed 
		//-----
		#endregion /CommodityStockForm

		#region SearchCommodityNameTextBox
		//-----
		#region	SearchCommodityNameTextBox_TextChanged
		private void SearchCommodityNameTextBox_TextChanged(object sender, EventArgs e)
		{
			CommodityName = searchCommodityNameTextBox.Text;

			if (searchCommodityNameTextBox.Text.Contains("نام کالا را وارد نمایید..."))
			{
				return;
			}

			searchCommodityNameTextBox.Text = Infrastructure.Utility.FixText(searchCommodityNameTextBox.Text);

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
						.ToList()
						;
				}
				else
				{
					commodities =
						databaseContext.Commodities
						.Where(current => current.CommodityName.Contains(searchCommodityNameTextBox.Text))
						.OrderBy(current => current.CommodityName)
						.ToList()
						;
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
		private void SearchCommodityNameTextBox_Enter(object sender, EventArgs e)
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
		private void SearchCommodityNameTextBox_Leave(object sender, EventArgs e)
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
		#endregion SearchCommodityNameTextBox

		#region SearchPurchaseDateMaskedBox_TextChanged
		private void SearchPurchaseDateMaskedBox_TextChanged(object sender, EventArgs e)
		{
			PurchaseDate = searchPurchaseDateMaskedBox.Text;

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
						.Where(current => current.PurchaseDate.Contains(searchPurchaseDateMaskedBox.Text))
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
		#endregion /SearchPurchaseDateMaskedBox_TextChanged

		#region MyDataGridView_CellDoubleClick
		private void MyDataGridView_CellDoubleClick
			(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			string selectCommodityName =
				myDataGridView.CurrentRow.Cells[0].Value.ToString();

			CommodityEditForm commodityEditForm = new CommodityEditForm
			{
				commodityStockForm = this,
				CommodityName = selectCommodityName,
			};

			commodityEditForm.ShowDialog();
		}
		#endregion /MyDataGridView_CellDoubleClick

		#region CommodityLoader
		public  void CommodityLoader()
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
			catch (Exception ex)
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
	}
}