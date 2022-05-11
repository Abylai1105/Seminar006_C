//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.

int InputNumber(string name)
{
    Console.WriteLine($"Введите число {name} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = InputNumber ("A");
int b = InputNumber ("B");
int c = InputNumber ("C");

if (a<b+c && b<a+c && c<b+c)
{
    Console.WriteLine("Это треугольник");
}
else
{
    Console.WriteLine("Это не тругольник");
}