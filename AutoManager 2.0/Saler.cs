using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoManager_2._0.DB;
using System.Threading;
using System.Data.Entity;



namespace AutoManager_2._0
{
    public partial class Saler : Form
    {
        public Saler()
        {
            InitializeComponent();
        //    DbAutoManager db = new DbAutoManager();
        //    foreach (var item in db.BrandCAR.ToList())
        //    {
        //        cmbBxBrand.Items.Add(item.NameBrandCar.ToString());
        //    }
        //    foreach (var item in db.ModelAuto.ToList())
        //    {
        //        cmbBxModel.Items.Add(item.NameModelAuto.ToString());
        //    }
        //    foreach (var item in db.VinCode.ToList())
        //    {
        //        cmbBxVinCode.Items.Add(item.IdVinCode.ToString());
        //    }
        //}
    }

        //включение и выключение параметров расширенного поиска
        private void chckBxFindEx_CheckedChanged(object sender, EventArgs e)
        {
        if (chckBxFindEx.Checked)
        {
            grpBxFindEx.Visible = true;
            DbAutoManager db = new DbAutoManager();
                //загружаем фильтры поиска
            foreach (var item in db.BrandCAR.ToList())
            {
                cmbBxBrand.Items.Add(item.NameBrandCar.ToString());
            }
            foreach (var item in db.ModelAuto.ToList())
            {
                cmbBxModel.Items.Add(item.NameModelAuto.ToString());
            }
            foreach (var item in db.VinCode.ToList())
            {
                cmbBxVinCode.Items.Add(item.IdVinCode.ToString());
            }
        }
        else
        {
            grpBxFindEx.Visible = false;
            cmbBxBrand.Items.Clear();//очистка форм
            cmbBxModel.Items.Clear();
            cmbBxVinCode.Items.Clear();
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //не нужен пока
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!chckBxFindEx.Checked)
            {
                //поиск выполнен как запрос к базе с параметром
                DbAutoManager db = new DbAutoManager();

                //db.Product.Where(p => p.NameProduct.Contains(textBox1.Text)).Load();//параметр строка, условие ее содержание в имени продука
                //                                                                    //дефолтный поиск идет по имени продукта
                //dataGridView1.DataSource = db.Product.Local.ToBindingList();

                //2 вариант 
                //поддерживает изменение таблицы для вывода нужных строк и исключения лишнего
                db.Product.Include(p => p.CountryCreateComponent).Where(pi => pi.NameProduct.Contains(textBox1.Text)).Load();//join(Include)+условие(where)
                dataGridView1.DataSource = db.Product.Local.Select(p => new
                {//вывод нужных строк
                    Product_Name = p.NameProduct,
                    Country = p.CountryCreateComponent.NameCountryCreateComponent,
                    Units = p.Units,
                    Quantity = p.Quantity,
                    Price = p.PriceOut,
                    Discount = p.Discount
                }).ToList();
            }
            else {
                if (cmbBxVinCode.SelectedItem == null) {
                    if()
                }
            }
        }
    }
}
