namespace LINQ_MethodSyntax;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Using LINQ : Method syntax type.");
        //Step 1: Creat the data source
        List<int> numberList = new List<int> { 1,2,3,4,5,6,7,8 };

        //Step 2: Creat the query
        var query = from n in numberList
                    where n > 3
                    select n;

        //Step 3: Execute query
        foreach (var n in numberList)
        {
            Console.WriteLine(n);
        }

    }
}
