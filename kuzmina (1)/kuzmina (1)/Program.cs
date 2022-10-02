double a, s, h, r, R = 0;

a = Convert.ToDouble(Console.ReadLine());

s = Math.Pow(a, 2) * Math.Sqrt(3) / 4;
h = a * Math.Sqrt(3) / 2;
r = a * Math.Sqrt(3) / 6;
R = a * Math.Sqrt(3) / 3;

Console.WriteLine($"Площадь равностороннего треугольника равна: {s}");
Console.WriteLine($"Высота равностороннего треугольника равна: {h}");
Console.WriteLine($"Площадь вписанной окружности равностороннего треугольника равна: {r}");
Console.WriteLine($"Площадь описанной окружности равностороннего треугольника равна: {R}");
