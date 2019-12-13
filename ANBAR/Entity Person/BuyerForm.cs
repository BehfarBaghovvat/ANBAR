using System.Linq;
namespace ANBAR.Client
{
	public partial class BuyerForm : Infrastructure.BaseForm
	{
		public BuyerForm() : base()
		{
			InitializeComponent();
		}

		#region Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }

		#endregion /Properties

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



				//*****

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = System.Windows.Forms.MessageBox.Show
					(text: "آیا خریدار مورد نظر ثبت گردد؟",
					caption: "تایید ثبت مشتری",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				//if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				//{
				//	Models.BuyerClient buyerClient =
				//	databaseContext.Buyers
				//	.Where(current => string.Compare(current.FullName, ) == 0)
				//	.FirstOrDefault();

				//	if (buyerClient != null)
				//	{
				//		errorMessage =
				//			"کالای مورد نظر در انبار موجود می باشد.";

				//		Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

				//		return;
				//	}

				//	buyerClient = new Models.BuyerClient
				//	{
						
				//	};

				//	databaseContext.Commodities.Add();
				//	databaseContext.SaveChanges();

				//	Mbb.Windows.Forms.MessageBox.InformationMessage("اطلاعات با موفقیت ذخیره گردید");

					
				//}

			}
			catch (System.Exception ex)
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage(ex.Message);
			}
		}

		private void FirstNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			FirstName = firstNameTextBox.Text;

			FullName = FirstName + " " + LastName;
		}

		private void LastNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			LastName = lastNameTextBox.Text;

			FullName = FirstName + " " + LastName;
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show(FullName);
		}
	}
}
