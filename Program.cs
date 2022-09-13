namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            //  You may need to import the source of PrintString
            "Hello, world".PrintString();
        }

        
    }

    //  Extension methods lets you add additional methods
    //  without modifying the existing type

    //  An extension method is a static method in a static class
    //  The first argument should be this <type>

    //  LINQ, EF, etc use extension methods a lot
    static class StringExtensions {
        public static void PrintString(this string s) {
            Console.WriteLine($"Print String: {s}");
        }
    }
}