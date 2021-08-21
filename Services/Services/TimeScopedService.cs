using System;

namespace Services.Services
{
	public class TimeScopedService : ITimeScoped
	{
		private readonly string instantiatedOn;
		public TimeScopedService()
		{
			instantiatedOn = DateTime.Now.ToString(Resources.AppResources.DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
		}

		public string GetTime()
		{
			return instantiatedOn;
		}
	}
}
