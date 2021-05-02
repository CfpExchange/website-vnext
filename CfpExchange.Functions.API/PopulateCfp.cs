using System;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using CfpExchange.Common.Models;

using RvdB.Scrapionize.Interfaces;

namespace CfpExchange.Functions.API
{
	public class PopulateCfp
	{
		private IScraper _scraper;

		public PopulateCfp(IScraper scraper)
		{
			_scraper = scraper;
		}

		[FunctionName(nameof(PopulateCfp))]
		public async Task<IActionResult> Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] PopulateCfpModel model,
			ILogger log)
		{
			if (model == null)
			{
				return new BadRequestResult();
			}

			var sessionizeData = _scraper.Scrape(new Uri(model.CfpUrl));
			var cfpModel = new CfpBaseModel
			{
				CfpUrl = model.CfpUrl,
				CfpEndDate = sessionizeData.CfpEndDate,
				CfpStartDate = sessionizeData.CfpStartDate,
				EventLocationName = sessionizeData.Location,
				EventName = sessionizeData.EventName,
				EventEndDate = sessionizeData.EventEndDate,
				EventStartDate = sessionizeData.EventStartDate
				//ProvidesAccommodation = sessionizeData.Accommodation,
				//ProvidesTravelAssistance = sessionizeData.Travel
			};


			return new OkObjectResult(cfpModel);
		}
	}
}
