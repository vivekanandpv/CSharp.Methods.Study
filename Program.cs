namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            //  classical approach
            int a;
            double b;
            Foo(out a, out b, 7);   //  out parameters should be called with out

            //   Since C# 6.0
            Foo(out int i, out double d, 89);    // i and d are in scope from this point
        }

        //  In C#, it is possible to return multiple values using out parameters
        //  out parameters cannot have default values
        //  out cannot be used with keywords: params or ref or in
        static void Foo(out int x, out double y, int z) {
            //  All out parameters must be assigned before return
            x = 90;
            y = 3.1415926535 * z;
        }
    }
}