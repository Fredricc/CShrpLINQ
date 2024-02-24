using System.Linq;

namespace C_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 44, 66, 45, 88};

            var query = 
                from n in numbers
                where n % 2 == 0
                select n;

            foreach ( var n in query )
            {
                Console.WriteLine( n );
            }

        }
    }
}