string[] GetArray(int howLongArray)
{
    string[] array = new string[howLongArray];
    for (int i = 0; i < howLongArray; i++)
    {
        Console.WriteLine("Введите новый элемент массива:");
        string newElement = (Console.ReadLine());
        array[i] = newElement;
    }
    return array;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.Write("[]");
    }
    else
    {
        Console.Write("[");
        for (int i = 0; i < array.Length-1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length - 1]}]");
    }

}



string[] NewArray(string[] array)
{
    int count = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count = count + 1;

    }
    string[] newArray = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j = j +1;
        }
    }
    return newArray;
}


string[] array = GetArray(4);
PrintArray(array);
string[] newArray = NewArray(array);
Console.WriteLine();
PrintArray(newArray);
