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
            Console.WriteLine("Bài toán Chuyển Bom");
            Console.WriteLine("--------------------");
            SortedList ht = new SortedList();
            Stack stack = new Stack();

            stack.Push('4');
            stack.Push('5');
            stack.Push('8');
            stack.Push('7');
            stack.Push('3');

            Console.WriteLine("Thung chua Bom ban dau la :");
            foreach (char c in stack)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();
            Console.Realine();
        }
    }
}
