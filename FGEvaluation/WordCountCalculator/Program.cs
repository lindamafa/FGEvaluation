using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Utils;

namespace WordCountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsoleLogger logger = new ConsoleLogger();

            logger.WriteLine("Welcome to FedGroup Word Count Calculator by Linda");

            var promptFilePath = "Please enter a valid text file path (e.g. C:\\Temp\\MyFile.txt):";
            var filePath = logger.Prompt(promptFilePath);

            while(!File.Exists(filePath))
            {
                filePath = logger.Prompt(promptFilePath);
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();

            //StringBuilder builder = new StringBuilder();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //builder.AppendLine(line);
                    var words = line.ToLower().Split(new[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        if (dict.ContainsKey(words[i]))
                        {
                            dict[words[i]] = dict[words[i]]+1;
                        }
                        else
                        {
                            dict.Add(words[i], 1);
                        }
                            
                    }
                    
                }
            }
            var sortedDict = dict.OrderByDescending(p => p.Value).Take(100);
            foreach (var item in sortedDict)
            {
                logger.WriteLine($"{item.Key} {item.Value}");
            }

            logger.ReadLine();
            // var textInput = builder.ToString();

            //Split the words
            //var words2 = textInput.Split(new [] {',', '.', ' '}, StringSplitOptions.RemoveEmptyEntries);


        }

        //Pseudocode
        //Prompt user to enter a file path for text file
        //Check if it is a valid text file           
            //While file is invalid
                //Let the user know that the file is invalid
                //Prompt the user to enter a file path for text file
             //If valid text file
                //Create stream reader to read each line
                //Split text by space into a hashset.
                    //Before inserting a word check if it exists yet
                        //If it does increment the count for that word
                        //Else add word with count = 1
                    //Once all the text has been added 
                        //Traverse through the hashset and print word and count





    }
}
