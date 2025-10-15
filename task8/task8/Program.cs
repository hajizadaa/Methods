namespace task8;
//Calculator methodu yaradın, 3 parametr qəbul edir: number1, number2,
//operator (+, -, *, /). Operatora uyğun nəticəni qaytarsın.

class Program
{
    static float Calculator(float num1, float num2, char ope)
    {
        float answer = 0;
        switch (ope)
        {
            case '+':
                answer = num1 + num2;
                break;
            case '-':
                answer = num1 - num2;
                break;
            case '*':
                answer = num1 * num2;
                break;
            case '/':
                answer = num1 / num2;
                break;
        }

        return answer;
    }
    static void Main(string[] args)
    {
        Console.Write("Birinci Ededi Daxil Edin: ");
        float num1;
        bool isNum = float.TryParse(Console.ReadLine(), out num1);
        if (!isNum)
        {
            Console.WriteLine("Eded Daxil Edin!");
            return;
        }
        
        Console.Write("Operatoru Daxil Edin: ");
        char ope = char.Parse(Console.ReadLine());
        if ((ope == '+' || ope == '-' || ope == '*' || ope == '/') == false)
        {
            Console.WriteLine("Bele Bir Emel Yoxdur.");
            return;
        }
        
        Console.Write("İkinci Ededi Daxil Edin: ");
        float num2;
        isNum = float.TryParse(Console.ReadLine(), out num2);
        if (!isNum)
        {
            Console.WriteLine("Eded Daxil Edin!");
            return;
        }

        float answer = Calculator(num1, num2, ope);
        Console.WriteLine("Cavab: " + answer);
    }
}