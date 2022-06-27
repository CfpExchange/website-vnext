namespace CfpExchange.Common.Models
{
	public class ContributorModel
	{
		public string Login { get; set; }
		public int Id { get; set; }
		public string Node_id { get; set; }
		public string Avatar_url { get; set; }
		public string Gravatar_id { get; set; }
		public string Url { get; set; }
		public string Html_url { get; set; }
		public string Followers_url { get; set; }
		public string Following_url { get; set; }
		public string Gists_url { get; set; }
		public string Starred_url { get; set; }
		public string Subscriptions_url { get; set; }
		public string Organizations_url { get; set; }
		public string Repos_url { get; set; }
		public string Events_url { get; set; }
		public string Received_events_url { get; set; }
		public string Type { get; set; }
		public bool Site_admin { get; set; }
		public int Contributions { get; set; }
	}

}
