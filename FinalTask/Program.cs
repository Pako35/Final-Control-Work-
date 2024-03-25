class Program
{
    static void Main(string[] args)
    {
        // Initial array of strings
        string[] initialArray = { "long", "one", "two", "short", "three", "longer", "another", "shorty" };

        // Call the FilterStrings method and pass the initial array
        string[] resultArray = FilterStrings(initialArray);

        // Print the new array to the console
        Console.WriteLine("Новый массив строк длиной <= 3 символов:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

