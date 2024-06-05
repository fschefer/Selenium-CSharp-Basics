namespace TupleExample
{
    class TupleExample
    {
        static void Main(string[] args)
        {
            // Create a tuple with three elements using the Tuple class
            Tuple<string, string, int> myTuple = new Tuple<string, string, int>("John", "Doe", 30);

            // Access the elements of the tuple
            Console.WriteLine($"First Name: {myTuple.Item1}");
            Console.WriteLine($"Last Name: {myTuple.Item2}");
            Console.WriteLine($"Age: {myTuple.Item3}");

            // Using a method that returns a tuple
            Tuple<string, int> result = GetPersonDetails();
            Console.WriteLine($"Name: {result.Item1}, Age: {result.Item2}");
        }

        static Tuple<string, int> GetPersonDetails()
        {
            string name = "Alice";
            int age = 28;

            // Return a tuple
            return new Tuple<string, int>(name, age);
        }
    }
}