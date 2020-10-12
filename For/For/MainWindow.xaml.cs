using System;
class Program
{
    static void Main()
    {
        For24();
    }

    static void For4()
    {
        int cena = 3, i = cena;
        for (int x = 1; x <= 10; x++)
        {
            Console.WriteLine(cena);
            cena += i;
        }
    }

    static void For8()
    {
        int A = 3, B = 18, P = 1;
        for (int i = A; i <= B; i++)
            P *= i;
        Console.WriteLine(P);
    }

    static void For12()
    {
        int N = 8;
        double P = 1, x = 1;
        for (int i = 1; i <= N; i++)
        {
            x = x + 0.1;
            P = P * x;
        }
        Console.WriteLine(P);
    }

    static void For16()
    {
        int A = 3, N = 14;
        for (int i = 1; i <= N; i++)
        {
            Console.WriteLine(Math.Pow(A, i));
        }
    }

    static void For20()
    {
        int N = 7, x = 0, fact = 1;
        for (int i = 1; i <= N; i++)
        {
            for (int u = 1; u <= i; u++)
                fact = fact * u;
            x = x + fact;
            fact = 1;
        }
        Console.WriteLine(x);
    }

    static void For24()
    {
        int n = 3, z = 1;
        double x = 5, x1 = 1, fact = 1, sum = 1;
        for (int i = 1; i <= 2 * n; ++i)
        {
            fact *= i;
            if (i % 2 == 0)
            {
                x1 = x * x1;
                z = (-z);
                sum += z * ((x1 * x1) / fact);
            }
        }
        Console.WriteLine(sum);
    }
}