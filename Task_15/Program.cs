Console.Write("Введите цифру, обозначающую день недели: "); // Ввод значения пользователем
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("{0} -> да этот выходной", dayWeek);
}
else if (dayWeek >= 1 && dayWeek <= 5)
{
    Console.WriteLine("{0} -> нет этот день не выходной", dayWeek);
}
else
{
    Console.WriteLine("{0} -> дня недели с такой цифрой нет", dayWeek);
}
