using System;

namespace CfpExchange.Common.Models
{
	public class CfpBaseModel
	{
		public string Slug { get; set; }

		public string EventName { get; set; }

		public string EventDescription { get; set; }

		public string EventLocationName { get; set; }

		public string EventUrl { get; set; } = string.Empty;

		public string EventTags { get; set; } = String.Empty;

		private string _eventImage;

		public string EventImage
		{
			get => string.IsNullOrWhiteSpace(_eventImage) ? Constants.NO_EVENT_IMAGE_URL : _eventImage;
			set => _eventImage = value;
		}

		public DateTime EventStartDate { get; set; }

		public DateTime EventEndDate { get; set; }

		public DateTime CfpEndDate { get; set; }

		public DateTime CfpStartDate { get; set; }

		public bool? ProvidesAccommodation { get; set; }

		public bool? ProvidesTravelAssistance { get; set; }

		public string CfpUrl { get; set; } = string.Empty;

		public bool IsVirtual { get; set; }

		public string ShortDescription
		{
			get
			{
				if (EventDescription?.Length > 140)
					return $"{EventDescription.Substring(0, 140)}...";

				return EventDescription;
			}
		}

		public string ReallyShortDescription
		{
			get
			{
				if (EventDescription?.Length > 40)
					return $"{EventDescription.Substring(0, 40)}...";

				return EventDescription;
			}
		}
	}
}
