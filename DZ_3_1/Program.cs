// Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите СТРОГО пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] array) //для собственной проверки правильности заполнения массива
    {
        int count = array.Length;
        for (int i = 0; i < count; i++)
        {
            System.Console.Write($"{array[i]} ");
        }
        System.Console.WriteLine();
    }

string str = N.ToString();

if (str.Length == 5)
{
    int[] array = new int[str.Length];
            
    for( int i=0; i< str.Length; i++)
    {
        array[i] = int.Parse(str[i].ToString());
    }

    //PrintArray(array);

    if (array[0] == array[4] || array[1] == array[3])
    {
        System.Console.WriteLine("Введенное число является палиндромом");
    }
    else
    {
    System.Console.WriteLine("Введенное число НЕ является палиндромом"); 
    }

}

else
{
    System.Console.WriteLine("Некорректный ввод. Повторите ввод ПЯТИЗНАЧНОГО числа");
}