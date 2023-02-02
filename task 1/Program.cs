//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите M чисел через пробел: ");
string? str = System.Console.ReadLine();
var arr = str.Split(" ");
int[] arrint = new int[arr.Length];
int count=0;

 for (int i = 0; i < arr.Length; i++)
{
    arrint[i]=Convert.ToInt32(arr[i]);
    
    if (arrint[i]>0) count++;
}

System.Console.WriteLine($"Введено {count} числа(чисел) больше 0");

