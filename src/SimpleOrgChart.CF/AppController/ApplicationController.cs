using EventAggregator.CF;
using Ninject.Core;
using SimpleOrgChart.AppController;

namespace SimpleOrgChart.CF.AppController
{
	public class ApplicationController : IApplicationController
	{

		private IKernel Container { get; set; }
		private IEventPublisher EventPublisher { get; set; }

		public ApplicationController(IKernel container, IEventPublisher eventPublisher)
		{
			Container = container;
			EventPublisher = eventPublisher;
			
			Container.Inject(this);
		}

		public void Execute<T>(T commandData)
		{
			ICommand<T> command = Container.Get<ICommand<T>>();
			if (command != null)
				command.Execute(commandData);
		}

		public void Raise<T>(T eventData)
		{
			EventPublisher.Publish(eventData);
		}

	}
}