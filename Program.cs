// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void SortArrayBy3(string[] array_1, string[] array_2)
{
    int num = 0;
    for (int i = 0; i < array_1.Length; i++)
    {
    if(array_1[i].Length <= 3)
        {
        array_2[num] = array_1[i];
        num++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array_1 = new string[10] {"Geek", "G/N", "Brain", "A", "world", "666", "KK", "Kazan", "702", "RUS"};
string[] array_2 = new string[array_1.Length];


SortArrayBy3(array_1, array_2);
PrintArray(array_2);