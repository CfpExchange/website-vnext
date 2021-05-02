using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using CfpExchange.Common.Models;

using RvdB.Scrapionize.Interfaces;
using RvdB.Scrapionize.Models;

namespace CfpExchange.Functions.API
{
	public class PopulateCfp
	{
		private readonly IScraper _scraper;

		public PopulateCfp(IScraper scraper)
		{
			_scraper = scraper;
		}

		[FunctionName(nameof(PopulateCfp))]
		public IActionResult Run(
			[HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] PopulateCfpModel model)
		{
			if (model == null)
			{
				return new BadRequestResult();
			}

			SessionizeData sessionizeData = _scraper.Scrape(new Uri(model.CfpUrl));
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
