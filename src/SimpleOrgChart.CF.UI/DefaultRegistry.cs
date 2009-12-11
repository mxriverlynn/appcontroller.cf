using System;
using System.Windows.Forms;
using EventAggregator.CF;
using Microsoft.Win32;
using Ninject.Core;
using Ninject.Core.Behavior;
using SimpleOrgChart.App;
using SimpleOrgChart.App.NewEmployeeProcess;
using SimpleOrgChart.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart.App.NewEmployeeProcess.SupplyEmployeeInfo;
using SimpleOrgChart.AppController;
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
				.To<ApplicationController>();

			Bind<IEventPublisher>()
				.To<EventPublisher>()
				.Using<SingletonBehavior>();

			Bind<IOrgChartView>()
				.To<MainForm>();

			Bind<IEmployeeRepository>()
				.To<InMemoryEmployeeRepository>();

			Bind<IEmployeeDetailView>()
				.To<ViewEmployeeDetailControl>();

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

			//RegisterInterceptor(new EventAggregatorInterceptor());
		}

	}
}