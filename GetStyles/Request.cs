using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace EdmundsRestApi.GetStyles
{
	public class Request
	{
		/// <summary>
		/// The API key.
		/// </summary>
		private string _apiKey = string.Empty;

		/// <summary>
		/// Initializes a new instance of the <see cref="GetStyles.Request"/> class.
		/// </summary>
		/// <param name="apiKey">API key.</param>
		public Request(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Gets the response async.
		/// </summary>
		/// <param name="make">Make.</param>
		/// <param name="model">Model.</param>
		/// <param name="year">Year.</param>
		public async Task<Response> GetResponseAsync(string make, string model, string year)
		{
			string url = "https://api.edmunds.com/api/vehicle/v2/{0}/{1}/{2}/styles?view=full&fmt=json&api_key={3}";
			url = string.Format(url, make, model, year, _apiKey);

			string content = await new HttpClient().GetStringAsync(url).ConfigureAwait(false);
			System.Diagnostics.Debug.WriteLine(url);
			System.Diagnostics.Debug.WriteLine(content);

			return await Task.Run(() => JsonConvert.DeserializeObject<Response>(content));
		}
	}
}

