using SABB.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SABB.BLL.Abstract
{
    public interface IUserService
    {
        public void Add(User user);

        public void Update(User user);

        public void Delete(User user);

        public List<User> GetAll();
        public User GetById(int id);
        public User GetByUserName(string userName);

        public List<User> GetAllByDietitianId(int dietitianId);
    }
}
