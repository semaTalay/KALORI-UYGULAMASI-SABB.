using SABB.BLL.Concrete;
using SABB.DataAccess.Concrete;
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
    public partial class MainLoginScreen : Form
    {
        public MainLoginScreen()
        {
            InitializeComponent();
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
            //new UserManager(new EfUserDal())
        }

        private void btnDietitianLogin_Click(object sender, EventArgs e)
        {
            LoginScreenDietitian loginScreenDietitian = new LoginScreenDietitian();
            loginScreenDietitian.Show();
            this.Hide();
        }
    }
}
