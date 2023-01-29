
/*
 Task 4:
Write Unit Tests to test the given program:

LO5: 
Design and perform tests on algorithms to verify.
Use the Arrange-Act-Assert (AAA) syntax to implement the Unit tests. 10 marks
Write 5 tests – two that passes and three that fails. 25 marks
 */

using System;

namespace Q4_UnittestApp
{
    public class Program
    {
        double c;
        public double SumofSquareOfTwoNumbers(double num1, double num2)
        {
            c = (num1 * num1) + (num2 * num2);
            Console.Write(c);
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
