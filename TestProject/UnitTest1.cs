using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow('q', "mysterious", 0)]
        [DataRow('y', "mysterious", 1)]
        [DataRow('l', "helllllo", 5)]
        public void CountOccurences_FindNNumberOfChars_MatchesExpectedCount(char charToFind, string stringToCheck, int expectedResult)
        {
            //Arrange
            int actualResult;

            //Act
            actualResult = StringUtilities.CountOccurences(charToFind, stringToCheck);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CountOccurences_StringIsNull_ReturnNegative1()
        {
            //Arrange
            string stringToCheck = null;
            char charToFind = 'a';
            int expectedResult = -1;
            int actualResult;

            //Act
            actualResult = StringUtilities.CountOccurences(charToFind, stringToCheck);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataTestMethod]
        [DataRow('a', "hello", 0)]
        [DataRow('y', "ymca", 1)]
        [DataRow('a', "aaA", 3)]
        [DataRow('A', "aloha", 2)]
        public void CountOccurences_FindNumberCasesensitive_MatchesExpectedCount(char charToFind, string stringToCheck, int expectedResult)
        {
            //Arrange
            int actualResult;

            //Act
            actualResult = StringUtilities.CountOccurences(charToFind, stringToCheck);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }


    }

    
}
