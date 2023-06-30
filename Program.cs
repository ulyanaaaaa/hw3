/* НП, кот. принимает на вход пятизначное число и проверяет,
являетсяли оно полиндромом.
*/

// Console.WriteLine("Enter five-digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());


// int firstDigit(int num)
// {
//     int first = num / 10000 % 10;
//     return first;
// }

// int secondDigit(int num)
// {
//     int second = num / 1000 % 10;
//     return second;
// }

// int fourthDigit(int num)
// {
//     int fourth = num / 10 % 10;
//     return fourth;
// }

// int fifthDigit(int num)
// {
//     int fifth = number % 10;
//     return fifth;
// }

// int fdigit = firstDigit(number);
// int sdigit = secondDigit(number);
// int fodigit = fourthDigit(number);
// int fidigit = fifthDigit(number);

// if (number < 100000 && number > 10000)

// {
//     if (fdigit == fidigit && sdigit == fodigit)
//     {
//         Console.WriteLine($"{number} -> Yes.");
//     }
//     else Console.WriteLine($"{number} -> No.");
// }
// else Console.WriteLine("It supposed to be five-digit number.");


/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
*/

// int InputNum(string message)
// {
//     Console.WriteLine(message);
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// int num = InputNum("Enter integer number: ");
// for (int i = 1; i <= num; i++)
// {
//     Console.Write($"{Math.Pow(i, 3)}");
//     if(i < num)
//     {
//         Console.Write(",");
//     }
//     else
//     {
//         Console.Write(".");
//     }
// }


/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.
*/

int InputNum(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int xA = InputNum("Enter x for dot A;");
int yA = InputNum("Enter y for dot A;");
int zA = InputNum("Enter z for dot A;");
int xB = InputNum("Enter x for dot B;");
int yB = InputNum("Enter y for dot B;");
int zB = InputNum("Enter z for dot B;");

double Root(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double res1 = Math.Pow(xB - xA, 2);
    double res2 = Math.Pow(yB - yA, 2);
    double res3 = Math.Pow(zB - zA, 2);
    double res = Math.Sqrt(res1 + res2 + res3);
    return res;
}

double distance = Root(xA, yA, zA, xB, yB, zB);
Console.WriteLine(Math.Round(distance, 2));

