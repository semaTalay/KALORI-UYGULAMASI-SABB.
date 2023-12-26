using Core.Domain;
using SABB.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.Domain.Concrete
{
    public class User : Person, IEntity
    {

        public double? DailyCalorieGoal { get; set; }
        public int? DietitianId { get; set; }
        public Dietitian Dietitian { get; set; }
        public ICollection<Meal> Meals { get; set; }

    }
}
