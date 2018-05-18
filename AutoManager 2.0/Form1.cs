using AutoManager_2._0.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoManager_2._0
{
    public partial class Form1 : Form
    {
        DbAutoManager db;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = new DbAutoManager();
            db.Capacity.Load();
            dataGridView1.DataSource = db.Capacity.Local.ToBindingList();
            //using (db=new Model1()) {
            //    db.BrandCAR.Load();
            //    dataGridView1.DataSource = db.BrandCAR.Local.ToBindingList();
            //}
        }
    }
}
