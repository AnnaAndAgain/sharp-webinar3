// Принимаем координаты 2 точек, выдаем расстояние между ними в двумерном пространстве

double[] pointA = new double[2];
double[] pointB = new double[2];

Console.WriteLine("Введите координату Х первого числа:");
pointA[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y первого числа:");
pointA[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х второго числа:");
pointB[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y второго числа:");
pointB[1] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow((pointB[0] - pointA[0]), 2) + Math.Pow((pointB[1] - pointA[1]), 2)), 3);
Console.WriteLine(distance);