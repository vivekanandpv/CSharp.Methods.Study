namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            Sum(8, 9);  //  Sum(int,int) is proximal
            Sum(5.0, 6);    //  Sum(double,int)
        }

        //  So long as parameter type list is different methods can be overloaded
        //  Overloaded methods can have different return types
        //  Rule of proximal types
        //  Beware of call-ambiguity

        //  Sum(int,int)
        static int Sum(int x, int y) {
            return x + y;
        }

        //  Sum(double,double)
        static double Sum(double x, double y) {
            return x + y;
        }

        //  Sum(double,int)
        static double Sum(double x, int y) {
            return x + y;
        }

        //  Sum(int,double)
        static double Sum(int x, double y) {
            return x + y;
        }
    }
}