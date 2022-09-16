
using dz_ukhabatov_1213;

class Program
{
    public static int Main()
    {
        var c = new dz_16_09();

        Console.WriteLine("Составить таблицу значений функции y = 5 - x2/2 на отрезке [-5; 5] с шагом 0.5.\n");
        c.table_func();

        Console.WriteLine("Ряд Фибоначи.\n");
        c.fibonachi();

        Console.WriteLine("Поиск числа.\n");
        c.findNumber();
        return 0;
    }
}
