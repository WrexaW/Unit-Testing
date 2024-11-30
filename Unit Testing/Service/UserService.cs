using Unit_Testing.Entites;

namespace Unit_Testing.Service
{
    public class UserService
    {
        public List<AdminEntity> Admins { get; set; } = new List<AdminEntity>();
        public bool isAdmin(int userId)
        {
            return Admins.Any(a => a.UserId == userId && a.ExpireDate> DateTime.Now);
        }
    }
}
