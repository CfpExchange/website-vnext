using Microsoft.Azure.Functions.Extensions.DependencyInjection;

using CfpExchange.Functions.API;

using RvdB.Scrapionize.Extensions;

[assembly: FunctionsStartup(typeof(Startup))]
namespace CfpExchange.Functions.API
{
	public class Startup : FunctionsStartup
	{
		public override void Configure(IFunctionsHostBuilder builder)
		{
			builder.Services.AddScrapionize();
		}
	}
}
