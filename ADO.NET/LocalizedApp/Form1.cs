using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LocalizedApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label Wel_Label;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.Wel_Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Wel_Label
			// 
			this.Wel_Label.AccessibleDescription = resources.GetString("Wel_Label.AccessibleDescription");
			this.Wel_Label.AccessibleName = resources.GetString("Wel_Label.AccessibleName");
			this.Wel_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("Wel_Label.Anchor")));
			this.Wel_Label.AutoSize = ((bool)(resources.GetObject("Wel_Label.AutoSize")));
			this.Wel_Label.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("Wel_Label.Dock")));
			this.Wel_Label.Enabled = ((bool)(resources.GetObject("Wel_Label.Enabled")));
			this.Wel_Label.Font = ((System.Drawing.Font)(resources.GetObject("Wel_Label.Font")));
			this.Wel_Label.Image = ((System.Drawing.Image)(resources.GetObject("Wel_Label.Image")));
			this.Wel_Label.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("Wel_Label.ImageAlign")));
			this.Wel_Label.ImageIndex = ((int)(resources.GetObject("Wel_Label.ImageIndex")));
			this.Wel_Label.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("Wel_Label.ImeMode")));
			this.Wel_Label.Location = ((System.Drawing.Point)(resources.GetObject("Wel_Label.Location")));
			this.Wel_Label.Name = "Wel_Label";
			this.Wel_Label.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("Wel_Label.RightToLeft")));
			this.Wel_Label.Size = ((System.Drawing.Size)(resources.GetObject("Wel_Label.Size")));
			this.Wel_Label.TabIndex = ((int)(resources.GetObject("Wel_Label.TabIndex")));
			this.Wel_Label.Text = resources.GetString("Wel_Label.Text");
			this.Wel_Label.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("Wel_Label.TextAlign")));
			this.Wel_Label.Visible = ((bool)(resources.GetObject("Wel_Label.Visible")));
			// 
			// Form1
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.Wel_Label);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Form1";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
