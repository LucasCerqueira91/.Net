using System;






namespace ConsoleApp1

{

    internal class Program

    {

        static void Main(string[] args)

        {









            //            4.The application receives an X number of inputs.It must return the correspondent value on

            //          request, on after each request it must ask the user if it desires another retrieval.The

            //          information must be stored in an array;

            //MainAnswerYes();









            //            Develop an application for each of the points below.

            //When a number is requested, the same must be provided by the user.

            //Applications:

            //1.The application receives five numbers and returns them ordered from lowest to largest.

            //The numbers before being displayed must be stored in an array;



            //int numbers = 5;

            ////int changeNum;

            //Console.WriteLine("Type 5 numbers and the aplication will put them in ascending order ");

            //int[] array = new int[numbers];





            //for (int i = 0; i < numbers; i++)

            //{

            //    array[i] = Convert.ToInt32(Console.ReadLine());

            //}



            //Array.Sort(array);



            ///*

            //for (int ord = numbers - 1; ord >= 1; ord--)

            //{

            //    for (int i = 0; i < ord; i++)

            //    {

            //        if (array[i] > array[i + 1])

            //        {

            //            changeNum = array[i];

            //            array[i] = array[i + 1];

            //            array[i + 1] = changeNum;

            //        }

            //    }

            //}*/







            //for (int i = 0; i <= array.Length; i++)

            //{

            //    Console.WriteLine("The {0}º number is {1}", i + 1, array[i]);

            //}





            //            2.The application receives five numbers and returns them ordered from lowest to largest.

            //The numbers must be stored in an array as they are received;



            //    int num = 5;

            //Console.WriteLine("Type 5 numbers and the aplication will put them in descending order ");

            //int[] size = new int[num];

            //for (int i = 0; i < num; i++)

            //{

            //    size[i] = Convert.ToInt32(Console.ReadLine());



            //}

            //Array.Reverse(size);



            //for (int i = 0; i <= size.Length; i++)

            //{

            //    Console.WriteLine("The {0}º number ordered is {1}", i + 1, size[i]);

            //}





            //            3.The application receives five numbers and returns the average. The initial numbers must

            //be stored in a array;

            //int n = 5;

            //int sum = 0;

            //Console.WriteLine("Type 5 numbers and discovery the average them: ");

            //int[] array = new int[n];

            //for (int i = 0; i < n; i++)

            //{

            //    array[i] = Convert.ToInt32(Console.ReadLine());

            //}



            //foreach (int i in array)

            //{

            //    sum += i;

            //}



            //Console.WriteLine("The Average is {0} ", sum / n);



            //            4.The application receives an X number of inputs.It must return the correspondent value on

            //          request, on after each request it must ask the user if it desires another retrieval.The

            //          information must be stored in an array;

            //static void MainAnswerYes()

            //{

            //    string answer;

            //    int x;

            //    Console.WriteLine("Type a number: ");

            //    x = Convert.ToInt32(Console.ReadLine());

            //    ArrayList arrayList = new ArrayList();

            //    arrayList.Add(x);

            //    //try catch

            //    Console.WriteLine("Do you want a type another number? Type Y/N (YES or NO)");

            //    answer = Console.ReadLine();

            //    while (answer == "y" || answer == "Y")

            //    {





            //        Console.WriteLine("Type a number: ");

            //        x = Convert.ToInt32(Console.ReadLine());

            //        arrayList.Add(x);

            //        Console.WriteLine("Do you want a type another number? Type Y/N (YES or NO)");

            //        answer = Console.ReadLine();

            //        Console.WriteLine(arrayList[0]);

            //    }





            //    if (answer == "n" || answer == "N")

            //    {

            //        foreach (int result in arrayList)

            //        {



            //            Console.WriteLine("Here is your number {0} ", result);

            //        }



            //    }

            //    else

            //    {

            //        Console.WriteLine("Sorry this option don't exist try again");

            //        MainAnswerYes();

            //    }





            //}



            //            5.Create the tic tac toe game.The data must be stored in an array and the request played

            //position is provided by the user with two coordinates.The application must validate it the

            //user play is valid;

            int row, column, moves = 0;
            char player, changePlayer = 'X';
            char[,] table = new char[3, 3];

            while (true)
            {
                Console.Clear();
                Board(table);
                Console.WriteLine("Choose the row");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose the column");
                column = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row " + row + " Column " + column);

                player = changePlayer;
                table[row, column] = player;

                if (changePlayer == 'X')
                {
                    changePlayer = 'O';
                }
                else
                {
                    changePlayer = 'X';
                }

                if (player == table[0, 0] && player == table[0, 1] && player == table[0, 2])
                {
                    Console.WriteLine("The player " + player + " is the Winner!!");
                    
                    break;
                }

                moves = moves + 1;

                if (moves == 9)
                {
                    Console.WriteLine("Draw");
                    break;
                }
            }

        }
        public static void Board(char[,] table)

        {

            Console.WriteLine("__|_0_|_1_|_2_|");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                //Console.Write("Row " + i + ": ");
                Console.Write(i + " | ");

                for (int j = 0; j < table.GetLength(1); j++)

                {
                    Console.Write(table[i, j]);
                    Console.Write(" | ");

                }

                Console.WriteLine();

            }

        }

    }

}