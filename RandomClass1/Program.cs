internal class Program
{
    /// <summary>
    /// Test drive with the Random class
    /// </summary>
    private static void Main(string[] args)
    {
        while (true)
        {
            Random random = new Random();
            int randomInt = random.Next();
            Console.WriteLine(randomInt);

            // random numbers from 0 < value
            int zeroToNine = random.Next(10);
            Console.WriteLine(zeroToNine);

            // can also specify min to simulate dice
            int dieRoll = random.Next(1, 7);
            Console.WriteLine(dieRoll);

            // double 0.0 - 1.0
            double randomDouble = random.NextDouble();
            // multiply to get larger doubles
            Console.WriteLine(randomDouble * 100);

            // casting to convert the double to other types
            Console.WriteLine((float)randomDouble * 100F);
            Console.WriteLine((decimal)randomDouble * 100M);

            // use Convert class to simulate coin toss
            int zeroOrOne = random.Next(2);
            bool coinFlip = Convert.ToBoolean(zeroOrOne);
            Console.WriteLine(coinFlip);

            Console.ReadLine();
        }
    }
}