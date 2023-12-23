//Лаб 6.1 Высокий 24

Console.Write("Введите равное кол-во делителей: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Трехзначные числа с {0} делителями:", k);
for (int num = 100; num <= 999; num++)
{
    if (divisors(num) == k)
    {
        Console.WriteLine(num);
    }
}
int divisors(int number)
{
    int count = 0;
    for (int i = 1; i <= number; i++)
    {
        if (number % i == 0)
        {
            count++;
        }
    }
    return count;
}