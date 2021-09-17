using System;
using System.Collections.Generic;
using System.Text;

namespace TO_AI.Trainer
{
    /// <summary>
    /// Matches input with dataset
    /// </summary>
    class Matcher
    {
        /// <summary>
        /// Matching dataset
        /// </summary>
        Dataset Data { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="dataset"></param>
        public Matcher(Dataset dataset)
        {
            this.Data = dataset;
        }

        public List<(string, string)> MatchSentence(string input)
        {
            /* From dataset, mismatched */
            List<(string, string)> unequalWords = new List<(string, string)>();
            /* From dataset, mismatched */
            List<(string, string)> tmpUnequal = new List<(string, string)>();

            string[] sentence = input.Split(' ');
            double score = 0;

            foreach(string[] dataSentence in Data.Data)
            {
                if(dataSentence.Length == sentence.Length)
                {
                    int count = 0;
                    for(int i = 0; i < dataSentence.Length; i++)
                    {
                        string dataWord = dataSentence[i];
                        if (dataWord.Equals(sentence[i]))
                        {
                            count += 1;
                        }
                        else
                        {
                            tmpUnequal.Add((dataWord, sentence[i]));
                        }
                    }

                    int tmpscore = (int)((double)count / dataSentence.Length * 100);
                    Console.WriteLine("Score: " + tmpscore);
                    if (tmpscore > score)
                    {
                        unequalWords = tmpUnequal;
                        score = tmpscore;
                    }

                    tmpUnequal.Clear();
                }
            }

            return unequalWords;
        }
    }
}
