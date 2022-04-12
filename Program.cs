// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3-м символам.

string[] array = {"hello", "2", "world", ":-)"};
string[] array2 = {"hello", "2", "world", ":-)"};
int index = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i].Length <= 3)
   {
      array2[index]= array[i];
      index++;
      Console.Write(array2[i] + " ");
   }
} 