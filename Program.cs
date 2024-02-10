public class Brain
{
    public static void Main(string []args)
    {
        if (args[0] == "-t")
        {
            //link to test file
        }
        else if (args[1] == "-mm")
        {
            double inputvalue = double.Parse(args[0]); //link to converter file
        }
        else if (args[1] == "-cm")
        {
            double inputvalue = double.Parse(args[0]); //link to converter file
        }
        else if (args[1] == "-m")
        {
            double inputvalue = double.Parse(args[0]); //link to converter file
        }
        else
        {
            Console.WriteLine("Error!");
            Environment.Exit(0);
        }
        
    }
}
