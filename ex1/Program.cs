/* Задайте значение N. Напишите программу, которая выведет все натуральные 
числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1" */
Console.Clear();
Console.WriteLine("Введи значение N");
int N = int.Parse(Console.ReadLine());
PrintNumbers(1, N);


void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start + 1, end);
}
