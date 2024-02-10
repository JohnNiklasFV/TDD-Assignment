public class Brain
{
    public static void Main(string []args)
    {
        if (args[0] == "-t")
        {

        }
        else if (args[1] == "-mm")
        {
            double inputvalue = double.Parse(args[0]);
        }
        else if (args[1] == "-cm")
        {
            double inputvalue = double.Parse(args[0]);
        }
        else if (args[1] == "-m")
        {
            double inputvalue = double.Parse(args[0]);
        }
        else
        {
            Console.WriteLine("Error!");
            Environment.Exit(0);
        }
        
    }
}
