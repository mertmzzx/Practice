namespace Zad28
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string tableFile = Console.ReadLine();
                string wordsFile = Console.ReadLine();

                if (tableFile == null || wordsFile == null)
                {
                    throw new Exception("Невалидни имена на файлове!"); // Invalid format: Matrix is not rectangular!
                }

                char[,] table = ReadMatrix(tableFile);
                List<string> words = ReadWords(wordsFile);

                List<string> contains = Contains(table, words);

                foreach (var item in contains)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            

        }

        public static char[,] InitializeArray(string fileName)
        {
            int rowCount = 0;
            int colCount = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string? line = reader.ReadLine();

                colCount = line.Length;

                while (line != null)
                {
                    if (line.Length != colCount)
                    {
                        throw new Exception("Матрицата не е правоъгълна!");
                        //return null; ???? по условие иска ReadMatrix() да връща null при неправоъгълна матрица ???
                    }
                    
                    rowCount++;
                    line = reader.ReadLine();
                }

                reader.Close();
            }

            char[,] array = new char[rowCount, colCount];
            return array;
        }

        public static char[,] ReadMatrix(string fileName)
        {
            char[,] array = InitializeArray(fileName); // ????????????

            using (StreamReader reader = new StreamReader(fileName))
            {

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    char[]? line = reader.ReadLine().ToCharArray();

                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = line[j];
                    }
                }

                reader.Close();
            }

            return array;
        }

        public static List<string> ReadWords(string fileName)
        {
            List<string> words = new List<string>();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string? line = reader.ReadLine();

                while (line != null)
                {
                    words.Add(line);

                    line = reader.ReadLine();
                }

                reader.Close();
            }

            return words;
        }

        public static List<string> Contains(char[,] table, List<string> words)
        {
            List<string> compatible = new List<string>();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                string line = "";

                for (int j = 0; j < table.GetLength(1); j++)
                {
                    line += table[i, j];
                }

                foreach (string word in words)
                {
                    string reversedWord = ReverseWord(word);
                    

                    if (line.Contains(word))
                    {
                        compatible.Add(word);
                    }
                    else if (line.Contains(reversedWord))
                    {
                        compatible.Add(word);
                    }
                }
            }

            return compatible;
        }

        public static string ReverseWord(string word)
        {
            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            string reversedWord = "";

            for (int i = 0; i < arr.Length; i++)
            {
                reversedWord += arr[i];
            }

            return reversedWord;
        }
    }
}