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

namespace SABB.UI.AdminChildForms
{
    public partial class UserPanel : Form
    {
        IUserService _userService;
        public UserPanel()
        {
            InitializeComponent();
            InitializeDependencies();
        }

        private void InitializeDependencies()
        {
            _userService = new UserManager(new EfUserDal());

        }
        public UserPanel(IUserService userService)
        {
            this._userService = userService;
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            List<User> user = _userService.GetAll();
            foreach (User item in user)
            {
                listBox1.Items.Add($"{item.FirstName} - {item.Status}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedItem is User selectedUser)
                {
                    
                    selectedUser.Status = (selectedUser.Status == Domain.Enums.Status.Active)
                        ? Domain.Enums.Status.Pasive
                        : Domain.Enums.Status.Active;

                    
                    _userService.Update(selectedUser);

                    
                    listBox1.Items.Clear();
                    foreach (User user in _userService.GetAll())
                    {
                        listBox1.Items.Add($"{user.FirstName} - {user.Status}");
                    }
                }
            }
        }

        private void UserPanel_Load_1(object sender, EventArgs e)
        {
            List<User> user = _userService.GetAll();

            foreach (User item in user)
            {
                if (item.UserName != "admin")
                {
                    listBox1.Items.Add($"{item.FirstName} - {item.Status}");
                }
            }
        }
    }
}
