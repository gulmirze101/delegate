List<int> list = new List<int> { 9, 0, -9, -3, -2, 9, 6, 4, 2, -8, 0, 2, -3, -2, 7, -7 };




ShowList(ApplyFilter(list, IsEven));
ShowList(ApplyFilter(list, IsOdd));
ShowList(ApplyFilter(list, IsPositive));
ShowList(ApplyFilter(list, IsNegative));



void ShowList(List<int> list)
{
    foreach (int i in list)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}
List<int> ApplyFilter(List<int> numbers, NumberFilter filter)
{
    List<int> result = numbers.Where(x => filter(x)).ToList();
    return result;
}


bool IsEven(int n)
{
    return n % 2 == 0; ;
}
bool IsOdd(int n)
{
    return (n % 2 == 1);
}
bool IsPositive(int n)
{
    return n > 0;
}
bool IsNegative(int n)
{
    return n < 0;
}
delegate bool NumberFilter(int n);