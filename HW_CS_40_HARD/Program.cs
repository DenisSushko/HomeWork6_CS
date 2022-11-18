// задача 40 - HARD необязательная. 
// На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, 
// значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.

double[] InputTriangle()
{
    double[] triangle = new double[3];
    Console.WriteLine("Введите первую сторону треугольника: ");
    triangle[0] = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите вторую сторону треугольника: ");
    triangle[1] = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите третью сторону треугольника: ");
    triangle[2] = double.Parse(Console.ReadLine()!);
    return triangle;
}

bool checkTriangle(double[] triangle)
{
    bool isTriangle = false;
    if (triangle[0] + triangle[1] > triangle[2] && triangle[0] + triangle[2] > triangle[1] && triangle[1] + triangle[2] > triangle[0])
    {
        Console.WriteLine("Такой треугольник может существовать");
        isTriangle = true;
    }
    else
    {
        Console.WriteLine("Такой треугольник НЕ может существовать");
    }
    return isTriangle;
}

void triangleStats(double[] triang)
{
    double P = (triang[0] + triang[1] + triang[2]); // Периметр
    double p = P / 2; // Полупериметр
    double S = Math.Round(Math.Sqrt(p * (p - triang[0]) * (p - triang[1]) * (p - triang[2])), 0); // Площадь

    double[] angles = new double[3];
    double cosAlpha = ((triang[0] * triang[0]) + (triang[2] * triang[2]) - (triang[1] * triang[1])) / (2 * triang[0] * triang[2]); //Косинус угла альфа
    double cosBeta = ((triang[0] * triang[0]) + (triang[1] * triang[1]) - (triang[2] * triang[2])) / (2 * triang[0] * triang[1]); //Косинус угла бета
    angles[0] = Math.Round((Math.Acos(cosAlpha)) * 180 / Math.PI, 0); //угол Альфа в градусах
    angles[1] = Math.Round((Math.Acos(cosBeta)) * 180 / Math.PI, 0); //угол Бета в градусах
    angles[2] = 180 - angles[1] - angles[0]; // угол Гамма в градусах


    bool isRectangular = false;
    for (int i = 0; i < 3; i++)
    {
        if (angles[i] == 90)
        {
            isRectangular = true;
            break;
        }
    }

    bool isIsoscles = false; //Равнобедренный или нет
    if (triang[0] == triang[1] || triang[0] == triang[2] || triang[1] == triang[2])
    {
        isIsoscles = true;
    }

    bool isEquilateral = false; // Равносторонний или нет
    if (triang[0] == triang[1] && triang[1] == triang[2])
    {
        isEquilateral = true;
    }

    Console.WriteLine($"Периметр = {P}, площадь = {S}");
    Console.WriteLine($"Угол между сторонами a и c = {angles[0]}, угол между сторонами a и b = {angles[1]}, угол между сторонами b и c = {angles[2]}");
    if (isRectangular)
    {
        Console.WriteLine("Треугольник - прямоугольный");
    }
    else
    {
        Console.WriteLine("Треугольник - НЕ прямоугольный");
    }
    if (isIsoscles)
    {
        Console.WriteLine("Треугольник - равнобедренный");
    }
    else
    {
        Console.WriteLine("Треугольник - НЕ равнобедренный");
    }
    if (isEquilateral)
    {
        Console.WriteLine("Треугольник - равносторонний");
    }
    else
    {
        Console.WriteLine("Треугольник - НЕ равносторонний");
    }
}

double[] triangle = InputTriangle();
if (checkTriangle(triangle))
{
    triangleStats(triangle);
}
