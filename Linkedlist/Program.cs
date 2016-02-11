using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("It is empty? - "+ list.Empty);
            Console.WriteLine("Count -" + list.Count);
            
            Console.ReadLine();
        }
    }
    public class Node
    {
        /*Constructor:
         * [ ] Node(Object data, Node next)
         * 
         * private field:
         * [ ]Object data - contain the data of the node, what we want to store in the list
         * [ ]Node next - referrence to the next node in the list
         * 
         * public properties:
         * [ ] Data - get and set the data field
         * [ ] Next - get and set the next field
         */
        private object data;
        private Node next;

        public Node (object data, Node next)
        { //???
            this.data = data;
            this.next = next;
        }
        public object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }

    public class LinkedList
    {
        /*Constructor:
         * [ ] LinkedList() - Initialized the private fields
         * 
         * private fields:
         * [ ] Node head - is a referrence to the FIRST node in the list
         * [ ] int size - the current size of the list
         * 
         * public properties:
         * [ ] Empty - if the list is empty
         * [ ] Count - how mant items are in the list
         * [ ] Indexer - Access data like an array
         * 
         * Methods:
         * [ ] Add(int index, object o) - Add item to list at specified index
         * [ ] Add(object o) - Add an item to the END of the list
         * [ ] Remove(int index) - Remove the item in the list at the specified index
         * [ ] Clear() - Clear the list
         * [ ] IndexOf(object o) - gets the index of the item in the list, if not in list return -1
         * [ ] Contain(object o) - if the list contains the object
         * [ ] Get(int index) - Gets item at the specified index
         */
        private Node head;
        private int count;

        public LinkedList()
        {
            this.head = null;
            this.count = 0;
        }

        public bool Empty
        {
            get { return this.count == 0; }
        }
        public int Count
        {
            get { return this.count; }
        }
        public object Add(int index, object o)
        {
            if ( index < 0)
            {
                throw new ArgumentOutOfRangeException("Index " + index);
            }
            if ( index > count)
            {
                index = count;
            }

        }

    }
}

