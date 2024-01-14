// Задача: Написать программу, которая из имеющегося массива 
//строк формирует новый массив из строк, длина которых меньше, 
//либо равна 3 символам. Первоначальный массив можно ввести с 
//клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше 
// обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int ReadInt(string text) // Метод принятия сроки и конвертирования его в значение int.
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] FillArray(int size) //Метод для заполнения массива
{
    string[] tempArray = new string[size];

    for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1} элемент массива: ");
    tempArray[i] = Console.ReadLine()!;
    Console.WriteLine();
}

return tempArray;
}

void PrintArray(string[] array)//Метод приема аргумента в виде строки и вывода форматированного значения
{
    Console.Write($"[{string.Join(", ", array)}]");
}

string[] ArraySort(string[] array, int stringLength)// Метод Сортировки искомого значения
{
    string[] tempArray = new string[0];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= stringLength) 
        {
            Array.Resize(ref tempArray, count+1);
            tempArray[count] = array[i];
            count ++;
        }
    }
    return tempArray;
}
// Основной код:
Console.Clear();
int size = ReadInt("Введите размер массива: ");
Console.WriteLine();
string[] myArray = FillArray(size);
string[] newArray = ArraySort(myArray, 3);
PrintArray(myArray); 
Console.Write(" -> ");
PrintArray(newArray);
Console.WriteLine();
