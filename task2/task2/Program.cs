namespace task2;
//Fahrenheit ilə verilmiş dəyəri Celsius-a çevirən method yazın. Kəsr ədəd daxil etmək olsun.
class Program
{
    static float ToCelsius(float f)
    {
        return (f - 32f) / 1.8f;
    }
    
    static void Main(string[] args)
    {
        Console.Write("Fahrenheiti Derecesini Daxil Edin: ");
        float f = float.Parse(Console.ReadLine());
        float c = ToCelsius(f);
        Console.WriteLine("Celsius: " + c);
    }
}