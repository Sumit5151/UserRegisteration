using UserRegisteration.DataLayer;
using UserRegisteration.Models;

namespace UserRegisteration.Repository
{
    public class UserRepository
    {

        public void Save(UserRegisterationViewModel userRegisterationVM)
        {
            BrightDb2Context db = new BrightDb2Context();
            User user = new User();

            user.UserName = userRegisterationVM.UserName;
            user.Password = userRegisterationVM.Password;
            user.EmailId = userRegisterationVM.EmailId;
            user.Address = userRegisterationVM.Address;
            user.Age = userRegisterationVM.Age;
            user.MobileNumber = userRegisterationVM.MobileNumber;

            db.Users.Add(user);
            db.SaveChanges();
        }


    }
}
