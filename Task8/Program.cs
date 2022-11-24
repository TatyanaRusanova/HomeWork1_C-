Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
for (i = 2; i <= num; i += 2)
{
        Console.Write($"{i}, ");
}