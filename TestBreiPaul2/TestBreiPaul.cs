using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Proiect_Fis.Models;
using Proiect_Fis.Data;
using System.Linq;

namespace Proiect_Fis.Tests
{
    [TestClass]
    public class ClientTests
    {
        private Mock<ApplicationDbContext> _mockContext;
        private Client _client;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockContext = new Mock<ApplicationDbContext>();
            _client = new Client();
        }

        [TestMethod]
        public void TestClientLogoutSuccess()
        {
            var client = new Client { Nume = "Test", Parola = "Test123" };
            client.IsUserLoggedIn();
            client.Logout();
            Assert.IsNull(Client.LoggedInUser);
        }

        [TestMethod]
        public void TestClientLogoutFailure()
        {
            var client = new Client { Nume = "Test", Parola = "Test123" };
            client.Logout();
            client.Logout();
            Assert.IsFalse(client.IsUserLoggedIn());
        }

        [TestMethod]
        public void TestClientConstructorByNameAndPassword()
        {
            // Arrange
            string testName = "TestUser";
            string testPassword = "TestPassword";

            // Act
            Client client = new Client(testName, testPassword);

            // Assert
            Assert.AreEqual(testName, client.Nume);
            Assert.AreEqual(testPassword, client.Parola);
        }

        [TestMethod]
        public void TestClientProperties()
        {

            Client client = new Client("TestUser", "TestPassword");

            Assert.AreEqual("TestUser", client.Nume);
            Assert.AreEqual("TestPassword", client.Parola);
        }

        [TestMethod]
        public void TestClientDefaultConstructor()
        {

            Client client = new Client();

            Assert.IsNull(client.Nume);
            Assert.IsNull(client.Parola);
        }
    }
}


