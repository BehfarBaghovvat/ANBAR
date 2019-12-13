namespace ANBAR
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		#region MainForm
		//-----
		#region MainForm_Load
		public static CommodityStockForm commodityStockForm = null;
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			if (commodityStockForm == null || commodityStockForm.IsDisposed == true)
			{
				commodityStockForm =
					new CommodityStockForm
					{
						MdiParent = this,
					};
			}
			commodityStockForm.Show();
		}
		#endregion /MainForm_Load
		//-----
		#endregion /MainForm

		#region Initialize
		public void Initialize()
		{
			Models.User authenticatUser = Program.Authenticate;

			if (authenticatUser == null)
			{
				System.Windows.Forms.Application.Exit();
			}

			string name =
				authenticatUser.FullName;

			if (string.IsNullOrWhiteSpace(name) || string.Compare(name, "نام و نام خانوادگی", false) == 0)
			{
				name = authenticatUser.Username;
			}

			welcomeUsernameStatusLabel.Text =
					$" { name } خوش آمدید.";

			persianCalendarStatusLabel.Text =
				Infrastructure.Utility.ShowWithNameMonthPersianCalenda(System.DateTime.Now);
		}
		#endregion /Initialize

		#region StockToolStripMenuItem_Click
		private void StockToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (commodityStockForm == null || commodityStockForm.IsDisposed == true)
			{
				commodityStockForm =
					new CommodityStockForm()
					{
						MdiParent = this,
					};

				commodityStockForm.Show();
			}
		}
		#endregion /StockToolStripMenuItem_Click

		#region CommodityAddStripMenuItem_Click
		private CommodityAddForm commodityAddForm = null;
		private void CommodityAddStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (commodityAddForm == null || commodityAddForm.IsDisposed == true)
			{
				commodityAddForm =
					new CommodityAddForm()
					{
						MdiParent = this,
					};
				commodityAddForm.Show();
			}
		}
		#endregion /CommodityAddStripMenuItem_Click

		#region CommoditySellingToolStripMenuItem_Click
		private CommoditySellingForm commoditySellingForm = null;
		private void CommoditySellingToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (commoditySellingForm == null || commoditySellingForm.IsDisposed == true)
			{
				commoditySellingForm =
					new CommoditySellingForm
					{
						MdiParent = this,
					};
				commoditySellingForm.Show();
			}
		}
		#endregion /CommoditySellingToolStripMenuItem_Click

		#region CommodityEditToolStripMenuItem_Click
		private CommodityEditForm commodityEditForm = null;

		private void CommodityEditToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (commodityEditForm == null || commodityEditForm.IsDisposed == true)
			{
				commodityEditForm =
					new CommodityEditForm
					{
						MdiParent = this,
					};

				commodityEditForm.Show();
			}
		}
		#endregion /CommodityEditToolStripMenuItem_Click

		#region ExitToolStripMenuItem_Click
		private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitToolStripMenuItem_Click

		#region BuyersToolStripMenuItem_Click
		private void BuyersToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
		}
		#endregion /BuyersToolStripMenuItem_Click

		#region SellersToolStripMenuItem_Click
		private void SellersToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
		}
		#endregion /SellersToolStripMenuItem_Click

		#region EditSellersToolStripMenuItem1_Click
		private Client.SellerForm sellerForm = null;
		private void EditSellersToolStripMenuItem1_Click(object sender, System.EventArgs e)
		{
			if (sellerForm == null || sellerForm.IsDisposed == true)
			{
				sellerForm =
					new Client.SellerForm();
			}

			sellerForm.Show();
		}
		#endregion /EditSellersToolStripMenuItem1_Click

		#region EditBuyersToolStripMenuItem1_Click
		private Client.BuyerForm buyerForm = null;
		private void EditBuyersToolStripMenuItem1_Click(object sender, System.EventArgs e)
		{
			if (buyerForm == null || buyerForm.IsDisposed == true)
			{
				buyerForm =
					new Client.BuyerForm();
			}

			buyerForm.Show();
		}
		#endregion /EditBuyersToolStripMenuItem1_Click
	}
}
