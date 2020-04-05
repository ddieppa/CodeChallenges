using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit.Sdk;

namespace HackerRank.xUnitTests
{
    public class ExternalHashTablesRansomNoteTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                var fileLines =
                    File.ReadAllLines("HashTablesRansomNoteTestData.txt");
                var testCases = new List<object[]>();
                foreach (var line in fileLines)
                {
                    var values = line.Split(',');
                    object[] testCase =
                    {
                        values[0], values[1].Split(' '), values[2].Split(' ')
                    };
                    testCases.Add(testCase);
                }

                return testCases;
            }
        }
    }
}