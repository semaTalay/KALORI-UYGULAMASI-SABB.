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
    public partial class LoginScreenDietitian : Form
    {
        public LoginScreenDietitian()
        {
            InitializeComponent();
            InitializeDependencies();
        }
        private void InitializeDependencies()
        {
            _dietitianService = new DietitianManager(new EfDietitianDal());
        }

        IDietitianService _dietitianService;

        public LoginScreenDietitian(IDietitianService dietitianService)
        {
            _dietitianService = dietitianService;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DietitianSignUp dietitianSignUp = new DietitianSignUp();
            dietitianSignUp.Show();
            this.Hide();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            MainLoginScreen loginScreen = new MainLoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dietitian dietitian = _dietitianService.GetByUserName(textBox1.Text);
            if (dietitian == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı lutfen kayıt olun");
                return;
            }

            if (dietitian.Password == textBox2.Text)
            {
                MessageBox.Show("Şifreniz yanlış");
                return;
            }

            //diyetisyen ekranı hangisiyse onun acılması gereken kodlar
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }
    }
}
