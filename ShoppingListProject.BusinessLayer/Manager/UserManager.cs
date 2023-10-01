using ShoppingListProject.BusinessLayer.Service;
using ShoppingListProject.DataLayer.Abstract;
using ShoppingListProject.EntityLayer;

namespace ShoppingListProject.BusinessLayer.Manager
{
    public class UserManager : IUserService
    {
        IUserRepository _userRepo;

        public UserManager(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public void Add(User t)
        {
            _userRepo.Insert(t);
        }

        public void Delete(User t)
        {
            _userRepo.Delete(t);
        }

        public User GetById(int id)
        {
            return _userRepo.GetById(id);
        }

        public List<User> GetList()
        {
            return _userRepo.GetListAll();
        }

        public void Update(User t)
        {
            _userRepo.Update(t);
        }
    }
}
