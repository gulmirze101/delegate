int[] arr = { 9, 0, -9, -3, -2, 9, 6, 4, 2, -8, 0, 2, -3, -2, 7, -7 };

CustomSort(arr, Artan);

ShowArr(arr);
CustomSort(arr, Azalan);
ShowArr(arr);

CustomSort(arr, TekCut);
ShowArr(arr);

CustomSort(arr, ModulArtan);
ShowArr(arr);



void ShowArr(int[] arr)
{
    foreach (int i in arr)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();
}

void CustomSort(int[] arr, Compare cmp)
{
    for (int j = 0; j < arr.Length; j++)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {

            if (cmp(arr[i], arr[i + 1]) == arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;

            }
        }
    }
}


int Artan(int a, int b)
{
    return Math.Max(a, b);
}
int Azalan(int a, int b)
{
    return Math.Min(a, b);
}

int TekCut(int a, int b)
{
    if (a % 2 == 0)
    {
        return a;
    }
    return b;
}

int ModulArtan(int a, int b)
{
    if (Math.Abs(a) > Math.Abs(b)) return a;
    return b;
}
delegate int Compare(int a, int b);