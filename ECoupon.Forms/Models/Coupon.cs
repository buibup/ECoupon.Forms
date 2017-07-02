using System;
namespace ECoupon.Forms.Models
{
    public class Coupon
    {
		public int COUPON_ID { get; set; }
		public string CODE { get; set; }
		public int ORDER_ID { get; set; }
		public int MEMBER_ID { get; set; }
		public string USERNAME { get; set; }
		public string NAME { get; set; }
		public string PACKAGE_NAME { get; set; }
		public string STATUS { get; set; }
		public string DATE_PURCHASED { get; set; }
		public string DATE_EXPIRED { get; set; }
		public double TOTAL_PRICE { get; set; }
		public int AMOUNT { get; set; }
		public string EVENTNAME { get; set; }
    }
}
