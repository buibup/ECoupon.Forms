using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ECoupon.Forms.Controls;
using ECoupon.Forms.Models;
using ECoupon.Forms.ViewModels;
using Xamarin.Forms;

namespace ECoupon.Forms.Views
{
    public class RootPage:MasterDetailPage
    {
		public static bool IsUWPDesktop { get; set; }
		Dictionary<MenuType, NavigationPage> Pages { get; set; }
        public RootPage()
        {
			if (IsUWPDesktop)
				this.MasterBehavior = MasterBehavior.Popover;

			Pages = new Dictionary<MenuType, NavigationPage>();
			Master = new MenuPage(this);
			BindingContext = new BaseViewModel
			{
				Title = "Hanselman",
				Icon = "slideout.png"
			};
			//setup home page
			NavigateAsync(MenuType.Login);

			InvalidateMeasure();
        }

		public async Task NavigateAsync(MenuType id)
		{

			if (Detail != null)
			{
				if (IsUWPDesktop || Device.Idiom != TargetIdiom.Tablet)
					IsPresented = false;

				if (Device.RuntimePlatform == Device.Android)
					await Task.Delay(300);
			}

			Page newPage;
			if (!Pages.ContainsKey(id))
			{

				switch (id)
				{
					case MenuType.Login:
						Pages.Add(id, new ECouponNavigationPage(new LoginPage()));
						break;
					case MenuType.CouponItems:
						Pages.Add(id, new ECouponNavigationPage(new LoginPage()));
						break;
				}
			}

			newPage = Pages[id];
			if (newPage == null)
				return;

			//pop to root for Windows Phone
			if (Detail != null && Device.RuntimePlatform == Device.WinPhone)
			{
				await Detail.Navigation.PopToRootAsync();
			}

			Detail = newPage;
		}
    }
}
