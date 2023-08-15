using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
            LoadAddCategories();
        }
        private void dgwData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAddProductName.Text = dgwData.CurrentRow.Cells[2].Value.ToString();
            cbxAddCategory.SelectedValue = dgwData.CurrentRow.Cells[1].Value;
            txtAddUnitPrice.Text = dgwData.CurrentRow.Cells[3].Value.ToString();
            txtAddStock.Text = dgwData.CurrentRow.Cells[4].Value.ToString();
            txtAddQuantityPerUnit.Text = dgwData.CurrentRow.Cells[5].Value.ToString();
        }

        private void LoadCategories()
        {
            cbxKategori.DataSource = _categoryService.GetAll();
            cbxKategori.DisplayMember = "CategoryName";
            cbxKategori.ValueMember = "CategoryId";
        }

        private void LoadAddCategories()
        {
            cbxAddCategory.DataSource = _categoryService.GetAll();
            cbxAddCategory.DisplayMember = "CategoryName";
            cbxAddCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwData.DataSource = _productService.GetAll();
        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwData.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxKategori.SelectedValue));
            }
            catch
            {
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAra.Text))
            {
                LoadProducts();
            }
            else
            {
                dgwData.DataSource = _productService.GetProductsByProductName(txtAra.Text);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product 
                {
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = txtAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(txtAddUnitPrice.Text),
                    UnitsInStock= Convert.ToInt16(txtAddStock.Text),
                    QuantityPerUnit= txtAddQuantityPerUnit.Text
                });
                LoadProducts();
                MessageBox.Show("Ürün Eklendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product 
                {
                    ProductId = Convert.ToInt32(dgwData.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                    ProductName = txtAddProductName.Text,
                    UnitPrice = Convert.ToDecimal(txtAddUnitPrice.Text),
                    UnitsInStock = Convert.ToInt16(txtAddStock.Text),
                    QuantityPerUnit = txtAddQuantityPerUnit.Text
                });
                LoadProducts();
                MessageBox.Show("Ürün Güncellendi");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgwData.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product 
                    {
                         ProductId = Convert.ToInt32(dgwData.CurrentRow.Cells[0].Value)
                    });
                    LoadProducts();
                    MessageBox.Show("Ürün Silindi");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
