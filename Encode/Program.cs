using Encode;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string to encode:");
        Console.WriteLine("Encoded string: " + EncodeStringTask.Encode(Console.ReadLine()));
    }
}