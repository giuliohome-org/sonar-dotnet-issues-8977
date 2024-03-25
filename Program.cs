namespace Generated;
using GeneratedCode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GeneratedClass generator = new GeneratedClass();
        generator.CreatePackage("output.xlsx");
    }
}
