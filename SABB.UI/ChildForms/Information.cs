using Microsoft.VisualBasic.ApplicationServices;
using SABB.BLL.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SABB.Domain.Concrete;
using User = SABB.Domain.Concrete.User;
using SABB.BLL.Concrete;
using SABB.DataAccess.Concrete;

namespace SABB.UI.ChildForms
{


    public partial class Information : Form
    {
        IUserService _userService;

        public Information(IUserService userService)
        {
            _userService = userService;
        }
        private void InitializeDependencies()
        {
            _userService = new UserManager(new EfUserDal());
        }
        User user;
        public Information(User user) : this()
        {
            this.user = user;
        }
        public Information()
        {
            loadUserData();
            initializePassEditControls();
            InitializeDependencies();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            lblUser.Text = user.UserName;
            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
            lblEmail.Text = user.Email;
        }

        private void loadUserData()
        {

            lblUser.Text = user.UserName;
            lblFirstName.Text = user.FirstName;
            lblLastName.Text = user.LastName;
            lblEmail.Text = user.Email;

            txtUUserName.Text = user.UserName;
            txtUFirstName.Text = user.FirstName;
            txtULastName.Text = user.LastName;
            txtUEmail.Text = user.Email;
            txtUPassword.Text = "";
            txtUPasswordConfirm.Text = "";
            txtCurrentPassword.Text = "";
        }

        private void initializePassEditControls()
        {
            LinkEditPass.Text = "Edit";
            txtUPassword.UseSystemPasswordChar = true;
            txtUPassword.Enabled = false;
            txtUPasswordConfirm.UseSystemPasswordChar = true;
            txtUPasswordConfirm.Enabled = false;
        }

        private void reset()
        {
            loadUserData();
            initializePassEditControls();
        }

        private void linkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.Visible = true;
            loadUserData();
        }

        private void LinkEditPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkEditPass.Text == "Edit")
            {
                LinkEditPass.Text = "Cancel";
                txtUPassword.Enabled = true;
                txtUPassword.Text = "";
                txtUPasswordConfirm.Enabled = true;
                txtUPasswordConfirm.Text = "";
            }
            else if (LinkEditPass.Text == "Cancel")
            {
                initializePassEditControls();
                txtUPassword.Text = user.Password;
                txtUPasswordConfirm.Text = user.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUUserName.Text) || string.IsNullOrEmpty(txtUEmail.Text) || string.IsNullOrEmpty(txtUFirstName.Text) || string.IsNullOrEmpty(txtULastName.Text) || string.IsNullOrEmpty(txtUPassword.Text) || string.IsNullOrEmpty(txtCurrentPassword.Text) || string.IsNullOrEmpty(txtUPasswordConfirm.Text))
            {
                MessageBox.Show("Alanlar bos gecılemez");
                return;
            }

            if (txtCurrentPassword != txtUPasswordConfirm)
            {
                MessageBox.Show("Şifreler Uyuşmuyor!!!");
                return;
            }

            string password = txtUPassword.Text;

            if (!PasswordCheck(password))
            {
                MessageBox.Show("Şifre büyük harf küçük harf rakam ve özel karakter içermelidir");
                return;
            }

            User user = _userService.GetByUserName(txtUUserName.Text);
            if (user != null)
            {
                MessageBox.Show("Bu kullanıcı adında biri mevcut başka bir kullanıcı adı belirleyin !!!");
                return;
            }

            if (!txtUEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Lütfen gmail uzantılı bir mail ile giriş yapınız !");
                return;
            }

            if (user.Password != txtUPassword.Text)
            {
                MessageBox.Show("Eski Şifre Doğru Değil");
                return;
            }

            User user1 = _userService.GetById(user.Id);
            user1.UserName = txtUUserName.Text;
            user1.FirstName = txtUFirstName.Text;
            user1.LastName = txtULastName.Text;
            user1.Email = txtUEmail.Text;
            user1.Password = txtUPasswordConfirm.Text;

            _userService.Update(user1);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        static bool PasswordCheck(string password)
        {
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                return false;
            }
            return true;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}
