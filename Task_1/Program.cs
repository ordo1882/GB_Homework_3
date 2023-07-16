// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Первый Вариант:
//======================================================================
// bool IsValidateNumber(int number)
// {
//     if ((number < 10000) || (number > 99999))
//     {
//         System.Console.WriteLine("Need to be only five-digit number");
//         return false;
//     }
//     return true;
// }

// System.Console.WriteLine("Enter a five-digit number:");
// int n = Convert.ToInt32(Console.ReadLine());

// if (IsValidateNumber(n))
// {
//     int num1 = n / 1000; // Разбиваем число на две части исключив при этом среднюю цифру.
//     int num2 = n % 100;

//     if ((num1 / 10 == num2 %10) && (num1 % 10 == num2 / 10))
//     {
//         System.Console.WriteLine("The number is a palindrome");
//     }
//     else
//     {
//         System.Console.WriteLine("The number is not a palindrome");
//     }
// }


// Второй вариант:
//================================================================

bool IsValidateNumber(string num)
{
    if (num.Length != 5)
    {
        System.Console.WriteLine("Need to be only five-digit number");
        return false;
    }
    return true;
}

Console.WriteLine("Enter a five-digit number:");
string number = Console.ReadLine();

if (IsValidateNumber(number))
{
    if ((number[0] == number[4]) && (number[1] == number[3]))
    {
        System.Console.WriteLine("The number is a palindrome");
    }
    else
    {
        System.Console.WriteLine("The number is not a palindrome");
    }
}