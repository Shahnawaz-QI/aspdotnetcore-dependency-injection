using System;

namespace Services.Services
{
	public class TimeSingletonService : ITimeSingleton
	{
		private readonly string instantiatedOn;
		public TimeSingletonService()
		{
			instantiatedOn = DateTime.Now.ToString(Resources.AppResources.DateTimeFormat, System.Globalization.CultureInfo.InvariantCulture);
		}

		public string GetTime()
		{
			return instantiatedOn;
		}
	}
}
