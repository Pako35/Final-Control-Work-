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
    