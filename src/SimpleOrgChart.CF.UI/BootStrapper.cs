using System.Windows.Forms;
using Ninject.Core;
using SimpleOrgChart.CF.App;

namespace SimpleOrgChart.CF.UI
{
	public class BootStrapper
	{

		private IKernel Kernel { get; set; }

		public BootStrapper(IKernel container)
		{
			Kernel = container;
			Kernel.Load(new DefaultRegistry());
		}

		public Form GetMainForm()
		{
			MainForm mainForm = new MainForm(Kernel);
			OrgChartPresenter presenter = Kernel.Get<OrgChartPresenter>();
			presenter.Run();
			
			return mainForm;
		}

	}
}