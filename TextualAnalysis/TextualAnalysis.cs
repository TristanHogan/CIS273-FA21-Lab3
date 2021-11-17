using System;
using System.Collections.Generic;

namespace TextualAnalysis
{
    public class TextualAnalysis
    {

        public const string STOP_WORD_PATH = "../../../Data/test.txt";
        public TextualAnalysis()
        {
        }


        public static Dictionary<string, int> ComputeWordFrequencies(string s, bool ignoreStopWords = false)
        {
            var wordCounts = new Dictionary<string, int>();
            // s = "all the faith he had had had had no effect."


            // split the string into words
            var words = s.ToLower().Split();


            var stopWords = GetStopWordsFromFile(STOP_WORD_PATH);

            // create hash set to store stopwords
            var stopWordsHashSet = new HashSet<string>();
            foreach (var word in stopWords)
            {
                stopWordsHashSet.Add(word);
            }

            // foreach word process it
                // if it's in the hashtable, then increment the count
                // else make a new entry with a count of 1

            foreach (string word in words)
            {

                // if ignoreStopWords is true and word is not a stop word, then do this

                if (wordCounts.ContainsKey(word))
                {
                    wordCounts[word]++;
                }
                else
                {
                    wordCounts[word] = 1;
                }
            }

            return wordCounts;
        }


        public static Dictionary<string, int> ComputeWordFrequenciesFromFile(string path, bool ignoreStopWords = false)
        {
            return null;
        }

        private static string[] GetStopWordsFromFile(string path)
        {
            var rawLines = System.IO.File.ReadAllLines(path);
            var lines = new List<string>();

            foreach (var line in rawLines)
            {
                if (line.Trim() != "")
                {
                    lines.Add(line.Trim().ToLower());
                }
            }

            return lines.ToArray();
        }

    }
}
