using System;
namespace ECoupon.Forms.Models
{
	public enum MenuType
	{
		Login,
		CouponItems,
		Twitter,
		Hanselminutes,
		Ratchet,
		DeveloperLife,
		Videos
	}
    public class HomeMenuItem: BaseModel
    {
		public HomeMenuItem()
		{
			MenuType = MenuType.Login;
		}
		public string Icon { get; set; }
		public MenuType MenuType { get; set; }
    }
}
