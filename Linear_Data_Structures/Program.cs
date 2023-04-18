using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Structures
{
    class Program
    {
        //Normal lists use arrays for storage, while linked lists are stored by having each element remember the previous and/or next element. While this makes regular lists better for accessing based
        //on index, linked lists are better for adding and removing elements in the middle of the list, as rather than rearranging an array, the computer merely needs to change the previous/next element
        //values for a couple elements. 

        //In a stack, elements are only added to the top of the stack, and elements can only be removed from the top of the stack. In a queue, elements can only be added to the end of the queue while
        //they can only be removed from the beginning of the queue. Stacks are for when you want to deal with the newest element in the list, queues are for when you want to deal with the oldest element. 

        //Stacks are used to keep interact with the newest elements of a sequence. They are useful for things such as undo buttons, as the newest actions can be easily accessed in order. 

        //Arrays are lists with fixed lengths. While resizing an array is expensive, if a set of data is going to be a fixed length, an array would be more optomized. This is especially important when
        //designing software intended for use on low-power devices. 

        static void Main(string[] args)
        {


            //have the user input some integers, then print them to the console in reverse order. 
            void StackDemonstration()
            {
                Console.WriteLine("(stack demo)Enter a space-separated sequence of integers");

                string[] integers = Console.ReadLine().Split(' ');

                Stack<int> intStack = new Stack<int>();

                //add each integer to the stack.
                foreach (string integer in integers)
                {
                    //ensure that integer is valid, restart the function if not. 
                    try
                    {
                        int.Parse(integer);
                    }
                    catch
                    {
                        Console.WriteLine(integer + " is not a valid integer");
                        StackDemonstration();
                        return;
                    }

                    intStack.Push(int.Parse(integer));
                }

                //pop each integer in the stack.
                while (intStack.Count > 0)
                {
                    Console.WriteLine(intStack.Pop());
                }
            }

            //count how many times each integer occurs in an array.
            void ArrayDemonstration()
            {
                Console.WriteLine("(array demo)Enter a space-separated sequence of integers");

                string[] integers = Console.ReadLine().Split(' ');
                Dictionary<int, int> intCounts = new Dictionary<int, int>();

                //count how many times each integer occurs.
                foreach (string integer in integers)
                {
                    //ensure that integer is valid, restart the function if not.
                    int parsedInt;
                    try
                    {
                        parsedInt = int.Parse(integer);
                    }
                    catch
                    {
                        Console.WriteLine(integer + " is not a valid integer");
                        ArrayDemonstration();
                        return;
                    }

                    if (intCounts.ContainsKey(parsedInt))
                    {
                        intCounts[parsedInt]++;
                    }
                    else
                    {
                        intCounts[parsedInt] = 1;
                    }
                }

                //print the counts
                foreach (int key in intCounts.Keys)
                {
                    Console.WriteLine(key + ": " + intCounts[key] + " times");
                }
            }

            void QueueDemonstration()
            {
                Queue<int> queue = new Queue<int>();
                int N;
                int M;

                Console.WriteLine("(queue demo)Enter an integer");

                try
                {
                    N = int.Parse(Console.ReadLine());
                    queue.Enqueue(N);
                    M = N;
                }
                catch
                {
                    Console.WriteLine("invalid integer");
                    return;
                }

                while (true)
                {
                    if (queue.Count < 50)
                    {
                        queue.Enqueue(M + 1);
                    }
                    else
                    {
                        break;
                    }

                    if (queue.Count < 50)
                    {
                        queue.Enqueue(2 * M + 1);
                    }
                    else
                    {
                        break;
                    }

                    if (queue.Count < 50)
                    {
                        queue.Enqueue(M + 2);
                    }
                    else
                    {
                        break;
                    }

                    M++;
                    Console.WriteLine(queue.Dequeue());
                }
            }

            StackDemonstration();
            ArrayDemonstration();
            QueueDemonstration();

            //keep showing the console after the last line is written.
            Console.ReadLine();
        }
    }
}
