// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве. 
// [345, 897, 568, 234] -> 2


int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int [] generateArray(int length, int start, int end)
{
    int [] result = new int [length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);
    }
    return result;
}
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getCount(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}
int number = getUserData("Введите количество элементов массива");
int [] array = generateArray(number, 100, 999);
printArray(array);
int getCountNumbers = getCount (array);
Console.WriteLine($"Колиество четных чисел {getCountNumbers}");
