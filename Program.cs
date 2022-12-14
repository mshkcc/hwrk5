int[] array = new int[5];
int sum = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(10);

for (int i = 1; i < array.Length; i += 2)
    sum += array[i];

for (int i = 0; i < array.Length; i++)

    Console.Write($"{array[i]} ");

Console.Write($"Сумма: {sum}");