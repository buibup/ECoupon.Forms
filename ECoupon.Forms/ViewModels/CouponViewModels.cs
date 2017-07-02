using System;
using System.Collections.Generic;
using ECoupon.Forms.Models;

namespace ECoupon.Forms.ViewModels
{
    public class CouponViewModels
    {
		public Member member { get; set; }
		public List<Event> Events { get; set; }
		public List<Coupon> Coupons { get; set; }
    }
}
