Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Таблица кубов чисел от 1 до {number}.");
Console.WriteLine();

Console.WriteLine("Число\tКуб числа");
    
for (int i = 1; i <= number; i++)
{
    Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
}

