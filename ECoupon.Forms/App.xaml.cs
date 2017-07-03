using ECoupon.Forms.Views;
using Xamarin.Forms;

namespace ECoupon.Forms
{
    public partial class App : Application
    {
        public static bool IsWindows10 { get; set; }
		public static bool IsUserLoggedIn { get; set; }

		public App()
		{
			if (!IsUserLoggedIn)
			{
				MainPage = new NavigationPage(new LoginPage());
			}
			else
			{
				MainPage = new NavigationPage(new MainPage());
			}
		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
