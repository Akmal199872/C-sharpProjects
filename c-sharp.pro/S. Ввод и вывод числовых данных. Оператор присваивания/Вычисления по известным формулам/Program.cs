void IntroTask(int number, string string_text)
{
    System.Console.WriteLine($"{string.Empty}\nЗадача №{number}\n{string.Empty}");
    System.Console.WriteLine(string_text);
    System.Console.WriteLine(string.Empty);
}
Random rnd = new Random();

int[] PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
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

IntroTask(1, "S2.1. Составить программу: а) вычисления значения функции y=7x^2+3x+6 при любом значении x; б) вычисления значения функции x=12a^2+7a+12 при любом значении а");

double FunctionA()
{
    int[] array = FillArray(CreateArray(5));
    // PrintArray(array);
    double y = 0;
    for (int x = 0; x < array.Length; x++)
    {
        y = 7 * (Math.Pow(array[x], 2)) + (3 * array[x]) + 6;
        System.Console.WriteLine($"y = {y} при x = {array[x]}");
    }
    return y;
}

System.Console.WriteLine("Задача А");
System.Console.WriteLine(string.Empty);

FunctionA();

System.Console.WriteLine(string.Empty);

System.Console.WriteLine(string.Empty);
System.Console.WriteLine("Задача Б");
System.Console.WriteLine(String.Empty);

double FunctionB()
{
    int[] array = FillArray(CreateArray(5));
    // PrintArray(array);
    double x = 0;
    for (int a = 0; a < array.Length; a++)
    {
        x = 12 * (Math.Pow(array[a], 2)) + (7 * array[a]) + 12;
        System.Console.WriteLine($"y = {x} при x = {array[a]}");
    }
    return x;
}

FunctionB();

IntroTask(2, "S2.2. Дана сторона квадрата. Найти его периметр.");

int FindPerimeter()
{
    int number = rnd.Next(1, 9);
    int ResultPerimeter = 4 * number;
    System.Console.WriteLine($"Сторона а = {number}. Периметр = {ResultPerimeter}");
    return ResultPerimeter;
}

FindPerimeter();

IntroTask(3, "S2.3. Дан радиус окружности. Найти ее диаметр.");

int RadRound()
{
    int radius = rnd.Next(1, 9);
    int diameter = 2 * radius;
    System.Console.WriteLine($"Диаметр = {diameter} при радиусе = {radius}");
    return diameter;
}

RadRound();

IntroTask(4, "S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей");

double FindPathToHorizont()
{
    double a = 6350; // Радиус АО
    double b = 0; // Расстояние до горизонта BG
    double c = rnd.NextDouble() * 100 + a; // Высота АВ
    b = (Math.Pow(c, 2)) - Math.Pow(a, 2);
    double result = Math.Sqrt(b);
    System.Console.WriteLine($"Расстояние BG = {Math.Round(result, 0)} при высоте h = {Math.Round((c - a), 0)}");
    return b;
}

FindPathToHorizont();

IntroTask(5, "S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности.");

double FindVolumeAndSquare()
{
    int a = rnd.Next(1,9);
    double b = Convert.ToDouble(a);
    double CubeVolume = Math.Pow(b, 3);
    double SquareSide = (4 * (Math.Pow(b, 2)));
    System.Console.WriteLine($"Объём куба = {CubeVolume}. Площадь боковой поверхности = {SquareSide} при ребре = {b}");
    return 0;
}

FindVolumeAndSquare();

IntroTask(6, "S2.6. Дан радиус окружности. Найти длину окружности и площадь круга.");

double FindLengthAndRoundSquare()
{
    double radius = Math.Round((rnd.NextDouble() * 10), 0);
    double RoundLength = 2 * radius * Math.PI;
    double SquareRound = Math.PI * Math.Pow(radius, 2);
    System.Console.WriteLine($"Длина окружности = {Math.Round(RoundLength, 2)}. Площадь круга = {Math.Round(SquareRound, 2)} при радиусе = {radius}");

    return 0;
}

FindLengthAndRoundSquare();

IntroTask(7, " S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.");

int [] CalcArithmeticAndGeometric()
{
    int [] array = FillArray(CreateArray(2));
    PrintArray(array);
    double resultArithmetic = 0;
    double resultGeometric = 1;
    for (int i = 0; i < array.Length; i++)
    {
        resultArithmetic += array[i];
        resultGeometric *= array[i];
    }
    resultArithmetic = resultArithmetic/array.Length;
    resultGeometric = Math.Sqrt(resultGeometric);

    System.Console.WriteLine($"Среднее арифметическое = {Math.Round(resultArithmetic, 1)}. Среднее геометрическое = {Math.Round(resultGeometric,1)}");
    return array;
}

CalcArithmeticAndGeometric();

IntroTask(8, "S2.8. Известны объем и масса тела. Определить плотность материала этого тела.");

double MaterialDensity()
{
    double MassBody = rnd.NextDouble() * 10;
    double VolumeBody = rnd.NextDouble() * 10;
    double Density = MassBody / VolumeBody;
    System.Console.WriteLine($"Плотность = {Math.Round(Density, 1)} при объёме = {Math.Round(VolumeBody,1)} и массе = {Math.Round(MassBody,1)}");
    return Density;
}

MaterialDensity();

IntroTask(9, "S2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.");

double CountCitizens()
{
    double people = rnd.NextDouble() * 1000;
    double territory = rnd.NextDouble() * 10000;
    double density = people / territory;
    System.Console.WriteLine($"Количество жителей = {Math.Round(people, 0)}. Длина территории = {Math.Round(territory, 2)}. Плотность населения = {Math.Round(density, 2)}");
    return density;
}

CountCitizens();

IntroTask(10, "S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).");

double CalculateEquation()
{
    double number_a = rnd.NextDouble() * 10;
    double number_b = rnd.NextDouble() * 10;
    double x = 0;
    x = (-number_b) / number_a;
    System.Console.WriteLine($"x = {Math.Round(x, 1)}. a = {Math.Round(number_a, 1)}, b = {Math.Round(number_b, 1)}");
    return x;
}

CalculateEquation();

IntroTask(11, "S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.");

double TriangleHypotenuse()
{
    double cathet_1 = rnd.NextDouble() * 10;
    double cathet_2 = rnd.NextDouble() * 10;
    double hypotenuse = Math.Sqrt((Math.Pow(cathet_1, 2) + Math.Pow(cathet_2, 2)));
    System.Console.WriteLine($"Гипотенуза = {Math.Round(hypotenuse,0)}. Катет 1 = {Math.Round(cathet_1,1)}, Катет 2 = {Math.Round(cathet_2, 1)}");
    return hypotenuse;
}

TriangleHypotenuse();

IntroTask(12, "S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.");

double FindSquareRing()
{
    double InternalRadius = rnd.NextDouble() * 10;
    double ExternalRadius = rnd.NextDouble() * 10;
    double SquareRing = Math.PI * (Math.Pow(ExternalRadius, 2) - Math.Pow(InternalRadius, 2));
    System.Console.WriteLine($"Площадь кольца = {Math.Round(SquareRing, 1)} при внешнем радиусе кольца = {Math.Round(ExternalRadius, 0)} и внутреннем = {Math.Round(InternalRadius, 0)}");
    return SquareRing;
}

FindSquareRing();

IntroTask(13, "S2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.");

double TrianglePerimeter()
{
    double cathet_1 = rnd.NextDouble() * 10;
    double cathet_2 = rnd.NextDouble() * 10;
    double hypotenuse = Math.Sqrt((Math.Pow(cathet_1, 2) + Math.Pow(cathet_2, 2)));
    System.Console.WriteLine($"Гипотенуза = {Math.Round(hypotenuse,0)}. Катет 1 = {Math.Round(cathet_1,1)}, Катет 2 = {Math.Round(cathet_2, 1)}");
    double perimeter = cathet_1 + cathet_2 + hypotenuse;
    System.Console.WriteLine($"Периметр треугольника = {Math.Round(perimeter, 1)}");
    return perimeter;
}

TrianglePerimeter();

IntroTask(13, "S2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.");

int [] CalcArithmeticAndGeometricModules()
{
    int [] array = FillArray(CreateArray(2));
    PrintArray(array);
    double resultArithmetic = 0;
    double resultGeometric = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        resultArithmetic += array[i];
        resultGeometric *= array[i];
    }
    resultArithmetic = Math.Abs(resultArithmetic/array.Length);
    resultGeometric = Math.Abs(Math.Sqrt(resultGeometric));

    System.Console.WriteLine($"Среднее арифметическое = {Math.Round(resultArithmetic, 1)}. Среднее геометрическое = {Math.Round(resultGeometric,1)}");
    return array;
}

CalcArithmeticAndGeometricModules();

IntroTask(14, "S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.");

double FindPerimeterTrapezoids()
{
    double base_a = rnd.NextDouble() * 10;
    double base_b = base_a * 1.06;
    double height_h = rnd.NextDouble() * 10;
    double PerimeterTrapezoids = base_a + base_b + (2 * Math.Sqrt((Math.Pow(height_h, 2) + Math.Pow(((base_a - base_b)/4), 2))));
    System.Console.WriteLine($"Периметр трапеции = {Math.Round(PerimeterTrapezoids, 1)} при катетах = {Math.Round(base_a, 1)}, {Math.Round(base_b, 1)} и высоте {Math.Round(height_h, 1)}");
    return PerimeterTrapezoids;
}

FindPerimeterTrapezoids();

IntroTask(15, "S2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.");

double RectanglePerimeterAndDiag()
{
    double side_1 = rnd.NextDouble() * 10;
    double side_2 = rnd.NextDouble() * 10;
    double perimeter = 2 * (side_1 + side_2);
    System.Console.WriteLine($"Периметр = {Math.Round(perimeter, 1)} при стороне a = {Math.Round(side_1, 1)} b = {Math.Round(side_2, 1)}.");
    double diagonal = Math.Sqrt((Math.Pow(side_1, 2) + Math.Pow(side_2, 2)));
    System.Console.WriteLine($"Диагональ прямоугольника = {Math.Round(side_2, 1)}");
    return perimeter;
}

RectanglePerimeterAndDiag();

IntroTask(16, "S2.16. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.");

double VolumeAndSquareParallelepiped()
{
    double side_1 = rnd.NextDouble() * 10;
    double side_2 = rnd.NextDouble() * 10;
    double height_h = rnd.NextDouble() * 10;
    double VolumeBody = side_1 * side_2 * height_h;
    double SquareBody = 2 * (side_1 * side_2 + side_1 * height_h + side_2 * height_h);
    System.Console.WriteLine($"a = {Math.Round(side_1, 1)}, b = {Math.Round(side_2, 1)}, h = {Math.Round(height_h, 1)}");
    System.Console.WriteLine($"Объём параллелипипеда = {Math.Round(VolumeBody, 1)}, площадь боковой поверхности = {Math.Round(SquareBody, 1)}");
    return SquareBody;
}

VolumeAndSquareParallelepiped();

IntroTask(17, "S2.17. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.");

int [,] TwoPointLength()
{
    int[,] array_1 = new int[2, 2];

    array_1[0, 0] = 3;
    array_1[0, 1] = 6;
    array_1[1, 0] = 2;
    array_1[1, 1] = 1;

    double result_1 = Math.Pow(array_1[0, 0] - array_1[1, 0], 2) + Math.Pow(array_1[0, 1] - array_1[1, 1], 2);
    double result_2 = Math.Round(Math.Sqrt(result_1));

    System.Console.WriteLine(result_2);
    return array_1;
}

TwoPointLength();

IntroTask(18, "S2.18. Даны основания и высота равнобедренной трапеции. Найти периметр трапеции.");

FindPerimeterTrapezoids();

IntroTask(19, "S2.19. Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.");

double FindSquareTrapezoids()
{
    double base_a = rnd.NextDouble() * 10;
    double base_b = base_a * 1.06;
    double base_c = rnd.NextDouble() * 100;
    double height_h = ((base_b - base_a) / 2) * Math.Tan(base_c);
    double SquareTrap = ((base_a + base_b) / 2) * height_h;
    System.Console.WriteLine(Math.Round(SquareTrap, 1));
    return SquareTrap;
}

FindSquareTrapezoids();