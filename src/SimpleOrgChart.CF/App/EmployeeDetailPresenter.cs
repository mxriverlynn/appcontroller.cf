using EventAggregator.CF;
using Ninject.Core;
using Ninject.Core.Infrastructure;
using SimpleOrgChart.App;
using SimpleOrgChart.Model;

namespace SimpleOrgChart.CF.App
{
	public class EmployeeDetailPresenter: IEventHandler<EmployeeSelectedEvent>
	{

		private IEmployeeDetailView View { get; set; }

		public EmployeeDetailPresenter(IEmployeeDetailView view, IKernel kernel)
		{
			View = view;
			SetupEventHandler(kernel);
		}

		private void SetupEventHandler(ILocator kernel)
		{
			IEventPublisher eventPublisher = kernel.Get<IEventPublisher>();
			eventPublisher.RegisterHandlers(this);
		}

		public void Handle(EmployeeSelectedEvent employeeSelectedEvent)
		{
			Employee employee = employeeSelectedEvent.Employee;
			View.DisplayEmployeeName(employee.FirstName, employee.LastName);
			View.DisplayEmployeeEmail(employee.Email);
		}

	}
}