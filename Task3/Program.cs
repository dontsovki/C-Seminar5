// Функция вывода элемента массива на экран (применяется только с имеющимся, обработаным массивом)
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

