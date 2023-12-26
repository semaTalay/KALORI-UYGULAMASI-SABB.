using SABB.Domain.Concrete;
using SABB.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Abstract
{
    public interface IMealService
    {
        public void Add(Meal meal);
        public void Delete(Meal meal);
        public void Update(Meal meal);

        public List<Meal> GetAllByUserId(int userId);
        public List<Meal> GetAllByUserIdAndMealType(int userId, MealType mealType);
        public Meal Get(MealType mealType, DateTime dateTime);

        public double CalculateCalorieByDaily(int userId, DateTime date);
        public double CalculateCalorieByWeekly(int userId, DateTime date);

        public double CalculateCalorieByMonthly(int userId, DateTime date);

        public List<string> GetDailyUserCalories(DateTime date);

        public List<string> GetWeeklyUserCalories(DateTime date);
        public List<string> GetMonthlyUserCalories(DateTime date);
        public List<string> GetDailyByMealTypeAndFoodType(DateTime date, MealType mealType, FoodType foodType);
        public List<string> GetWeeklyByMealTypeAndFoodType(DateTime date, MealType mealType, FoodType foodType);
        public List<string> GetMonthlyByMealTypeAndFoodType(DateTime date, MealType mealType, FoodType foodType);

        public List<string> GetDailyByMealType(DateTime date, MealType mealType);
        public List<string> GetWeeklyByMealType(DateTime date, MealType mealType);
        public List<string> GetMonthlyByMealType(DateTime date, MealType mealType);
        public List<string> GetDailyByFoodType(DateTime date, FoodType foodType);
        public List<string> GetWeeklyByFoodType(DateTime date, FoodType foodType);
        public List<string> GetMonthlyByFoodType(DateTime date, FoodType foodType);

        //public List<string> GetMealConsumptionReport(DateTime date);
        //public List<string> GetMostConsumedFoodsReport();
        public List<Meal> GetAll();

    }
}
