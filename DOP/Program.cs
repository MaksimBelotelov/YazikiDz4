// Программа принимает радиус круга и находит его площадь, округленную
// до целого числа. Необходимо вывести максимальную цифру в полученном
// округленном значении круга.

Console.Clear();

Console.Write("Введите радиус круга: ");
double r=Convert.ToDouble(Console.ReadLine());

double s = Math.Round(3.1415 * r*r);

Console.WriteLine($"Площадь круга: {s}");
Console.WriteLine($"Максимальная цифра в площади: {FindMaxDig(s)}");

int FindMaxDig(double number)
{
    int num=Convert.ToInt32(number);
    int max=-1;

    for(int i=num; i!=0; i/=10)
    {
        if(i%10>max)
            max=i%10;
    }
    return max;
}