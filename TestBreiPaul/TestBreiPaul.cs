using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proiect_Fis.Models;
using Proiect_Fis.Data;
using System.Collections.Generic;
using System.Linq;
namespace TestBreiPaul
{
    [TestClass]
    public class TestBreiPaul
    {
        
            [TestInitialize]
            public void TestInitialize()
            {
                
            }

            [TestCleanup]
            public void TestCleanup()
            {
                
            }

            [TestMethod]
            public void TestClientConstructorById()
            {
                int testClientId = 1;

                Client client = new Client(testClientId);

                Assert.AreEqual("pual", client.Nume);
                Assert.AreEqual("1234", client.Parola); 
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
            public void TestLoginSuccessful()
            {
                // Arrange
                Client client = new Client("ExistingUser", "CorrectPassword");

                // Act
                client.Login();

                // Assert
                Assert.IsNotNull(Client.LoggedInUser);
                Assert.AreEqual("ExistingUser", Client.LoggedInUser.Nume);
            }

            [TestMethod]
            public void TestLoginUnsuccessful()
            {
                // Arrange
                Client client = new Client("NonExistingUser", "WrongPassword");

                // Act
                client.Login();

                // Assert
                Assert.IsNull(Client.LoggedInUser);
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