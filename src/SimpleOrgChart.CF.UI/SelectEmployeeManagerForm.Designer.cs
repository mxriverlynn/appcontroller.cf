namespace SimpleOrgChart.CF.UI
{
	partial class SelectEmployeeManagerForm
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
			this.Employee = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ManagerList = new System.Windows.Forms.ListBox();
			this.Done = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Employee
			// 
			this.Employee.Location = new System.Drawing.Point(3, 23);
			this.Employee.Multiline = true;
			this.Employee.Name = "Employee";
			this.Employee.ReadOnly = true;
			this.Employee.Size = new System.Drawing.Size(234, 65);
			this.Employee.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.Text = "Employee:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.Text = "Select Manager:";
			// 
			// ManagerList
			// 
			this.ManagerList.Location = new System.Drawing.Point(3, 136);
			this.ManagerList.Name = "ManagerList";
			this.ManagerList.Size = new System.Drawing.Size(234, 72);
			this.ManagerList.TabIndex = 4;
			this.ManagerList.SelectedIndexChanged += new System.EventHandler(this.ManagerList_SelectedIndexChanged);
			// 
			// Done
			// 
			this.Done.Location = new System.Drawing.Point(128, 214);
			this.Done.Name = "Done";
			this.Done.Size = new System.Drawing.Size(109, 51);
			this.Done.TabIndex = 5;
			this.Done.Text = "Done";
			this.Done.Click += new System.EventHandler(this.Done_Click);
			// 
			// SelectEmployeeManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.ControlBox = false;
			this.Controls.Add(this.Done);
			this.Controls.Add(this.ManagerList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Employee);
			this.Menu = this.mainMenu1;
			this.Name = "SelectEmployeeManagerForm";
			this.Text = "SelectEmployeeManagerForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox Employee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox ManagerList;
		private System.Windows.Forms.Button Done;

	}
}