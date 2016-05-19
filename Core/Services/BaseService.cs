using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Core.Services
{
	public abstract class BaseService
	{
		public async Task<IList<TResult>> Get<TResult>(string endPoint) where TResult : class
		{
			string url = string.Format("{0}{1}", ConfigApp.RestApiBaseUrl, endPoint);

			HttpClient httpClient = new HttpClient ();
			HttpRequestMessage request = new HttpRequestMessage (HttpMethod.Get, url);
			request.Headers.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));
			HttpResponseMessage response = await httpClient.SendAsync (request);
			string result = await response.Content.ReadAsStringAsync ();
			return JsonConvert.DeserializeObject<IList<TResult>>(result);
		}

		public async Task<TResult> Get<TResult>(string endPoint, string id) where TResult : class
		{
			string url = string.Format("{0}{1}/{2}", ConfigApp.RestApiBaseUrl, endPoint, id);

			HttpClient httpClient = new HttpClient ();
			HttpRequestMessage request = new HttpRequestMessage (HttpMethod.Get, url);
			request.Headers.Accept.Add (new MediaTypeWithQualityHeaderValue ("application/json"));
			HttpResponseMessage response = await httpClient.SendAsync (request);
			string result = await response.Content.ReadAsStringAsync ();
			return JsonConvert.DeserializeObject<TResult>(result);
		}
	}
}

