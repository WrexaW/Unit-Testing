namespace Unit_Testing.Entites
{
    public class AdminEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
