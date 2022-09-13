namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            var complexNumber = new ComplexNumber { Real = 9, Imaginary = 7};

            Foo(complexNumber);    //  
        }

        //  Introduced in C# 7.2, in parameters are readonly-references
        //  Useful dealing with heavy-weight structs
        //  in parameter is a reference, so the copy is not made
        //  and in parameter is readonly
        static void Foo(in ComplexNumber cn) {
            //  in parameters cannot be assigned
            //  but mutation is allowed

            //  cn = new ComplexNumber { Real = 3, Imaginary = 5 }; //  illegal

            Console.WriteLine(cn);
        }
    }

    struct ComplexNumber {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public override string ToString() {
            return $"Real = {Real}; Imaginary = {Imaginary}";
        }
    }
}