using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingDoubleLinkedList();
        }
        static void UsingDoubleLinkedList()
        {
            DoubleLinkedList<int> doubleLinkedList = new DoubleLinkedList<int>();
            doubleLinkedList.PushBack(5);
            doubleLinkedList.PushBack(124);
            doubleLinkedList.PushBack(23);
            doubleLinkedList.PushBack(35);
            doubleLinkedList.PushBack(12);
            doubleLinkedList.PushBack(62);
            doubleLinkedList.PushBack(83);
            doubleLinkedList.PushBack(74);
            //Console.WriteLine("Value: {0}", doubleLinkedList.Last.Value);
            //Console.WriteLine("Count: {0}", doubleLinkedList.Count);
            foreach (var item in doubleLinkedList)
            {
                
            }
        }
    }
}
