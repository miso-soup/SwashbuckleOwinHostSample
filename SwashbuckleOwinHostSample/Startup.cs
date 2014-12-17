using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Swashbuckle.Application;

[assembly: OwinStartup(typeof(SwashbuckleOwinHostSample.Startup))]

namespace SwashbuckleOwinHostSample
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			HttpConfiguration config = new HttpConfiguration();

			//Swashbuckle の設定
			Swashbuckle.Bootstrapper.Init(config);
			SwaggerSpecConfig.Customize(c =>
			{
				var xmlPath = System.String.Format(@"{0}\SwashbuckleOwinHostSample.XML", System.AppDomain.CurrentDomain.BaseDirectory);
				// Self-host でない場合は HttpContext.Current.Server.MapPath("~/bin/SwashbuckleOwinHostSample.XML");

				c.IncludeXmlComments(xmlPath);
			});

			// ASP.NET Web API のルーティング設定
			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			app.UseWebApi(config);
		}
	}
}
