using System;

namespace SimpleCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Function Selector";
            //Selector selector = new Selector();
            //selector.start();



        
    // public   class Selector
      //  {
            bool calculation = true;
            double num1 = 0; double num2 = 0;
            const int n = 5;
            double result=0;
            int[] resultArray = new int[n];

            int[] arrayOne = new int[n] { 1, 2, 3, 4, 5 };
            int[] arrayTwo = new int[n] { 5, 4, 3, 2, 1 };
            //public void start()
            //{
            while (calculation)
            {

                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t1 : Add");
                Console.WriteLine("\t2 : Subtract");
                Console.WriteLine("\t3 : Multiply");
                Console.WriteLine("\t4 : Divide");
                Console.WriteLine("\t5 : Array addition { 1, 2, 3, 4, 5 } and  { 5, 4, 3, 2, 1 } ");
                Console.WriteLine("\t6 : Array Substraction { 1, 2, 3, 4, 5 } and  { 5, 4, 3, 2, 1 } ");

                Console.WriteLine("\t0 : To stop ");
                int.TryParse(Console.ReadLine(), out int selection);
                if (selection == 5 || selection == 6)
                {
                    //Console.WriteLine("enter the sizes of the arrays :");
                    //n = Convert.ToInt32(Console.ReadLine());
                    goto Arraycalculation;

                }
                else
                {
                    //Declare variables and then initialize to zero.

                    //Ask the user to type the first number.
                    Console.WriteLine("Type first number, and then press Enter");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Type second number, and then press Enter");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    goto Arraycalculation;
                }
            

            Arraycalculation:


                    //  resultArray = arrayOne + arrayTwo;
            
                    // Use a switch statement to do the math.
                    switch (selection)
                    {
                        case 1:
                            Console.Clear();
                            //CalculatorFunctions objCalcAdd = new CalculatorFunctions();
                            result = Addition(num1, num2);
                            Console.WriteLine("press any key to continue ");
                            break;
                        case 2:
                            Console.Clear();
                            //CalculatorFunctions objCalcSubstract = new CalculatorFunctions();
                            result = Subtraction(num1, num2);
                            Console.WriteLine("press any key to continue ");
                            break;
                        case 3:
                            Console.Clear();
                            //CalculatorFunctions objCalcMultiply = new CalculatorFunctions();
                            result = Multiplication(num1, num2);
                            Console.WriteLine("press any key to continue ");
                            break;
                        case 4:
                            Console.Clear();
                          //  CalculatorFunctions objCalcDivide = new CalculatorFunctions();
                            result = Division(num1, num2);
                            Console.WriteLine("press any key to continue ");
                            break;
                        //array addition 
                        case 5:
                            Console.Clear();
                          //  CalculatorFunctions objCalcAddArray = new CalculatorFunctions();
                            resultArray =Addition(arrayOne, arrayTwo);
                            break;

                        //array substraction 
                        case 6:
                            Console.Clear();
                            //CalculatorFunctions objCalSubsractArray = new CalculatorFunctions();
                            resultArray = Substraction(arrayOne, arrayTwo);
                            Console.WriteLine("press any key to continue ");
                            break;
                        case 0:
                            Console.Clear();
                            Console.WriteLine(" Thank you for using the program.. exiting program...");
                            Environment.Exit(0);


                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }
                    if (selection == 5 || selection == 6)
                    {
                        if (selection == 5)
                        {
                            Console.Write("The result of adding { 1, 2, 3, 4, 5 } and  { 5, 4, 3, 2, 1 } is : ");
                            for (int i = 0; i < resultArray.Length; i++)
                            {
                                Console.Write("{0} ", resultArray[i]);
                            }
                        }
                        else
                        {
                            Console.Write("The result of substracting  { 1, 2, 3, 4, 5 } and  { 5, 4, 3, 2, 1 } is:  ");
                            for (int i = 0; i < resultArray.Length; i++)
                            {
                                Console.Write("{0} ", resultArray[i]);
                            }
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("press enter key to continue calculation  ");
                        Console.WriteLine("\n");
                        Console.ReadKey();
                    }
                    else
                    {
                    Console.WriteLine("The result is {0}", result);
                        Console.WriteLine("\n");
                        Console.WriteLine("press enter key to continue calculation  ");
                        Console.ReadKey();
                        calculation = false;
                    }


                }

            }

        
     //   public class CalculatorFunctions
      //  {
            // functions start
            public static double Addition(double input_1, double input_2)
            {
                double result = input_1 + input_2;
                return result;
            }

            //Substraction  
            public static double Subtraction(double input_1, double input_2)
            {
                double result = input_1 - input_2;
                return result;
            }

            //Multiplication  
            public static double Multiplication(double input_1, double input_2)
            {
                double result = input_1 * input_2;
                return result;
            }
            //Division  
            public static  double Division(double input_1, double input_2)
            {
                //bool validNumber = false;
                //while (validNumber == false)
                //{

                //    //if  it  a valid integer number i.e . validnuber==true break out of the loop 
                //    if (input_2 != 0)
                //    {

                //        break;
                //    }
                //    else
                //    {//xunit test for divide by zero
                //     //promp re enter age in the right format if the age is still invalid integer i.e validnumber == false 
                //        Console.WriteLine("you are trying to divide by 0 ...exiting  ");
                //        // throw new DivideByZeroException();
                //        Environment.Exit(0);


                //    }
                //}
                if ((input_2 != 0)) 
            {
                double result = input_1 / input_2;
                return result;
            }

            else
            {//custom business logic
                return 0;
            }

                

            }
            //overloaded array addition 
            public static int[] Addition(int[] arrayOne, int[] arrayTwo)
            {
            int[] resArray = new int[arrayOne.Length];

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    resArray[i] = arrayOne[i] + arrayTwo[i];
                }

                return (resArray);
            }
            ////overloaded array substraction 
            public static int[] Substraction(int[] arrayOne, int[] arrayTwo)
            {
            int[] resArray = new int[arrayOne.Length];

                for (int i = 0; i < arrayOne.Length; i++)
                {
                    resArray[i] = arrayOne[i] - arrayTwo[i];
                }

                return (resArray);
            }
        
    }
}

