int[] array = new int[3];
int n = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 1000);

for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0)
        n++;

for (int i = 0; i < array.Length; i++)

    Console.Write($"{array[i]} ");

Console.Write($"{n}");