// задача 2 HARD необязательная. 
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры). 
// Вывести на экран красивенько таблицей. Найти минимальное число и его индекс, найти максимальное число и его индекс, 
// среднее арифметическое. Вывести эту информацию на экран.

int[,] createArray(int m, int n) {
    int[,] arr = new int [m, n];
    Random rnd = new Random();
    for(int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i,j] = rnd.Next(201) - 100;
        }
    }
    return arr;
}

void printArray(int [,] arr, int m, int n) {
    for(int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

double[] arrayStats (int[,] arr, int m, int n) {
    int max = arr[0,0];
    int maxIndex1 = 0;
    int maxIndex2 = 0;

    int min = arr[0,0];
    int minIndex1 = 0;
    int minIndex2 = 0;

    double avg = 0;

    double[] stats = new double [7];

    for(int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            if(arr[i,j] > max) {
                max = arr[i,j];
                maxIndex1 = i;
                maxIndex2 = j;
            }
            if(arr[i,j] < min) {
                min = arr[i,j];
                minIndex1 = i;
                minIndex2 = j;
            }
            avg += arr[i,j];
        }
    }

    avg /= m * n;
    stats[0] = max;
    stats[1] = maxIndex1;
    stats[2] = maxIndex2;
    stats[3] = min;
    stats[4] = minIndex1;
    stats[5] = minIndex2;
    stats[6] = avg;

    return stats;
}
Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arr = createArray(m,n);
printArray(arr, m, n);
double[] stats = arrayStats(arr, m, n);
Console.WriteLine($"Максимальное число: {stats[0]}, его индекс: ({stats[1]}, {stats[2]})");
Console.WriteLine($"Минимальное число: {stats[3]}, его индекс: ({stats[4]}, {stats[5]})");
Console.WriteLine($"Среднее арифметическое: {stats[6]}");