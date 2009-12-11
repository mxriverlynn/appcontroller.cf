namespace SimpleOrgChart.CF.UI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MainMenu mainMenu1;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.viewEmployeeDetailControl1 = new SimpleOrgChart.CF.UI.ViewEmployeeDetailControl();
			this.AddNewEmployee = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(3, 4);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(234, 131);
			this.treeView1.TabIndex = 0;
			// 
			// viewEmployeeDetailControl1
			// 
			this.viewEmployeeDetailControl1.Location = new System.Drawing.Point(3, 141);
			this.viewEmployeeDetailControl1.Name = "viewEmployeeDetailControl1";
			this.viewEmployeeDetailControl1.Size = new System.Drawing.Size(234, 71);
			this.viewEmployeeDetailControl1.TabIndex = 1;
			// 
			// AddNewEmployee
			// 
			this.AddNewEmployee.Location = new System.Drawing.Point(3, 218);
			this.AddNewEmployee.Name = "AddNewEmployee";
			this.AddNewEmployee.Size = new System.Drawing.Size(234, 47);
			this.AddNewEmployee.TabIndex = 2;
			this.AddNewEmployee.Text = "Add New Employee";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.AddNewEmployee);
			this.Controls.Add(this.viewEmployeeDetailControl1);
			this.Controls.Add(this.treeView1);
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private ViewEmployeeDetailControl viewEmployeeDetailControl1;
		private System.Windows.Forms.Button AddNewEmployee;
	}
}