using System.Threading.Tasks;

using CfpExchange.Common.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using SendGrid.Helpers.Mail;

namespace CfpExchange.Functions.API
{
	public static class SendMail
	{
		#region Fields

		private const string MAIL_ADDRESS = "rickvdbosch@outlook.com";
		private const string MAIL_TEMPLATE = "<p>The contact form on cfp.exchange was filled in:</p><p>Name: {0}</p><p>Email: {1}</p><p>Message:</p><p>{2}</p>";

		#endregion

		[FunctionName("SendMail")]
		public static async Task<IActionResult> Run(
				[HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "contact")] ContactModel model,
				[SendGrid(ApiKey = "SendGridKey")] IAsyncCollector<SendGridMessage> messageCollector,
				ILogger log)
		{
			var message = new SendGridMessage();
			message.AddTo(MAIL_ADDRESS);
			message.AddContent("text/html", string.Format(MAIL_TEMPLATE, model.Name, model.Email, model.Message.Replace("\n", "<br>")));
			message.SetFrom(new EmailAddress(MAIL_ADDRESS));
			message.SetSubject("Contact form cfp.exchange");

			await messageCollector.AddAsync(message);

			return new OkResult();
		}
	}
}
