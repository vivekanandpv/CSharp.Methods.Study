namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            Sum(14);    //  x -> 14 and y -> 0 (default)
            Sum(12, 15);    //  x -> 12 and y -> 15
            Sum(y: 8);  //  x -> 0 and y -> 8 (using named parameter)
        }

        //  The optional parameters must come after the required parameters
        static int Sum(int x = 0, int y = 0) {
            return x + y;
        }
    }
}