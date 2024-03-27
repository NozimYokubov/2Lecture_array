//int n = 10;
int[] array = { 2, 5, 6, 4, 7, 56, 8, 9, 1, 11 };
//int i = 0;

//while (i < array.Length)
//{
//    if (array[i] % 2 == 0)
//    {
//        Console.Write($"{array[i]} ");
//    }
//    i = i + 1;
//}

//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0)
//    {
//        Console.Write($"{array[i]} ");
//
//    }
//}

foreach (int e in array)
{
    if (e % 2 == 0)
    {
        Console.Write($"{e} ");

    }
}