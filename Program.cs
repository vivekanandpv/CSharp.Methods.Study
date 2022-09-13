namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            Foo(9, 8.65, 1, 2, 3, 4, 5);    //  1, 2, 3, 4, 5 are passed as varargs
        }

        //  C# supports variadic methods

        //  Rules:
        //  a method can take only one params
        //  params must be at the end
        //  params type should be an array
        //  params is optional
        //  default value for the parameter array is not allowed
        static void Foo(int x, double y, params int[] z) {
            Console.WriteLine($"int x = {x}");
            Console.WriteLine($"double y = {y}");

            foreach (var el in z) {
                Console.WriteLine($"Element in z -> {el}");
            }
        }
    }
}