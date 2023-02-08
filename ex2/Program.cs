/* Задайте значения M и N. Напишите программу, которая найдёт
 сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120 */
Console.Clear();
Console.WriteLine("Введи значение M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введи значение N");
int N = int.Parse(Console.ReadLine());

int Summ(int n)
{
     if (n == 1) return 1;
    else return n + Summ(n - 1);
}
for (int i = M; i <= N; i++)

    Console.WriteLine(Summ(i));
