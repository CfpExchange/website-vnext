using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using CfpExchange.Common.Entities;
using CfpExchange.Common.Helpers;

namespace CfpExchange.Functions.API
{
	public static class GetCfpsFunction
	{
		[FunctionName(nameof(GetCfpsFunction))]
		public static async Task<IActionResult> Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "cfps")] HttpRequest req,
			[Table(nameof(Cfp), Connection = "StorageConnectionString")] CloudTable table, ILogger log)
		{
			var entities = await TableStorageHelper.GetEntitiesFromTableAsync<Cfp>(table);

			return new OkObjectResult(entities);
		}
	}
}

