using Core.Domain;
using SABB.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.Domain.Concrete
{
    public class Food : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public string Description { get; set; }
        public string? ImagePath { get; set; }
        public Status Status { get; set; }
        public FoodType FoodType { get; set; }
        public ICollection<Meal> Meals { get; set; }



        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
