// Задача 45: Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.


Console.WriteLine("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
int [] Fibonacci = new int [length];

FillArray(Fibonacci);
WriteArray(Fibonacci);

int [] newArray = new int [length];

for (int i = 0; i < length; i++)
{
    newArray [i] = Fibonacci [i];
}
Console.WriteLine("Копия массива: ");
WriteArray(newArray);

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}
void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(array);
}