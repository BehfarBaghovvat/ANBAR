using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class CustomerOrder : Models.BaseEntity
	{
		public CustomerOrder() : base()
		{

		}

		#region CommodityName

		[System.ComponentModel.DisplayName(displayName: "نام کالا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string CommodityName { get; set; }

		#endregion /CommodityName

		//==================================================

		//*****
		#region OrderAmount

		[System.ComponentModel.DisplayName(displayName: "مقدار سفارش")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 10)]
		public string OrderAmount { get; set; }

		#endregion OrderAmount

		//*****
		#region CommodityUnit
		[System.ComponentModel.DisplayName(displayName: "واحد")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 10)]

		public string CommodityUnit { get; set; }
		#endregion CommodityUnit

		//==================================================

		#region CommodityPrice

		[System.ComponentModel.DisplayName(displayName: "قیمت کالا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 20)]
		public string CommodityPrice { get; set; }

		#endregion CommodityPrice

		//==================================================

		#region TotalPrice

		[System.ComponentModel.DisplayName(displayName: "جمع کل")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 25)]
		public string TotalPrice { get; set; }

		#endregion /TotalPrice

		//==================================================

		#region BuyerName

		[System.ComponentModel.DisplayName(displayName: "نام خریدار")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]
		public string BuyerName { get; set; }
		#endregion /BuyerName

		//==================================================

		#region OrderDate

		[System.ComponentModel.DisplayName(displayName: "تاریخ سفارش")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]
		public string OrderDate { get; set; }
		#endregion /OrderDate

		//==================================================

		#region CellPhone

		[System.ComponentModel.DisplayName(displayName: "تلفن همراه")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 13)]
		public string CellPhone { get; set; }

		#endregion /CellPhone

		//==================================================
		#region Phone
		[System.ComponentModel.DisplayName(displayName: "تلفن ثابت")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 9)]

		public string Phone { get; set; }
		#endregion /Phone
		//==================================================

		#region Address

		[System.ComponentModel.DisplayName(displayName: "آدرس")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250)]

		public string Address { get; set; }
		#endregion /Address

		//==================================================
		#region Description

		[System.ComponentModel.DisplayName(displayName: "توضیحات")]

		public string Description { get; set; }
		#endregion /Description

		//==================================================
	}
}
