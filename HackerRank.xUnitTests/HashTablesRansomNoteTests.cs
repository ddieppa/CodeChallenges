using HackerRank.Solutions;
using Xunit;

namespace HackerRank.xUnitTests
{
    public class HashTablesRansomNoteTests
    {
        private readonly HashTablesRansomNote _sut;

        public HashTablesRansomNoteTests()
        {
            _sut = new HashTablesRansomNote();
        }

        [Theory]
        [InlineData("Yes","give me One grand today night","give One grand today")]
        [InlineData("Yes","apgo clm w lxkvg mwz elo bg elo lxkvg elo apgo apgo w elo bg","elo lxkvg bg mwz clm w")]
        [InlineData("No","two times three is not four","two times two is four")]
        [InlineData("No","ive got a lovely bunch of coconuts","ive got some coconuts")]
        [InlineData("No","give me One grand today night","give one grand today")]
        public void CheckMagazine_InlineData(string expected, string magazine, string note)
        {
            //Arrange
            var magazineArray = magazine.Split(' ');
            var noteArray = note.Split(' ');
                
            //Act
            var actual = _sut.CheckMagazine(magazineArray, noteArray);
            
            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait("Category", "Internal")]
        [MemberData(nameof(InternalHashTablesRansomNoteTestData.TestData), MemberType = typeof(InternalHashTablesRansomNoteTestData))]
        public void CheckMagazine_InternalTestData(string expected, string[] magazine, string[] note)
        {
            //Act
            var actual = _sut.CheckMagazine(magazine, note);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [MemberData(nameof(ExternalHashTablesRansomNoteTestData.TestData), MemberType = typeof(ExternalHashTablesRansomNoteTestData))]
        public void CheckMagazine_ExternalTestData(string expected, string[] magazine, string[] note)
        {
            //Act
            var actual = _sut.CheckMagazine(magazine, note);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}