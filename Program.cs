namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            //  named parameters can be defined in an arbitrary order
            Sum(y: 8, x: 7);

            //  avoid mixing positional and named parameters
            //  Sum(y: 9, 12);  //  Illegal
            
            Sum(8, y: 56);  //  Legal, but confusing
            Sum(x: 9, 78);  //  Legal, but confusing
        }

        //  The optional parameters must come after the required parameters
        static int Sum(int x, int y) {
            return x + y;
        }
    }
}