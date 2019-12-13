using System;

namespace ANBAR.Infrastructure
{
	class Utility
	{
		#region PersianCalendar
		/// <summary>
		/// نمایش سال شمسی
		/// </summary>
		/// <param name="date">دریافت تاریخ روز میلادی</param>
		/// <returns></returns>
		private static int PersianCalendar(System.DateTime date)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = int.Parse(persianCalendar.GetYear(date).ToString());

			return year;
		}
		#endregion /PersianCalendar

		#region SetPersianCalender
		/// <summary>
		/// مبدل تاریخ میلادی به شمسی 
		/// </summary>
		/// <param name="dateTime">دریافت تاریخ میلادی</param>
		/// <returns></returns>
		public static string SetPersianCalender(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;
		}
		#endregion /SetPersianCalender

		#region ShowWithNameMonthPersianCalenda
		/// <summary>
		/// نمایش تقویم فارسی به همراه اسامی ماه ها
		/// </summary>
		/// <param name="dateTime">Parametr of Date</param>
		/// <returns></returns>
		public static string ShowWithNameMonthPersianCalenda(System.DateTime dateTime)
		{
			string persianMonth = string.Empty;

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			switch (month)
			{
				case 1:
					persianMonth = "فروردین";
					break;

				case 2:
					persianMonth = "اردیبهشت";
					break;

				case 3:
					persianMonth = "خرداد";
					break;

				case 4:
					persianMonth = "تیر";
					break;

				case 5:
					persianMonth = "مرداد";
					break;

				case 6:
					persianMonth = "شهریور";
					break;

				case 7:
					persianMonth = "مهر";
					break;

				case 8:
					persianMonth = "آبان";
					break;

				case 9:
					persianMonth = "آذر";
					break;

				case 10:
					persianMonth = "دی";
					break;

				case 11:
					persianMonth = "بهمن";
					break;

				case 12:
					persianMonth = "اسفند";
					break;

				default:
					System.Windows.Forms.MessageBox.Show("محدوده ماه مورد نظر اشتباه است.");
					break;
			}

			string showCalendar =
				day.ToString().PadLeft(2, '0') + " / " +
				persianMonth + " / " +
				year.ToString();
			return showCalendar;

		}
		#endregion /ShowWithNameMonthPersianCalenda

		#region ShowWithoutNameMonthPersianCalenda
		/// <summary>
		/// View Persian Calendar.
		/// </summary>
		/// <param name="dateTime">Calendar entry</param>
		/// <returns></returns>
		public static string ShowWithOutNameMonthPersianCalenda(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;

		}
		#endregion / ShowWithoutNameMonthPersianCalenda

		#region CalculateAge
		public static int CalculateAge(int birthYear)
		{
			int agePerson;

			agePerson = PersianCalendar(System.DateTime.Now) - birthYear;

			return agePerson;
		}
		#endregion /CalculateAge

		#region FixText
		/// <summary>
		/// Remove extra text distances.
		/// </summary>
		/// <param name="text">Input text</param>
		/// <returns></returns>
		public static string FixText(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			text.Trim();

			if (text == string.Empty)
			{
				return string.Empty;
			}

			while (text == "  ")
			{
				text =
					text.Replace("  ", " ");
			}

			return text;
		}
		#endregion FixText

		#region Exit
		public static void Exit()
		{
			System.Windows.Forms.DialogResult dialogResult;

			dialogResult = System.Windows.Forms.MessageBox.Show(
				text: "آیا قصد خروج از برنامه را دارید؟",
				caption: "اطلاع",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /Exit

		#region Payment
		/// <summary>
		///  Calculate the cost of purchasing commodity.
		/// </summary>
		/// <param name="quatity"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		public static decimal Payment(decimal quatity, decimal price)
		{
			decimal payment;

			payment = quatity * price;

			return payment;
		}
		#endregion /Payment
	}
}
