using SABB.BLL.Abstract;
using SABB.BLL.Concrete;
using SABB.DataAccess.Concrete;
using SABB.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SABB.UI.ChildForms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            InitializeDependencies();
        }

        private void InitializeDependencies()
        {
            _mealService = new MealManager(new EfMealDal());
            _foodService = new FoodManager(new EfFoodDal());
        }

        IMealService _mealService;
        IFoodService _foodService;

        public Calculator(IMealService mealService, IFoodService foodService)
        {
            _mealService = mealService;
            _foodService = foodService;
            InitializeComponent();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                List<string> siralama = _mealService.GetDailyUserCalories(dateTimePicker1.Value.Date);
                foreach (string item in siralama)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex == -1)
            {
                List<string> siralam2 = _mealService.GetDailyByMealType(dateTimePicker1.Value.Date, (MealType)comboBox1.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
            {
                List<string> siralam2 = _mealService.GetDailyByFoodType(dateTimePicker1.Value.Date, (FoodType)comboBox2.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
            else
            {
                List<string> siralam2 = _mealService.GetDailyByMealTypeAndFoodType(dateTimePicker1.Value.Date, (MealType)comboBox1.SelectedValue, (FoodType)comboBox2.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                List<string> siralama = _mealService.GetWeeklyUserCalories(dateTimePicker1.Value.Date);
                foreach (string item in siralama)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex == -1)
            {
                List<string> siralam2 = _mealService.GetWeeklyByMealType(dateTimePicker1.Value.Date, (MealType)comboBox1.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
            {
                List<string> siralam2 = _mealService.GetWeeklyByFoodType(dateTimePicker1.Value.Date, (FoodType)comboBox2.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
            else
            {
                List<string> siralam2 = _mealService.GetWeeklyByMealTypeAndFoodType(dateTimePicker1.Value.Date, (MealType)comboBox1.SelectedValue, (FoodType)comboBox2.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
            {
                List<string> siralama = _mealService.GetMonthlyUserCalories(dateTimePicker1.Value.Date);
                foreach (string item in siralama)
                {
                    listBox1.Items.Add(item);
                }
            }
            else if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex == -1)
            {
                List<string> siralam2 = _mealService.GetMonthlyByMealType(dateTimePicker1.Value.Date, (MealType)comboBox1.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
            else if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex != -1)
            {
                List<string> siralam2 = _mealService.GetMonthlyByFoodType(dateTimePicker1.Value.Date, (FoodType)comboBox2.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
            else
            {

                List<string> siralam2 = _mealService.GetMonthlyByMealTypeAndFoodType(dateTimePicker1.Value.Date, (MealType)comboBox1.SelectedValue, (FoodType)comboBox2.SelectedValue);
                foreach (string item2 in siralam2)
                {
                    listBox1.Items.Add(item2);
                }
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(SABB.Domain.Enums.MealType));
            comboBox2.DataSource = Enum.GetValues(typeof(SABB.Domain.Enums.FoodType));

            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;


        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> encokyemek = _foodService.GetMostConsumedFoodsByCategory();
            foreach (String item in encokyemek)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
