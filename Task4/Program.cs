// функция заполненния массива из 12 случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
//void ShowArray(int[] Array)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.Write(array[i] + " ");
//    }
//    Console.WriteLine();
//}

//int[] myArray = CreateArray(12,-9,9);
//ShowArray(Array);

int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

//int[] CreateArray(){
//    Console.WriteLine("Введите количество элементов массива");
//    int size = Convert.ToInt32(Console.ReadLine());
//    int[] array = new int[size];
//    for (int i = 0; i < size; i++)
//    {   
//        Console.WriteLine($"Введите {i+1} элемент массива");
//        array[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    return array;
//}

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int [] Array = CreateRandomArray(12, -9, 9);
ShowArray(Array);

int negative = 0;
int positive = 0;

for (int i=0; i < Array.Length; i++){
    if (Array[i] > 0) positive += Array[i];
    if (Array[i] < 0) negative += Array[i];
}

Console.WriteLine($"Сумма отрицательных {negative}");
Console.WriteLine($"Сумма положительных {positive}");
