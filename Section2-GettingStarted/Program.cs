using System.Linq;

namespace C_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using LINQ");
            //Step 1: Getting the data source
            List<int> numbers = new List<int> { 1, 3, 44, 66, 45, 88};

            //Step 2: Writting query
            var query = 
                from n in numbers// Part 1: Data source
                where n % 2 == 0// Part 2: Filter
                select n; // Part 3: Select

            //Step 3: Executing query
            foreach ( var n in query )
            {
                Console.WriteLine( n );
            }

        }
    }
}