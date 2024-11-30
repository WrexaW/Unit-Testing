using Unit_Testing.Entites;

namespace Unit_Testing.Service
{
    public class ReserveService
    {
        public ReserveService() { }
        public bool CanselReserve(ReserveEntity reserve, UserEntity user)
        {
            if (reserve.ownerId == user.Id)
            { 
            return true;
            }
            return true;

        }
         
        public bool CanselReserve(ReserveEntity reserve, UserEntity user, UserService userService)
        {
            if (reserve.ownerId == user.Id)
            {
                return true;
            }
            else if(userService.isAdmin(user.Id))
            {
                return true;
            }
            return true;

        }
    }
}
