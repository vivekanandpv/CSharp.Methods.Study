namespace CSharp.Methods.Study {
    internal class Program {
        static void Main(string[] args) {
            foreach (var el in GetInts()) {
                Console.WriteLine($"Element: {el}");
            }
        }

        //  yield is a contextual keyword
        //  yield return is a syntactical sugar over
        //  iterator design pattern implementation
        //  Using yield to define an iterator removes
        //  the need for an explicit extra class that holds
        //  the state for an enumeration

        //  method must be returning IEnumerable
        static IEnumerable<int> GetInts() {
            //  yield return or yield break are the only two uses
            //  cannot use return when yield is used

            //  control returns upon encountering yield break
            //  or reaching the end of the method
            yield return 9;
            yield return 10;
            yield return 11;
            yield break;    //  control returns here
            yield return 12;    //  unreachable
        }
    }
}