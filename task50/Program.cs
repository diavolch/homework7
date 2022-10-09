/*
Напишите программу, которая на вход принимает позицию элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}
int getIndexInArray(int[,] incomingArray, int index)
{
    int result = -1;
    int height = incomingArray.GetLength(0);
    int width = incomingArray.GetLength(1);
    int size = height * width;
    int i = index / width;
    int j = index % width;
    if (index < size)
    {
        result = incomingArray[i, j];
    }
    return result;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] generatedArray = generate2DArray(3, 4, 1, 10);
print2DArray(generatedArray);
Console.Write("Введите индекс: ");
int index = Convert.ToInt32(Console.ReadLine());
int result = getIndexInArray(generatedArray, index);
Console.WriteLine($"{(result == -1 ? "Такого числа в массиве нет" : "Число под индексом " + index + " = " + result)}");