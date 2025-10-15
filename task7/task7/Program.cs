namespace task7;
//Verilmiş massivdəki sadə ədədləri ekrana çap edən method yazın.

class Program
{
    static void PrimeNumbers(int[] arr, int len)
    {
        bool isThere = false;
        int divisors = 0;
        Console.WriteLine("Cavab:");
        for (int i = 0; i <len; i++)
        {
            divisors = 0;
            for (int j = 1; j <= arr[i]; j++)
            {
                if (arr[i] % j == 0)
                {
                    divisors++;
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine(arr[i]);
                isThere = true;
            }
        }
        if (isThere == false)
            Console.WriteLine("Sade Eded Yoxdur");
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("Arrayi Daxil Edin: ");
        int[] arr = new int [10];
        int arrLen = arr.Length;
        for (int i = 0; i < arrLen; i++)
            arr[i] = int.Parse(Console.ReadLine());
        PrimeNumbers(arr, arrLen);
    }
}