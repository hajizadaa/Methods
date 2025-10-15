namespace task5;

class Program
{
    static bool IsPrimeNumber(int n)
    {
        int divisor = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                divisor++;
            }
        }

        if (divisor == 2)
            return true;
        return false;

    }
    static void Main(string[] args)
    {
        Console.Write("Ededi Daxil Edin: ");
        int n = int.Parse(Console.ReadLine());
        bool answer = IsPrimeNumber(n);
        Console.WriteLine(answer);
    }
}