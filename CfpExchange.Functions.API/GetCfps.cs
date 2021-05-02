using System.Collections.Generic;

using CfpExchange.Common.Entities;
using CfpExchange.Common.Models;

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
		public static IActionResult Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "cfps")] HttpRequest req,
			[Table(nameof(Cfp), Connection = "StorageConnectionString")] CloudTable table, ILogger log)
		{
			//var entities = await TableStorageHelper.GetEntitiesFromTableAsync<Cfp>(table);

			var entities = new List<CfpBaseModel>
			{
				new CfpBaseModel { Slug = "future-tech-2021", EventName = "Future Tech 2021" },
				new CfpBaseModel { Slug = "techorama-2021", EventName = "Techorama 2021" },
				new CfpBaseModel { Slug = "azure-lowlands", EventName = "Azure Lowlands", EventImage = "https://www.azurelowlands.com/wp-content/uploads/2018/09/Header.jpg" }
			};

			return new OkObjectResult(entities);
		}
	}
}
