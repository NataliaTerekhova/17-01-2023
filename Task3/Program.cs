// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2%number1==0)
{
    System.Console.WriteLine( $"{number2} кратно {number1}");
}

else 
{
System.Console.WriteLine( $"не кратно, остаток - {number2%number1}");
}


// if (number1 * number1 == number2)
// {
//     System.Console.WriteLine(number2 + " кратно " + number1);
// }
// else
// {
//     int num = number2 / number1;
//     int remainder = number2 - num;
//     System.Console.WriteLine(number2 + " не кратно " + number1 + ", остаток - " + remainder);
// }