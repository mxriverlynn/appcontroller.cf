using System.Windows.Forms;
using Ninject.Core;

namespace SimpleOrgChart.CF.UI
{
	static class Program
	{

		static void Main()
		{
			IKernel kernel = new StandardKernel();
			BootStrapper bootStrapper = new BootStrapper(kernel);

			Application.Run(bootStrapper.GetMainForm());
		}

	}
}