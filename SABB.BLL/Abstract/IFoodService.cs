using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Abstract
{
    public interface IFoodService
    {
        public void Add(Food food);
        public void Delete(Food food);
        public void Update(Food food);
        public List<Food> GetAllByInputWord(string inputWord);
        public List<Food> GetAll();
        public Food GetById(int id);
        public List<string> GetMostConsumedFoodsReport();
        public List<string> GetMostConsumedFoodsByCategory();


    }
}
