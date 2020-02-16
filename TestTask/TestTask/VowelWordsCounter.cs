using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestTask
{
    public class VowelWordsCounter
    {
        private readonly Regex format = new Regex(@"\.txt$");
        private readonly Regex content = new Regex("^[a-zA-Z\n, ]*$");
        private readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        
        public bool FormatIsValid(string filePath) => format.IsMatch(filePath);
        public bool ContentIsValid(string contentText) => content.IsMatch(contentText);

        public int VowelWordsInStringCount(string data)
             => data.Split(' ', '\n', StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => x.ToLower().All(c => vowels.Contains(c)))
                    .ToArray().Length;

        public int VowelWordsInFileCount(string filePath)
        {
            int counter = 0;
            if (!FormatIsValid(filePath)) 
                throw new ArgumentException("Wrong format of file");
            try
            {
                using (StreamReader sr = new StreamReader(filePath, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!ContentIsValid(line)) 
                            throw new ArgumentException("Content of file is invalid");
                        counter += VowelWordsInStringCount(line);
                    }
                }
                return counter;
            }
            catch (FileNotFoundException)
            {
                throw;
            }
        }
    }
}
