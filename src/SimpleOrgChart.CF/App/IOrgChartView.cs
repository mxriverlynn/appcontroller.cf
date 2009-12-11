using System.Collections.Generic;
using SimpleOrgChart.Model;

namespace SimpleOrgChart.CF.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
		OrgChartPresenter Presenter { get; set; }
	}
}