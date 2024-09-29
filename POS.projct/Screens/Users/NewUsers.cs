using POS.projct.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.projct.Screens
{
	public partial class NewUsers : Form
	{
		Neam_DBEntities2 db = new Neam_DBEntities2();
		string imagepath;
		public NewUsers()
		{
			InitializeComponent();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Creat a New User");
		}

		private void User_Click(object sender, EventArgs e)
		{
			//User obj = new User();
			//obj.UserName = TxtUser.Text;
			//obj.Password = TxtPassword.Text;
			//db.Users.Add(obj);
			db.Users.Add(new User
			{
				UserName = TxtUser.Text,
				Password = TxtPassword.Text,
				image = imagepath
			});
			db.SaveChanges();
			File.Copy(imagepath, Environment.CurrentDirectory);

			MessageBox.Show("Done");
		}




		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Creat a New Password");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				imagepath = dialog.FileName;
				pictureBox1.ImageLocation = dialog.FileName;
			}
		}

		private void NewUsers_Load(object sender, EventArgs e)
		{

		}
	}



}
