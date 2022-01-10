using System;
using System.Collections.Generic;
using System.Text;

namespace TO_AI.Trainer
{
    /// <summary>
    /// Generic dataset
    /// </summary>
    class Dataset
    {
        public List<string[]> Data = new List<string[]>();

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="Data"></param>
        public Dataset(string Data)
        {
            /* Splits dataset from into a higher format */
            string[] sentences = Data.ToLower().Replace(". ", ".").Split('.');
            foreach(string sentence in sentences)
            {
                this.Data.Add(sentence.Split(' '));
            }
        }
    }
}
