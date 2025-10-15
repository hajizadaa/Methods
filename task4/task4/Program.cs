namespace task4;
//Verilmiş ədədin faktorialını hesablayan method yazın.
class Program
{
    static int Fakt(int n)
    {
        if (n > 1)
            return n * Fakt(n - 1);
        return 1;
    }
    
    static void Main(string[] args)
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int fakt = Fakt(n);
        Console.WriteLine("n! = " + fakt);
    }
}