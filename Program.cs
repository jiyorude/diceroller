using System;

class Program
{
    static void Main()
    {
        int rolls;
        Random dice = new Random();

        while (true)
        {
            Console.Write("\nPlease specify the number of rolls: ");
            if (int.TryParse(Console.ReadLine(), out rolls))
            {
                break;
            }
            else 
            {
                Console.WriteLine("\n...Invalid Input. Integers only.");
            }
        }

        int count = 0;
        int ones = 0;
        int twos = 0;
        int threes = 0;
        int fours = 0;
        int fives = 0;
        int sixes = 0;

        while (count < rolls)
        {
            int roll = dice.Next(1, 7);
            count++;
            switch (roll)
            {
                case 1:
                    ones++;
                    break;
                case 2:
                    twos++;
                    break;
                case 3:
                    threes++;
                    break;
                case 4:
                    fours++;
                    break;
                case 5:
                    fives++;
                    break;
                case 6:
                    sixes++;
                    break;

            }
        }
        Console.WriteLine($"\nRESULTS AFTER {count} ROLLS:");

        int[] results = { ones, twos, threes, fours, fives, sixes };
        int total = ones + twos + threes + fours + fives + sixes;

        for (int x = 0; x < results.Length; x++)
        {
            Console.WriteLine($"{x + 1} -- {results[x]} rolls");
        }

        Console.WriteLine("\nSUMMARY:");
        Console.WriteLine($"Total Rolls: {total}\n");
        Console.WriteLine($"Ones: {ones} ({(double)ones / total:P2})");
        Console.WriteLine($"Twos: {twos} ({(double)twos / total:P2})");
        Console.WriteLine($"Threes: {threes} ({(double)threes / total:P2})");
        Console.WriteLine($"Fours: {fours} ({(double)fours / total:P2})");
        Console.WriteLine($"Fives: {fives} ({(double)fives / total:P2})");
        Console.WriteLine($"Sixes: {sixes} ({(double)sixes / total:P2})");
        Console.WriteLine("");
    }
}
