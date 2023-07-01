// определяем четверть по координатам


/*bool methPositive(int arg1) 
{
    bool tmp;
    if (arg1 > 0)  tmp = true;
    else tmp = false;
    return tmp;
}

Console.WriteLine("Введите Х, только не нояь:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y, только не нояь:");
int y = Convert.ToInt32(Console.ReadLine());

if ((x == 0)|(y == 0))
{
    Console.WriteLine("Вы ввели 0, не надо так!");
}
else if (methPositive(x) & methPositive(y))
{
    Console.WriteLine("Четверть 1");
}
else if ((methPositive(x) | methPositive(y)) == false)
{
    Console.WriteLine("Четверть 3");
}
else if (methPositive(x))
{
    Console.WriteLine("Четверть 4");
}
else Console.WriteLine("Четверть 2");*/

int[] point = new int[2];

Console.WriteLine("Введите Х, только не ноль:");
point[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y, только не ноль:");
point[1] = Convert.ToInt32(Console.ReadLine());

if ((point[0] == 0)|(point[1] == 0))
{
    Console.WriteLine("Вы ввели 0, не надо так!");
}
else if (point[0] > 0)
{
    if (point[1] > 0)     Console.WriteLine("Четверть 1");
    else Console.WriteLine("Четверть 4");
}
else
{
    if (point[1] > 0)     Console.WriteLine("Четверть 2");
    else Console.WriteLine("Четверть 3");
}
