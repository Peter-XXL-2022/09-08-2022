Console.Write("Введите число: "); // Ввод значения пользователем
int number = Convert.ToInt32(Console.ReadLine());


int thirdNumber = ThirdNumber(number);
Console.WriteLine(thirdNumber);


static int ThirdNumber(int count)
{
    while (count <= -1000 || count >= 1000) count /= 10;
    int digit = count % 10;
    return digit;
}