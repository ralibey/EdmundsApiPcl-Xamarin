using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;

namespace EdmundsRestApi.GetMakes
{
	/// <summary>
	/// Request.
	/// </summary>
	public class Request
	{
		private string _apiKey = string.Empty;

		/// <summary>
		/// Initializes a new instance of the <see cref="EdmundsRestApi.GetMakes.Request"/> class.
		/// </summary>
		/// <param name="apiKey">API key.</param>
		public Request(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Gets the response async.
		/// </summary>
		/// <returns>The response async.</returns>
		/// <param name="year">Year.</param>
		public async Task<Response> GetResponseAsync(string year)
		{
			string view = "basic";
			string fmt = "json";
			string url = "http://api.edmunds.com/api/vehicle/v2/makes?fmt={0}&api_key={1}&year={2}&view={3}";
			url = string.Format(url, fmt, _apiKey, year, view);
			string responseContent = await new HttpClient().GetStringAsync(url).ConfigureAwait(false);
			System.Diagnostics.Debug.WriteLine(responseContent);
			return await Task.Run(() => JsonConvert.DeserializeObject<Response>(responseContent));
		}
	}

}

