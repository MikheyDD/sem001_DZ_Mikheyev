Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
if (A == B)
{
    Console.WriteLine("Числа равны");
} else
if (A > B) 
{
    Console.Write("max = ");
    Console.Write(A);
    Console.Write(" , min = ");
    Console.Write(B);
}
else 
{
Console.Write("max = ");
    Console.Write(B);
    Console.Write(" , min = ");
    Console.Write(A);
}