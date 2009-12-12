namespace SimpleOrgChart.CF.AppController
{
	public interface IApplicationController
	{
		void Execute<T>(T commandData);
		void Raise<T>(T eventData);
		void RegisterHandlers(object eventHandlerObject);
	}
}