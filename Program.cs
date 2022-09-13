namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            //  Parameters are passed by value by default
            int i = 9;
            Foo(i);
            Console.WriteLine(i);   //  still 9

            int[] scores = { 7, 8, 9 };
            Foo(scores);
            Console.WriteLine($"{scores[0]}, {scores[1]}, {scores[2]}");    //  scores is intact
        }

        static void Foo(int x) {
            ++x;    //  Foo gets its own copy of x
        }

        static void Foo(int[] ar) {
            //  ar is a reference copy of the argument passed
            //  If ar changes to a new value (null in this case),
            //  it doesn't affect the argument's binding with the object

            ar = null;  
        }
    }
}