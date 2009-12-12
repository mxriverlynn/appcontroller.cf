using EventAggregator.CF;
using Ninject.Core;
using NUnit.Framework;
using Rhino.Mocks;
using SimpleOrgChart.App;
using SimpleOrgChart.CF.App;
using SimpleOrgChart.CF.AppController;
using SimpleOrgChart.Model;
using SpecUnit;

namespace SimpleOrgChart.UnitTests
{
	public class ViewEmployeeDetailSpecs
	{

		public class ViewEmployeeDetailSpecsContext : ContextSpecification
		{

			protected Employee bob;
			protected IEmployeeDetailView view;
			protected IApplicationController appController;

			protected override void SharedContext()
			{
				bob = new Employee("Bob", "Jones", "bob.jones@example.com");
				view = MockRepository.GenerateMock<IEmployeeDetailView>();
				appController = MockRepository.GenerateMock<IApplicationController>();
			}

			protected EmployeeDetailPresenter GetPresenter()
			{
				EmployeeDetailPresenter presenter = new EmployeeDetailPresenter(view, appController);
				return presenter;
			}
		}

		[TestFixture]
		[Concern("View Employee Details")]
		public class When_an_employee_has_been_selected : ViewEmployeeDetailSpecsContext
		{

			protected override void Context()
			{
				EmployeeDetailPresenter presenter = GetPresenter();

				presenter.Handle(new EmployeeSelectedEvent(bob));
			}

			[Test]
			[Observation]
			public void Should_show_the_employee_name()
			{
				view.AssertWasCalled(v => v.DisplayEmployeeName(bob.FirstName, bob.LastName));
			}

			[Test]
			[Observation]
			public void Should_show_the_employee_email()
			{
				view.AssertWasCalled(v => v.DisplayEmployeeEmail(bob.Email));
			}

		}

	}

}
