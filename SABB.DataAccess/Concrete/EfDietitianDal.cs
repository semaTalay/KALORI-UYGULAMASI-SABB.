using Core.DataAccess.EntityFramework;
using SABB.DataAccess.Abstract;
using SABB.DataAccess.Context;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.DataAccess.Concrete
{
    public class EfDietitianDal : EfRepositoryBase<Dietitian, SABBDbContext> , IDietitianDal
    {
    }
}
