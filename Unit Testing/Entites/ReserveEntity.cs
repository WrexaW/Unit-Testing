namespace Unit_Testing.Entites
{
    public class ReserveEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public UserEntity owner { get; set; }
        public int ownerId { get; set; }
        public ReserveStatus Status { get; set; }


        public enum ReserveStatus
        {
            PENNDING,
            ACCESPT,
            REJECT,
            CANSEL
        }
    }
}
