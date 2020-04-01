using HackerRank.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HackerRank.UnitTests
{
    [TestClass]
    public class NewYearChaosTests
    {
        private NewYearChaos _solution;

        [TestInitialize]
        public void TestInitialize()
        {
            _solution = new NewYearChaos();
        }
        
       
        [TestMethod]
        public void MinimunBribes_Scenario1_Returns4()
        {
            //Arrange
            
            var expected = "4";
            var q = new int[] { 1 ,2 ,5 ,3 ,4 ,7 ,8 ,6 };
            //Act
            var actual = _solution.MinimunBribes(q);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MinimunBribes_Scenario2_ReturnsTooChaotic()
        {
            //Arrange
            
            var expected = "Too chaotic";
            var q = new int[] { 5 ,1, 2 ,3 ,7 ,8 ,6 ,4 };
            //Act
            var actual = _solution.MinimunBribes(q);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void MinimunBribes_Scenario3_Returns7()
        {
            //Arrange
            
            var expected = "7";
            var q = new int[] { 1 ,2 ,5 ,3, 7, 8, 6, 4 };
            //Act
            var actual = _solution.MinimunBribes(q);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
