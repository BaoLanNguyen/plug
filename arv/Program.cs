internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Give me width:");
        double Width = double.Parse(Console.ReadLine());
        Console.WriteLine("Give me height:");
        double Height = double.Parse(Console.ReadLine());
        Console.WriteLine("Is it a triangle or a rectangle");
        string input = Console.ReadLine();
        if (input == "triangle")
        {
            Triangle t = new Triangle(Width, Height);
            Console.WriteLine(t.Area());
        }
        else if (input == "rectangle"){
            Rectangle r = new Rectangle(Width, Height);
            Console.WriteLine(r.Area());
        }
        else{
            Console.WriteLine("Wrong input");
        }
    }
}