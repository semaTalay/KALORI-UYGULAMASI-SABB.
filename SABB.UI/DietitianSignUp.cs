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
    public partial class DietitianSignUp : Form
    {
        public DietitianSignUp()
        {
            InitializeComponent();
            InitializeDependencies();
        }

        private void InitializeDependencies()
        {
            _dietitanService = new DietitianManager(new EfDietitianDal());
        }

        IDietitianService _dietitanService;

        public DietitianSignUp(IDietitianService service)
        {
            _dietitanService = service;
            InitializeComponent();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            LoginScreenDietitian loginScreenDietitian = new LoginScreenDietitian();
            loginScreenDietitian.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDUserName.Text) || string.IsNullOrEmpty(txtDEmail.Text) || string.IsNullOrEmpty(txtDFirstName.Text) || string.IsNullOrEmpty(txtDLastName.Text) || string.IsNullOrEmpty(txtDPassword.Text) || string.IsNullOrEmpty(txtDPasswordAgain.Text))
            {
                MessageBox.Show("Alanlar bos gecılemez");
                return;
            }

            if (txtDPassword != txtDPasswordAgain)
            {
                MessageBox.Show("Şifreler Uyuşmuyor!!!");
                return;
            }

            string password = txtDPassword.Text;

            if (!PasswordCheck(password))
            {
                MessageBox.Show("Şifre büyük harf küçük harf rakam ve özel karakter içermelidir");
                return;
            }

            Dietitian dietitian = _dietitanService.GetByUserName(txtDUserName.Text);
            if (dietitian != null)
            {
                MessageBox.Show("Bu kullanıcı adında biri mevcut başka bir kullanıcı adı belirleyin !!!");
                return;
            }

            if (!txtDEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Lütfen gmail uzantılı bir mail ile giriş yapınız !");
                return;
            }

            Dietitian dietitian1 = new Dietitian();
            dietitian1.UserName = txtDUserName.Text;
            dietitian1.FirstName = txtDFirstName.Text;
            dietitian1.LastName = txtDLastName.Text;
            dietitian1.Email = txtDEmail.Text;
            dietitian1.Password = password;

            _dietitanService.Add(dietitian1);

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

        private void btnDReset_Click(object sender, EventArgs e)
        {
            ClearTextboxes() ;
        }
    }
}
