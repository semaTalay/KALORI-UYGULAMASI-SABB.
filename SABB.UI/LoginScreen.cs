using SABB.BLL.Abstract;
using SABB.BLL.Concrete;
using SABB.DataAccess.Concrete;
using SABB.Domain.Concrete;
using SABB.UI.AdminPanels;
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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            InitializeDependencies();
        }

        private void InitializeDependencies()
        {
            _userService = new UserManager(new EfUserDal());
        }
        IUserService _userService;

        public LoginScreen(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }
        User user;
        private void button2_Click(object sender, EventArgs e)
        {
            if (_userService == null)
            {
                MessageBox.Show("UserService null. Dependency injection doğru yapılmamış olabilir.");
                return;
            }

            user = _userService.GetByUserName(textBox1.Text);
            if (user == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı lutfen kayıt olun");
                return;
            }

            if (user.Password != textBox2.Text)
            {
                MessageBox.Show("Şifreniz yanlış");
                return;
            }

            if (user != null)
            {
                if (user.UserName == "admin")
                {
                    AdminMainMenu adminMainMenu = new AdminMainMenu();
                    adminMainMenu.ShowDialog();
                    return;
                }


                MainMenu mainMenu = new MainMenu(user);
                mainMenu.Show(this);
                this.Hide();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSignUp userSignUp = new UserSignUp();
            userSignUp.ShowDialog();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTurnBack_Click_1(object sender, EventArgs e)
        {
            MainLoginScreen loginScreen = new MainLoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            infoScreen infoScreen = new infoScreen();
            infoScreen.Show();

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
