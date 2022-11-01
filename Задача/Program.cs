// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array1 = 
{
    "Hello",
    "2",
    "world",
    ":-)"
};

int size = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length < 4)
    {
        size++;
    }
}
string[] array2 = new string[size];
int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length < 4)
    {
        array2[count] = array1[i];
        count++;
    }
}

Console.Write("[{0}]", string.Join(", ", array2));