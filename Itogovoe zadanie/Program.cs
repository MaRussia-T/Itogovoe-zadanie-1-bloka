/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/

string[] array = new string[4] { "January", "April", "May", " :-) " }; // задан массив из 4 элементов
string[] SortedArray = new string[array.Length]; // задан массив для сортировки

void ArraySorting(string[] array, string[] SortedArray) // метод сортировки массива
{
    int count = 0; // счетчик элементов массива
    for (int i = 0; i < array.Length; i++) // поиск элементов длиной менее 3 символов
    {
        if (array[i].Length <= 3)
        {
            SortedArray[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array) // вывод массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
ArraySorting(array, SortedArray);
PrintArray(SortedArray);