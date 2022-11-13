Console.WriteLine("Введите число : ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 1;
while (B <= A)
{
    if (B % 2 == 0)
    {
        Console.Write(B + ", ");
    }
    B++;
}