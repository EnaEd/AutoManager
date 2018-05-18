using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoManager_2._0
{
    
    public partial class Authorization : Form
    {
        public delegate string EmpName(string name);
        
        public Authorization()
        {
            InitializeComponent();
         //создаем дефолтных юзеров
            Users mangerDefault = new Users { UserName = "manager", UserPassword = "123" };
            Users salerDefault = new Users { UserName = "saler", UserPassword = "123" };
            Users ownerDefault = new Users { UserName = "owner", UserPassword = "123" };
            //добавляем дефолт в наши списки
            UsersRole.UserManager = new List<Users>();
            UsersRole.UserSaler = new List<Users>();
            UsersRole.UserOwner = new List<Users>();
            UsersRole.UserManager.Add(mangerDefault);
            UsersRole.UserSaler.Add(salerDefault);
            UsersRole.UserOwner.Add(ownerDefault);
            //создание дефолтных ролей
            UsersRole.Roles = new List<Role>();
            Role userManager = new Role { Roles = "manager" };
            Role userSaler = new Role { Roles = "saler" };
            Role userOwner = new Role { Roles = "owner" };
            //добавление ролей в список
            UsersRole.Roles.Add(userManager);
            UsersRole.Roles.Add(userSaler);
            UsersRole.Roles.Add(userOwner);
            //вычитываем все роли в наш комбобокс
            foreach (var item in UsersRole.Roles)
            {
                cmbRole.Items.Add(item.Roles);
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            //проводим авторизацию пользователя при нужной роли и правильном пароле
            if (cmbRole.SelectedItem.Equals("manager")) {//проверка выбранной роли
                foreach (var item in UsersRole.UserManager)
                {
                    if (item.UserName.Equals(txtName.Text)&&item.UserPassword.Equals(txtPassword.Text)) {//проверка верного пароля
                        EmpName en = s => s = txtName.Text;
                        Manager man = new Manager();
                        man.Show();
                        return;
                    }
                }
                MessageBox.Show("неверный пароль или логин");
                txtPassword.Clear();
                txtName.Clear();
            }
            else if (cmbRole.SelectedItem.Equals("saler"))//проверка выбранной роли
            {
                foreach (var item in UsersRole.UserSaler)
                {
                    if (item.UserPassword.Equals(txtPassword.Text) && item.UserName.Equals(txtName.Text))//проверка верного пароля
                    {
                        EmpName en = s => s = txtName.Text;
                        Saler sal = new Saler();
                        sal.Show();
                        //Saler s =new Saler();
                        //s.Show();
                        return;
                    }
                }
                MessageBox.Show("неверный пароль или логин");
                txtPassword.Clear();
                txtName.Clear();
            }
            else if (cmbRole.SelectedItem.Equals("owner"))//проверка выбранной роли
            {
                foreach (var item in UsersRole.UserOwner)
                {
                    if (item.UserPassword.Equals(txtPassword.Text) && item.UserName.Equals(txtName.Text))//проверка верного пароля
                    {
                        EmpName en = s => s = txtName.Text;
                        Owner sal = new Owner();
                        sal.Show();
                        return;
                    }
                }
                MessageBox.Show("неверный пароль или логин");
                txtPassword.Clear();
                txtName.Clear();
            }
        }
    }
}
