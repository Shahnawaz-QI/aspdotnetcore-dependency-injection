namespace Services.Models
{
	public class InitializationData
	{
		public string SingletonServiceInitializedOn { get; internal set; }
		public string TransientServiceInitializedOn { get; internal set; }
		public string ScopedServiceInitializedOn { get; internal set; }
	}
}