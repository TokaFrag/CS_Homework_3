void Print(string text)
{
    Console.WriteLine(text);
}

int GetIntNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void GetCube(int number)
{
    Console.Clear();
    Print($"table of cube number {number}:");
    int index = 1;
    while (number >= index)
    {
        double result = Math.Pow(index, 3);
        Print($"{result}");
        index++;
    }
}

Print("Input number");
int number = GetIntNumber();
GetCube(number);