namespace SimpleOrgChart.CF.UI
{
	partial class NewEmployeeInfoForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.FirstName = new System.Windows.Forms.TextBox();
			this.LastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Next = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 24);
			this.label1.Text = "First Name:";
			// 
			// FirstName
			// 
			this.FirstName.Location = new System.Drawing.Point(92, 3);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(145, 21);
			this.FirstName.TabIndex = 1;
			this.FirstName.TextChanged += new System.EventHandler(this.FirstName_TextChanged);
			// 
			// LastName
			// 
			this.LastName.Location = new System.Drawing.Point(92, 30);
			this.LastName.Name = "LastName";
			this.LastName.Size = new System.Drawing.Size(145, 21);
			this.LastName.TabIndex = 3;
			this.LastName.TextChanged += new System.EventHandler(this.LastName_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 24);
			this.label2.Text = "Last Name:";
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(3, 81);
			this.Email.Multiline = true;
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(234, 62);
			this.Email.TabIndex = 6;
			this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 21);
			this.label3.Text = "Email:";
			// 
			// Next
			// 
			this.Next.Location = new System.Drawing.Point(127, 149);
			this.Next.Name = "Next";
			this.Next.Size = new System.Drawing.Size(110, 40);
			this.Next.TabIndex = 8;
			this.Next.Text = "Next";
			this.Next.TextChanged += new System.EventHandler(this.Next_Click);
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(3, 149);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(110, 40);
			this.Cancel.TabIndex = 9;
			this.Cancel.Text = "Cancel";
			this.Cancel.TextChanged += new System.EventHandler(this.Cancel_Click);
			// 
			// NewEmployeeInfoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(240, 268);
			this.ControlBox = false;
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.Next);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.LastName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.FirstName);
			this.Controls.Add(this.label1);
			this.Menu = this.mainMenu1;
			this.Name = "NewEmployeeInfoForm";
			this.Text = "NewEmployeeInfoForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FirstName;
		private System.Windows.Forms.TextBox LastName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button Next;
		private System.Windows.Forms.Button Cancel;
	}
}