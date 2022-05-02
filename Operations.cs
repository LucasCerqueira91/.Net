using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Applications:
            //  1.The application receives four numbers and see which one is the highest. The result must be returned;
            int number1, number2, number3, number4;
            Console.WriteLine("Type four numbers and see what's the highest one. Please type different numbers! ");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            number4 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3 && number1 > number4)
            {
                Console.WriteLine("The highest one is " + number1 + "!");
            }
            else if (number2 > number1 && number2 > number3 && number2 > number4)
            {
                Console.WriteLine("The highest one is " + number2 + "!");
            }
            else if (number3 > number1 && number3 > number2 && number3 > number4)
            {
                Console.WriteLine("The highest one is " + number3 + "!");
            }
            else
            {
                Console.WriteLine("The highest one is " + number4 + "!");
            }
            //  2.The application receives two number a see which has the highest result of the division of one from the other.The result must be returned;


            double num1, num2;
            Console.WriteLine("Type 2 numbers and see what's the highest of the division one. Please type different numbers! ");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {

                Console.WriteLine("The highest of the division one is " + (num1 / num2) + "!");
            }
            else
            {

                Console.WriteLine("The highest of the division one is " + (num2 / num1) + "!");
            }
            // 3.The application receives four number a see which is the lowest after beaning divided by the remaining. The result must be returned;
            // a aplicação pede 4 numeros  e faz a divisao apos a soma dos restantes.
            // n1 / n2 + n3 + n4
            // n2 / n1 + n3 + n4

            double n1, n2, n3, n4, div1, div2, div3, div4;

            Console.WriteLine("Type 2 numbers and see what's the lowest and of the remaining one. The numbers beeing divided ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());
            div1 = n1 / (n2 + n3 + n4);
            div2 = n2 / (n1 + n3 + n4);
            div3 = n3 / (n1 + n2 + n4);
            div4 = n4 / (n1 + n2 + n3);
            if (div1 < div2 && div1 < div3)
            {
                if (div1 < div4)
                {
                    Console.WriteLine("The lowest number is " + div1 + "!");
                }
            }
            else if (div2 < div3 && div2 < div4)
            {
                Console.WriteLine("The lowest number is " + div2 + "!");
            }

            else if (div3 < div4)
            {
                Console.WriteLine("The lowest number is " + div3 + "!");
            }
            else
            {
                Console.WriteLine("The lowest number is " + div4 + "!");
            }
            //  4.The application receives two number and divides them.The result must be returned, with two decimal places;
            double nubr1, nubr2, divNubr;
            Console.WriteLine("Type 2 numbers and see the division bettween them with two decimal places");
            nubr1 = Convert.ToDouble(Console.ReadLine());
            nubr2 = Convert.ToDouble(Console.ReadLine());
            divNubr = nubr1 / nubr2;

            Console.WriteLine("The division with two decimal places is " + divNubr.ToString("F2"));


            //  5.The application receives two number, calculates the multiplication and return the word “Bizz”when even and “Buzz” when odd;
            int numX, numY, mult;
            Console.WriteLine("Please type two numbers for verify the multiplication beetween them. Will be return Bizz (for even) or Buzz (for odd)");
            numX = Convert.ToInt32(Console.ReadLine());
            numY = Convert.ToInt32(Console.ReadLine());
            mult = numX * numY;

            if (mult % 2 == 0)
            {
                Console.WriteLine("Bizz!! The number " + mult + " is even");
            }
            else
                Console.WriteLine("Buzz!! The number " + mult + " is odd");

            //  6.The application that allows the user to select the application which allows the user to select application of the above wants to execute. The selection if based on providing a selection code(Md#ID#). A Switch must be used;
            //pedir ao utilizador um codigo ( Md#ID = Md#1) 
            string code;

            Console.WriteLine("Type the code to going to the exercise wanted ex: Md#1 go to the first exercise ");
            code = Convert.ToString(Console.ReadLine());



            switch (code)
            {
                case "Md#1":

                    Console.WriteLine("Type four numbers and see what's the highest one. Please type different numbers! ");
                    number1 = Convert.ToInt32(Console.ReadLine());
                    number2 = Convert.ToInt32(Console.ReadLine());
                    number3 = Convert.ToInt32(Console.ReadLine());
                    number4 = Convert.ToInt32(Console.ReadLine());

                    if (number1 > number2 && number1 > number3 && number1 > number4)
                    {
                        Console.WriteLine("The highest one is " + number1 + "!");
                    }
                    else if (number2 > number1 && number2 > number3 && number2 > number4)
                    {
                        Console.WriteLine("The highest one is " + number2 + "!");
                    }
                    else if (number3 > number1 && number3 > number2 && number3 > number4)
                    {
                        Console.WriteLine("The highest one is " + number3 + "!");
                    }
                    else
                    {
                        Console.WriteLine("The highest one is " + number4 + "!");
                    }

                    break;

                case "Md#2":
                    Console.WriteLine("Type 2 numbers and see what's the highest of the division one. Please type different numbers! ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());

                    if (num1 > num2)
                    {

                        Console.WriteLine("The highest of the division one is " + (num1 / num2) + "!");
                    }
                    else
                    {

                        Console.WriteLine("The highest of the division one is " + (num2 / num1) + "!");
                    }
                    break;
                case "Md#3":
                    Console.WriteLine("Type 2 numbers and see what's the lowest and of the remaining one. The numbers beeing divided ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    n2 = Convert.ToDouble(Console.ReadLine());
                    n3 = Convert.ToDouble(Console.ReadLine());
                    n4 = Convert.ToDouble(Console.ReadLine());
                    div1 = n1 / (n2 + n3 + n4);
                    div2 = n2 / (n2 + n3 + n4);
                    div3 = n3 / (n1 + n2 + n4);
                    div4 = n4 / (n1 + n2 + n3);
                    if (div1 < div2 && div1 < div3)
                    {
                        if (div1 < div4)
                        {
                            Console.WriteLine("The lowest number is " + div1 + "!");
                        }
                    }
                    else if (div2 < div3 && div2 < div4)
                    {
                        Console.WriteLine("The lowest number is " + div2 + "!");
                    }

                    else if (div3 < div4)
                    {
                        Console.WriteLine("The lowest number is " + div3 + "!");
                    }
                    else
                    {
                        Console.WriteLine("The lowest number is " + div4 + "!");
                    }
                    break;
                case "Md#4":

                    Console.WriteLine("Type 2 numbers and see the division bettween them with two decimal places");
                    nubr1 = Convert.ToDouble(Console.ReadLine());
                    nubr2 = Convert.ToDouble(Console.ReadLine());
                    divNubr = nubr1 / nubr2;

                    Console.WriteLine("The division with two decimal places is " + divNubr.ToString("F2"));

                    break;
                case "Md#5":


                    Console.WriteLine("Please type two numbers for verify the multiplication beetween them. Will be return Bizz (for even) or Buzz (for odd)");
                    numX = Convert.ToInt32(Console.ReadLine());
                    numY = Convert.ToInt32(Console.ReadLine());
                    mult = numX * numY;

                    if (mult % 2 == 0)
                    {
                        Console.WriteLine("Bizz!! The number " + mult + " is even");
                    }
                    else
                        Console.WriteLine("Buzz!! The number " + mult + " is odd");

                    break;

                case "Md#7":

                    int numb, numb0;
                    string opt1;

                    Console.WriteLine("Write two numbers ");
                    numb = Convert.ToInt32(Console.ReadLine());
                    numb0 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wich the operations do you want to do:  SUM |  SUB |  MLT |  DIV ");
                    opt1 = Convert.ToString(Console.ReadLine());

                    switch (opt1)
                    {
                        case "SUM":
                        case "sum":
                            Console.WriteLine("The result of the operation is " + (numb + numb0));
                            break;
                        case "SUB":
                        case "sub":
                            Console.WriteLine("The result of the operation is " + (numb - numb0));
                            break;
                        case "MLT":
                        case "mlt":
                            Console.WriteLine("The result of the operation is " + (numb * numb0));
                            break;
                        case "DIV":
                        case "div":
                            Console.WriteLine("The result of the operation is " + (numb / numb0));
                            break;
                        default:
                            Console.WriteLine("Sorry but we don't have this option try again");
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("Sorry but we don't have this exercise ");
                    break;
            }



            //  7.The application that receives two number and one operator option and executes the calculation.The result must be returned.
            //     The operation codes are:
            //     • SUM;
            //     • SUB;
            //     • MLT;
            //     • DIV;
            //    . A Switch must be used;

            int numb1, numb2;
            string opt;

            Console.WriteLine("Write two numbers ");
            numb1 = Convert.ToInt32(Console.ReadLine());
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wich the operations do you want to do:  SUM |  SUB |  MLT |  DIV ");
            opt = Convert.ToString(Console.ReadLine());

            switch (opt)
            {
                case "SUM":
                case "sum":
                    Console.WriteLine("The result of the operation is " + (numb1 + numb2));
                    break;
                case "SUB":
                case "sub":
                    Console.WriteLine("The result of the operation is " + (numb1 - numb2));
                    break;
                case "MLT":
                case "mlt":
                    Console.WriteLine("The result of the operation is " + (numb1 * numb2));
                    break;
                case "DIV":
                case "div":
                    Console.WriteLine("The result of the operation is " + (numb1 / numb2));
                    break;
                default:
                    Console.WriteLine("Sorry but we don't have this option try again");
                    break;
              //            8.Add the application on 7 to the application on 6; Applications:
            }
        }
    }
}
    



    


