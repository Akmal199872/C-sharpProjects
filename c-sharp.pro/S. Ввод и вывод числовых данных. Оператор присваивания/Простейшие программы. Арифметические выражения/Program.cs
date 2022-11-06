void IntroTask(int number, string string_text)
{
    System.Console.WriteLine($"{string.Empty}\nЗадача №{number}\n{string.Empty}");
    System.Console.WriteLine(string_text);
    System.Console.WriteLine(string.Empty);
}
Random rnd = new Random();

void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

IntroTask(1, "S1.1. Вывести на экран число с точностью до сотых.");

double One_Hundredth()
{
    double number = Math.Round(rnd.NextDouble(), 2);
    System.Console.WriteLine(number);
    return number;
}

One_Hundredth();




IntroTask(2, "S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.");

double LogarithmBasement()
{
    double result = Math.Round(Math.Exp(rnd.NextDouble()), 1);
    System.Console.WriteLine(result);
    return result;
}

LogarithmBasement();




IntroTask(3, "S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».");

int RandomNumbers()
{
    int number = 0;
    int i = 0;
    bool issuccess = false;
    while (issuccess == false)
    {
        System.Console.Write("Введите любое число: ");
        string StringInputNumbers = Console.ReadLine();
        if (int.TryParse(StringInputNumbers, out number))
        {
            System.Console.WriteLine($"Вы ввели число: {number}");
            i++;
            if (i > 2)
            {
                issuccess = true;
            }
        }
        else
        {
            System.Console.WriteLine("Введите число заново.");
            issuccess = false;
        }
    }
    return number;
}

RandomNumbers();




IntroTask(4, "S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».");

int RandomNumbers_2()
{
    int number = 0;
    bool issuccess = false;
    while (issuccess == false)
    {
        System.Console.WriteLine("Введите любое число: ");
        string StringInputNumbers = Console.ReadLine();
        if (int.TryParse(StringInputNumbers, out number))
        {
            System.Console.WriteLine($"Вот какое число Вы ввели: {number}");
            issuccess = true;
        }
        else
        {
            System.Console.WriteLine("Введите число заново.");
            issuccess = false;
        }
    }
    return number;
}




RandomNumbers_2();

IntroTask(5, "S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.");




string OneString(string text)
{
    System.Console.WriteLine(text);
    return text;
}

OneString("1 13 49");





IntroTask(6, "S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.");

OneString("7  15  100");




IntroTask(7, "S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.");

int NumbersInOneString()
{
    int number = 0;
    int i = 0;
    int [] string_array = new int [1];
    int size = string_array.Length;
    bool issuccess = false;

    while (issuccess == false)
    {
        System.Console.Write("Введите любое число: ");
        string StringInputNumbers = Console.ReadLine();
        if (int.TryParse(StringInputNumbers, out number))
        {
            System.Console.WriteLine($"Вот какое число Вы ввели: {number}");
            i++;
            if (i > 2)
            {
                issuccess = true;   
            }
            Array.Resize(ref string_array, size++);
            string_array[size - 2] = number;
        }
        else
        {
            System.Console.WriteLine("Введите число заново.");
            issuccess = false;
        }
    }

    for (int j = 0; j < string_array.Length; j++)
    {
        System.Console.Write($"{string_array[j]}  ");
    }
    return number;
}

NumbersInOneString();




IntroTask(8, "S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.");

int NumbersInOneString_2()
{
    int number = 0;
    int i = 0;
    int [] string_array = new int [1];
    int size = string_array.Length;
    bool issuccess = false;

    while (issuccess == false)
    {
        System.Console.Write("Введите любое число: ");
        string StringInputNumbers = Console.ReadLine();
        if (int.TryParse(StringInputNumbers, out number))
        {
            System.Console.WriteLine($"Вот какое число Вы ввели: {number}");
            i++;
            if (i > 3)
            {
                issuccess = true;   
            }
            Array.Resize(ref string_array, size++);
            string_array[size - 2] = number;
        }
        else
        {
            System.Console.WriteLine("Введите число заново.");
            issuccess = false;
        }
    }

    for (int j = 0; j < string_array.Length; j++)
    {
        System.Console.Write($"{string_array[j]} ");
    }
    return number;
}

NumbersInOneString_2();





IntroTask(9, "S1.9. Вывести на экран числа 50 и 10 одно под другим.");

int [] UnderNumber(params int [] array)
{
    PrintArray(array);
    return array;
}

UnderNumber(50, 10);




IntroTask(10, "S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.");

UnderNumber(5, 10, 21);




IntroTask(11, "S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.");

int NumbersInOneColumn()
{
    int number = 0;
    int i = 0;
    int [] string_array = new int [1];
    int size = string_array.Length;

    while (i < 4)
    {
        number = rnd.Next(1,99);
        Array.Resize(ref string_array, size++);
        string_array[size - 2] = number;
        i++;
    }
    UnderNumber(string_array);
    return number;
}

NumbersInOneColumn();





IntroTask(12, "Составить программу вывода на экран следующей информации:");

System.Console.WriteLine("5 10");
System.Console.WriteLine("7 см");






IntroTask(12, "Составить программу вывода на экран следующей информации:");

System.Console.WriteLine("2 кг");
System.Console.WriteLine("13 17");