using HackerRank.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRank.UnitTests
{
    [TestClass]
    public class HashTablesRansomNoteTests
    {
        public HashTablesRansomNote CreateClass()
        {
            return new HashTablesRansomNote();
        }

        [TestMethod]
        public void CheckMagazine_Scenario1_ReturnsYes()
        {
            //Arrange
            var ramsonNote = CreateClass();
            var magazine = "give me one grand today night".Split(' ');
            var note = "give one grand today".Split(' ');
            var expected = "Yes";

            //Act
            var actual = ramsonNote.CheckMagazine(magazine, note);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CheckMagazine_Scenario2_ReturnsNo()
        {
            //Arrange
            var ramsonNote = CreateClass();
            var magazine = "two times three is not four".Split(' ');
            var note = "two times two is four".Split(' ');
            var expected = "No";

            //Act
            var actual = ramsonNote.CheckMagazine(magazine, note);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMagazine_Scenario3_ReturnsNo()
        {
            //Arrange
            var ramsonNote = CreateClass();
            var magazine = "ive got a lovely bunch of coconuts".Split(' ');
            var note = "ive got some coconuts".Split(' ');
            var expected = "No";

            //Act
            var actual = ramsonNote.CheckMagazine(magazine, note);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMagazine_Scenario4_ReturnsYes()
        {
            //Arrange
            var ramsonNote = CreateClass();
            var magazine = "give me One grand today night".Split(' ');
            var note = "give One grand today".Split(' ');
            var expected = "Yes";

            //Act
            var actual = ramsonNote.CheckMagazine(magazine, note);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMagazine_Scenario5_ReturnsNo()
        {
            //Arrange
            var ramsonNote = CreateClass();
            var magazine = "give me One grand today night".Split(' ');
            var note = "give one grand today".Split(' ');
            var expected = "No";

            //Act
            var actual = ramsonNote.CheckMagazine(magazine, note);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMagazine_Scenario5_ReturnsYes()
        {
            //Arrange
            var ramsonNote = CreateClass();
            var magazine = "apgo clm w lxkvg mwz elo bg elo lxkvg elo apgo apgo w elo bg".Split(' ');
            var note = "elo lxkvg bg mwz clm w".Split(' ');
            var expected = "Yes";

            //Act
            var actual = ramsonNote.CheckMagazine(magazine, note);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
