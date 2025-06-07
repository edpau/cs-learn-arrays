using System.Diagnostics.CodeAnalysis;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = { "how", "now", "brown", "cow" };
            int[] arrayOfInts = { 0, 0, 1, 2, 3 };
            char[] arrayOfLetters = { };

            Console.WriteLine($"arrayOfStrings.Length = {arrayOfStrings.Length}");
            Console.WriteLine($"arrayOfInts.Length = {arrayOfInts.Length}");
            Console.WriteLine($"arrayOfLetters.Length = {arrayOfLetters.Length}");
            Console.WriteLine();

            Console.WriteLine(arrayOfStrings[0]); // how
            Console.WriteLine(arrayOfStrings[3]); // cow
            Console.WriteLine(arrayOfStrings[arrayOfInts[3]]); // uses value 0 to index

            //Assign to variable and create array from string
            string cowColor = arrayOfStrings[2]; // "brown"
            arrayOfLetters = new char[cowColor.Length];

            arrayOfLetters[0] = 'c';
            arrayOfLetters[1] = cowColor[1]; // 'r'
            arrayOfLetters[2] = cowColor[2]; // 'o'

            Console.WriteLine(arrayOfLetters); // prints as string -> cro??
            Console.WriteLine(arrayOfLetters[3]); //'\0' the null character
            Console.WriteLine();

            //Two-dimensional array
            int[,] checkers = new int[4, 4];

            checkers[0, 0] = 1;
            checkers[0, 1] = 2;
            checkers[1, 0] = 3;
            checkers[1, 1] = 4;

            Console.WriteLine("Checkerboard pattern:");
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write($"{checkers[row, col]} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}

