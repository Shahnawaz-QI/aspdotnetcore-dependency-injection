using System;

namespace Services.Services
{
	public class TimeTransientService : ITimeTransient
	{
		private readonly string instantiatedOn;

		public TimeTransientService()
		{
			instantiatedOn = DateTime.Now.ToString(Resources.AppResources.DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
		}

		public string GetTime()
		{
			return instantiatedOn;
		}
	}
}
