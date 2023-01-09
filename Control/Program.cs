// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] StrPlusStr(string str)
{
    string[] arrStr = str.Split(',');
    return arrStr;
}

void PrintArray(string[] arr, string firstStr, string links, string lastStr, string skob)
{
    Console.Write(firstStr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{skob}{arr[i]}{skob}{links}");
        else Console.Write($"{skob}{arr[i]}{skob}");
    }
    Console.Write(lastStr);
}

string[] SecArr(string[] ara, int strLength)
{
    int size = 0;
    for (int i = 0; i < ara.Length; i++)
    {
        if (ara[i].Length <= strLength) size++;
    }
    string[] arr1 = new string[size];
    int index1 = 0;
    for (int i = 0; i < ara.Length; i++)
    {
        if (ara[i].Length <= strLength) arr1[index1++] = ara[i];
    }
    return arr1;
}

Console.WriteLine($"Введите элементы массива через запятую ");
string string1 = Console.ReadLine();

string[] array = StrPlusStr(string1);
PrintArray(array, "[", ", ", "]", "\"");

string[] array1 = SecArr(array, 3);
PrintArray(array1, " -> [", ", ", "]", "\"");