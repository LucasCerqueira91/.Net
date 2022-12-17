
namespace PersonExec
{
    public class Person
    {
        public string Name;

        public int Age;
    }
}

namespace PersonExec
{
    public class Employee
    {
        public string NameEmployee;
        public double SalaryEmployee;
    }
}



using System;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Globalization;

namespace PersonExec
{
    public class Program
    {
        static void Main(string[] args)
        {
            //            EXERCÍCIO 01:
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            //velha.
            //Exemplo:
            //Dados da primeira pessoa:
            //Nome: Maria
            //Idade: 17
            //Dados da segunda pessoa:
            //Nome: Joao
            //Idade: 16
            //Pessoa mais velha: Maria

            //Person FirstPerson = new Person();
            //Person SecondPerson = new Person();

            //Console.WriteLine("Hi type the name of the first Person");
            //FirstPerson.Name = Console.ReadLine();
            //Console.WriteLine("What's the first person's age? ");
            //FirstPerson.Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Hi type the name of the second Person");
            //SecondPerson.Name = Console.ReadLine();
            //Console.WriteLine("What's the second person's age? ");
            //SecondPerson.Age = Convert.ToInt32(Console.ReadLine());

            //if (FirstPerson.Age > SecondPerson.Age)
            //{
            //    Console.WriteLine("The olderst person is: " + FirstPerson.Name);
            //}
            //else
            //{
            //    Console.WriteLine("The olderst person is: " + SecondPerson.Name);
            //}

            //            EXERCÍCIO 02:
            //Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
            //médio dos funcionários.
            //Exemplo:
            //            Dados do primeiro funcionário:
            //Nome: Carlos Silva
            //Salário: 6300.00
            //Dados do segundo funcionário:
            //Nome: Ana Marques
            //Salário: 6700.00
            //Salário médio = 6500.00


            Employee FirstEmployee = new Employee();
            Employee SecondEmployee = new Employee();

            Console.WriteLine("Hi type the name of the first employee");
            FirstEmployee.NameEmployee = Console.ReadLine();
            Console.WriteLine("What's the first employee's salary? ");
            FirstEmployee.SalaryEmployee = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.WriteLine("Hi type the name of the second employee");
            SecondEmployee.NameEmployee = Console.ReadLine();
            Console.WriteLine("What's the second employee's salary? ");
            SecondEmployee.SalaryEmployee = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salaryMedia = (FirstEmployee.SalaryEmployee + SecondEmployee.SalaryEmployee)/2;

            Console.WriteLine("The salary's media of your employees is: " + salaryMedia.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
