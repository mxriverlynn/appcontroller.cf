using System;
using EventAggregator.CF;
using Ninject.Core;
using SimpleOrgChart.AppController;

namespace SimpleOrgChart.CF.AppController
{
	public class ApplicationController : IApplicationController
	{

		private IKernel Kernel { get; set; }
		private IEventPublisher EventPublisher { get; set; }

		public ApplicationController(IKernel kernel, IEventPublisher eventPublisher)
		{
			Kernel = kernel;
			EventPublisher = eventPublisher;
		}

		public void Execute<T>(T commandData)
		{
			ICommand<T> command = Kernel.Get<ICommand<T>>();
			if (command != null)
				command.Execute(commandData);
		}

		public void Raise<T>(T eventData)
		{
			EventPublisher.Publish(eventData);
		}

		public void RegisterHandlers(object eventHandlerObject)
		{
			EventPublisher.RegisterHandlers(eventHandlerObject);
		}
	}
}