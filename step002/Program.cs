// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
/*
int CreateNumber()
{
    int number = new Random().Next(100, 1000);
    return number;
}

int DeleteDigit(int number)
{
    int Sot = number / 100;
    int Decimal = number / 10;
    int Ed = number % 10;
    int Ot = Sot*100+Ed
    {
        return Ot;
    }
}

int a = CreateNumber();
Console.WriteLine(a);
int deleteDigit = DeleteDigit(a);
Console.WriteLine(DeleteDigit);*/

int CreateNumber() // Генерация случайного целого числа
{
    return new Random().Next(100,1000);
}

int DeleteSecondDigit(int Number) // Удаление второй цифры из трехзначного числа
{
    int Hundred = Number/100;
    //int Decimal = (Number-Hundred*100)/10;
    int Ed = Number%10;
    return (Hundred*100+Ed);
}


int Number = CreateNumber(); 
Console.WriteLine(Number);
Console.WriteLine(DeleteSecondDigit(Number));
