Console.WriteLine("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

double z = (Math.Log(Math.Abs(Math.Cos(x)))) / (Math.Log(1 + Math.Pow(x, 2)));

Console.WriteLine(z);
