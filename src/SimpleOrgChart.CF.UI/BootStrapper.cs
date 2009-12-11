using System.Windows.Forms;
using Ninject.Core;
using SimpleOrgChart.App;

namespace SimpleOrgChart.CF.UI
{
	public class BootStrapper
	{

		private IKernel Container { get; set; }

		public BootStrapper(IKernel container)
		{
			Container = container;
		}

		public Form GetMainForm()
		{
			MainForm mainForm = new MainForm();
			Container.Inject(mainForm);
			
			OrgChartPresenter presenter = Container.Get<OrgChartPresenter>();
			presenter.Run();
			
			return mainForm;
		}

	}
}