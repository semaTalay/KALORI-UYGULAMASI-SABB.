using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Abstract
{
    public interface IDietitianService 
    {
        public void Add(Dietitian dietitian);
        public void Delete(Dietitian dietitian);
        public void Update(Dietitian dietitian);

        public Dietitian GetByUserName(string userName);
        public List<Dietitian> GetAll();

    }
}
