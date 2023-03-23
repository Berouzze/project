// Ввод размера перввого массива
int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
// Ввод элементов первого массива
string GetString(string text)
{
    System.Console.WriteLine(text);
    string? y = Console.ReadLine();
    if (y == null) { return "null"; } 
    return y;
}
// Создание массива
string[] CreateArray(int size)
{
    return new string[size];
}
// Заполнение первого массива
void FillByUser(string[] array)
{
    int size = array.Length;

    int index = 0;

    while (index < size)
    {
        array[index] = GetString("Введите " + index + " элемент: ");
        index++;
    }
}
// Заполнение второго массива
void FillSecondArray(string[] array, string[] array2)
{
    for (int index = 0, index2 = 0; index < array.Length && index2 < array2.Length; index++)
    {
        int stringSize = 3;
        string item = array[index];
        if (item.Length <= stringSize)
        {
            array2[index2] = array[index];
            index2++;
        }

    }
}
// Определение размера второго массива
int NewSize(string[] array)
{
    int stringSize = 3;
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        string item = array[index];
        if (item.Length <= stringSize)
        {
            count++;

        }
    }
    return count;
}
// Печать массива
string Print(string[] array)
{
    string result = String.Empty;
    int index = 0;
    while (index < array.Length)
    {
        result = ($"{result} {array[index]}");
        index++;
    }
    return result;
}
int size = GetNumber("Введите размер массива");
string[] firstArrayStr = CreateArray(size);
FillByUser(firstArrayStr);
int newSize = NewSize(firstArrayStr);
string[] secondArrayStr = CreateArray(newSize);
FillSecondArray(firstArrayStr, secondArrayStr);
System.Console.WriteLine(Print(firstArrayStr));
System.Console.WriteLine();
System.Console.WriteLine($"{Print(secondArrayStr)}");