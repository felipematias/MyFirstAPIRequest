using Model;
using Model.Receita;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Script.Serialization;

namespace Controller
{
    public class RatesController
    {
		private static readonly string API_URL = @"http://api.fixer.io/latest?base=";

		public Model.Conversao GetCurrencyInfo(string currency)
		{

			try
			{
				string request = string.Concat(API_URL, currency);
				WebRequest webRequest = WebRequest.Create(request);
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
				WebResponse httpResponse = webRequest.GetResponse();
				StreamReader loResponseStream = new StreamReader(httpResponse.GetResponseStream());
				string response = loResponseStream.ReadToEnd();
				Model.Conversao model = Deserialize(response);
				return model;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public static Conversao Deserialize(string json)
		{
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReceitaModel));
			return new JavaScriptSerializer().Deserialize<Conversao>(json);
		}
	}
}
