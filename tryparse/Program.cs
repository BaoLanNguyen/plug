internal class Program
{
    private static void Main(string[] args)
    {
        string input = "42";
        int number;

        if (int.TryParse(input, out number))
            {
                Console.WriteLine("Parsed successfully: " + number);
            }   
        else
            {
                Console.WriteLine("Could not parse input");
            }
        try
        {
            int x = 42;
            int y = 0;
            Console.WriteLine(x/y);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Can't divide with 0");
        }
    }
}