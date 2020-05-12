using System;

namespace Pactice.LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var this_ = new Program();
            var sll = new SingleLinkedList();
            this_.InsertLast(sll, 1);
            this_.InsertLast(sll, 2);
            this_.InsertLast(sll, 3);


            Node curNode = sll.head;
            do
            {
                Console.WriteLine($"current node data {curNode.data} points to {curNode.next?.data}");
                curNode = curNode.next;
            } while (curNode != null);
        }

        internal void InsertFront(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            Node new_node = new Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }
        internal Node GetLastNode(SingleLinkedList singlyList)
        {
            Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
