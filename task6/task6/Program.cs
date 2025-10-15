namespace task6;
//Verilmiş massivdəki ədədlərin ədədi ortasını ekrana çap edən method yazın.

class Program
{
    static double Mean(int[] arr, int len)
    {
        float sum = 0;
        for (int i = 0; i < len; i++)
        {
            sum += (float)arr[i];
        }
        float mean = sum / len;
        return mean;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Arrayi Daxil Edin: ");
        int[] arr = new int[10];
        int arrLen = arr.Length;
        for (int i = 0; i < arrLen; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        double answer = Mean(arr, arrLen);
        Console.WriteLine("Cavab: " + answer);
    }
}