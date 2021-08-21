using Microsoft.AspNetCore.Mvc;
using Services.Models;
using Services.Services;

namespace Services.Controllers
{
	public class DemoController : Controller
	{
		private readonly ITimeSingleton _timerSingleton;
		private readonly ITimeTransient _timerTransient;
		private readonly ITimeScoped _timerScoped;

		public DemoController(ITimeSingleton timerSingleton, ITimeTransient timerTransient, ITimeScoped timerScoped)
		{
			_timerSingleton = timerSingleton;
			_timerTransient = timerTransient;
			_timerScoped = timerScoped;
		}

		public IActionResult Index()
		{
			InitializationData initializationData = new()
			{
				SingletonServiceInitializedOn = _timerSingleton.GetTime(),
				TransientServiceInitializedOn = _timerTransient.GetTime(),
				ScopedServiceInitializedOn = _timerScoped.GetTime()
			};
			return View(initializationData);
		}
	}
}
