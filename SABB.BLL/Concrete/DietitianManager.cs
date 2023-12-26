using SABB.BLL.Abstract;
using SABB.DataAccess.Abstract;
using SABB.DataAccess.Concrete;
using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Concrete
{
    public class DietitianManager : IDietitianService
    {
        IDietitianDal _dietitianDal;
        public DietitianManager(IDietitianDal dietitianDal)
        {
            _dietitianDal = dietitianDal;
        }
        public void Add(Dietitian dietitian)
        {
            _dietitianDal.Add(dietitian);
        }

        public void Delete(Dietitian dietitian)
        {
            _dietitianDal.Delete(dietitian);
        }

        public List<Dietitian> GetAll()
        {
            return _dietitianDal.GetAll();
        }

        public Dietitian GetByUserName(string userName)
        {
            return _dietitianDal.Get(u => u.UserName == userName);
        }

        public void Update(Dietitian dietitian)
        {
            _dietitianDal.Update(dietitian);
        }
    }
}
