// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
int [] Fibonacci = new int [length];
Fibonacci[0] = 0;
Fibonacci[1] = 1;
for (int i = 2; i < length; i++)
{
    Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
}
WriteArray(Fibonacci);

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(array);
}