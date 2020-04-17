using System.Collections.Generic;

namespace HackerRank.xUnitTests
{
    public class InternalHashTablesRansomNoteTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[]
                {
                    "Yes"
                    , "give me One grand today night".Split(' ')
                    , "give One grand today".Split(' ')
                };
                yield return new object[]
                {
                    "Yes"
                    , "apgo clm w lxkvg mwz elo bg elo lxkvg elo apgo apgo w elo bg"
                        .Split(' ')
                    , "elo lxkvg bg mwz clm w".Split(' ')
                };
                yield return new object[]
                {
                    "No", "two times three is not four".Split(' '), "two times two is four".Split(' ')
                };
                yield return new object[]
                {
                    "No"
                    , "two times three is not four".Split(' ')
                    , "two times two is four".Split(' ')
                };
                yield return new object[]
                {
                    "No"
                    , "give me One grand today night".Split(' ')
                    , "give one grand today".Split(' ')
                };
            }
        }
    }
}