using Core.Domain;
using SABB.Domain.Abstract;
using SABB.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.Domain.Concrete
{
    public class Meal : IEntity
    {
        public int MealId { get; set; }
        public int? UserId { get; set; }
        public int? FoodQuantity { get; set; }
        public double? FoodPortion { get; set; }
        public MealType MealType { get; set; }
        public double TotalCalorie { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
