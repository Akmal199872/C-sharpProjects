void IntroTask(int number, string string_text)
{
    System.Console.WriteLine($"{string.Empty}\nЗадача №{number}\n{string.Empty}");
    System.Console.WriteLine(string_text);
    System.Console.WriteLine(string.Empty);
}
Random rnd = new Random();

int[] PrintArray(int[] array)
{
    System.Console.WriteLine("Массив: ");
    System.Console.WriteLine(string.Empty);
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
    System.Console.WriteLine(string.Empty);
    return array;
}

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 9);
    }
    return array;
}

int[] CreateArray(int number)
{
    int[] array = new int[number];
    return array;
}

IntroTask(1, "S3.1 Составить программу обмена значениями двух переменных величин.");

int ChangePlace()
{
    int FirstNumber = 10;
    int SecondNumber = 15;
    System.Console.WriteLine($"{FirstNumber} => {SecondNumber}");
    (FirstNumber, SecondNumber) = (SecondNumber, FirstNumber);
    System.Console.WriteLine($"{FirstNumber} <= {SecondNumber}");
    return SecondNumber;
}

ChangePlace();

IntroTask(2, "S3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по следующим двум схемам: а) b присвоить значение c, а присвоить значение b, с присвоить значение а; б) b присвоить значение а, с присвоить значение b, а присвоить значение с.");

int [] ChangePlaceThree()
{
    int [] array = FillArray(CreateArray(3));
    int a = array[0];
    int b = array[1];
    int c = array[2];
    PrintArray(array);
    int temp = b;
    b = c;
    c = a;
    a = temp;
    System.Console.WriteLine($"Решение А: a => {temp}, b => {b}, c => {c}");
    // a = c;
    // b = temp;
    // temp = a;
    // System.Console.WriteLine($"Решение Б: a => {temp}, b => {c}, c => {b}");
    return array;
}

ChangePlaceThree();

IntroTask(3, "S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:");

double PowNumber(int size)
{
    int number = rnd.Next(1,9);
    double result = 1;
    for (int i = 0; i < size; i++)
    {
        result *= number;
    }
    System.Console.WriteLine($"Возведение в степень {size} числа {number} = {result}");
    return result;
}

PowNumber(4);
PowNumber(6);
PowNumber(8);
PowNumber(9);
PowNumber(10);
PowNumber(7);

IntroTask(4, "S3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:");

double PowTwoNumber(int size)
{
    int FirstNumber = rnd.Next(1,9);
    int SecondNumber = rnd.Next(1,9);
    double result = 1;
    double result_2 = 1;
    for (int i = 0; i < size; i++)
    {
        result *= FirstNumber;
        result_2 *= SecondNumber;
    }

    System.Console.WriteLine($"Возведение в степень {size} числа {FirstNumber} = {result}.\n{SecondNumber} => {result_2}");
    return result;
}

PowTwoNumber(3);
PowTwoNumber(16);

IntroTask(5, "S3.5. Чему будет равно 10^10 по Вашему алгоритму?");

double PowNumberTen()
{
    int number = 10;
    double result = 1;
    for (int i = 0; i < 10; i++)
    {
        result *= number;
    }
    System.Console.WriteLine($"Возведение в степень 10 числа {number} = {result}");
    return result;
}

PowNumberTen();