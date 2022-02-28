using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvičení_4_text
{
    public class StringStatistics
    {

        string text;
        public StringStatistics(string text)
        {
            this.text = text;
        }

        public string[] SplitStringToArray()
        {

            char[] separators = new char[] { ' ', '.', ',', ';', '!', '?', '\n', '(', ')' };
            return text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        }
        public int CountWords()
         {
             int wordCount = 0;
             char[] separators = { ' ', ',', '?', '.', '\n' };
             string[] subs = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
             foreach (String item in subs)
             {
                 wordCount += 1; 
             }
             return wordCount;
         }
        public int CountLines()
        {
            var count = text.Split('\n').Length;

            return count;
        }

        public int CountSentences()
        {
            int CountSentences = 0;
            char[] separators = { '.', '!', '?' };
            string[] count = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (String item in count)
            {
                CountSentences += 1 ;
            }

            return CountSentences -1;
        }

        public string[] LongestWords()
        {
            int lengthOfWord = 0;
            int numOfLongestWords = 0;

            string[] textArray = SplitStringToArray();
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i].Length > lengthOfWord)
                {
                    lengthOfWord = textArray[i].Length;
                    numOfLongestWords = 1;
                }
                else if (textArray[i].Length == lengthOfWord)
                {
                    numOfLongestWords++;
                }
            }
            string[] longest = new string[numOfLongestWords];
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i].Length == lengthOfWord)
                {

                    longest[Array.IndexOf(longest, null)] = textArray[i];
                }
            }
            return longest;

        }
        public string[] ShortestWords()
        {
            int lengthOfWord = int.MaxValue;
            int numOfShortestWords = 0;

            string[] textArray = SplitStringToArray();
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i].Length < lengthOfWord)
                {
                    lengthOfWord = textArray[i].Length;
                    numOfShortestWords = 1;
                }
                else if (textArray[i].Length == lengthOfWord)
                {
                    numOfShortestWords++;
                }
            }
            string[] shortest = new string[numOfShortestWords];
            for (int i = 0; i < textArray.Length; i++)
            {
                if (textArray[i].Length == lengthOfWord)
                {

                    shortest[Array.IndexOf(shortest, null)] = textArray[i];
                }
            }
            return shortest;
        }
        public string[] SortText()
        {
            string[] textArray = SplitStringToArray();
            Array.Sort(textArray);
            return textArray;
        }
        public string[] MostOftenWords()
        {
            string[] textArray = SplitStringToArray();
            int numOfWords = 0;
            int numOfMostCommon = 0;
            List<string> commonWords = new List<string>();

            for (int i = 0; i < textArray.Length; i++)
            {
                numOfWords = 0;
                for (int j = 0; j < textArray.Length; j++)
                {

                    if (textArray[i] == (textArray[j]))
                    {
                        numOfWords++;
                    }
                }
                if (numOfWords > numOfMostCommon)
                {
                    numOfMostCommon = numOfWords;
                    numOfWords = 1;
                    commonWords.Clear();
                    commonWords.Add(textArray[i]);
                }
                else if (numOfWords == numOfMostCommon)
                {
                    numOfWords++;
                    if (!commonWords.Contains(textArray[i])) commonWords.Add(textArray[i]);
                }
            }
            return commonWords.ToArray();


        }
        public String[] Alphabet()
        {
            char[] separators = { ',', '!', '?', '.', '(', ')', ' ', '\n' };
            string[] alph = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(alph);

            return alph;

        }
    }
}
