using System;
using System.Collections.Generic;
using ECoupon.Forms.Helpers;
using ECoupon.Forms.Models;
using ECoupon.Forms.ViewModels;
using Xamarin.Forms;

namespace ECoupon.Forms.Views
{
	public partial class LoginPage : ContentPage
	{

        static string accessToken = null;

		public LoginPage()
		{
			InitializeComponent();
		}

		async void OnSignUpButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SignUpPage());
		}

		async void OnLoginButtonClicked(object sender, EventArgs e)
		{
			var user = new User
			{
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			//var isValid = AreCredentialsCorrect(user);
            accessToken = await OAuth.GetAccessToken(user.Username, user.Password);

			if (accessToken != null)
			{
                CouponViewModels data = await OAuth.GetCoupon(accessToken);
				App.IsUserLoggedIn = true;
				Navigation.InsertPageBefore(new MainPage(), this);
				await Navigation.PopAsync();
			}
			else
			{
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect(User user)
		{
			return user.Username == Constants.Username && user.Password == Constants.Password;
		}
	}
}
