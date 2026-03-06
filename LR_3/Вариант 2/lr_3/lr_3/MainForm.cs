using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_3
{
    public partial class MainForm : Form
    {
        private Dictionary<string, List<Product>> products_ = new Dictionary<string, List<Product>>();

        public MainForm()
        {
            InitializeComponent();

            List<string> allCategories = products_.Keys.ToList();
            ProductListBox.DataSource = allCategories;
        }

        private void ProductListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = ProductListBox.SelectedItem.ToString();
            List<Product> productSelectedCategory = products_[selectedCategory];

            ProductComboBox.DataSource= productSelectedCategory;
            ProductComboBox.DisplayMember = "Name";
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = ProductComboBox.SelectedItem as Product;
            if (selectedProduct != null)
            {
                PriceLabel.Text = selectedProduct.Price;
                DataLabel.Text = selectedProduct.Data;
            }
        }
    }
}