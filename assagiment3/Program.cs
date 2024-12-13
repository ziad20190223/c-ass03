namespace assagiment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region assa3=======================================
            #region   problem1
            //Console.WriteLine("please enter your number");
            //int num1=int.Parse(Console.ReadLine());
            //if (num1%3==0&&num1%4==0) 
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion

            #region  problem2

            //Console.WriteLine("please entre your number: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num < 0)
            //{
            //    Console.WriteLine("negative");

            //}
            //else
            //{
            //    Console.WriteLine("positive");

            //}
            #endregion

            #region problem3
            //Console.WriteLine("please enter your 3 number");
            //    int num1=int.Parse(Console.ReadLine());
            //    int num2 = int.Parse(Console.ReadLine());
            //    int num3 = int.Parse(Console.ReadLine());
            //int maxNum, minNum;
            //maxNum=Math.Max(Math.Max(num1,num2),num3);
            //minNum = Math.Min(Math.Min(num1, num2), num3);
            //Console.WriteLine("the max number :: " + maxNum);
            //Console.WriteLine("the min number :: " + minNum);



            #endregion

            #region problem4
            //Console.WriteLine("please enter your number");
            //int num1=int.Parse(Console.ReadLine());
            //if (num1%2==0)
            //{ 

            //    Console.WriteLine("even");
            //}
            //else
            //{
            //  Console.WriteLine("odd");
            //}
            #endregion

            #region prebolem5
            //Console.WriteLine("please enter your char");
            //char ch=char.ToLower(Console.ReadKey().KeyChar);
            //string vowels= "aeiou";
            //if(vowels.Contains(ch))
            //{
            //    Console.WriteLine("\nVowels");
            //}
            //else
            //{
            //    Console.WriteLine("\nConsonant");
            //}

            #endregion

            #region problem 7

            //Console.WriteLine("enter your number ");
            //    int num= int.Parse (Console.ReadLine());
            //for (int i = 1; i < 13; i++)
            //{
            //    Console.Write(" "+num * i);
            //}
            #endregion

            #region problem 9
            //Console.WriteLine("please enter 2 number");
            // int num1=int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int res = 1;
            //for (int i = 0; i < num2; i++)
            //{
            //    res *= num1;
            //}
            //Console.WriteLine("the result     " + res);

            #endregion

            #region problem10
            //int subjects, total_marks=0;
            //Console.WriteLine("enter 5 subjects");
            //for (int i = 0; i < 5; i++) 
            //{
            //    subjects=int.Parse(Console.ReadLine());
            //    total_marks += subjects;
            //}
            //Console.WriteLine("total_mark   :" + total_marks);
            //Console.WriteLine("Average Marks :" + total_marks / 5);
            //Console.WriteLine("Percentage :"+ (double)total_marks/500*100);
            #endregion

            #region problem 11 month

            //Console.Write("Enter Month Number: ");
            //int month = int.Parse(Console.ReadLine());

            //int daysInMonth = 0;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        daysInMonth = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        daysInMonth = 30;
            //        break;
            //    case 2:
            //        // Handle February 
            //        daysInMonth = 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + daysInMonth);
            #endregion

            #region problem17 points
            //Console.WriteLine("please enter point 1 (x1,y1)");
            //    int x1 = int.Parse(Console.ReadLine());
            //    int y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter point 2 (x2,y2)");
            //     int x2 = int.Parse(Console.ReadLine());
            //     int y2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("please enter point 1 (x3,y3)");
            //      int x3 = int.Parse(Console.ReadLine());
            //      int y3 = int.Parse(Console.ReadLine());
            ////calc area from three point
            //int area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            //if (area == 0)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");

            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");

            //}

            #endregion

            #region  problem18 worker

            //Console.WriteLine("Enter the time taken to complete the task (in hours):");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken <= 3)
            //{
            //    Console.WriteLine("Highly Efficient");
            //}
            //else if (timeTaken > 3 && timeTaken <= 4)
            //{
            //    Console.WriteLine("Increase Speed");
            //}
            //else if (timeTaken > 4 && timeTaken <= 5)
            //{
            //    Console.WriteLine("Provided with Training");
            //}
            //else
            //{
            //    Console.WriteLine("Required to Leave the Company");
            //}


            #endregion

            #region problem21 value type
            //int num1 = 15;
            //int num2 = num1;
            //num1 = 20;
            //     Console.WriteLine("num1: " + num1); 
            //      Console.WriteLine("num2: " + num2);


            #endregion

            #region 22value type
            //unsafe
            //{
            //    int* num1 = stackalloc int[1];
            //    *num1 = 10;
            //    int* num2 = num1;
            //    *num1 = 20;
            //    Console.WriteLine("num1: " + *num1);
            //    Console.WriteLine("num2: " + *num2);
            //}
            #endregion

            #region  23ternary op
            //int d = Convert.ToInt32((30 > 20) ? 1 : 0);
            #endregion

            #region  ==========25
            // output    12    7
            #endregion


            #endregion


        }
    }
}