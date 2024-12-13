using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Bismillah Al-Rahman Al-Raheem");

            #region Session 3 
            #region  1-Fraction And Discard 
            ////Fraction الكسور 
            ////By Defualt Fractions Is Double
            //double x = 123.344;
            //float  y = 1.0f;        //If We Dont But  (f)  It is happening Error
            //decimal z = 233.3343m;  //If We Dont But  (m)  It is happening Error 

            ////discard 

            //int number = 100_000_000;
            //Console.WriteLine(number);//100000000

            #endregion
            #region 2-Casting

            #region Implicit Casting (Save Casting)
            ////put Small In Big 
            //int x = 8;
            //long y = x; // == long y = (long)x
            //Console.WriteLine(8);
            #endregion
            #region Explicit Casting (Un Save Casting)
            ////put  Big  In Small   
            //long x = 9;
            ////int y = x;//error 
            //int y = (int)x;//true but not save if x have mig number y take wrong number
            //Console.WriteLine(y);//8
            ////change value of x 
            //x = 985748757875894375;
            //y= (int)x;
            //Console.WriteLine(y);//-956716953  


            #endregion


            //Examples
            //int x = 23;
            //double y = x;  // == double y = (double)x => implicit casting save casting

            //double num1 = 3.3;
            //int num2 =(int) num1;//=>Explicit casting not save 
            //Console.WriteLine(num2);//3 not 3.3



            #endregion
            #region 3-Try Parse 
            //string name = "mohamed";
            //int x;
            //bool flag = int.TryParse(name, out x);
            ////if not happing casting , the value of  x = defualt 
            //Console.WriteLine($"result = {flag} and x = {x}");//result = False and x = 0
            #endregion
            #region 4-Operator

            #region 1-Unary Operator(++,--)
            // //(++) 
            // int x = 10;
            // //++x prefex => [icrement + prent]
            // Console.WriteLine(++x);//11
            //// x++ postfex => [print + icrement]
            // Console.WriteLine(x++);//11
            // Console.WriteLine(x);//12

            // //(--)
            // int z = 10;
            // //--z prefex => [decrement + print]
            // Console.WriteLine(--z);//9
            // //z-- postfex => [print + dexrement]
            // Console.WriteLine(z--);//9
            // Console.WriteLine(z);//8
            #endregion
            #region 2-Binary Operators(+,-,*,/,%)
            //// Workes On 2 Variables 
            //int num1=100, num2=50;

            //Console.WriteLine($"{num1} + {num2} = {num1+num2}");

            //Console.WriteLine($"{num1} - {num2} = {num1 - num2}");

            //Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            //Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            //Console.WriteLine($"{num1} % {num2} = {num1 % num2}");

            #endregion
            #region  3-Assign Operators(=,+=,-=,*=,/=,%=)
            //int x = 2;
            //x += 2;//x=x+2 = 2+2=4
            //x *= 2;//x=x*2 = 4*2=8
            //x /= 2;//x=x/2 = 8/2=4
            //x %= 2;//x=x%2 = 4%2=0

            #endregion
            #region  4-Relation Operators(==,>,<,>=,<=)
            ////Comparison = > المقارنه 
            //int x =10 , y =10 ;
            //Console.WriteLine(x==y);//True
            //Console.WriteLine(x>y); //False
            //Console.WriteLine(x<y); //False
            //Console.WriteLine(x>=y);//True
            //Console.WriteLine(x<=y);//True
            #endregion
            #region   5-Logical Operators And Betwise Operators (!,&&,||,&,|)
            //Console.WriteLine(!false);//T
            //Console.WriteLine(false && true);// F short circit  
            //Console.WriteLine(true || false);//T short circit
            ////Betwise Operator (|,&) => Long Circit
            //Console.WriteLine(false & false);//F long circit 
            //Console.WriteLine(true | false);//T long circit

            #endregion
            #region   6-Ternary Operator (?:)
            //int x = 10, y = 5;
            //Console.WriteLine(x==y?true:false);


            //string res = x == y ? "yes x = y " : "no x != y ";
            //Console.WriteLine(res);


            #endregion




            #endregion
            #region 5-Operators priority
            ////الاولويه 
            ////1-Unary Operator [prefex]
            ////2-Round Brace ()
            ////3-* , / , % 
            ////4- +,-
            //int Equation = 4 + 3 * 8;
            //Console.WriteLine(Equation);//28


            #endregion
            #region  6-String format
            //int x = 3;
            //// 1
            //Console.WriteLine("x= "+x);//اسوء طريقه 
            //// 2
            //string message = string.Format("x = {0}",x); // افضل من الطريقه 1
            //Console.WriteLine(message);
            //// 3 string interpolation [manupolation operator  ($) ]
            //Console.WriteLine($"x   ={x}");//الافضل 



            #endregion
            #region  7-Controal Statement(if,switch)


            #region  1-If Statement

            ////use in complex logic 
            ///chosse by check line by line
            //int day = 1;

            //if (day == 1)
            //{
            //    Console.WriteLine("1");
            //}
            //else if (day == 2)
            //{
            //    Console.WriteLine("2");
            //}
            //else
            //{
            //    Console.WriteLine("invalid value!");
            //}



            #endregion
            #region  2-Switch
            ////Chosse By [Jump table] بيختار الحاله علي طول دون فحص جميل الحالات
            ////work with(int , double , float , string , char)
            //int day = 1;
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("1");
            //        break;
            //    case 2:
            //        Console.WriteLine("2");
            //        break;
            //    case 3:
            //        Console.WriteLine("3");
            //        break;
            //    default:
            //        Console.WriteLine("enter correct number");
            //        break;
            //}


            #endregion

            #region C# 7  Switch 
            //object input = new object();
            //input = 3;
            //input = "ali";
            //input = 1.23;
            //input = 80;
            //input = 300;
            //switch (input)
            //{
            //    // when number >30 && number <= 100: C# 7
            //    case int number when number >30 && number <= 100:
            //        Console.WriteLine($"integer : {number}");
            //        break;
            //    case double number:
            //        Console.WriteLine($"double : {number}");
            //        break;
            //    case string name :
            //        Console.WriteLine($"string : {name}");
            //        break;
            //    default:
            //        Console.WriteLine("no found");
            //        break;
            //}

            #endregion
            #region C# 8 Switch Expression



            //int day = 1;

            //string option = day switch
            //{
            //    1 => "case 1",
            //    2 => "case 2",
            //    _ => "no value"
            //};
            //Console.WriteLine(option);
            #endregion

            #endregion
            #region  9-For , Foreach


            #region 1-For
            ////Use when you know start and end of array 
            ////use eith specific operation with index
            ////controal on start and end of loop
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 90, 098 };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"index of ( {i} ) = {array[i] }" );
            //}


            #endregion

            #region 2-Foreach 
            ////use when you dont know start and end
            ////not use any operator as know index

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 5, 43, 2, 3, 5, 6 };

            //Console.Write(" { ");
            //foreach (int i in array)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine(" } ");
            #endregion

            #endregion
            #region 10-While ,  Do While 

            #region 1-do while 
            ////علي الاقل ينفذ الكود مره 
            ////ثم يذهب ليفحص الشرط 

            //int number;
            //bool flag;
            //do
            //{
            //    Console.Write("Enter Even Number : ");

            //    //number = Convert.ToInt32(Console.ReadLine()); //true but not save
            //    flag = int.TryParse(Console.ReadLine() , out number) ;


            //} while (number% 2==1 || flag == false);
            ////This loop stoped when take even number 



            #endregion
            #region 2- while
            ////first check the  condition
            //string Name;

            //while (true )
            //{
            //    Console.Write("Enter name of developer he white this code : ");
            //     Name = Console.ReadLine();
            //    if (Name == "mohamed")
            //    {
            //        Console.WriteLine($"Yes Name : {Name}");
            //        break;
            //    }

            //}
            ////this loop not stoped without take the correct name


            #endregion

            #endregion

            #endregion

            #region  Assignment 3

            #region Problem 1

            /*
               1 - Write a program that takes a number from the user then print yes
               if that number can be divided by 3 and 4 otherwise print no.

               Example(1)
               Input: 12
               Output: Yes
               Example(2)
               Input: 9
               Output: No

           */

            //Console.WriteLine("Enter Number : ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number % 3 == 0 && Number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion
            #region Problem 2

            //  2 - Write a program that allows the user to insert an integer then
            //  print negative if it is negative number otherwise print positive.

            //  Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            //Output: positive




            //Console.WriteLine("Enter Number : ");
            //int Number = int.Parse(Console.ReadLine());

            //if (Number < 0)
            //{
            //    Console.WriteLine("negative");
            //}
            //else
            //{
            //    Console.WriteLine("positive");
            //}




            #endregion
            #region Problem 3
            // 3 - Write a program that takes 3 integers from the user then
            // prints the max element and the min element.


            // Example(1)
            // Input: 7,8,5
            // Output:
            //         max element = 8
            // min element = 5
            // Example(2)
            // Input: 3 6 9
            // Outputs:
            //         Max element = 9
            // Min element = 3


            //____________________________Solution_______________________________//


            //int[] array=new int[3];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($"Enter number ({i+1})  : ");
            //    array[i] = int.Parse( Console.ReadLine() ); 

            //}

            //int max = array[0], min = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (max < array[i])
            //    { 
            //    max = array[i];
            //    }

            //    if (min > array[i])
            //    { 
            //    min = array[i]; 
            //    }    
            //}
            //Console.WriteLine($"Max Is : {max}");
            //Console.WriteLine($"Min Is : {min}" );





            #endregion
            #region Problem 4


            //    4- Write a program that allows the user to insert an integer number then
            //    check If a number is even or odd.

            //____________________________Solution_______________________________//


            //Console.WriteLine("Enter Number : ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even Number ");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}



            #endregion
            #region Problem 5


            //    5- Write a program that takes character from the user then
            //    if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).


            //      Example(1)
            //      Input: O
            //      Output: vowel
            //      Example(2)
            //      Input: b
            //      Output: Consonant
            //____________________________Solution_______________________________//



            //Console.Write("Enter Character : ");
            //char ch = char.Parse(Console.ReadLine());
            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //{
            //    Console.WriteLine("vowel");
            //}
            //else
            //{
            //    Console.WriteLine("consonant");
            //}




            #endregion
            #region Problem 6


            //6- Write a program that allows the user to insert an integer
            //then print all numbers between 1 to that number.

            //Example
            //Input: 5
            //Output: 1, 2, 3, 4, 5

            //____________________________Solution_______________________________//


            //Console.Write("Enter Number : ");
            //int num=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.Write(i);
            //}

            #endregion
            #region Problem 7


            //    7- Write a program that allows the user to insert an integer then
            //   rint a multiplication table up to 12.
            //      Example
            //      Input: 5
            //      Outputs: 5 10 15 20 25 30 35 40 45 50 55 60


            //____________________________Solution_______________________________//




            //Console.Write(  "Enter Number : ");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);


            //if (flag == true)
            //{
            //    for (int i = num; i <= num; i++)
            //    {
            //        for (int j = 1; j <= 12; j++)
            //        {
            //            Console.Write(j * num + " ");
            //        }
            //    }
            //    Console.WriteLine(" ");

            //}
            //else
            //{
            //    Console.WriteLine("Only Integer Number ");
            //}


            #endregion
            #region Problem 8

            //   8- Write a program that allows to user to insert number then
            //   print all even numbers between 1 to this number
            //      Example:
            //      Input: 15
            //   Output: 2 4 6 8 10 12 14
            //____________________________Solution_______________________________//


            //Console.Write("Enter Number : ");
            //int num;
            //bool flag = int.TryParse(Console.ReadLine(), out num);

            //if (flag == true)
            //{
            //    for (int i = 2; i <= num; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i);
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Only Integer Number");
            //}




            #endregion
            #region Problem 9

            //9- Write a program that takes two integers then prints the power.
            // Example:
            // Input: 4 3
            // Output: 64
            // Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //____________________________Solution_______________________________//

            //Console.Write("Enter Num 1 : ");
            //int num1;
            //bool flag1=int.TryParse (Console.ReadLine(), out num1);

            //Console.Write("Enter Num 2 : ");
            //int num2;
            //bool flag2 = int.TryParse(Console.ReadLine(), out num2);

            //if (flag1 == flag2 == true)
            //{
            //    int res = 1;
            //    for (int i = 1; i <= num2; i++)
            //    {
            //        for (int j = num1; j <= num1; j++)
            //        {
            //              res *=  num1;

            //        }
            //    }
            //    Console.WriteLine( res);
            //}


            #endregion
            #region Problem 10


            //10 - Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Example
            //Input: -Enter Marks of five subjects: 95 76 58 90 89
            //Output: Total marks = 408
            //        Average Marks = 81
            //        Percentage = 81

            //____________________________Solution_______________________________//


            //Console.Write("Enter Number Of Subjects : ");
            //int NumOfSubject;
            //bool flag = int.TryParse(Console.ReadLine(), out NumOfSubject);
            //if (flag == false)
            //{
            //    Console.WriteLine("Only Integer Number ");
            //    return;
            //}

            //int[] array = new int[NumOfSubject];
            //int Total =0;
            //for (int i = 0; i < NumOfSubject; i++)
            //{ 
            //Console.Write($"Enter Subject Nimber ({i+1}) : ");
            //   Total+= array[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine($"Total : {Total}");
            //Console.WriteLine($"Avarage : {Total/NumOfSubject}");
            //Console.WriteLine($"Percentage : {(Total*100)/(NumOfSubject*100) }");



            #endregion
            #region Problem 11



            //   11 - Write a program to input the month number and print the number of days in that month.
            //      Example
            //      Input: Month Number: 1
            //      Output: Days in Month: 31

            //  31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31

            //____________________________Solution_______________________________//

            //Console.Write("Enter Number Of Month : ");
            //int Month;
            //bool flag = int.TryParse(Console.ReadLine(), out Month);
            //if (flag == true)
            //{
            //    switch (Month)
            //    {
            //        case 1:
            //            Console.WriteLine(31);
            //            break;
            //        case 2:
            //            Console.WriteLine(28);
            //            break;
            //        case 3:
            //            Console.WriteLine(31);
            //            break;
            //        case 4:
            //            Console.WriteLine(30);
            //            break;
            //        case 5:
            //            Console.WriteLine(31);
            //            break;
            //        case 6:
            //            Console.WriteLine(30);
            //            break;
            //        case 7:
            //            Console.WriteLine(31);
            //            break;
            //        case 8:
            //            Console.WriteLine(31);
            //            break;
            //        case 9:
            //            Console.WriteLine(30);
            //            break;
            //        case 10:
            //            Console.WriteLine(31);
            //            break;
            //        case 11:
            //            Console.WriteLine(30);
            //            break;

            //        case 12:
            //            Console.WriteLine(31);
            //            break;
            //        default:
            //            Console.WriteLine("Enter correct Number");
            //            break;

            //    }



            //}




            #endregion
            #region Problem 12


            //   12 - Write a program to create a Simple Calculator.

            //____________________________Solution_______________________________//

            //Console.Write("Enter Number 1 : ");
            //int num1=int.Parse(Console.ReadLine());

            //Console.Write("Enter Oprtator  [ + , - , * , / , % ] :  ");
            //char c = char.Parse(Console.ReadLine());

            //Console.Write("Enter Number 2 : ");
            //int num2 = int.Parse(Console.ReadLine());

            //switch (c)
            //{

            //    case '+':
            //        Console.WriteLine($"{num1} + {num2} = {num1+num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //        break;
            //    case '%':
            //        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            //        break;
            //    default:
            //        Console.WriteLine("Enter Correct Number !");
            //        break;


            //}






            #endregion
            #region Problem 13



            //13 - Write a program to allow the user to enter a string and print the REVERSE of it.

            //____________________________Solution_______________________________//


            //Console.Write("Enter String Text : ");
            //string String= Console.ReadLine();

            //for (int i = String.Length-1; i >= 0; i--)
            //{
            //    Console.Write(String[i]+" ");
            //}



            #endregion
            #region Problem 14


            //   14 - Write a program to allow the user to enter int and print the REVERSED of it.
            //____________________________Solution_______________________________//


            //Console.Write("Enter Number : ");
            //string Number = Console.ReadLine();

            //for (int i = Number.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(Number[i]);


            #endregion
            #region Problem 15

            //   15 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //   est Data:
            //   Input starting number of range: 1
            //   nput ending number of range: 50
            //   
            //   xpected Output :
            //   he prime number between 1 and 50 are:
            //              2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            //   



            //____________________________Solution_______________________________//

            //int start = 1;
            //int end = 50;
            
            //if (start == 1)
            //{
            //    start++;
            //}
            //for (int i = start; i <= end; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {

            //        if (i % j == 0)
            //        {

            //            goto ask;

            //        }


            //    }
            //    Console.Write(i + " ");

            //ask: Console.Write("");
            //}


            #endregion
            #region Problem 16


            //   16 - .Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //   est Data:
            //              Enter a number to convert: 25
            //   xpected Output :
            //   he Binary of 25 is 11001.


            //____________________________Solution_______________________________//

            //Console.Write("Enter Decimal Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Stack<int> stack = new Stack<int>();

            //while (num > 0)
            //{
            //    if (num % 2 == 0)
            //    {
            //        stack.Push(0);
            //    }
            //    else
            //    {
            //        stack.Push(1);
            //    }

            //    num = num / 2;


            //}


            //foreach (int item in stack)
            //{
            //    Console.Write(item);
            //}
            #endregion



     


         
            #endregion



          



        }
    }
}
