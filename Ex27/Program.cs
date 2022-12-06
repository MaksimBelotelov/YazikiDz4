// Программа принимает на вход число и выдает сумму цифр в числе

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {num} равна {SumOfDig(num)}");

int SumOfDig(int num)
{
    int sum=0;
    for (int i=num; i!=0; i/=10)
        sum+=i%10;
    return sum;
}
