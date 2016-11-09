using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiToanBOM
{
    class Program
    {
        public static void InGiaTri(IEnumerable myCollection)
        {
            IEnumerator myEnumerator = myCollection.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.WriteLine("{0} ", myEnumerator.Current);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Vi du minh hoa Stack trong C#");
            Console.WriteLine("-------------------------------------");
            SortedList ht = new SortedList();
            Stack stack = new Stack();

            stack.Push('4');
            stack.Push('5');
            stack.Push('8');
            stack.Push('7');
            stack.Push('3');

            Console.WriteLine("Thung chua Bom ban dau la ");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Cac tri trong myStack:\t");
            InGiaTri(stack);
            Console.WriteLine("\nDa day ra\t{0}", stack.Pop());
            Console.WriteLine("Cac gia tri trong myStack:\t");
            InGiaTri(stack);
            Console.WriteLine("\nDa day ra\t{0}", stack.Pop());
            Console.WriteLine("Cac gia tri trong myStack:\t");
            InGiaTri(stack);
            Console.WriteLine("Peek:\t{0}", stack.Peek());
            Console.WriteLine("Cac gia tri trong myStack:\t");
            InGiaTri(stack);
            Console.ReadLine();
        }
    }
}
