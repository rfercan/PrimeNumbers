int num1;
Console.WriteLine("Enter number");
num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 0 || num1 == 1)
{
    Console.WriteLine(num1 + " is not prime");
}
else
{
    for (int i = 2; i <= num1 / 2; i++)
    {
        if (num1 % i == 0)
        {
            Console.WriteLine(num1 + " is not prime");
            return;
        }
    }
    Console.WriteLine(num1 + " is prime");
}

