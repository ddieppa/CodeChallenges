using System.Collections;

namespace HackerRank.Solutions
{
    public class HashTablesRansomNote
    {
        public string CheckMagazine(string[] magazine, string[] note)
        {
            var result = "No";
            var magazineHastable = new Hashtable();
            var noteHastable = new Hashtable();
            if (note.Length > magazine.Length)
            {
                return result;
            }

            foreach (var key in note)
            {
                if (noteHastable.ContainsKey(key))
                {
                    noteHastable[key] = (int)noteHastable[key] + 1;
                    continue;
                }

                noteHastable.Add(key, 1);
            }

            foreach (var key in magazine)
            {
                if (magazineHastable.ContainsKey(key))
                {
                    magazineHastable[key] = (int)magazineHastable[key] + 1;
                    continue;
                }
                magazineHastable.Add(key, 1);
            }

            foreach (var noteKey in noteHastable.Keys)
            {
                if (magazineHastable.ContainsKey(noteKey) && (int)magazineHastable[noteKey] >= (int)noteHastable[noteKey])
                {
                    result = "Yes";
                    continue;
                }
                result = "No";
                break;
            }

            return result;
        }
    }
}
