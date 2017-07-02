using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ECoupon.Forms.Models;
using ECoupon.Forms.ViewModels;
using Newtonsoft.Json;

namespace ECoupon.Forms.Helpers
{
    public class OAuth
    {
		static string baseUri = "https://ecoupon.bdms.co.th/eCouponAPI/";

		public static async Task<string> GetAccessToken(string userName, string password)
		{

			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseUri);

				// We want the response to be JSON
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				// Build up the data to POST.
				List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>()
				{
					new KeyValuePair<string, string>("grant_type","password"),
					new KeyValuePair<string, string>("username",userName),
					new KeyValuePair<string, string>("password", password)
				};

				FormUrlEncodedContent content = new FormUrlEncodedContent(postData);

				// Post to the Server and parse the response.
				using (HttpResponseMessage response = await client.PostAsync("Token", content))
				{
					string jsonString = await response.Content.ReadAsStringAsync();
					Token tokenData = JsonConvert.DeserializeObject<Token>(jsonString);
					return tokenData.AccessToken;
				}
			}
		}

		public static async Task<CouponViewModels> GetCoupon(string accessToken)
		{
			CouponViewModels data = new CouponViewModels();
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(baseUri);
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

				// Add the Autorization header with the AccessToken
				client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);

				// ceate the URL string.
				string url = string.Format("api/CouponsNew");

				// make the request
				HttpResponseMessage response = await client.GetAsync(url);

				// parse the response and return the data. 
				string jsonSting = await response.Content.ReadAsStringAsync();
				data = JsonConvert.DeserializeObject<CouponViewModels>(jsonSting);
				return data;
			}
		}
    }
}
