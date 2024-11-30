using Unit_Testing.Entites;
using Unit_Testing.Service;

namespace TestProject1
{

    public class Tests
    {
        private UserService userService;
        private ReserveService serveService;
        [SetUp]
        public void Setup()
        {
            userService = new UserService();
            serveService = new ReserveService();

        }
        [Test]

       public void CanCansel_owner_True()
        {
            //Arrenge
            UserEntity owner = new UserEntity()
            {
                FullName = "کاربر 1",
                Id = 1
            };
            ReserveEntity reserve = new ReserveEntity()
            {
                Id = 10,
                owner =owner,
                ownerId = 1,
                Status = ReserveEntity.ReserveStatus.PENNDING,
                Title = "هتل پردیس"
            };

            //Act
            bool result = serveService.CanselReserve(reserve.Id , owner.Id);
            //Assert
            Assert.IsTrue(result);
        }
    }
}