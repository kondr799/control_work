﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

Console.Write("Ввести количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
//string[] inputstring = new string [m];
//string[] outputstring = new string [m];
string[] stringArray = new string[m];

void array(string[] sringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.WriteLine ($"Введите {i + 1} элемент массива");
    stringArray[i] = Console.ReadLine();
  }  
}

string[] count(string[] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    n++;
  }

string[] result = new string[n];
int j = 0;
for (int i = 0; i < stringArray.Length; i++)
{
  if (stringArray[i].Length <= 3)
  {
    result[j] = stringArray[i];
    j++;
  }
}
return result;
}

void PrintArray(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"'{stringArray[i]}',");
  }
  Console.Write("]");
}
array(stringArray);
PrintArray(count(stringArray));

