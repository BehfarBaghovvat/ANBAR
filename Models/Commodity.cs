namespace Models
{
	public class Commodity : BaseEntity
	{
		public Commodity()
		{

		}

		#region CommodityName

		[System.ComponentModel.DisplayName(displayName: "نام کالا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		public string CommodityName { get; set; }

		#endregion /CommodityName
		//==================================================
		#region SelleryName

		//این خط از نمایش در کنترل گیرید ویو جلو گیری میکند.
		[System.ComponentModel.Browsable(browsable: true)]

		[System.ComponentModel.DisplayName(displayName: "نام فروشنده")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string SelleryName { get; set; }

		#endregion /SelleryName
		//==================================================
		#region PurchaseDate

		[System.ComponentModel.DisplayName(displayName: "تاریخ خرید کالا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]

		public string PurchaseDate { get; set; }

		#endregion PurchaseDate
		//==================================================
		//*****
		#region Quantity

		[System.ComponentModel.DisplayName(displayName: "تعداد")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5)]

		public string Quantity { get; set; }

		#endregion /Quantity
		//*****
		#region Unit

		[System.ComponentModel.DisplayName(displayName: "واحد")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]

		public string Unit { get; set; }

		#endregion/ Unti
		//*****
		//==================================================
		#region CommodityPrice

		[System.ComponentModel.DisplayName(displayName: "قیمت کالا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string CommodityPrice { get; set; }

		#endregion /CommodityPrice
		//==================================================
		#region TotalPrice

		//این خط از نمایش در کنترل گیرید ویو جلو گیری میکند.
		[System.ComponentModel.Browsable(browsable: true)]

		[System.ComponentModel.DisplayName(displayName: "قیمت کل")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]

		public string TotalPrice { get; set; }

		#endregion TotalPrice
		//==================================================
		#region Description

		[System.ComponentModel.DisplayName(displayName: "توضیحات")]

		public string Description { get; set; }

		#endregion /Description
		//==================================================
		#region CommodityPictur

		//این خط از نمایش در کنترل گیرید ویو جلو گیری میکند.
		[System.ComponentModel.Browsable(browsable: true)]

		[System.ComponentModel.DisplayName(displayName: "عکس کالا")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]
		
		public byte[] CommodityPictur { get; set; }

		#endregion /CommodityPictur
		//==================================================
	}
}
