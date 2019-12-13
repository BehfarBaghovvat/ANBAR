using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANBAR
{
	public static class Program
	{
		public static Models.User Authenticate { get; set; }

		public static Models.Commodity AutenticatCommodity { get; set; }

		#region LoginForm
		private static LoginForm loginForm;

		public static LoginForm LoginForm
		{
			get
			{
				if (loginForm == null || loginForm.IsDisposed == true)
				{
					loginForm =
						new LoginForm();
				}

				return loginForm;
			}
		}

		public static void ShowLoginForm()
		{
			LoginForm.Show();
			LoginForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		}
		#endregion /LoginForm
		//==================================================

		//==================================================
		#region RegisterForm
		public static RegisterForm registerForm;

		public static RegisterForm RegistrForm
		{
			get
			{
				if (registerForm == null || registerForm.IsDisposed == true)
				{
					registerForm =
						new RegisterForm();
				}

				return registerForm;
			}
		}
		public static void ShowRegisterForm()
		{
			RegistrForm.Show();
			RegistrForm.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		}
		#endregion /RegisterForm
		//==================================================

		//==================================================
		#region MainForm
		public static MainForm mainForm;
		public static MainForm MainForm
		{
			get
			{
				if (mainForm == null || mainForm.IsDisposed == true)
				{
					mainForm =
						new MainForm();
				}

				return mainForm;
			}
		}

		public static void ShowMainForm()
		{
			MainForm.Initialize();
			MainForm.Show();
		}

		#endregion /MainForm
		//==================================================

		//==================================================
		#region CommoditySellingForm
		public static CommoditySellingForm commoditySellingForm = null;

		public static CommoditySellingForm CommoditySellingForm
		{
			get
			{
				if (commoditySellingForm == null || commoditySellingForm.IsDisposed == true)
				{
					commoditySellingForm =
						new CommoditySellingForm();
				}

				return commoditySellingForm;
			}
		}
		#endregion /CommoditySellingForm
		//==================================================

		//==================================================
		#region AdminUser
		private static void AdminUser()
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				string username = "Administrator";

				Models.User adminuser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, username, true) == 0)
					.FirstOrDefault();

				if (adminuser == null)
				{
					adminuser = new Models.User
					{
						IsActive = true,
						IsAdministrator = true,
						Username = username,
						Password = "12345",
					};

					databaseContext.Users.Add(adminuser);
				}

				else
				{
					if (adminuser.IsActive == false)
					{
						adminuser.IsActive = true;
					}

					if (adminuser.IsAdministrator == false)
					{
						adminuser.IsAdministrator = true;
					}
				}

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
		}
		#endregion /AdminUser
		//==================================================

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AdminUser();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
