using System;

namespace CycleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //           Application:
            //1. The application receives a number and returns the table of 5. User the for cycle;

            /*  int i;
              Console.WriteLine("The table of 5, type until maximum of multiplication that you wish + 1. Example if you want know the table of 5 until 10 put 11");
              i = Convert.ToInt32(Console.ReadLine());
              int[] array = new int[i];
              Console.WriteLine("The table of 5 until your indication went:  ");

              for (int n = 1; n < array.Length; n++)
              {
                  array[n] = n * 5;
                  Console.WriteLine("5 x " + n + " = " + array[n]);
              }
            */

            //2. Update the application 1 so that the calculated table is based on a provided number by
            //the user. User the for cycle;

            /*
                       int t, n1;
                       Console.WriteLine("What is The Table do you want to know? ");
                       t = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine("The table that your indication went:  ");

                       for (int i = 1; i < 11; i++)
                       {

                           n1 = t * i;
                           Console.WriteLine(t + " x " + i + " = " + n1);
                       }
            */


            //3. The application draws half a tree with the character *. The number of lines is provided by

            //the user. Use the for cycle;

            //Example for number 4:

            //*

            //**

            //***

            //****





            //int lines, count, colum;



            //Console.WriteLine("Draw a half a tree while the number that you are digit ");

            //lines = Convert.ToInt32(Console.ReadLine());



            //Console.WriteLine("Here is  your tree :  ");



            //for (count = 1; count < lines; count++)

            //{

            //    for (colum = 1; colum <= count; colum++)

            //    {



            //        Console.Write("*");



            //    }

            //    Console.WriteLine();

            //}





            //4. The application draws a full tree with the character *. The number of lines is provided by
            //the user. User the for cycle;



            //int lines1, col1, lin1, col2;

            //Console.WriteLine("Draw a tree while the number that you are digit ");
            //lines1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Here is  your tree :  ");

            //for (lin1 = 0; lin1 < lines1; lin1++)
            //{
            //    for(col2 = lin1; col2 < lines1; col2++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (col1 = 0; col1 < lines1; col1++)
            //    {

            //        Console.Write("* ");
            //        if (col1 >= lin1)
            //        {

            //            break;
            //        }

            //    }

            //    Console.WriteLine();
            //}


            //5. The application is identical to application 3, using the Do/While cycle;

            //int lines, count = 1, i = 0;
            //Console.WriteLine("Draw a half a tree while the number that you are digit ");
            //lines = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Here is  your tree :  ");



            //do
            //{

            //    string Linha = new string('*', count);
            //    Console.WriteLine(Linha);

            //    count += 2;

            //    i++;

            //} while (i <= lines);






            //6. The application is identical to application 3, using the While cycle;
            //int lines, count = 1, i = 0;
            //Console.WriteLine("Draw a half a tree while the number that you are digit ");
            //lines = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Here is  your tree :  ");



            //while (i <= lines)
            //{
            //    string Linha = new string('*', count);
            //    Console.WriteLine(Linha);

            //    count += 2;

            //    i++;
            //}


            //7. The application is identical to application 4, using the Do/While cycle;
            //Happy coding!!

            int lines, count = 1, i = 0, colum;
            Console.WriteLine("Draw the number of lines that your tree will have ");
            lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is  your tree :  ");
            colum = lines - 1;


            do
            {
                string espaco = new string(' ', colum);
                string Linha = new string('*', count);
                Console.WriteLine(espaco + Linha);
                colum--;
                count += 2;
                i++;

            } while (i < lines);

        }
    }
}
