// По номеру четверти пишем диапазоны

/*

if (quadrant == 1) Console.WriteLine("x > 0, y > 0");
else if (quadrant == 2) Console.WriteLine("x < 0, y > 0");
else if (quadrant == 3) Console.WriteLine("x < 0, y < 0");
else if (quadrant == 4) Console.WriteLine("x > 0, y < 0");
else Console.WriteLine("Ошибка!");*/

string[] coordinates = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0"};
Console.WriteLine("Введите номер четверти");
int quadrant = Convert.ToInt32(Console.ReadLine());
if (quadrant  > 0 && quadrant < 5) Console.WriteLine(coordinates[quadrant-1]);
else Console.WriteLine("Ошибка!");