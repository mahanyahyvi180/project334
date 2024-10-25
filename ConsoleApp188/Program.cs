using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp188
{
    class Program
    {
        private static double[] doubleElements = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
        private static int[] intElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

        private static Stack<double> doubleStack;
        private static Stack<int> intStack;
        static void Main(string[] args)
        {
            doubleStack = new Stack<double>(5);
            intStack = new Stack<int>(10);

            TestPush(nameof(doubleStack), doubleStack, doubleElements);
            TestPop(nameof(doubleStack), doubleStack);
            TestPush(nameof(doubleStack), intStack, intElements);
            TestPop(nameof(doubleStack), intStack);
        }
    
        private static void TestPush<T>(string name, Stack<T> stack, IEnumerable<T> elements)
        {
            try
            {
                Console.WriteLine($"\n Pushing elements onto{name}");

                foreach (var element in elements)
                {
                    Console.Write($"{element}");
                    stack.Push(element);
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\n Message:{exception.Message}");
                Console.Error.WriteLine(exception.StackTrace);
            }
           
        }
        private static void TestPop<T>(string name, Stack<T> stack)
        {
            try
            {
                Console.WriteLine($"\n Popping elements from{name}");

                T popValue;

                while (true)
                {
                    popValue = stack.Pop();
                    Console.Write($"{popValue}");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.WriteLine($"\n Message:{exception.Message}");
                Console.WriteLine(exception.StackTrace);
            }
            Console.ReadLine();
           
        }
                }
            }
          





        
            
               
                
            
                
            
        
    

