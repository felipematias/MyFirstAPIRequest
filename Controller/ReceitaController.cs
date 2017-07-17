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
    public class ReceitaController
    {
		private static readonly string API_URL = @"https://www.receitaws.com.br/v1/cnpj/";

		public ReceitaModel GetCNPJInfo(string cnpj)
		{

			try
			{
				string request = string.Concat(API_URL, cnpj);
				WebRequest webRequest = WebRequest.Create(request);
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
				WebResponse httpResponse = webRequest.GetResponse();
				StreamReader loResponseStream = new StreamReader(httpResponse.GetResponseStream());
				string response = loResponseStream.ReadToEnd();
				ReceitaModel model = Deserialize(response);
				return model;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public static ReceitaModel Deserialize(string json)
		{
			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ReceitaModel));
			return new JavaScriptSerializer().Deserialize<ReceitaModel>(json);
		}
	}
}
