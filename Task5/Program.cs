// Функция сбора в массиве положительных и отрицательных чисел
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
