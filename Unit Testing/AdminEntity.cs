namespace Unit_Testing
{
    public class AdminEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
