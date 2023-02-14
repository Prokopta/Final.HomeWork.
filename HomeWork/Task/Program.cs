// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо ровна 3 символа. 

Console.Clear();

Console.WriteLine("Введите строки через пробел");
string inputUser = Console.ReadLine();
string[] Array = inputUser.Split(' ');

string[] resultArray = new string[Array.Length];

SearchForTheRightElements(Array, resultArray);
Console.Write($"Элементы содержащие меньше, либо 3 символа: ");
PrintArray(resultArray);

// SearchForTheRightElements - ищет нужные элементы в массиве.
void SearchForTheRightElements(string[] inputArray, string[] resultArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length < 4)
        {
            resultArray[count] = inputArray[i];
            count++;
        }
    }
}

// PrintArray - выводит решение в консоль.
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}