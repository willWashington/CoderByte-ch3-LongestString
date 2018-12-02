using System;

namespace CoderByte_LongestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using the C# language, have the function LongestWord(sen) take the sen parameter being passed and return the largest word in the string. 
            //If there are two or more words that are the same length, return the first word from the string with that length. 
            //Ignore punctuation and assume sen will not be empty. 

            Console.WriteLine(LengthDeterminer("This is a very long string that has a large number of words in it!"));
            Console.ReadLine();
        }

        public static string LengthDeterminer(string _string)
        {
            if (_string == null)
            {
                _string = " ";
            }
            string[] revString = _string.Split(null);
            string finString = " ";

            foreach (string str in revString)
            {
                if (str.Length > finString.Length)
                {
                    finString = str;
                }
            }
            return (finString);
        }
    }
}
