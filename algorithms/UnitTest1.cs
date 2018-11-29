using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace algorithms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //I love solving problems and it is fun
            //Split the title string by spaces
            //Capitalize word[0]
            //Capitalize word[last]
            //For each word from word[1] to word[last-1]
            //if the list contains the word
            //Lowercase word
            //Else
            //Capitalize word

            //Combine word into sentence
            var x = Capitalizer("Hello World");
            var y = Capitalizer("heLlo in at the arGentina ConFedEration World");
            var z = Capitalizer("mello World World");
            Debug.WriteLine(z);
            Debug.WriteLine(y);
            Debug.WriteLine(x);
            Console.WriteLine(x);
        }

        private string Capitalizer(string standardString)
        {

            string[] inputWords = standardString.Split(' ');
            if (inputWords.Length <= 0)
                return "";

            List<string> trasnformedWords = new List<string>();
            trasnformedWords.Add(Capitalize(inputWords[0]));

            var count = 1;
            while (count <= inputWords.Length - 1)
            {
                trasnformedWords.Add(InnerTextChecker(inputWords[count]));
                count++;

            }
            trasnformedWords.Add(Capitalize(inputWords.Last()));
            return string.Join(" ", trasnformedWords);
        }

        private string Capitalize(string inputString)
        {

            var modifiedString = inputString.ToLower();
            modifiedString = String.Format("{0}{1}",
                                            modifiedString.First().ToString().ToUpper(),
                                            modifiedString.Substring(1));
            return modifiedString;

        }

        private string InnerTextChecker(string inputString)
        {
            var modifiedString = inputString.ToLower();
            string[] nonCapitalizableString = { "a", "the", "to", "at", "in", "with" };

            if (nonCapitalizableString.Contains(modifiedString))
                return modifiedString;
            return Capitalize(modifiedString);
        }

        //Capitalize word
        //Lowercase word
        //Capitalize word[0]

        //Lowercase word
        //foreach letter in word
        //lowercase letter
    }
}
