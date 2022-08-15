int numberRandom = new Random().Next(10000, 100000); // Случайное значение на вход
Console.WriteLine($"Является ли число {numberRandom} палиндромом?");

// Console.WriteLine("Ведите пятизначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

void ShifterNumber(int num)
{

    int lastNum = num % 10;
    int firstNum = num / 10000;
    if (firstNum == lastNum)
    {
        lastNum = (num % 100) / 10;
        firstNum = (num / 1000) % 10;
        if (firstNum == lastNum) Console.WriteLine($"{num} -> Да");
        else Console.WriteLine($"{num} -> Нет");
    }
    else Console.WriteLine($"{num} -> Нет");

    
}
ShifterNumber(numberRandom);

