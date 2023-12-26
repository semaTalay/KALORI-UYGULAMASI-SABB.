using SABB.BLL.Abstract;
using SABB.BLL.Concrete;
using SABB.DataAccess.Abstract;
using SABB.DataAccess.Concrete;
using SABB.Domain.Concrete;
using SABB.UI.AdminChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User = SABB.Domain.Concrete.User;

namespace SABB.UI.ChildForms
{
    public partial class Meals : Form
    {
        public Meals()
        {
            InitializeComponent();
            InitializeDependencies();
        }
        private void InitializeDependencies()
        {
            _foodService = new FoodManager(new EfFoodDal());
            _mealService = new MealManager(new EfMealDal());
        }

        User user;
        public Meals(User user) : this()
        {
            this.user = user;
        }

        IFoodService _foodService;
        IMealService _mealService;

        public Meals(IFoodService foodService, IMealService mealService)
        {

            _foodService = foodService;
            _mealService = mealService;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Food> foods = _foodService.GetAllByInputWord(textBox1.Text);
            listBox17.DataSource = foods;
            listBox17.DisplayMember = "Name";
            listBox17.ValueMember = "Id";
        }

        private void listBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox17.SelectedItem != null)
            {
                Food selectedFood = (Food)listBox17.SelectedItem;
                //int selectedId = (int)listBox17.SelectedItem;
                //Food selectedFood = _foodService.GetById(selectedId);

                if (selectedFood != null)
                {
                    if (selectedFood.FoodType == Domain.Enums.FoodType.Vegetable)
                    {
                        listBox1.DataSource = new List<Food> { selectedFood };
                        listBox1.DisplayMember = "Name";
                        listBox1.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Fruit)
                    {
                        listBox2.DataSource = new List<Food> { selectedFood };
                        listBox2.DisplayMember = "Name";
                        listBox2.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Drink)
                    {
                        listBox3.DataSource = new List<Food> { selectedFood };
                        listBox3.DisplayMember = "Name";
                        listBox3.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Salad)
                    {
                        listBox4.DataSource = new List<Food> { selectedFood };
                        listBox4.DisplayMember = "Name";
                        listBox4.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Soap)
                    {
                        listBox5.DataSource = new List<Food> { selectedFood };
                        listBox5.DisplayMember = "Name";
                        listBox5.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Meat)
                    {
                        listBox6.DataSource = new List<Food> { selectedFood };
                        listBox6.DisplayMember = "Name";
                        listBox6.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Fish)
                    {
                        listBox7.DataSource = new List<Food> { selectedFood };
                        listBox7.DisplayMember = "Name";
                        listBox7.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Legume)
                    {
                        listBox8.DataSource = new List<Food> { selectedFood };
                        listBox8.DisplayMember = "Name";
                        listBox8.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.PastaAndRice)
                    {
                        listBox9.DataSource = new List<Food> { selectedFood };
                        listBox9.DisplayMember = "Name";
                        listBox9.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Pastry)
                    {
                        listBox10.DataSource = new List<Food> { selectedFood };
                        listBox10.DisplayMember = "Name";
                        listBox10.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Desert)
                    {
                        listBox11.DataSource = new List<Food> { selectedFood };
                        listBox11.DisplayMember = "Name";
                        listBox11.ValueMember = "Id";
                    }
                    else if (selectedFood.FoodType == Domain.Enums.FoodType.Other)
                    {
                        listBox12.DataSource = new List<Food> { selectedFood };
                        listBox12.DisplayMember = "Name";
                        listBox12.ValueMember = "Id";
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        List<Food> breakFast = new List<Food>();
        private List<Food> lunchFoods = new List<Food>();
        private List<Food> dinnerFoods = new List<Food>();
        private List<Food> snackFoods = new List<Food>();


        public void MealTypeAdding(ListBox targetListBox, params ListBox[] otherListBoxes)
        {

            if (comboBox1.SelectedItem != null)
            {
                string selectedMealType = comboBox1.SelectedItem.ToString();
                AddFoodToMealTypeList(selectedMealType, targetListBox, otherListBoxes);
            }
        }

        private void AddFoodToMealTypeList(string mealType, ListBox targetListBox, ListBox[] otherListBoxes)
        {
            if (otherListBoxes.All(lst => lst != targetListBox))
            {
                Food selectedFood = (Food)listBox17.SelectedItem;

                if (selectedFood != null)
                {
                    // İlgili öğe için doğru listeyi seçin
                    ListBox selectedListBox = GetListBoxByMealType(mealType, targetListBox, otherListBoxes);

                    // Seçili öğeyi hedef listbox'a ekle
                    selectedListBox.Items.Add(selectedFood);
                    selectedListBox.DisplayMember = "Name";
                }
            }
        }
        private ListBox GetListBoxByMealType(string mealType, ListBox targetListBox, ListBox[] otherListBoxes)
        {
            switch (mealType)
            {
                case "Breakfast":
                    return listBox13;
                case "Lunch":
                    return listBox14;
                case "Dinner":
                    return listBox15;
                case "Snack":
                    return listBox16;
                default:
                    return null;
            }
        }
       


        

        private void button4_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MealTypeAdding(listBox13, listBox14, listBox15, listBox16);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listBox13.Items.Clear();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            listBox14.Items.Clear();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            listBox15.Items.Clear();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            listBox16.Items.Clear();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double totalCal = 0;
            foreach (Food item in listBox13.Items)
            {
                totalCal += item.Calories;
            }
            lblBreakfast.Text = totalCal.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            double totalCal = 0;
            foreach (Food item in listBox14.Items)
            {
                totalCal += item.Calories;
            }
            lblLunch.Text = totalCal.ToString();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            double totalCal = 0;
            foreach (Food item in listBox15.Items)
            {
                totalCal += item.Calories;
            }
            lblDinner.Text = totalCal.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double totalCal = 0;
            foreach (Food item in listBox16.Items)
            {
                totalCal += item.Calories;
            }
            lblSnack.Text = totalCal.ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.UserId = this.user.Id;
            meal.MealType = Domain.Enums.MealType.Breakfast;
            meal.Date = dateTimePicker1.Value;
            meal.TotalCalorie = int.Parse(lblBreakfast.Text);

            List<Food> foodList = listBox13.Items.Cast<Food>().ToList();
            meal.Foods = foodList;
            foreach (Food item in listBox13.Items)
            {
                foodList.Add(item);
            }
            meal.Foods = foodList;

            _mealService.Add(meal);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.UserId = this.user.Id;
            meal.MealType = Domain.Enums.MealType.Lunch;
            meal.Date = dateTimePicker1.Value;
            meal.TotalCalorie = int.Parse(lblLunch.Text);

            List<Food> foodList = listBox14.Items.Cast<Food>().ToList();
            meal.Foods = foodList;
            foreach (Food item in listBox14.Items)
            {
                foodList.Add(item);
            }
            meal.Foods = foodList;

            _mealService.Add(meal);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.UserId = this.user.Id;
            meal.MealType = Domain.Enums.MealType.Dinner;
            meal.Date = dateTimePicker1.Value;
            meal.TotalCalorie = int.Parse(lblDinner.Text);

            List<Food> foodList = listBox15.Items.Cast<Food>().ToList();
            meal.Foods = foodList;
            foreach (Food item in listBox15.Items)
            {
                foodList.Add(item);
            }
            meal.Foods = foodList;

            _mealService.Add(meal);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.UserId = this.user.Id;
            meal.MealType = Domain.Enums.MealType.Snack;
            meal.Date = dateTimePicker1.Value;
            meal.TotalCalorie = int.Parse(lblSnack.Text);

            List<Food> foodList = listBox16.Items.Cast<Food>().ToList();
            meal.Foods = foodList;
            foreach (Food item in listBox16.Items)
            {
                foodList.Add(item);
            }
            meal.Foods = foodList;

            _mealService.Add(meal);
        }
    }
}
