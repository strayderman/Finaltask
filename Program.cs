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
// Функция выполнения программы по первому способу
void Task1()
{
    string[] array1 = new string[7] {"123", "23", "hello", "world", "res","string", "get” };
    string[] array2 = new string[array1.Length];
    FindElements2Massive(array1, array2);
    PrintArray(array2);
}
    













//Task1();

