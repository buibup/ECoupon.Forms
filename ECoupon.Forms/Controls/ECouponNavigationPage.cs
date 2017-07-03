using System;
using Xamarin.Forms;

namespace ECoupon.Forms.Controls
{
    public class ECouponNavigationPage: NavigationPage
    {
        public ECouponNavigationPage(Page root): base(root)
        {
            Init();
        }
        public ECouponNavigationPage()
        {
            Init();
        }
		void Init()
		{

			BarBackgroundColor = Color.FromHex("#03A9F4");
			BarTextColor = Color.White;
		}
    }
}
