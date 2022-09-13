namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            //  C# supports the pass by reference mode
            int i = 9;
            Foo(ref i); //  the caller should pass the argument with ref
            Console.WriteLine(i);   //  10

            int[] scores = { 7, 8, 9 };
            Foo(ref scores);
            Console.WriteLine(scores == null);    //  True as scores is null now
        }

        //  The method must declare the parameter as ref
        static void Foo(ref int x) {
            //  x is the same reference to the argument
            //  below action changes the argument!
            ++x;
        }

        static void Foo(ref int[] ar) {
            //  ar is the same reference to the argument passed
            //  below action changes the argument!

            ar = null;
        }
    }
}