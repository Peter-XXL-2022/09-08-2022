int number = new Random().Next(100, 1000); // Случайное значение на вход
Console.Write($"{number} -> ");

// Console.Write("Введите трехзначное число: "); // Ввод значения пользователем
// int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = (number % 100) / 10;

Console.Write(secondNumber);
