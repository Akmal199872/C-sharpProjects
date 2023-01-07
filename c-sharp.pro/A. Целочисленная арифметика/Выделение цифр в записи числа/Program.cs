void IntroTask(int number, string string_text)
{
    System.Console.WriteLine($"{string.Empty}\nЗадача №{number}\n{string.Empty}");
    System.Console.WriteLine(string_text);
    System.Console.WriteLine(string.Empty);
}

Random rnd = new Random();

int [] PrintArray(int[] array)
{
    System.Console.WriteLine("Массив: ");
    System.Console.WriteLine(string.Empty);
    System.Console.WriteLine(string.Join(", ", array));
    System.Console.WriteLine(string.Empty);
    return array;
}

int [] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 9);       
    }
    return array;
}

int [] CreateArray(int number)
{
    int[] array = new int[number];
    return array; 
}

IntroTask(1, "A2.1. Дано двузначное число. Найти:\nа) число десятков в нем;\nб) число единиц в нем;\nв) сумму его цифр;\nг) произведение его цифр.");

int AnyDigitNum(int number)
{
    System.Console.WriteLine($"а) {number} => {number/10} десятков в нём");
    System.Console.WriteLine($"б) {number} => содержит {Convert.ToString(number).Split().Sum(s => s.Count(ch => ch == '1'))} единиц.");
    int [] number2 = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    System.Console.WriteLine($"в) {number} => сумма цифр составляет {number2.Aggregate(0, (interim, next) => interim + next)}");
    System.Console.WriteLine($"в) {number} => произведение цифр составляет {number2.Aggregate(1, (interim, next) => interim * next)}");
    return number;
}

AnyDigitNum(1618);

IntroTask(2, "A2.2. Дано двузначное число. Получить число, образованное при перестановке цифр заданного числа.");

int ReverseNum(int number)
{
    int [] number2 = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    System.Console.WriteLine($"{number} если перевернуть =>");
    Array.Reverse(number2);
    PrintArray(number2);
    return number;
}

ReverseNum(79);

IntroTask(3, "A2.3. Дано трехзначное число. Найти:\nа) число десятков в нем;\nб) число единиц в нем;\nв) сумму его цифр;\nг) произведение его цифр");

AnyDigitNum(171);

IntroTask(4, "A2.4. Дано трехзначное число. Найти число, полученное при прочтении его цифр справа налево.");

ReverseNum(789);

IntroTask(5, "A2.5. Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.");

int SpecReverseNum(int number)
{
    int [] number2 = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    System.Console.WriteLine($"{number} если перевернуть =>");
    int temp = number2[0];
    for (int i = 1; i < number2.Length; i++)
    {
        number2[i - 1] = number2[i];
    }
    number2[number2.Length - 1] = temp;
    PrintArray(number2);
    return number;
}

SpecReverseNum(678);

IntroTask(6, "A2.6. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали ее в начале. Найти полученное число.");

int SpecReverseNum2(int number)
{
    int [] number2 = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    System.Console.WriteLine($"{number} если перевернуть =>");
    int temp = number2[number2.Length - 1];
    for (int i = number2.Length - 1; i > 0; i--)
    {
        number2[i] = number2[i - 1];
    }
    number2[0] = temp;
    PrintArray(number2);
    return number;
}
SpecReverseNum2(789);

IntroTask(7, "A2.7. Дано трехзначное число. Найти число, полученное при перестановке первой и второй цифр заданного числа.");

int SpecReverseNum3(int number, int index, int length)
{
    int[] number2 = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    System.Console.WriteLine($"{number} если поменять местами цифры =>");
    Array.Reverse(number2, index, length);
    PrintArray(number2);
    return number;
}

SpecReverseNum3(567, 0, 2);

IntroTask(8, "A2.8. Дано трехзначное число. Найти число, полученное при перестановке второй и третьей цифр заданного числа.");

SpecReverseNum3(567, 1, 2);

IntroTask(9, "A2.9. Дано трехзначное число, в котором все цифры различны. Получить шесть чисел, образованных при перестановке цифр заданного числа.");

int JoinNums(int number)
{
    int[] number2 = number.ToString().Select(e => int.Parse(e.ToString())).ToArray();
    int[] number3 = new int [number2.Length];
    Array.Copy(number2, number3, number2.Length);
    System.Console.WriteLine($"{number} если поменять местами первую и вторую цифру =>");
    Array.Reverse(number2, 0, 2);
    PrintArray(number2);
    System.Console.WriteLine("Так будет выглядеть объединение:\n");
    PrintArray(number3.Concat(number2).ToArray());
    return number;
}

JoinNums(358);

IntroTask(10, "A2.10. Дано четырехзначное число. Найти:\nа) число десятков в нем;\nб) число единиц в нем;\nв) сумму его цифр;\nг) произведение его цифр");

AnyDigitNum(1788);

IntroTask(11, "A2.11. Дано четырехзначное число. Найти:\nа) число, полученное при прочтении его цифр справа налево;\nб) число, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;\nв) число, образуемое при перестановке второй и третьей цифр заданного числа. Например, из числа 5084 получить 5804;\nг) число, образуемое при перестановке двух первых и двух последних цифр заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.\nПоследнюю задачу решить двумя способами:\n1) с выделением отдельных цифр заданного числа;\n2) без выделения отдельных цифр заданного числа.");

