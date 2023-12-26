using SABB.BLL.Abstract;
using SABB.DataAccess.Abstract;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodDal _foodDal;
        public FoodManager(IFoodDal foodDal)
        {

            _foodDal = foodDal;

        }
        public void Add(Food food)
        {
            _foodDal.Add(food);
        }

        public void Delete(Food food)
        {
            _foodDal.Delete(food);
        }

        public List<Food> GetAll()
        {
            return _foodDal.GetAll();
        }

        public List<Food> GetAllByInputWord(string inputWord)
        {
            return _foodDal.GetAll(f => f.Name.Contains(inputWord));
        }

        public Food GetById(int id)
        {
            return _foodDal.Get(f => f.Id == id);
        }

        public List<string> GetMostConsumedFoodsByCategory()
        {
            var mostConsumedFoodsByCategory = _foodDal.GetAll().GroupBy(food => food.Name).Select(group => new { FoodName = group.Key, TotalPortions = group.Sum(food => food.Meals.Sum(meal => meal.FoodQuantity ?? 0)) }).OrderByDescending(result => result.TotalPortions).Take(5).Select(result => $"{result.FoodName}: {result.TotalPortions} Portions").ToList(); 
            return mostConsumedFoodsByCategory;
        }

        public List<string> GetMostConsumedFoodsReport()
        {
            var mostConsumedFoods = _foodDal
            .GetAll()
            .OrderByDescending(food => food.Meals.Sum(meal => meal.FoodQuantity ?? 0))
            .Take(5) 
            .Select(food => $"{food.Name}: {food.Meals.Sum(meal => meal.FoodQuantity ?? 0)} Portions")
            .ToList();

                return mostConsumedFoods;
        }

        public void Update(Food food)
        {
            _foodDal.Update(food);
        }
    }
}
