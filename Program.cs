using System;

namespace SelectionStatementExercise2
{
    class Program
    {
        static void Main(string[] args)


            Console.WriteLine("What is your favorite subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())


    {

            case "math":
                Console.WriteLine("I love math!");
            break;

            case "science":
                Console.WriteLine("I love science!");
            break;

            case "gym":
                Console.WriteLine("I love gym class!");
            break;

            case "history":
                Console.WriteLine("I love history!");
            break;

            case "english":
                Console.WriteLine("I love english"!);
            break;

            default:
                Console.WriteLine("I don't know that subject!");
            break;

            //end of code    
    }
}

