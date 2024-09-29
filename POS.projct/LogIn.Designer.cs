namespace POS.projct
{
	partial class LogIn
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
			this.TextUser = new System.Windows.Forms.TextBox();
			this.TextPassword = new System.Windows.Forms.TextBox();
			this.User = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TextUser
			// 
			this.TextUser.Location = new System.Drawing.Point(170, 38);
			this.TextUser.Name = "TextUser";
			this.TextUser.Size = new System.Drawing.Size(112, 20);
			this.TextUser.TabIndex = 1;
			// 
			// TextPassword
			// 
			this.TextPassword.Location = new System.Drawing.Point(170, 93);
			this.TextPassword.Name = "TextPassword";
			this.TextPassword.PasswordChar = '*';
			this.TextPassword.Size = new System.Drawing.Size(112, 20);
			this.TextPassword.TabIndex = 1;
			// 
			// User
			// 
			this.User.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User.BackgroundImage")));
			this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.User.FlatAppearance.BorderSize = 0;
			this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.User.Location = new System.Drawing.Point(183, 146);
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(82, 30);
			this.User.TabIndex = 4;
			this.User.Text = "LogIn";
			this.User.UseVisualStyleBackColor = false;
			this.User.Click += new System.EventHandler(this.User_Click);
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.Location = new System.Drawing.Point(86, 28);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(52, 39);
			this.button2.TabIndex = 3;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::POS.projct.Properties.Resources._225_2251197_users_and_permissions_permission_icon_png;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(86, 85);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(52, 35);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImage = global::POS.projct.Properties.Resources.OIP__7_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(401, 214);
			this.Controls.Add(this.User);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.TextPassword);
			this.Controls.Add(this.TextUser);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogIn";
			this.RightToLeftLayout = true;
			this.Text = "LogIn";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox TextUser;
		private System.Windows.Forms.TextBox TextPassword;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button User;
	}
}

