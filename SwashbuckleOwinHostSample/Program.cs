using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwashbuckleOwinHostSample
{
	class Program
	{
		static void Main(string[] args)
		{
			string baseAddress = "http://localhost:9000/";

			using (WebApp.Start<Startup>(url: baseAddress))
			{
				HttpClient client = new HttpClient();

				var response = client.GetAsync(baseAddress + "api/users").Result;

				Console.WriteLine(response);
				Console.WriteLine(response.Content.ReadAsStringAsync().Result);

				Console.ReadLine();
			}
		}
	}
}
