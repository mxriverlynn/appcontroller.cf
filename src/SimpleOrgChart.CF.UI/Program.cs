using System.Windows.Forms;
using Ninject.Core;

namespace SimpleOrgChart.CF.UI
{
	static class Program
	{

		static void Main()
		{
			BootStrapper bootStrapper = new BootStrapper(new StandardKernel());
			Application.Run(bootStrapper.GetMainForm());
		}

	}
}