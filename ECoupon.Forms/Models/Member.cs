using System;
namespace ECoupon.Forms.Models
{
    public class Member
    {
		public int? ID { get; set; }
		public int? MemberNo { get; set; }
		public string USERNAME { get; set; }
		public string EMAIL { get; set; }
		public string FIRSTNAME { get; set; }
		public string MIDDLENAME { get; set; }
		public string LASTNAME { get; set; }
		public string PERSONAL_ID { get; set; }
		public string PASSPORT_ID { get; set; }
		public string DOB { get; set; }
		public string HOME_TELNO { get; set; }
		public string MOBILENO { get; set; }
		public string ADDRESS1 { get; set; }
		public string ADDRESS2 { get; set; }
		public string POSTCODE { get; set; }
		public string BILLINGNAME { get; set; }
		public string BILLING_ADDRESS1 { get; set; }
		public string BILLING_ADDRESS2 { get; set; }
		public string BILLING_POSTCODE { get; set; }
		public string REMARKS { get; set; }
		public bool? ENABLED { get; set; }
		public string CREATED_DATETIME { get; set; }
		public string CREATED_BY { get; set; }
		public string UPDATED_DATETIME { get; set; }
		public string UPDATED_BY { get; set; }
		public string GENDER { get; set; }
    }
}
