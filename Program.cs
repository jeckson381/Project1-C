string oper;
do
{
    Console.WriteLine("Введите тип операции \n1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");
    oper = Console.ReadLine();
    if (oper == "1")
    {
        Console.WriteLine("Введите первое число");
        string num1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string num2 = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(num1) + Convert.ToInt32(num2));
    }
    if (oper == "2")
    {
        Console.WriteLine("Введите первое число");
        string num1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string num2 = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(num1) - Convert.ToInt32(num2));
    }
    if (oper == "3")
    {
        Console.WriteLine("Введите первое число");
        string num1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string num2 = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(num1) * Convert.ToInt32(num2));
    }
    if (oper == "4")
    {
        Console.WriteLine("Введите первое число");
        string num1 = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        string num2 = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(num1) / Convert.ToInt32(num2));
    }
    if (oper == "5")
    {
        Console.WriteLine("Введите число");
        string num1 = Console.ReadLine();
        Console.WriteLine("Введите степень");
        string num2 = Console.ReadLine();
        Int32 num = Convert.ToInt32(num1);
        for (int i = 1; i < Convert.ToInt32(num2); i++)
        {
            num = num * Convert.ToInt32(num1);
        }
        Console.WriteLine(num);
    }
    if (oper == "6")
    {
        Console.WriteLine("Введите число");
        string num = Console.ReadLine();
        Console.WriteLine(Math.Sqrt(Convert.ToInt32(num)));
    }
    if (oper == "7")
    {
        Console.WriteLine("Введите число");
        string num = Console.ReadLine();
        Console.WriteLine(Convert.ToDouble(num)/100);
    }
    if (oper == "8")
    {
        Console.WriteLine("Введите число");
        string num1 = Console.ReadLine();
        Int32 num = Convert.ToInt32(num1);
        for (int i = 1; i < Convert.ToInt32(num1); i++)
        {
            num = num * i;
        }
        Console.WriteLine(num);
    }
} while (oper != "9");
