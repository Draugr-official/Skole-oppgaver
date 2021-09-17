using System;
using System.Collections.Generic;
using System.IO;
using TO_AI.Trainer;

namespace TO_AI
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ; )
            {
                /* Preparation */
                Dataset dataset = new Dataset(File.ReadAllText("text.ds"));
                Matcher matcher = new Matcher(dataset);

                /* Execution */
                string input = Console.ReadLine();
                // Matched, original
                List<(string, string)> sentence = matcher.MatchSentence(input);

                /* Output */
                foreach((string, string) result in sentence)
                {
                    if(result.Item1 != result.Item2)
                    {
                        Console.WriteLine($"Replace {result.Item1} with {result.Item2}");
                    }
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
