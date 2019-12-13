namespace Models
{
	public class DatabaseContext : System.Data.Entity.DbContext
	{
		static DatabaseContext()
		{
			System.Data.Entity.Database.SetInitializer
				(new System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>());
		}

		public DatabaseContext() : base()
		{
		}

		public System.Data.Entity.DbSet<User> Users { get; set; }

		public System.Data.Entity.DbSet<Commodity> Commodities { get; set; }

		public System.Data.Entity.DbSet<BuyerClient> Buyers { get; set; }

		public System.Data.Entity.DbSet<CustomerOrder> CustomerOrders { get; set; }
	}
}
