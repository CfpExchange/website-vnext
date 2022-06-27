using Azure;
using Azure.Data.Tables;

using System;
using System.Runtime.Serialization;

namespace CfpExchange.Common.Entities
{
	public class Cfp : ITableEntity
	{
		#region ITableEntity properties

		public string PartitionKey { get; set; }
		public string RowKey { get; set; }
		public DateTimeOffset? Timestamp { get; set; }
		public ETag ETag { get; set; }

		#endregion

		[IgnoreDataMember]
		public Guid Id
		{
			get => Guid.Parse(RowKey);
			set => RowKey = value.ToString();
		}

		public string EventName { get; set; }

		public string EventDescription { get; set; }

		public string EventLocationName { get; set; }

		public double EventLatitude { get; set; }

		public double EventLongitude { get; set; }

		public string EventUrl { get; set; } = string.Empty;

		public int EventType { get; set; }

		public string EventImage { get; set; }

		public DateTime EventStartDate { get; set; }

		public DateTime EventEndDate { get; set; }

		public string EventTimezone { get; set; }

		public string EventTwitterHandle { get; set; }

		public string Tags { get; set; } = string.Empty;

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public DateTime DecisionDate { get; set; }

		public DateTime DateAdded { get; set; }

		public bool? ProvidesAccommodation { get; set; }

		public bool? ProvidesTravelAssistance { get; set; }

		public string CfpUrl { get; set; } = string.Empty;

		public string Remarks { get; set; }

		public int Views { get; set; }

		public int ClicksToCfpUrl { get; set; }

		public string SubmittedBy { get; set; }

		public string Slug { get; set; }
	}
}
