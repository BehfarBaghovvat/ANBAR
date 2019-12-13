namespace ANBAR
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mymenuStrip1 = new Mbb.Windows.Forms.MenuStrip();
			this.mineMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commodityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commodityAddStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commoditySellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.relatedPeopleListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buyersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editSellersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.editBuyersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.mystatusStrip1 = new Mbb.Windows.Forms.StatusStrip();
			this.welcomeUsernameStatusLabel = new Mbb.Windows.Forms.StatusLabel();
			this.splitStatusLabel = new Mbb.Windows.Forms.StatusLabel();
			this.persianCalendarStatusLabel = new Mbb.Windows.Forms.StatusLabel();
			this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mymenuStrip1.SuspendLayout();
			this.mystatusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mymenuStrip1
			// 
			this.mymenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mineMenuToolStripMenuItem,
            this.settingToolStripMenuItem});
			this.mymenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.mymenuStrip1.Name = "mymenuStrip1";
			this.mymenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mymenuStrip1.Size = new System.Drawing.Size(884, 24);
			this.mymenuStrip1.TabIndex = 1;
			this.mymenuStrip1.Text = "menuStrip1";
			// 
			// mineMenuToolStripMenuItem
			// 
			this.mineMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem,
            this.commodityToolStripMenuItem,
            this.relatedPeopleListToolStripMenuItem,
            this.toolStripMenuItem1,
            this.logoutToolStripMenuItem,
            this.aboutMeToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.mineMenuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mineMenuToolStripMenuItem.Image")));
			this.mineMenuToolStripMenuItem.Name = "mineMenuToolStripMenuItem";
			this.mineMenuToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.mineMenuToolStripMenuItem.Text = "&منوی اصلی";
			this.mineMenuToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// commodityToolStripMenuItem
			// 
			this.commodityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commodityAddStripMenuItem,
            this.commoditySellingToolStripMenuItem});
			this.commodityToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commodityToolStripMenuItem.Image")));
			this.commodityToolStripMenuItem.Name = "commodityToolStripMenuItem";
			this.commodityToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.commodityToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.commodityToolStripMenuItem.Text = "&کالا";
			this.commodityToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.commodityToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
			// 
			// commodityAddStripMenuItem
			// 
			this.commodityAddStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commodityAddStripMenuItem.Image")));
			this.commodityAddStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.commodityAddStripMenuItem.Name = "commodityAddStripMenuItem";
			this.commodityAddStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
			this.commodityAddStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.commodityAddStripMenuItem.Text = "&افزودن کلا";
			this.commodityAddStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.commodityAddStripMenuItem.Click += new System.EventHandler(this.CommodityAddStripMenuItem_Click);
			// 
			// commoditySellingToolStripMenuItem
			// 
			this.commoditySellingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("commoditySellingToolStripMenuItem.Image")));
			this.commoditySellingToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.commoditySellingToolStripMenuItem.Name = "commoditySellingToolStripMenuItem";
			this.commoditySellingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.commoditySellingToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.commoditySellingToolStripMenuItem.Text = "&فروش کلا";
			this.commoditySellingToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.commoditySellingToolStripMenuItem.Click += new System.EventHandler(this.CommoditySellingToolStripMenuItem_Click);
			// 
			// relatedPeopleListToolStripMenuItem
			// 
			this.relatedPeopleListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sellersToolStripMenuItem,
            this.buyersToolStripMenuItem});
			this.relatedPeopleListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("relatedPeopleListToolStripMenuItem.Image")));
			this.relatedPeopleListToolStripMenuItem.Name = "relatedPeopleListToolStripMenuItem";
			this.relatedPeopleListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.relatedPeopleListToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.relatedPeopleListToolStripMenuItem.Text = "&لیست افراد مرتبط";
			this.relatedPeopleListToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sellersToolStripMenuItem
			// 
			this.sellersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sellersToolStripMenuItem.Image")));
			this.sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
			this.sellersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
			this.sellersToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.sellersToolStripMenuItem.Text = "&فروشندگان کالا";
			this.sellersToolStripMenuItem.Click += new System.EventHandler(this.SellersToolStripMenuItem_Click);
			// 
			// buyersToolStripMenuItem
			// 
			this.buyersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buyersToolStripMenuItem.Image")));
			this.buyersToolStripMenuItem.Name = "buyersToolStripMenuItem";
			this.buyersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
			this.buyersToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
			this.buyersToolStripMenuItem.Text = "&خریداران کالا";
			this.buyersToolStripMenuItem.Click += new System.EventHandler(this.BuyersToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.logoutToolStripMenuItem.Text = "&ورود مجدد";
			this.logoutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// aboutMeToolStripMenuItem
			// 
			this.aboutMeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutMeToolStripMenuItem.Image")));
			this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
			this.aboutMeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.aboutMeToolStripMenuItem.Text = "&درباره ما";
			this.aboutMeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.exitToolStripMenuItem.Text = "&خروج";
			this.exitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// settingToolStripMenuItem
			// 
			this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInformationToolStripMenuItem});
			this.settingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingToolStripMenuItem.Image")));
			this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
			this.settingToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.settingToolStripMenuItem.Text = "&تنظیمات";
			// 
			// editInformationToolStripMenuItem
			// 
			this.editInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUsersToolStripMenuItem,
            this.editSellersToolStripMenuItem1,
            this.editBuyersToolStripMenuItem1});
			this.editInformationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editInformationToolStripMenuItem.Image")));
			this.editInformationToolStripMenuItem.Name = "editInformationToolStripMenuItem";
			this.editInformationToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.editInformationToolStripMenuItem.Text = "&ویرایش اطلاعات";
			// 
			// editUsersToolStripMenuItem
			// 
			this.editUsersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editUsersToolStripMenuItem.Image")));
			this.editUsersToolStripMenuItem.Name = "editUsersToolStripMenuItem";
			this.editUsersToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.editUsersToolStripMenuItem.Text = "&کاربران";
			// 
			// editSellersToolStripMenuItem1
			// 
			this.editSellersToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editSellersToolStripMenuItem1.Image")));
			this.editSellersToolStripMenuItem1.Name = "editSellersToolStripMenuItem1";
			this.editSellersToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
			this.editSellersToolStripMenuItem1.Text = "&فروشندگان کالا";
			this.editSellersToolStripMenuItem1.Click += new System.EventHandler(this.EditSellersToolStripMenuItem1_Click);
			// 
			// editBuyersToolStripMenuItem1
			// 
			this.editBuyersToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("editBuyersToolStripMenuItem1.Image")));
			this.editBuyersToolStripMenuItem1.Name = "editBuyersToolStripMenuItem1";
			this.editBuyersToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
			this.editBuyersToolStripMenuItem1.Text = "&خریداران کالا";
			this.editBuyersToolStripMenuItem1.Click += new System.EventHandler(this.EditBuyersToolStripMenuItem1_Click);
			// 
			// mystatusStrip1
			// 
			this.mystatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.welcomeUsernameStatusLabel,
            this.splitStatusLabel,
            this.persianCalendarStatusLabel});
			this.mystatusStrip1.Location = new System.Drawing.Point(0, 739);
			this.mystatusStrip1.Name = "mystatusStrip1";
			this.mystatusStrip1.Size = new System.Drawing.Size(884, 22);
			this.mystatusStrip1.TabIndex = 3;
			this.mystatusStrip1.Text = "statusStrip1";
			// 
			// welcomeUsernameStatusLabel
			// 
			this.welcomeUsernameStatusLabel.Name = "welcomeUsernameStatusLabel";
			this.welcomeUsernameStatusLabel.Size = new System.Drawing.Size(55, 17);
			this.welcomeUsernameStatusLabel.Text = "نام کاربری";
			// 
			// splitStatusLabel
			// 
			this.splitStatusLabel.Name = "splitStatusLabel";
			this.splitStatusLabel.Size = new System.Drawing.Size(10, 17);
			this.splitStatusLabel.Text = "|";
			// 
			// persianCalendarStatusLabel
			// 
			this.persianCalendarStatusLabel.Name = "persianCalendarStatusLabel";
			this.persianCalendarStatusLabel.Size = new System.Drawing.Size(72, 17);
			this.persianCalendarStatusLabel.Text = "تقویم شمسی";
			// 
			// stockToolStripMenuItem
			// 
			this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
			this.stockToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.stockToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
			this.stockToolStripMenuItem.Text = "&انبار";
			this.stockToolStripMenuItem.Click += new System.EventHandler(this.StockToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 761);
			this.Controls.Add(this.mystatusStrip1);
			this.Controls.Add(this.mymenuStrip1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mymenuStrip1;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(900, 726);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "صفحه اصلی";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mymenuStrip1.ResumeLayout(false);
			this.mymenuStrip1.PerformLayout();
			this.mystatusStrip1.ResumeLayout(false);
			this.mystatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.MenuStrip mymenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mineMenuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commodityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commodityAddStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commoditySellingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem relatedPeopleListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sellersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buyersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editInformationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editUsersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editSellersToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem editBuyersToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private Mbb.Windows.Forms.StatusStrip mystatusStrip1;
		private Mbb.Windows.Forms.StatusLabel welcomeUsernameStatusLabel;
		private Mbb.Windows.Forms.StatusLabel splitStatusLabel;
		private Mbb.Windows.Forms.StatusLabel persianCalendarStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
	}
}

