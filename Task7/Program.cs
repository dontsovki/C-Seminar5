// Программа, которая определяет, присутствует ли заданное число в массиве.

int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}
int[] CreateArray(){
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
        Console.WriteLine($"Введите {i+1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

bool checkNum (int [] array, int num) {
    bool finded = false;

    for (int i=0; i < array.Length; i++)
        if (array[i] == num)
            finded = true;

    return finded;
}

int [] Array = CreateArray();
ShowArray(Array);

Console.Write("Введите искомое число: ");
string stringNum = Console.ReadLine();
int intNum = Convert.ToInt32(stringNum);

bool finded = checkNum(Array, intNum);

if (finded == true) 
    Console.Write("Искомое число существует");
else
    Console.Write("Искомое число не существует");