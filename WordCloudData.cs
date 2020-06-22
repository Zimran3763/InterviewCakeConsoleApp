using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCakeConsoleApp
{
    //public class WordCloudData
    //{


    //    public static List<string> GetWords(string text)
    //    {
    //        char[] charArray = text.ToCharArray();
    //        var wordList = new List<string>();
    //        int startIndex = 0;
    //        int length = 0;

    //        for (int i = 0; i < charArray.Length; i++)
    //        {
    //            length++;

    //            if (charArray[i] == ' ' || i == charArray.Length - 1)
    //            {
    //                string newWord = text.Substring(startIndex, length);
    //                wordList.Add(newWord);
    //                startIndex = i + 1;
    //                length = 0;
    //            }
    //        }
    //        return wordList;
    //    }

    //}
    using System.Collections.Generic;

    public class WordCloudData
    {
        private Dictionary<string, int> _wordsToCounts = new Dictionary<string, int>();

        //public IDictionary<string, int> WordsToCounts
        //{
        //    get { return _wordsToCounts; }
        //}

        public WordCloudData(string inputString)
        {
            PopulateWordsToCounts(inputString);
        }

        private void PopulateWordsToCounts(string inputString)
        {
            // Iterates over each character in the input string, splitting
            // words and passing them to addWordToDictionary()

            int currentWordStartIndex = 0;
            int currentWordLength = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                var character = inputString[i];

                if (i == inputString.Length - 1)
                {
                    // If we reached the end of the string we check if the last
                    // character is a letter and add the last word to our dictionary

                    if (char.IsLetter(character))
                    {
                        currentWordLength++;
                    }
                    if (currentWordLength > 0)
                    {
                        var currentWord = inputString.Substring(currentWordStartIndex,
                            currentWordLength);
                        AddWordToDictionary(currentWord);
                    }
                }
                else if (character == ' ' || character == '\u2014')
                {
                    // If we reach a space or emdash we know we're at the end of a word
                    // so we add it to our dictionary and reset our current word

                    if (currentWordLength > 0)
                    {
                        var currentWord = inputString.Substring(currentWordStartIndex,
                            currentWordLength);
                        AddWordToDictionary(currentWord);
                        currentWordLength = 0;
                    }
                }
                else if (character == '.')
                {
                    // We want to make sure we split on ellipses so if we get two periods in
                    // a row we add the current word to our dictionary and reset our current word

                    if (i < inputString.Length - 1 && inputString[i + 1] == '.')
                    {
                        if (currentWordLength > 0)
                        {
                            var currentWord = inputString.Substring(currentWordStartIndex,
                                currentWordLength);
                            AddWordToDictionary(currentWord);
                            currentWordLength = 0;
                        }
                    }
                }
                else if (char.IsLetter(character) || character == '\'')
                {
                    // If the character is a letter or an apostrophe, we add it to our current word

                    if (currentWordLength == 0)
                    {
                        currentWordStartIndex = i;
                    }
                    currentWordLength++;
                }
                else if (character == '-')
                {
                    // If the character is a hyphen, we want to check if it's surrounded by letters.
                    // If it is, we add it to our current word

                    if (i > 0 && char.IsLetter(inputString[i - 1])
                            && char.IsLetter(inputString[i + 1]))
                    {
                        if (currentWordLength == 0)
                        {
                            currentWordStartIndex = i;
                        }
                        currentWordLength++;
                    }
                    else
                    {
                        if (currentWordLength > 0)
                        {
                            var currentWord = inputString.Substring(currentWordStartIndex,
                                currentWordLength);
                            AddWordToDictionary(currentWord);
                            currentWordLength = 0;
                        }
                    }
                }
            }
        }

        private void AddWordToDictionary(string word)
        {
            int currentCount = 0;

            // If the word is already in the dictionary we increment its count
            if (_wordsToCounts.TryGetValue(word, out currentCount))
            {
                _wordsToCounts[word] = currentCount + 1;
            }
            else if (_wordsToCounts.TryGetValue(word.ToLower(), out currentCount))
            {
                // If a lowercase version is in the dictionary, we know our input word must be uppercase,
                // but we only include uppercase words if they're always uppercase.
                // So we just increment the lowercase version's count

                _wordsToCounts[word.ToLower()] = currentCount + 1;
            }
            else if (_wordsToCounts.TryGetValue(Capitalize(word), out currentCount))
            {
                // If an uppercase version is in the dictionary, we know our input word must be lowercase.
                // Since we only include uppercase words if they're always uppercase, we add the
                // lowercase version and give it the uppercase version's count

                _wordsToCounts.Add(word, currentCount + 1);
                _wordsToCounts.Remove(Capitalize(word));
            }
            else
            {
                // Otherwise, the word is not in the dictionary at all, lowercase or uppercase.
                // So we add it to the dictionary

                _wordsToCounts.Add(word, 1);
            }
        }

        private string Capitalize(string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1);
            
        }
    }
}
