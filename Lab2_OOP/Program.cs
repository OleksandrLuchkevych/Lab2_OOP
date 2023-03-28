using System;
using System.Globalization;

namespace Lab2_OOP
{
    internal class Program
    {
        struct Dog
        {
            public string Name;
            public string Mark;
            public int Age;

            public override string ToString()
            {
                return string.Format("Dog Name is " + Name + "; " + " Mark is " + Mark + "; " + " Age is " + Age);
            }
        }
        enum HTTPError 
        {
            
            Bad_Request = 400,
            Unauthorized = 401,
            Payment_Required = 402,
            Forbidden = 403,
            Not_Found = 404,
            Method_Not_Allowed = 405

        }
        static void Main(string[] args)
        {
            //Перше завдання
            Console.WriteLine("Task 1:");
            Console.Write("Write 3 float numbers and use ';' to divide numbers : ");
            double[] doubleNums;

            doubleNums = Array.ConvertAll(Console.ReadLine().Split(';'), double.Parse);// split роздільник

            if (doubleNums.All(element => element <= 5 && element >= -5))// => видалить елемент після того як вийду з дужок
            {
                Console.WriteLine("All numbers belong to the range [-5;5]");
            }
            else
                Console.WriteLine("At least one number does not belong to the range [-5;5]");

            //Console.WriteLine(doubleNums.All(element => element <= 5 && element >= -5) ? "All numbers belong to the range [-5;5]" : "At least one number does not belong to the range [-5;5]");

            //Друге завдання
            Console.WriteLine("Task 2:");

            int[] intNums;
            Console.Write("Write 3 int numbers and use ';' to divide numbers : ");

            intNums = Array.ConvertAll(Console.ReadLine().Split(';'), int.Parse);

            Console.WriteLine("Max number is " + intNums.Max() + "  " + "Min number is " + intNums.Min());

            //Третє завдання
            Console.WriteLine("Task 3:");
            Console.Write("Write error number (400, 401, 402, 403, 404, 405) : ");
            int errorCode = int.Parse(Console.ReadLine());

            if (Enum.GetName(typeof(HTTPError), errorCode) != null)//getName повертає ім'я елементу з енаму
                                                                   //за його значенням, typeof повретає тип даних в енамі,
                                                                   //errorCode назва змінної
            {
                Console.WriteLine($"Your error is {Enum.GetName(typeof(HTTPError), errorCode)}");
            }

            else
            {
                Console.WriteLine("There are no error with this code!");
            }

            //Четверте завдання
            Console.WriteLine("Task 4:");

            Dog dog = new Dog();

            
            Console.WriteLine("Write dog name: ");
            dog.Name = Console.ReadLine(); 
            Console.WriteLine("Write dog mark: ");
            dog.Mark = Console.ReadLine();
            Console.WriteLine("Write dog age: ");
            dog.Age = int.Parse(Console.ReadLine());

              
            Console.WriteLine(dog.ToString());

        }
    }
}