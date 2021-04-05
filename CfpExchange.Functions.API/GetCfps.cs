using System.Threading.Tasks;

using CfpExchange.Common.Entities;
using CfpExchange.Common.Helpers;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace CfpExchange.Functions.API
{
	public static class GetCfps
	{
		[FunctionName(nameof(GetCfps))]
		public static async Task<IActionResult> Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "cfps")] HttpRequest req,
			[Table(nameof(Cfp), Connection = "StorageConnectionString")] CloudTable table, ILogger log)
		{
			var entities = await TableStorageHelper.GetEntitiesFromTableAsync<Cfp>(table);

			return new OkObjectResult(entities);
		}
	}
}
