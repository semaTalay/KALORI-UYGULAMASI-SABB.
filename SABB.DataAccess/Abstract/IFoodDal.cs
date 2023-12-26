using Core.DataAccess.EntityFramework;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.DataAccess.Abstract
{
    public interface IFoodDal : IEntityRepository<Food>
    {
    }
}
