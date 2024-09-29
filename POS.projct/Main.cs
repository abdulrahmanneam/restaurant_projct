using POS.projct.DB;
using POS.projct.Screens;
using POS.projct.Screens.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.projct
{
	public partial class Main : Form
	{
		Neam_DBEntities2 db = new Neam_DBEntities2(); 
		public Main()
		{
			InitializeComponent();
		}

		private void sipplierToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void creatUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewUsers frm = new NewUsers();
			frm.Show();
		}

		private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddProducts Product = new AddProducts();
			Product.Show();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			AddProducts Product = new AddProducts();
			Product.Show();
		}
	}
}
