using POS.projct.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.projct
{
	public partial class LogIn : Form
	{
		Neam_DBEntities2 db = new Neam_DBEntities2();
		public LogIn()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void User_Click(object sender, EventArgs e)
		{
			var result = db.Users.Where(y => y.UserName == TextUser.Text && y.Password == TextPassword.Text).ToList();


			if (result.Count() > 0)
			{
				this.Close();
				Thread thread = new Thread(openform);
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
			}
			else
			{
				MessageBox.Show("User Name Or Password Are invalid");
			}


		}

		void openform()
		{
			Application.Run(new Main());
		}
	}
}
