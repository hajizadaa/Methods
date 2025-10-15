namespace task3;
//Verilmiş ədədin bütün bölənlərini array-a yığıb return edən method yazın.
class Program
{
    static int[] Divisors(int n)
    {
        int[] arr = new int [40];
        int k = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                arr[k] = i;
                k++;
            }
        }

        arr[k] = n;
        k++;
        Array.Resize(ref arr, k);
        return arr;
    }
    static void Main(string[] args)
    {
        Console.Write("Ededi Daxil Edin: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = Divisors(n);

        Console.WriteLine("Cavab: ");
        foreach (int element in arr)
        {
            Console.WriteLine(element);
        }
    }
}