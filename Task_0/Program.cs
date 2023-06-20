// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Print(string text)
{
    Console.WriteLine(text);
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetSquare(int num)
{
    if (num >= 10000 && num < 100000)
    {
        int numberFirst = num / 10000;
        int numberSecond = (num / 1000) % 10;
        int numberFourth = (num / 10) % 10;
        int numberFifth = num % 10;
        if (numberFirst == numberFifth && numberSecond == numberFourth)
        {
            Print($"Number {num} is a palindrome!");
        }
        else
        {
            Print($"Number {num} is not a palindrome!");
        }

    }
    else
    {
        Print("A non-five-digit number is entered. Try again.");
        Print("Enter a five-digit number");
        int number = GetIntNumber();
        GetSquare(number);
    }
}

Print("Enter a five-digit number");
int number = GetIntNumber();
GetSquare(number);
