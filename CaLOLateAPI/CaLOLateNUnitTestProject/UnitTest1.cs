using CaLOLateAPI.Controllers;
using NUnit.Framework;
using System.Net.Http;
using System.Web.Http;
namespace Tests
{
    public class Tests
    {
        BattlerController battler = new BattlerController();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SetPlayer1()
        {
            var controller = new BattlerController();
            controller.UpdatePlayer1("Ashe");
            Assert.Pass();
        }

        public void Test2()
        {

        }
    }
}