using SABB.BLL.Abstract;
using SABB.DataAccess.Abstract;
using SABB.DataAccess.Concrete;
using SABB.Domain.Concrete;
using SABB.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Concrete
{
    public class MealManager : IMealService
    {
        IMealDal _mealDal;
        public MealManager(IMealDal mealDal)
        {
            _mealDal = mealDal;
        }
        public void Add(Meal meal)
        {
            _mealDal.Add(meal);
        }

        public double CalculateCalorieByDaily(int userId, DateTime date)
        {
            List<Meal> meals = _mealDal.GetAll(m => m.UserId == userId && m.Date == date);
            double totalCalorie = meals.Sum(m => m.TotalCalorie);
            return totalCalorie;
        }

        public double CalculateCalorieByMonthly(int userId, DateTime date)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            List<Meal> meals = _mealDal.GetAll(m => m.UserId == userId && m.Date.Date >= startOfMonth && m.Date.Date <= endOfMonth);
            double totalCalorie = meals.Sum(m => m.TotalCalorie);
            return totalCalorie;
        }

        public double CalculateCalorieByWeekly(int userId, DateTime date)
        {
            DateTime startOfWeek = date.AddDays(DayOfWeek.Monday - date.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);
            List<Meal> meals = _mealDal.GetAll(m => m.UserId == userId && m.Date.Date >= startOfWeek.Date && m.Date.Date <= endOfWeek);
            double totalCalorie = meals.Sum(m => m.TotalCalorie);
            return totalCalorie;
        }

        public void Delete(Meal meal)
        {
            _mealDal.Delete(meal);
        }

        public Meal Get(MealType mealType, DateTime dateTime)
        {
            return _mealDal.Get(m => m.MealType == mealType && m.Date == dateTime);
        }

        public List<Meal> GetAllByUserId(int userId)
        {
            return _mealDal.GetAll(m => m.UserId == userId);
        }

        public List<Meal> GetAllByUserIdAndMealType(int userId, MealType mealType)
        {
            return _mealDal.GetAll(m => m.UserId == userId && m.MealType == mealType);
        }

        public void Update(Meal meal)
        {
            _mealDal.Update(meal);
        }


        public List<string> GetDailyUserCalories(DateTime date)
        {
            List<Meal> allMeals = _mealDal.GetAll(m => m.Date.Date == date.Date);

            var groupedCalories = allMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;

        }



        public List<string> GetWeeklyUserCalories(DateTime date)
        {
            DateTime startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            List<Meal> allMeals = _mealDal.GetAll(m => m.Date.Date >= startOfWeek && m.Date.Date <= endOfWeek);

            var groupedCalories = allMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }



        public List<string> GetMonthlyUserCalories(DateTime date)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            List<Meal> allMeals = _mealDal.GetAll(m => m.Date.Date >= startOfMonth && m.Date.Date <= endOfMonth);

            var groupedCalories = allMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetDailyByMealTypeAndFoodType(DateTime date, MealType mealType, FoodType foodType)
        {
            DateTime startOfDay = date.Date;
            DateTime endOfDay = startOfDay.AddDays(1).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfDay && m.Date <= endOfDay &&
                m.MealType == mealType &&
                m.Foods.Any(f => f.FoodType == foodType)
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetWeeklyByMealTypeAndFoodType(DateTime date, MealType mealType, FoodType foodType)
        {
            DateTime startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(6);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date.Date >= startOfWeek && m.Date.Date <= endOfWeek &&
                m.MealType == mealType &&
                m.Foods.Any(f => f.FoodType == foodType)
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetMonthlyByMealTypeAndFoodType(DateTime date, MealType mealType, FoodType foodType)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date.Date >= startOfMonth && m.Date.Date <= endOfMonth &&
                m.MealType == mealType &&
                m.Foods.Any(f => f.FoodType == foodType)
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetDailyByMealType(DateTime date, MealType mealType)
        {
            DateTime startOfDay = date.Date;
            DateTime endOfDay = startOfDay.AddDays(1).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfDay && m.Date <= endOfDay &&
                m.MealType == mealType
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetWeeklyByMealType(DateTime date, MealType mealType)
        {
            DateTime startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(7).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfWeek && m.Date <= endOfWeek &&
                m.MealType == mealType
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetMonthlyByMealType(DateTime date, MealType mealType)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfMonth && m.Date <= endOfMonth &&
                m.MealType == mealType
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetDailyByFoodType(DateTime date, FoodType foodType)
        {
            DateTime startOfDay = date.Date;
            DateTime endOfDay = startOfDay.AddDays(1).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfDay && m.Date <= endOfDay &&
                m.Foods.Any(f => f.FoodType == foodType)
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetWeeklyByFoodType(DateTime date, FoodType foodType)
        {
            DateTime startOfWeek = date.Date.AddDays(-(int)date.DayOfWeek);
            DateTime endOfWeek = startOfWeek.AddDays(7).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfWeek && m.Date <= endOfWeek &&
                m.Foods.Any(f => f.FoodType == foodType)
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<string> GetMonthlyByFoodType(DateTime date, FoodType foodType)
        {
            DateTime startOfMonth = new DateTime(date.Year, date.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddSeconds(-1);

            List<Meal> filteredMeals = _mealDal.GetAll(m =>
                m.Date >= startOfMonth && m.Date <= endOfMonth &&
                m.Foods.Any(f => f.FoodType == foodType)
            );

            var groupedCalories = filteredMeals
                .GroupBy(m => m.UserId)
                .Select(group => new
                {
                    UserId = group.Key,
                    TotalCalorie = group.Sum(m => m.TotalCalorie)
                })
                .OrderByDescending(x => x.TotalCalorie)
                .ToList();

            var result = new List<string>();
            foreach (var item in groupedCalories)
            {
                result.Add($"UserID: {item.UserId}, TotalCalorie: {item.TotalCalorie}");
            }

            return result;
        }

        public List<Meal> GetAll()
        {
            return _mealDal.GetAll();
        }

        //public List<string> GetMealConsumptionReport(DateTime date)
        //{
        //    List<Meal> meals = _mealDal.GetAll(m => m.Date.Date == date.Date, includeProperties: "Foods");

        //    var report = new List<string>();

        //    foreach (Meal meal in meals)
        //    {
        //        var mealType = meal.MealType.ToString();
        //        var foodDetails = meal.Foods.Select(food => $"{food.Name}: {food.Calories} Calories").ToList();

        //        report.Add($"{mealType} Meal - Total Calories: {meal.TotalCalorie}");
        //        report.AddRange(foodDetails);
        //        report.Add(""); // Boş bir satır ekleyebilirsiniz.
        //    }

        //    return report;
        //}

        //public List<string> GetMostConsumedFoodsReport()
        //{
        //    var mostConsumedFoods = _foodDal
        //    .GetAll()
        //    .OrderByDescending(food => food.Meals.Sum(meal => meal.FoodQuantity ?? 0))
        //    .Take(5) // En çok tüketilen 5 yemeği al
        //    .Select(food => $"{food.Name}: {food.Meals.Sum(meal => meal.FoodQuantity ?? 0)} Portions")
        //    .ToList();

        //    return mostConsumedFoods;
        //}
    }


}




