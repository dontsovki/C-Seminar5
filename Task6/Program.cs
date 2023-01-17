// программуа замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
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

int [] Arra = CreateRandomArray(4, -10, 10);

ShowArray(Arra);

for (int i=0; i < Arra.Length; i++){
    Arra[i] = Arra[i] * -1;
}

ShowArray(Arra);

