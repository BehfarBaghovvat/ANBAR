using System.Linq;
namespace ANBAR
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm() : base()
		{
			InitializeComponent();
		}

		#region Initialize
		public void Initialize()
		{
			usernameLabel.Visible = true;
			usernameTextBox.Text = string.Empty;
			usernameTextBox.Focus();

			passwordLabel.Visible = false;
			passwordTextBox.Text = "رمز عبور";
			passwordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /Initialize

		#region LoginForm_FormClosed
		private void LoginForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /LoginForm_FormClosed

		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			usernameLabel.Visible = true;
			if (string.Compare(usernameTextBox.Text, "شناسه کاربری", true) == 0)
			{
				usernameTextBox.Text = string.Empty;
			}
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_Leave
		private void UsernameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				usernameLabel.Visible = false;
				usernameTextBox.Text = "شناسه کاربری";
			}
		}
		#endregion /UsernameTextBox_Leave

		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordLabel.Visible = true;
			if (string.Compare(passwordTextBox.Text, "رمز عبور", true) == 0)
			{
				passwordTextBox.Text = string.Empty;
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordLabel.Visible = false;
				passwordTextBox.Text = "رمز عبور";
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordTextBox_Leave

		#region ShowPasswordPicturBox_MouseDown
		private void ShowPasswordPicturBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showPasswordPicturBox.Image = Properties.Resources.icons8_hide_100;

			if (string.Compare(passwordTextBox.Text, "رمز عبور", false) != 0)
			{
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}

		#endregion /ShowPasswordPicturBox_MouseDown

		#region ShowPasswordPicturBox_MouseUp
		private void ShowPasswordPicturBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showPasswordPicturBox.Image = Properties.Resources.icons8_eye_100;
			if (string.Compare(passwordTextBox.Text, "رمز عبور", false) != 0)
			{
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /ShowPasswordPicturBox_MouseUp

		#region LoginPicturBox_Click
		private void LoginPicturBox_Click(object sender, System.EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DatabaseContext();

				#region Validation
				string errorMessage = null;

				if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
					string.Compare(usernameTextBox.Text, "شناسه کاربری", false) == 0)
				{
					errorMessage =
						"شناسه کاربری را وارد نمایید!";

					usernameTextBox.Focus();
				}

				if (string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
					string.Compare(passwordTextBox.Text, "رمز عبور", false) == 0)
				{
					if (errorMessage != null)
					{
						errorMessage +=
							System.Environment.NewLine;
					}
					errorMessage +=
						"رمز عبور را وارد نمایید!";

					passwordTextBox.Focus();
				}

				if (errorMessage != null)
				{
					if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
						string.Compare(usernameTextBox.Text, "شناسه کاربری", false) == 0)
					{
						usernameTextBox.Focus();
					}

					else if (string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
						string.Compare(passwordTextBox.Text, "رمز عبور", false) == 0)
					{
						passwordTextBox.Focus();
					}
					Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);
					return;
				}

				#endregion Validation

				#region FoundUser

				Models.User foundUser =
					databaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (foundUser == null)
				{
					errorMessage =
						"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";

					Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

					usernameTextBox.Focus();

					return;
				}

				if (string.Compare(foundUser.Password, passwordTextBox.Text, false) != 0)
				{
					errorMessage =
						"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";

					Mbb.Windows.Forms.MessageBox.ErrorMessage(errorMessage);

					passwordTextBox.Focus();

					return;
				}

				if (foundUser.IsActive == false)
				{
					errorMessage =
						"کاربر گرامی حساب کاربری شما تا اطلاع ثانوی مسدود می باشد.";

					usernameTextBox.Focus();

					return;
				}
				#endregion /FoundUser

				Hide();

				Program.Authenticate = foundUser;

				Models.Commodity commodity =
					databaseContext.Commodities.FirstOrDefault();

				Initialize();

				Program.AutenticatCommodity = commodity;

				Program.ShowMainForm();
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
		#endregion /LoginPicturBox_Click

		#region LoginPicturBox_MouseEnter
		private void LoginPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			loginPicturBox.Image = Properties.Resources.LoginButton_Glow;
		}
		#endregion /LoginPicturBox_MouseEnter

		#region LoginPicturBox_MouseLeave
		private void LoginPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			loginPicturBox.Image = Properties.Resources.LoginButton;
		}
		#endregion /LoginPicturBox_MouseLeave

		#region ResetPicturBox_Click
		private void ResetPicturBox_Click(object sender, System.EventArgs e)
		{
			Initialize();
		}
		#endregion /ResetPicturBox_Click

		#region ResetPicturBox_MouseEnter
		private void ResetPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			resetPicturBox.Image = Properties.Resources.ResetButton_Glow;
		}
		#endregion ResetPicturBox_MouseEnter

		#region ResetPicturBox_MouseLeave
		private void ResetPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			resetPicturBox.Image = Properties.Resources.ResetButton;
		}
		#endregion ResetPicturBox_MouseLeave

		#region RegisterPicturBox_Click
		private void RegisterPicturBox_Click(object sender, System.EventArgs e)
		{
			Initialize();
			Hide();
			Program.ShowRegisterForm();

		}
		#endregion /RegisterPicturBox_Click

		#region RegisterPicturBox_MouseEnter
		private void RegisterPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			registerPicturBox.Image = Properties.Resources.RegisterButton_Glow;
		}
		#endregion /RegisterPicturBox_MouseEnter

		#region RegisterPicturBox_MouseLeave
		private void RegisterPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			registerPicturBox.Image = Properties.Resources.RegisterButton;
		}
		#endregion /RegisterPicturBox_MouseLeave

		#region ExitPicturBox_Click
		private void ExitPicturBox_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ExitPicturBox_Click

		#region ExitPicturBox_MouseEnter
		private void ExitPicturBox_MouseEnter(object sender, System.EventArgs e)
		{
			exitPicturBox.Image = Properties.Resources.ExitButton_Glow;
		}
		#endregion /ExitPicturBox_MouseEnter

		#region ExitPicturBox_MouseLeave
		private void ExitPicturBox_MouseLeave(object sender, System.EventArgs e)
		{
			exitPicturBox.Image = Properties.Resources.ExitButton;
		}
		#endregion /ExitPicturBox_MouseLeave
	}
}
