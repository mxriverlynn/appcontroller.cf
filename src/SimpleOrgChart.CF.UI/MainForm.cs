using System.Collections.Generic;
using System.Windows.Forms;
using Ninject.Core;
using Ninject.Core.Behavior;
using SimpleOrgChart.App;
using SimpleOrgChart.CF.App;
using SimpleOrgChart.Model;

namespace SimpleOrgChart.CF.UI
{
	public partial class MainForm : Form, IOrgChartView
	{

		public OrgChartPresenter Presenter { get; set; }

		public MainForm(IKernel kernel)
		{
			InitializeComponent();
			kernel.Load(new InlineModule(f =>
     		{
     			f.Bind<IOrgChartView>().ToConstant(this);
     			f.Bind<IEmployeeDetailView>().ToConstant(ViewEmployeeDetail);
     		}));
		}

		public void DisplayEmployeeHierarchy(IList<Employee> employees)
		{
			OrgChart.Nodes.Clear();

			foreach (Employee employee in employees)
			{
				TreeNode node = GetNode(employee);
				IList<TreeNode> children = GetChildren(employee);
				foreach (TreeNode childNode in children)
					node.Nodes.Add(childNode);
				OrgChart.Nodes.Add(node);
			}
			OrgChart.ExpandAll();
		}

		private TreeNode GetNode(Employee employee)
		{
			TreeNode node = new TreeNode(employee.DisplayName);
			node.Tag = employee;
			return node;
		}

		private IList<TreeNode> GetChildren(Employee employee)
		{
			IList<TreeNode> nodes = new List<TreeNode>();
			foreach (Employee child in employee.Employees)
			{
				TreeNode node = GetNode(child);
				IList<TreeNode> children = GetChildren(child);
				foreach (TreeNode childNode in children)
					node.Nodes.Add(childNode);
				nodes.Add(node);
			}
			return nodes;
		}

		private void OrgChart_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Employee employee = e.Node.Tag as Employee;
			if (employee != null)
				Presenter.EmployeeSelected(employee);
		}

		private void AddNewEmployee_Click(object sender, System.EventArgs e)
		{
			Presenter.AddNewEmployeeRequested();
		}

	}
}