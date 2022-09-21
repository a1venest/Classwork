Console.WriteLine("Vvedite chislo 1.");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vvedite chislo 2.");
int number2 = Convert.ToInt32(Console.ReadLine());

void Div(int number1, int number2)
{
    if (number2 % number1 == 0)
    {
        Console.WriteLine("Kratno");
    }
    else
    {
        Console.WriteLine("Ne kratno, ostatok: " + (Convert.ToDouble(number2 % number1)) + ".");
    }
}

Div(number1, number2);