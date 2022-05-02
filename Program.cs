using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            All the following to your application:
            //1.Based on the “Operations” exercises, create a method for each exercise. In a single
            //application, using the most recent version of each exercise;

            //Console.WriteLine("Wich of the 7 exercises you want to see?  ");
            //int user = Convert.ToInt32(Console.ReadLine());
            //if (user == 1)
            //{
            //    Console.WriteLine("Here is the first exercise of Operations");
            //    OperatiosExercOne();
            //}
            //else if (user == 2)
            //{
            //    Console.WriteLine("Here is the second exercise of Operations");
            //    OperatiosExercTwo();
            //}
            //else if (user == 3)
            //{
            //    Console.WriteLine("Here is the third exercise of Operations");
            //    OperatiosExercThree();
            //}
            //else if (user == 4)
            //{
            //    Console.WriteLine("Here is the fourth exercise of Operations");
            //    OperatiosExercFour();
            //}
            //else if (user == 5)
            //{
            //    Console.WriteLine("Here is the five exercise of Operations");
            //    OperatiosExercFive();
            //}
            //else if (user == 6)
            //{
            //    Console.WriteLine("Here is the sixth exercise of Operations");
            //    OperatiosExercSix();
            //}
            //else if (user == 7)
            //{
            //    Console.WriteLine("Here is the seventh exercise of Operations");
            //    OperatiosExercSeven();
            //}
            //else
            //{
            //    Console.WriteLine("Sorry the Operations Exercise just have 7 Questions");
            //}
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


            //    2.Create a method named “SquareRoot” that receives one numeric input(double) and
            ////          returns the mathematical square root value of the same. The number must be a
            ////decimal with two decimal places;
            //    double nu1, result;
            //    Console.WriteLine("Digit a number that you know the mathematical square root of it");
            //    nu1 = Convert.ToDouble(Console.ReadLine());
            //    result = SquareRoot(nu1);
            //    Console.WriteLine("The mathematical square root of " + nu1 + " is " + result.ToString("F2"));
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            ////            3.Create a method named “NumberModule” that receives one numeric input(double)
            ////and returns the module value of the same;

            //double input, module;
            //Console.WriteLine("Digit a number and discover the module value");
            //input = Convert.ToDouble(Console.ReadLine());
            //module = NumberModule(input);

            //Console.WriteLine(" The module of the number " + input + " is " + module.ToString());

            //Console.WriteLine("Digit 3 numbers and see a positive result of the quadratic equation: ");
            //QuadraticEquationPos();


            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //            5.Create a method named “QuadraticEquationNeg” that receives three inputs and
            //           returns the negative value option of the quadratic equation;


            //Console.WriteLine("Digit 3 numbers and see a negative result of the quadratic equation: ");
            //QuadraticEquationNeg();


            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //            6.Create a method named “Factorial” that receives one numeric input(integer) and
            //          returns the factorial value of the input;
            Console.WriteLine("Walcome lets see  a factorial result of a number that you digit ");
            Factorial();


        }
        //            All the following to your application:
        //1.Based on the “Operations” exercises, create a method for each exercise. In a single
        //application, using the most recent version of each exercise;
        //public static void OperatiosExercOne()
        //{
        //    int number1, number2, number3, number4;
        //    Console.WriteLine("Type four numbers and see what's the highest one. Please type different numbers! ");
        //    number1 = Convert.ToInt32(Console.ReadLine());
        //    number2 = Convert.ToInt32(Console.ReadLine());
        //    number3 = Convert.ToInt32(Console.ReadLine());
        //    number4 = Convert.ToInt32(Console.ReadLine());

        //    if (number1 > number2 && number1 > number3 && number1 > number4)
        //    {
        //        Console.WriteLine("The highest one is " + number1 + "!");
        //    }
        //    else if (number2 > number1 && number2 > number3 && number2 > number4)
        //    {
        //        Console.WriteLine("The highest one is " + number2 + "!");
        //    }
        //    else if (number3 > number1 && number3 > number2 && number3 > number4)
        //    {
        //        Console.WriteLine("The highest one is " + number3 + "!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The highest one is " + number4 + "!");
        //    }

        //}
        //public static void OperatiosExercTwo()
        //{
        //    double num1, num2;
        //    Console.WriteLine("Type 2 numbers and see what's the highest of the division one. Please type different numbers! ");
        //    num1 = Convert.ToDouble(Console.ReadLine());
        //    num2 = Convert.ToDouble(Console.ReadLine());

        //    if (num1 > num2)
        //    {

        //        Console.WriteLine("The highest of the division one is " + (num1 / num2) + "!");
        //    }
        //    else
        //    {

        //        Console.WriteLine("The highest of the division one is " + (num2 / num1) + "!");
        //    }
        //}
        //public static void OperatiosExercThree()
        //{
        //    double n1, n2, n3, n4, div1, div2, div3, div4;
        //    Console.WriteLine("Type 2 numbers and see what's the lowest and of the remaining one. The numbers beeing divided ");
        //    n1 = Convert.ToDouble(Console.ReadLine());
        //    n2 = Convert.ToDouble(Console.ReadLine());
        //    n3 = Convert.ToDouble(Console.ReadLine());
        //    n4 = Convert.ToDouble(Console.ReadLine());
        //    div1 = n1 / (n2 + n3 + n4);
        //    div2 = n2 / (n2 + n3 + n4);
        //    div3 = n3 / (n1 + n2 + n4);
        //    div4 = n4 / (n1 + n2 + n3);
        //    if (div1 < div2 && div1 < div3)
        //    {
        //        if (div1 < div4)
        //        {
        //            Console.WriteLine("The lowest number is " + div1 + "!");
        //        }
        //    }
        //    else if (div2 < div3 && div2 < div4)
        //    {
        //        Console.WriteLine("The lowest number is " + div2 + "!");
        //    }

        //    else if (div3 < div4)
        //    {
        //        Console.WriteLine("The lowest number is " + div3 + "!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The lowest number is " + div4 + "!");
        //    }
        //}
        //public static void OperatiosExercFour()
        //{
        //    double nubr1, nubr2, divNubr;
        //    Console.WriteLine("Type 2 numbers and see the division bettween them with two decimal places");
        //    nubr1 = Convert.ToDouble(Console.ReadLine());
        //    nubr2 = Convert.ToDouble(Console.ReadLine());
        //    divNubr = nubr1 / nubr2;

        //    Console.WriteLine("The division with two decimal places is " + divNubr.ToString("F2"));
        //}
        //public static void OperatiosExercFive()
        //{
        //    int numX, numY, mult;
        //    Console.WriteLine("Please type two numbers for verify the multiplication beetween them. Will be return Bizz (for even) or Buzz (for odd)");
        //    numX = Convert.ToInt32(Console.ReadLine());
        //    numY = Convert.ToInt32(Console.ReadLine());
        //    mult = numX * numY;

        //    if (mult % 2 == 0)
        //    {
        //        Console.WriteLine("Bizz!! The number " + mult + " is even");
        //    }
        //    else
        //        Console.WriteLine("Buzz!! The number " + mult + " is odd");

        //}
        //public static void OperatiosExercSix()
        //{
        //    string code;
        //    int number1, number2, number3, number4, numX, numY, mult;
        //    double num1, num2, n1, n2, n3, n4, div1, div2, div3, div4, nubr1, nubr2, divNubr;

        //    Console.WriteLine("Type the code to going to the exercise wanted ex: Md#1 go to the first exercise ");
        //    code = Convert.ToString(Console.ReadLine());



        //    switch (code)
        //    {
        //        case "Md#1":

        //            Console.WriteLine("Type four numbers and see what's the highest one. Please type different numbers! ");
        //            number1 = Convert.ToInt32(Console.ReadLine());
        //            number2 = Convert.ToInt32(Console.ReadLine());
        //            number3 = Convert.ToInt32(Console.ReadLine());
        //            number4 = Convert.ToInt32(Console.ReadLine());

        //            if (number1 > number2 && number1 > number3 && number1 > number4)
        //            {
        //                Console.WriteLine("The highest one is " + number1 + "!");
        //            }
        //            else if (number2 > number1 && number2 > number3 && number2 > number4)
        //            {
        //                Console.WriteLine("The highest one is " + number2 + "!");
        //            }
        //            else if (number3 > number1 && number3 > number2 && number3 > number4)
        //            {
        //                Console.WriteLine("The highest one is " + number3 + "!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("The highest one is " + number4 + "!");
        //            }

        //            break;

        //        case "Md#2":
        //            Console.WriteLine("Type 2 numbers and see what's the highest of the division one. Please type different numbers! ");
        //            num1 = Convert.ToDouble(Console.ReadLine());
        //            num2 = Convert.ToDouble(Console.ReadLine());

        //            if (num1 > num2)
        //            {

        //                Console.WriteLine("The highest of the division one is " + (num1 / num2) + "!");
        //            }
        //            else
        //            {

        //                Console.WriteLine("The highest of the division one is " + (num2 / num1) + "!");
        //            }
        //            break;
        //        case "Md#3":
        //            Console.WriteLine("Type 2 numbers and see what's the lowest and of the remaining one. The numbers beeing divided ");
        //            n1 = Convert.ToDouble(Console.ReadLine());
        //            n2 = Convert.ToDouble(Console.ReadLine());
        //            n3 = Convert.ToDouble(Console.ReadLine());
        //            n4 = Convert.ToDouble(Console.ReadLine());
        //            div1 = n1 / (n2 + n3 + n4);
        //            div2 = n2 / (n2 + n3 + n4);
        //            div3 = n3 / (n1 + n2 + n4);
        //            div4 = n4 / (n1 + n2 + n3);
        //            if (div1 < div2 && div1 < div3)
        //            {
        //                if (div1 < div4)
        //                {
        //                    Console.WriteLine("The lowest number is " + div1 + "!");
        //                }
        //            }
        //            else if (div2 < div3 && div2 < div4)
        //            {
        //                Console.WriteLine("The lowest number is " + div2 + "!");
        //            }

        //            else if (div3 < div4)
        //            {
        //                Console.WriteLine("The lowest number is " + div3 + "!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("The lowest number is " + div4 + "!");
        //            }
        //            break;
        //        case "Md#4":

        //            Console.WriteLine("Type 2 numbers and see the division bettween them with two decimal places");
        //            nubr1 = Convert.ToDouble(Console.ReadLine());
        //            nubr2 = Convert.ToDouble(Console.ReadLine());
        //            divNubr = nubr1 / nubr2;

        //            Console.WriteLine("The division with two decimal places is " + divNubr.ToString("F2"));

        //            break;
        //        case "Md#5":


        //            Console.WriteLine("Please type two numbers for verify the multiplication beetween them. Will be return Bizz (for even) or Buzz (for odd)");
        //            numX = Convert.ToInt32(Console.ReadLine());
        //            numY = Convert.ToInt32(Console.ReadLine());
        //            mult = numX * numY;

        //            if (mult % 2 == 0)
        //            {
        //                Console.WriteLine("Bizz!! The number " + mult + " is even");
        //            }
        //            else
        //                Console.WriteLine("Buzz!! The number " + mult + " is odd");

        //            break;

        //        case "Md#7":

        //            int numb, numb0;
        //            string opt1;

        //            Console.WriteLine("Write two numbers ");
        //            numb = Convert.ToInt32(Console.ReadLine());
        //            numb0 = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine("Wich the operations do you want to do:  SUM |  SUB |  MLT |  DIV ");
        //            opt1 = Convert.ToString(Console.ReadLine());

        //            switch (opt1)
        //            {
        //                case "SUM":
        //                case "sum":
        //                    Console.WriteLine("The result of the operation is " + (numb + numb0));
        //                    break;
        //                case "SUB":
        //                case "sub":
        //                    Console.WriteLine("The result of the operation is " + (numb - numb0));
        //                    break;
        //                case "MLT":
        //                case "mlt":
        //                    Console.WriteLine("The result of the operation is " + (numb * numb0));
        //                    break;
        //                case "DIV":
        //                case "div":
        //                    Console.WriteLine("The result of the operation is " + (numb / numb0));
        //                    break;
        //                default:
        //                    Console.WriteLine("Sorry but we don't have this option try again");
        //                    break;

        //            }
        //            break;
        //        default:
        //            Console.WriteLine("Sorry but we don't have this exercise ");
        //            break;
        //    }


        //}
        //public static void OperatiosExercSeven()
        //{
        //    int numb1, numb2;
        //    string opt;

        //    Console.WriteLine("Write two numbers ");
        //    numb1 = Convert.ToInt32(Console.ReadLine());
        //    numb2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Wich the operations do you want to do:  SUM |  SUB |  MLT |  DIV ");
        //    opt = Convert.ToString(Console.ReadLine());

        //    switch (opt)
        //    {
        //        case "SUM":
        //        case "sum":
        //            Console.WriteLine("The result of the operation is " + (numb1 + numb2));
        //            break;
        //        case "SUB":
        //        case "sub":
        //            Console.WriteLine("The result of the operation is " + (numb1 - numb2));
        //            break;
        //        case "MLT":
        //        case "mlt":
        //            Console.WriteLine("The result of the operation is " + (numb1 * numb2));
        //            break;
        //        case "DIV":
        //        case "div":
        //            Console.WriteLine("The result of the operation is " + (numb1 / numb2));
        //            break;
        //        default:
        //            Console.WriteLine("Sorry but we don't have this option try again");
        //            break;
        //    }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //            2.Create a method named “SquareRoot” that receives one numeric input(double) and
        //          returns the mathematical square root value of the same. The number must be a
        //decimal with two decimal places;

        //public static double SquareRoot(double nu1)
        //{

        //    double result = nu1 * nu1;

        //    return result;

        //}

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //            3.Create a method named “NumberModule” that receives one numeric input(double)
        //and returns the module value of the same;

        //public static double NumberModule(double input)
        //{
        //    double module = input % input;
        //    return module;

        //}

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        //            4.Create a method named “QuadraticEquationPos” that receives three inputs and
        //           returns the positive value option of the quadratic equation;

        //public static void QuadraticEquationPos()
        //{
        //    double a, b, c, delta, x1, x2;

        //    Console.WriteLine("Digit the value of number A: ");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digit the value of number B: ");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digit the value of number C: ");
        //    c = Convert.ToDouble(Console.ReadLine());
        //    delta = Math.Pow(b, 2) - 4 * a * c;
        //    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
        //    x2 = (-b - Math.Sqrt(delta)) / 2 * a;

        //    if (delta > 0)
        //    {
        //        Console.WriteLine("Delta has a value positive equal: " + delta + " and X1 has a value of " + x1);
        //    }
        //    if (delta > 0)
        //    {
        //        Console.WriteLine("Delta has a value positive equal: " + delta + " and X2 has a value of " + x2);
        //    }
        //    if (delta <= 0)
        //    {
        //        Console.WriteLine("Delta has a value negative or equal zero " );
        //    }

        //}


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //            5.Create a method named “QuadraticEquationNeg” that receives three inputs and
        //           returns the negative value option of the quadratic equation;

        //public static void QuadraticEquationNeg()
        //{
        //    double a, b, c, delta, x1, x2;

        //    Console.WriteLine("Digit the value of number A: ");
        //    a = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digit the value of number B: ");
        //    b = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digit the value of number C: ");
        //    c = Convert.ToDouble(Console.ReadLine());
        //    delta = Math.Pow(b, 2) - 4 * a * c;
        //    x1 = (-b + Math.Sqrt(delta)) / 2 * a;
        //    x2 = (-b - Math.Sqrt(delta)) / 2 * a;

        //    if (delta < 0)
        //    {
        //        Console.WriteLine("Delta has a value negative equal: " + delta );
        //    }
        //    else
        //    {
        //        Console.WriteLine("Delta has a value positive or equal zero ");
        //    }

        //}




        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //            6.Create a method named “Factorial” that receives one numeric input(integer) and
        //          returns the factorial value of the input;

        public static void Factorial()
        {
            int num, factorial = 1,count;
            

            Console.WriteLine("Digit a positive and integer number and dicovery a Factorial result of it");
            num = Convert.ToInt32(Console.ReadLine());
            
            if ( num <= 0)
            {
                Console.WriteLine(" Sorry you choose zero or a negative number try again");
            }else if (num > 0)
            {
                for (count = num; count >= 1; count--)
                {
                    factorial *= count;
                }
                Console.WriteLine("The factorial of number " + num + " is " + factorial);
            }

        }



    }
}




