using System;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name:");
            string path = Console.ReadLine();
            try
            {
                VowelWordsCounter vowelWordsCounter = new VowelWordsCounter();
                int count = vowelWordsCounter.VowelWordsInFileCount(path);
                Console.WriteLine("Words consist of vowels characters only: " + count);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
