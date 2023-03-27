// Поиск элементов с длиной <=3 и записью во второй массив
void FindElements2Massive(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
// Метод выполнения программы по первому способу
void Task1()
{
    string[] array1 = new string[5] {"123", "23", "hello", "world", "res" };
    string[] array2 = new string[array1.Length];
    FindElements2Massive(array1, array2);
    PrintArray(array2);
}
    

// Метод проверки введенной строки длина <=3  и записи в массив
string[] FillStringArray(int n)
{
    string[] array = new string[n];
    Console.WriteLine("Введите слова");
    for (int i = 0; i < n; i++)
    {
        string M = Console.ReadLine()!;
         if(M.Length <= 3)
        {
            array[i] = M;
        }     
    }
return array;
}

// Метод вывода результата
void PrintArray(string[] array)
{
    Console.WriteLine("Элементы с длинной <=3: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");  
    }
    Console.WriteLine();
}
// Метод выполнения программы по второму способу
void Task2()
{
    Console.WriteLine("Введите количество элементов");
    int N = int.Parse(Console.ReadLine()!);
    string[] Result = FillStringArray(N);
    Console.WriteLine();
    PrintArray(Result);
}
Task2();

//Task1();

