using AddressBookLinQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookLinQTest
{
    [TestClass]
    public class UnitTest1
    {
        DataTableManager dataTableMangerT;

        [TestInitialize]
        public void SetUp()
        {
            dataTableMangerT = new DataTableManager();
        }
        //UC-1 insert contact value
        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            //Arrange
            int expected = 3;
            //Act
            int actual = dataTableMangerT.AddValues();
            //Assert
            Assert.AreEqual(actual, expected);
        }
        //UC-4 Edit Contact
        [TestMethod]
        [TestCategory("Modify Values in Data Table")]
        public void GivenModifyValues_returnInteger()
        {
            int expected = 1;
            int actual = dataTableMangerT.EditDataTable("Swapnil", "Firstname", "Shweta");
            Assert.AreEqual(actual, expected);
        }
        //UC-5 
        [TestMethod]
        [TestCategory("Delete person details")]
        public void DeleteQuery_returnInteger()
        {
            int expected = 1;
            int actual = dataTableMangerT.DeleteRowInDataTable("Swagata");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 6 
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City or state")]
        public void GivenRetrieveQuery_BasedOnCityandState_returnString()
        {
            string expected = "Swagata ";
            string actual = dataTableMangerT.RetrieveBasedOnCityorState("Benglore", "Karnataka");
            Assert.AreEqual(actual, expected);
        }

        //UC 7 Retrieve count values from DataTable based on City or State
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City ")]
        public void GivenRetrieveCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "2 1 ";
            string actual = dataTableMangerT.RetrieveCountBasedOnCityorState();
            Assert.AreEqual(actual, expected);
        }
        //UC 8 Sort based on City
        [TestMethod]
        [TestCategory("Sort based on City")]
        public void GivenSortQuery_BasedOnCityandState_returnString()
        {
            string expected = "Snehal Swapnil ";
            string actual = dataTableMangerT.SortBasedOnCity("Pune");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 8 sort based on Contact Type
        [TestMethod]
        [TestCategory("Sort based on Type")]
        public void GivenCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "2 1 ";
            string actual = dataTableMangerT.RetrieveCountBasedOnType();
            Assert.AreEqual(actual, expected);
        }
    }

}