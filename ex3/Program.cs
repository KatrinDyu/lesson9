/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
Console.Clear();
Console.WriteLine("Введи значение M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введи значение N");
int N = int.Parse(Console.ReadLine());
akk(M,N);

int akk(int m, int n)
{
    if (m == 0)
    {
     int res = n + 1;
    }
    else if (m >0 && n==0)
    {
       int res  = akk(m-1, 1);
    }
    else if (m>0 && n>0)
    {
       int res = akk(m-1, akk(m,n-1));
    }
    return res;

Console.WriteLine(res);
}

//попробовала сделать, но толком не поняла функцию Аккермана