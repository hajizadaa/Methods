namespace task1;
//Verilən ədədin cüt olub olmadığını yoxlayan method yazın. Return type: bool.

class Program
{
    static bool IsEven(int num)
    {
        if (num % 2 == 0)
            return true;
        return false;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Ededi Daxil Edin: ");
        int n = int.Parse(Console.ReadLine());
        bool answer = IsEven(n);
        Console.WriteLine(answer);
    }
}