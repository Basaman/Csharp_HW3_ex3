//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num;

while (true)
{
    Console.Write("Введите целое число большее или равное 1: ");
    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

int num_abs = Math.Abs(num);
if (num_abs == 0)
{
    Console.WriteLine($"Вы ввели 0, попробуйте еще раз");
    return;
}

double count = 1;
double num_cube = 0;

Console.Write($"{num_abs} -> ");
while (count <= num_abs)
{
    num_cube = Math.Pow(count, 3);
    Console.Write($"{num_cube}");
    if (count < num_abs)
    {
        Console.Write(", ");
    }
    count++;
}
