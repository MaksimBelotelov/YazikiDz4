// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

Console.Clear();

Console.Write("Введите число (А): ");
int a=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральную степень, в которую нужно возвести число (В): ");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} ^ {b} = {Expon(a,b)}");

int Expon(int a, int b)
{
    int result=a;
    
    for(int i=1; i<b; i++)
        result*=a;
    return result;
}
