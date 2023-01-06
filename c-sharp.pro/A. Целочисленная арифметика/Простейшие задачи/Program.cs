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
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
    System.Console.WriteLine(string.Empty);
    return array;
}

int [] FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=rnd.Next(1, 9);
    }
    return array;
}

int [] CreateArray(int number)
{
    int [] array = new int[number];
    return array;
}

IntroTask(1, "A1.1. Дано расстояние в сантиметрах. Найти число полных метров в нем.");

int SantimToMeters(int number)
{
    System.Console.WriteLine($"{number} сантиметров = {(double)number/100.0} метра");
    return number;
}

SantimToMeters(363);

IntroTask(2, "Дана масса в килограммах. Найти число полных центнеров в ней");

int KilogToCentn(int number)
{
    System.Console.WriteLine($"{number} килограмм = {(double)number/100.0} центнера");
    return number;
}

KilogToCentn(30);

IntroTask(3, "Дана масса в килограммах. Найти число полных тонн в ней");

int KilogToTons(int number)
{
    System.Console.WriteLine($"{number} килограмм = {(double)number/1000.0} тонн");
    return number;
}

KilogToTons(344);

IntroTask(4, "Дано расстояние в метрах. Найти число полных километров в нем");

int MeterToKiloms(int number)
{
    System.Console.WriteLine($"{number} метров = {(double)number/1000.0} километров");
    return number;
}

MeterToKiloms(350);

IntroTask(5, "С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?");

int CalcDays(int number)
{
    System.Console.WriteLine($"{number} дней = {number/7} недель");
    return number;
}

CalcDays(234);

IntroTask(6, "A1.6. С начала суток прошло n секунд. Определить:\nа) сколько полных часов прошло с начала суток;\nб) сколько полных минут прошло с начала очередного часа;\nв) сколько полных секунд прошло с начала очередной минуты.");

int CalcTime(int number)
{
    System.Console.WriteLine($"Дано: {number} секунд.\n");
    System.Console.WriteLine($"a) {number} секунд = прошло {Math.Round((double)number/(60*60), 2)} полных часов с начала суток");
    System.Console.WriteLine($"б) {number} секунд = прошло {Math.Round((double)(number%(60))/60, 2)} полных минут с начала очередного часа");
    System.Console.WriteLine($"в) {number} секунд = прошло {Math.Round((double)number%(60), 2)} полных секунд с начала очередной минуты");
    return number;
}

CalcTime(3620);

IntroTask(7, "A1.7. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него?");

int CalcNumOfSquares(int number, int number2)
{
    System.Console.WriteLine($"AB = {number2}, AD = {number}.");
    System.Console.WriteLine($"Из этого прямоугольника, отрезав по {number2} мм, можно сформировать {number/number2} квадрата.");
    return number2;
}

CalcNumOfSquares(543, 130);

IntroTask(8, "A1.8. Дано целое число k (1 <= k <= 365). Присвоить целочисленной величине n значение 1, 2, ..., 6 или 0 в зависимости от того, на какой день недели (понедельник, вторник, ..., субботу или воскресенье) приходится k-й день года, в котором 1 января:\nа) понедельник;\nб) вторник;\nв) d-й день недели (если 1 января — понедельник, то d=1, если вторник — d=2, ..., если воскресенье — d=7).");

int DefineWeekDay(int number)
{
    int WeekDay(int number_day)
    {
        switch (number_day)
        {
            case 1: System.Console.WriteLine("Понедельник");break;
            case 2: System.Console.WriteLine("Вторник");break;
            case 3: System.Console.WriteLine("Среда");break;
            case 4: System.Console.WriteLine("Четверг");break;
            case 5: System.Console.WriteLine("Пятница");break;
            case 6: System.Console.WriteLine("Суббота");break;
            case 7: System.Console.WriteLine("Воскресенье");break;
        }
        return number_day;
    }

    System.Console.WriteLine($"В году прошло {number} дней.");
    System.Console.WriteLine($"а) Если 1 января - понедельник => {number} день в году - {WeekDay(number <= 7 ? number : number%7)}");
    System.Console.WriteLine($"б) Если 1 января - вторник => {number} день в году - {WeekDay(number+1 <= 7 ? number+1 : (number%7)+1)}");
    System.Console.WriteLine($"в) Если 1 января - среда => {number} день в году - {WeekDay(number+2 <= 7 ? number+2 : (number%7)+2)}");
    return 0;
}

DefineWeekDay(7);

IntroTask(9, "A1.9. С начала 2020 года по некоторый день прошло n месяцев и 2 дня. Присвоить целочисленной величине x значение 1, 2, ..., 11 или 12 в зависимости от того, каким месяцем (январем, февралем и т.п.) является месяц этого дня. Например, при n=3 значение х равно 4.");

int DefineMonth(int number)
{
    System.Console.WriteLine($"В году прошло {number} дней. Это {(number/30)+1} номер месяца.");
    return number;
}

DefineMonth(95);