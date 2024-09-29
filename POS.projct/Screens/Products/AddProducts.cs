using POS.projct.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.projct.Screens.Products
{
	public partial class AddProducts : Form
	{
		Neam_DBEntities2 db = new Neam_DBEntities2();
		string imagepath;

		public object Code { get; private set; }
		public object Price { get; private set; }
		public object Note { get; private set; }
		public object Quantity { get; private set; }

		public AddProducts()
		{
			InitializeComponent();
		}

		private void User_Click(object sender, EventArgs e)
		{
			if (TextBarcode.Text == "" || TextName.Text == "" || TextPrice.Text == "")
			{
				MessageBox.Show("Can't Save Product");
			}

			else
			{
				POS.projct.DB.Product Product = new POS.projct.DB.Product();
				Product.Name = TextName.Text;
				Product.Code = TextBarcode.Text;
				Product.Price = Convert.ToDecimal(textBox1.Text);
				Product.Notes = TextNote.Text;
				Product.Quantity = int.Parse(textBox2.Text);

				db.Products.Add(Product);
				db.SaveChanges();
				MessageBox.Show("Complet");

			}
		}
	
		private void AddProducts_Load(object sender, EventArgs e)
		{

		}

		private void TextQyt_Click(object sender, EventArgs e)
		{

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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void A_Click(object sender, EventArgs e)
		{

		}

		private void TextNote_Click(object sender, EventArgs e)
		{

		}

		private void TextQty_Click(object sender, EventArgs e)
		{

		}

		private void TextPrice_Click(object sender, EventArgs e)
		{

		}

		private void TextName_Click(object sender, EventArgs e)
		{

		}

		private void TextBarcode_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void TxtUser_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}