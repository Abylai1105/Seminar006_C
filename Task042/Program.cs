// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


int InputNumber(string chislo)
{
    Console.WriteLine($"Введите число {chislo} ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int a = InputNumber ("A");
string result = "" + a%2;
while (a >= 2)
{
    a = a / 2;
    int c = a%2;
   result = c + result;
}
Console.WriteLine(result);