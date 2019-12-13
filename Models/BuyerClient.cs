using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class BuyerClient : BaseEntity
	{
		public BuyerClient() : base()
		{

		}

		#region FullName
		[System.ComponentModel.DisplayName(displayName: "نام و نام خانوادگی")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		public string FullName { get; set; }
		#endregion /FullName
		//-----
		#region Phone
		[System.ComponentModel.DataAnnotations.StringLength
					(maximumLength: 11)]

		[System.ComponentModel.DataAnnotations.Schema.Index
					(IsUnique = true)]

		public string Phone { get; set; }
		#endregion /Phone
		//-----
		#region CellPhone
		[System.ComponentModel.DataAnnotations.StringLength
							(maximumLength: 11)]

		[System.ComponentModel.DataAnnotations.Schema.Index
							(IsUnique = true)]

		public string CellPhone { get; set; }
		#endregion /CellPhone
		//-----
		#region Address
		[System.ComponentModel.DataAnnotations.StringLength
						(maximumLength: 300)]
		[System.ComponentModel.DataAnnotations.Schema.Index
				(IsUnique = true)]

		public string Address { get; set; }
		#endregion Address
		//-----
		#region Description
		public string Description { get; set; }
		#endregion /Description
	}
}
