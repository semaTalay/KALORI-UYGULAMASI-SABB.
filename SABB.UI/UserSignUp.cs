using SABB.BLL.Abstract;
using SABB.BLL.Concrete;
using SABB.DataAccess.Concrete;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SABB.UI
{
    public partial class UserSignUp : Form
    {
        public UserSignUp()
        {
            InitializeComponent();
            InitializeDependencies();
        }
        private void InitializeDependencies()
        {
            _userService = new UserManager(new EfUserDal());
        }

        IUserService _userService;

        public UserSignUp(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void btnUSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUUserName.Text) || string.IsNullOrEmpty(txtUEmail.Text) || string.IsNullOrEmpty(txtUFirstName.Text) || string.IsNullOrEmpty(txtULastName.Text) || string.IsNullOrEmpty(txtUPassword.Text) || string.IsNullOrEmpty(txtUPasswordAgain.Text))
            {
                MessageBox.Show("Alanlar bos gecılemez");
                return;
            }

            if (txtUPassword.Text != txtUPasswordAgain.Text)
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

            User user1 = new User();
            user1.UserName = txtUUserName.Text;
            user1.FirstName = txtUFirstName.Text;
            user1.LastName = txtULastName.Text;
            user1.Email = txtUEmail.Text;
            user1.Password = txtUPassword.Text;

            _userService.Add(user1);
            
            ClearTextboxes();

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

        public void ClearTextboxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private void btnUReset_Click(object sender, EventArgs e)
        {
            ClearTextboxes() ;
        }
    }
}
