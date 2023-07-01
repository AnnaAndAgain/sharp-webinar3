// Принимаем число N, выдает все квадраты чисел от 1 до N (5->1, 4, 9, 25 )

Console.WriteLine("Введите целое число N больше 0");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int i = 0;

for (i = 1; i <= N; i++)
{
    array[i - 1] = Convert.ToInt32(Math.Pow(i, 2));
};

Console.WriteLine(string.Join(", ", array));