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
			this.OrgChart = new System.Windows.Forms.TreeView();
			this.ViewEmployeeDetail = new SimpleOrgChart.CF.UI.ViewEmployeeDetailControl();
			this.AddNewEmployee = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// OrgChart
			// 
			this.OrgChart.Location = new System.Drawing.Point(3, 4);
			this.OrgChart.Name = "OrgChart";
			this.OrgChart.Size = new System.Drawing.Size(234, 131);
			this.OrgChart.TabIndex = 0;
			// 
			// ViewEmployeeDetail
			// 
			this.ViewEmployeeDetail.Location = new System.Drawing.Point(3, 141);
			this.ViewEmployeeDetail.Name = "ViewEmployeeDetail";
			this.ViewEmployeeDetail.Size = new System.Drawing.Size(234, 71);
			this.ViewEmployeeDetail.TabIndex = 1;
			// 
			// AddNewEmployee
			// 
			this.AddNewEmployee.Location = new System.Drawing.Point(3, 218);
			this.AddNewEmployee.Name = "AddNewEmployee";
			this.AddNewEmployee.Size = new System.Drawing.Size(234, 47);
			this.AddNewEmployee.TabIndex = 2;
			this.AddNewEmployee.Text = "Add New Employee";
			this.AddNewEmployee.Click += new System.EventHandler(this.AddNewEmployee_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.Controls.Add(this.AddNewEmployee);
			this.Controls.Add(this.ViewEmployeeDetail);
			this.Controls.Add(this.OrgChart);
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView OrgChart;
		private ViewEmployeeDetailControl ViewEmployeeDetail;
		private System.Windows.Forms.Button AddNewEmployee;
	}
}