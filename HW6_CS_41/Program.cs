// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray()
{
    Console.WriteLine("Введите число М ");
    int m = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите массив ");
    int[] arr = new int[m];
    for (int i = 0; i < m; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    string str = "[";

    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            str = str + arr[i] + "]";
        }
        else
            str = str + arr[i] + ", ";
    }
    Console.WriteLine(str);
}


int CountPositives(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;

        }
    }
    return count;
}

int[] arr1 = CreateArray();
PrintArray(arr1);
int count1 = CountPositives(arr1);
Console.WriteLine($"Количество чисел больше нуля {count1}");
