internal class Program
{
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("talfil.txt");
        string line;
        int sum = 0;
        int evensum = 0;
        while ((line = sr.ReadLine()) != null )
        {
            int num = int.Parse(line);
            sum += num;
            if (num % 2 == 0){
                evensum += num;
            }
        }
        using (StreamWriter sw = new StreamWriter("output.txt")) {
        sw.WriteLine("Total sum: " + sum);
        sw.WriteLine("Sum of even numbers: " + evensum);
        }
    }
    
}