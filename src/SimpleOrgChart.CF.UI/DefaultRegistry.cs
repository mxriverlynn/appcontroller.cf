using System;
using System.Windows.Forms;
using EventAggregator.CF;
using Microsoft.Win32;
using Ninject.Core;
using Ninject.Core.Activation;
using Ninject.Core.Behavior;
using Ninject.Core.Interception;
using SimpleOrgChart.App;
using SimpleOrgChart.App.NewEmployeeProcess;
using SimpleOrgChart.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart.AppController;
using SimpleOrgChart.CF.App;
using SimpleOrgChart.CF.App.NewEmployeeProcess;
using SimpleOrgChart.CF.App.NewEmployeeProcess.SupplyEmployeeInfo;
using SimpleOrgChart.CF.AppController;
using SimpleOrgChart.Model;
using SimpleOrgChart.Repositories;

namespace SimpleOrgChart.CF.UI
{
	public class DefaultRegistry : StandardModule
	{

		public override void Load()
		{
			Bind<IApplicationController>()
				.To<ApplicationController>()
				.Using<SingletonBehavior>();

			Bind<IEventPublisher>()
				.To<EventPublisher>()
				.Using<SingletonBehavior>();

			Bind<IEmployeeRepository>()
				.To<InMemoryEmployeeRepository>();

			Bind<ICommand<AddNewEmployeeData>>()
				.To<AddNewEmployeeService>();

			Bind<IGetNewEmployeeInfo>()
				.To<NewEmployeeInfoPresenter>();

			Bind<INewEmployeeInfoView>()
				.To<NewEmployeeInfoForm>();

			Bind<IGetEmployeeManager>()
				.To<SelectEmployeeManagerPresenter>();

			Bind<ISelectEmployeeManagerView>()
				.To<SelectEmployeeManagerForm>();

			Bind<EmployeeDetailPresenter>()
				.To<EmployeeDetailPresenter>();
		}

	}
}