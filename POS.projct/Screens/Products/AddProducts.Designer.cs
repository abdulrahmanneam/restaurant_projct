namespace POS.projct.Screens.Products
{
	partial class AddProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.TxtUser = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.TextBarcode = new System.Windows.Forms.Label();
			this.TextName = new System.Windows.Forms.Label();
			this.TextPrice = new System.Windows.Forms.Label();
			this.TextQty = new System.Windows.Forms.Label();
			this.TextNote = new System.Windows.Forms.Label();
			this.A = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.User = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// TxtPassword
			// 
			this.TxtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.TxtPassword.Location = new System.Drawing.Point(511, 136);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.Size = new System.Drawing.Size(112, 20);
			this.TxtPassword.TabIndex = 11;
			this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
			// 
			// TxtUser
			// 
			this.TxtUser.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.TxtUser.Location = new System.Drawing.Point(511, 80);
			this.TxtUser.Name = "TxtUser";
			this.TxtUser.Size = new System.Drawing.Size(112, 20);
			this.TxtUser.TabIndex = 12;
			this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox1.Location = new System.Drawing.Point(511, 205);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(112, 20);
			this.textBox1.TabIndex = 12;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox2.Location = new System.Drawing.Point(511, 261);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(112, 20);
			this.textBox2.TabIndex = 11;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox3.Location = new System.Drawing.Point(57, 69);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(177, 84);
			this.textBox3.TabIndex = 11;
			this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// TextBarcode
			// 
			this.TextBarcode.AutoSize = true;
			this.TextBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBarcode.Location = new System.Drawing.Point(668, 80);
			this.TextBarcode.Name = "TextBarcode";
			this.TextBarcode.Size = new System.Drawing.Size(60, 24);
			this.TextBarcode.TabIndex = 18;
			this.TextBarcode.Text = "Code";
			this.TextBarcode.Click += new System.EventHandler(this.TextBarcode_Click);
			// 
			// TextName
			// 
			this.TextName.AutoSize = true;
			this.TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextName.Location = new System.Drawing.Point(668, 136);
			this.TextName.Name = "TextName";
			this.TextName.Size = new System.Drawing.Size(65, 24);
			this.TextName.TabIndex = 18;
			this.TextName.Text = "Name";
			this.TextName.Click += new System.EventHandler(this.TextName_Click);
			// 
			// TextPrice
			// 
			this.TextPrice.AutoSize = true;
			this.TextPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextPrice.Location = new System.Drawing.Point(668, 201);
			this.TextPrice.Name = "TextPrice";
			this.TextPrice.Size = new System.Drawing.Size(58, 24);
			this.TextPrice.TabIndex = 18;
			this.TextPrice.Text = "Price";
			this.TextPrice.Click += new System.EventHandler(this.TextPrice_Click);
			// 
			// TextQty
			// 
			this.TextQty.AutoSize = true;
			this.TextQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextQty.Location = new System.Drawing.Point(668, 261);
			this.TextQty.Name = "TextQty";
			this.TextQty.Size = new System.Drawing.Size(41, 24);
			this.TextQty.TabIndex = 18;
			this.TextQty.Text = "Qty";
			this.TextQty.Click += new System.EventHandler(this.TextQty_Click);
			// 
			// TextNote
			// 
			this.TextNote.AutoSize = true;
			this.TextNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextNote.Location = new System.Drawing.Point(274, 75);
			this.TextNote.Name = "TextNote";
			this.TextNote.Size = new System.Drawing.Size(54, 24);
			this.TextNote.TabIndex = 18;
			this.TextNote.Text = "Note";
			this.TextNote.Click += new System.EventHandler(this.TextNote_Click);
			// 
			// A
			// 
			this.A.AutoSize = true;
			this.A.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A.Location = new System.Drawing.Point(640, 83);
			this.A.Name = "A";
			this.A.Size = new System.Drawing.Size(21, 25);
			this.A.TabIndex = 19;
			this.A.Text = "*";
			this.A.Click += new System.EventHandler(this.A_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(640, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 25);
			this.label1.TabIndex = 19;
			this.label1.Text = "*";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(640, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 25);
			this.label3.TabIndex = 19;
			this.label3.Text = "*";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox1.Location = new System.Drawing.Point(57, 185);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(177, 122);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// User
			// 
			this.User.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User.BackgroundImage")));
			this.User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.User.FlatAppearance.BorderSize = 0;
			this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.User.Location = new System.Drawing.Point(255, 381);
			this.User.Name = "User";
			this.User.Size = new System.Drawing.Size(79, 30);
			this.User.TabIndex = 15;
			this.User.Text = "Save";
			this.User.UseVisualStyleBackColor = true;
			this.User.Click += new System.EventHandler(this.User_Click);
			// 
			// AddProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.A);
			this.Controls.Add(this.TextNote);
			this.Controls.Add(this.TextQty);
			this.Controls.Add(this.TextPrice);
			this.Controls.Add(this.TextName);
			this.Controls.Add(this.TextBarcode);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.User);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.TxtPassword);
			this.Controls.Add(this.TxtUser);
			this.Name = "AddProducts";
			this.Text = "AddProducts";
			this.Load += new System.EventHandler(this.AddProducts_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button User;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.TextBox TxtUser;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label TextBarcode;
		private System.Windows.Forms.Label TextName;
		private System.Windows.Forms.Label TextPrice;
		private System.Windows.Forms.Label TextQty;
		private System.Windows.Forms.Label TextNote;
		private System.Windows.Forms.Label A;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}