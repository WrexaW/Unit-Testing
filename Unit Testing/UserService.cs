namespace Unit_Testing
{
    public class UserService
    {
        public List<AdminEntity> Admins { get; set; } = new List<AdminEntity>();
        public bool isAdmin(int userId) 
        { 
        return Admins.Any(a => a.UserId == userId);
        }
    }
}
