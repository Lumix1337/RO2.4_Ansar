using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Ex1
        Console.WriteLine("Enter two numbers");
        double num = double.Parse(Console.ReadLine());
        double num1 = double.Parse(Console.ReadLine());

        if (num > num1)
        {
            Console.WriteLine($"{num} is higher then {num1}");
        }
        else if (num < num1)
        {
            Console.WriteLine($"{num} is less then {num1}");
        }
        else if (num == num1)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Zero");
        }


        //Console.WriteLine("Enter age:");
        //int num2 = int.Parse(Console.ReadLine());
        //if (num2 > 0) { 
        //    if (num2 < 13)
        //    {
        //        Console.WriteLine("Child");
        //    }
        //    else if (13 <= num2 && num2 <= 19)
        //    {
        //        Console.WriteLine("Teenager");
        //    }
        //    else if (20 <= num2 && num2 < 60)
        //    {
        //        Console.WriteLine("Adult");
        //    }
        //    else {
        //        Console.WriteLine("Senior");
        //    }
        
        //}
        //else
        //{
        //    Console.WriteLine("Enter real age");
        //}

        //Ex2

        Console.WriteLine("Enter any number:");
        int num22 = int.Parse(Console.ReadLine());
        if (num22 > 5 && num22 < 10)
        {
            Console.WriteLine("Your number is higher then 5 and less then 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }


        //Ex3

        Console.WriteLine("Enter any number:");
        int num3 = int.Parse(Console.ReadLine());
        if(num3 == 5 || num3 == 10){
            Console.WriteLine("Your number either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        //Ex4/Ex5
        Console.WriteLine("Enter deposit number");
        double num4 = double.Parse(Console.ReadLine());
        if (num4 > 0 && num4 < 100) {
            Console.WriteLine($"Your deposit: {(num4 * 0.05) + num4}, your interest: 5%");
        }
        else if ( num4 > 100 && num4 < 200)
        {
            Console.WriteLine($"Your deposit: {(num4 * 0.07) + num4}, your interest: 7%");
        }
        else {  
            Console.WriteLine($"Your deposit: {(num4 * 0.1) + num4}, your interest: 10%"); 
        }

        //Ex6/Ex7
        Console.Write("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter operation number: (+, -, *)");
        string operation = Console.ReadLine();


        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result of addition: {a + b}");
                break;
            case "-":
                Console.WriteLine($"Result of subtraction: {a - b}");
                break;
            case "*":
                Console.WriteLine($"Result of multiplication: {a * b}");
                break;
            default:
                Console.WriteLine("Operation is undefined.");
                break;
        }


    }
}