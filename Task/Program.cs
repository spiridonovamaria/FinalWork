// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.


string startString = Prompt("Введите массив элементов через запятую");
string[] startArray = ArrayOfString(startString);
ArrayPrint(startArray, "Входной массив строк: ");
string[] result = StringsWithLenghtLessThanThree(startArray);
ArrayPrint(result, "Итоговый массив со строками, длина которых меньше либо равна 3");


string Prompt(string message)       
{
    System.Console.WriteLine(message);
    return Console.ReadLine();
}
string[] ArrayOfString(string str)     
{
    string[] array = str.Trim().Split(",");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].Trim();
    }
    return array;
}
string[] StringsWithLenghtLessThanThree(string[] array)    
{        
    string[] answer = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            answer[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref answer, j);
    return answer;
}
void ArrayPrint(string[] array, string message)     
{      
    System.Console.WriteLine(message);
    if (array.Length == 0)
    {
        System.Console.WriteLine("Массив пустой");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine(array[i]);
        }

    }
}