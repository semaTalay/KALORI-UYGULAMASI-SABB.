using Core.Domain;
using SABB.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.Domain.Concrete
{
    public class Dietitian : Person, IEntity
    {
        public string CV { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
