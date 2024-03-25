class Program
{
    static string[] FilterStrings(string[] inputArray)
    {
        // Подсчитываем количество строк длиной <= 3 символов
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужной длины
        string[] outputArray = new string[count];
        int index = 0;

        // Заполняем новый массив строками длиной <= 3 символов
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                outputArray[index] = str;
                index++;
            }
        }

        return outputArray;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        string[] resultArray = FilterStrings(inputArray);

        Console.WriteLine("Новый массив строк длиной <= 3 символов:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    }
}
