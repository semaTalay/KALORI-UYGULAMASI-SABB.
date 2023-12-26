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
    public partial class Information : Form
    {
        IUserService _userService;
        IMealService _mealService;
        IDietitianService _dietitianService;
        public Information()
        {
            InitializeComponent();
            InitializeDependencies();
        }
        public Information(IUserService userService, IMealService mealService, IDietitianService dietitianService)
        {
            this._mealService = mealService;
            this._userService = userService;
            this._dietitianService = dietitianService;
        }
        private void InitializeDependencies()
        {
            _userService = new UserManager(new EfUserDal());
            _mealService = new MealManager(new EfMealDal());
            _dietitianService = new DietitianManager(new EfDietitianDal());
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        User user;
        Dietitian dietitian;
        //private void Information_Load(object sender, EventArgs e)
        //{
        //    List<User> user = _userService.GetAll();
        //    int userCount = user.Count;
        //    label4.Text = userCount.ToString();

        //    List<Dietitian> dietitians = _dietitianService.GetAll();
        //    int dietitian1 = dietitians.Count;
        //    label5.Text = dietitian1.ToString();

        //    List<Meal> meals = _mealService.GetAll();
        //    int meal1 = meals.Count;
        //    label6.Text = meal1.ToString();
        //}

        private void Information_Load_1(object sender, EventArgs e)
        {
            List<User> user = _userService.GetAll();
            int userCount = user.Count;
            label4.Text = userCount.ToString();

            List<Dietitian> dietitians = _dietitianService.GetAll();
            int dietitian1 = dietitians.Count;
            label5.Text = dietitian1.ToString();

            List<Meal> meals = _mealService.GetAll();
            int meal1 = meals.Count;
            label6.Text = meal1.ToString();
        }
    }
}
