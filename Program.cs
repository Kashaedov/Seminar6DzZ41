Console.WriteLine ($"Задайте количеcтво чисел, которые будут введены:");
int M = Convert.ToInt32(Console.ReadLine());
void FillNumber ( int M)
{
    int count = 0;
    for (int i = 1; i < M + 1; i++)
    {
        Console.WriteLine ($"Введите число {i}:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) count++;
    }

    Console.WriteLine("Количество чисел больше нуля = " + count);
}
FillNumber (M);
