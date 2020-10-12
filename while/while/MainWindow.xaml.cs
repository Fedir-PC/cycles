using System;
class Program
{
    static void Main()
    {
        While24();
    }

    static void While4()
    {
        int N = 15;
        while (N >= 3 && N % 3 == 0)
            N = N / 3;
        if (N == 1)
            Console.Write("TRUE");
        else
            Console.Write("FALSE");
    }

    static void While8()
    {
        int N = 16, k = 0;
        while (Math.Pow(k, 2) <= N)
            k++;
        Console.Write(k - 1);
    }

    static void While12()
    {
        int N = 16, k = 0, sum = 0;
        while (sum <= N)
        {
            k++;
            sum = sum + k;
        }
        Console.WriteLine(k - 1);
        Console.WriteLine(sum - k);
    }

    static void While16()
    {
        int N = 10, K = 1, sum = 10, P = 10;
        while (sum <= 200)
        {
            K++;
            N = N + N / 100 * P;
            sum = sum + N;
        }
        Console.WriteLine(K - 1);
        Console.WriteLine(sum - N);
    }

    static void While20()
    {
        int N = 76527865, k = 0;
        while (N >= 10)
        {
            k = N % 10;
            if (k == 2)
            {
                Console.WriteLine("TRUE");
                break;
            }
            N = N / 10;
        }
        if (k == 2)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");
    }

    static void While24()
    {
        int N = 21, sum = 0, i = 1, j = 1, j1 = 0;
        while (i <= N)
        {
            i += j;
            j1 = j;
            j = i - j;
        }
        if (N == i - j1)
            Console.WriteLine("TRUE");
        else
            Console.WriteLine("FALSE");
    }

}