namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		#region IsActive
		[System.ComponentModel.DisplayName(displayName: "فعال")]

		// دستور ذیل کار نمی‌کند
		//[System.ComponentModel.DataAnnotations.Display(Name = "فعال")]
		public bool IsActive { get; set; }
		#endregion /IsActive
		// **********

		// **********
		#region IsAdministrator
		[System.ComponentModel.DisplayName(displayName: "مدیر")]
		public bool IsAdministrator { get; set; }
		#endregion /IsAdministrator
		// **********

		// **********
		#region Username
		[System.ComponentModel.DisplayName(displayName: "شناسه‌کاربر")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string Username { get; set; }
		#endregion /Username
		// **********

		// **********
		#region Password
		[System.ComponentModel.Browsable(browsable: false)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40)]
		public string Password { get; set; }
		#endregion /Password
		// **********

		// **********
		#region FullName
		[System.ComponentModel.DisplayName(displayName: "نام و نام خانوادگی")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]
		public string FullName { get; set; }
		#endregion
		// **********

		// **********
		#region Description
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 200)]
		[System.ComponentModel.Browsable(browsable: false)]
		public string Description { get; set; }
		#endregion Description
		// **********

		// **********
		#region AdministratorDescription
		[System.ComponentModel.Browsable(browsable: false)]
		public string AdministratorDescription { get; set; }
		#endregion /AdministratorDescription
		// **********
	}
}
