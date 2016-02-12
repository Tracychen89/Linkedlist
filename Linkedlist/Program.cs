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
            list.Add("Test1");
            list.Add("Test2");
            list.Add("Test3");
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
       
        // declare a private object variable named data
        private object data;
        // declare a private Node variable named next
        private Node next;

        // this is a constructor with two argument which is declared above :data and next 
        public Node (object data, Node next)
        { //???
            this.data = data;
            this.next = next;
        }

        // declare a property named Data which return object data type
        public object Data
        { // this property use both get and set accessor so this is a read/write property
            // return private variable data 
            get { return this.data; }
            // assign user specified value to private variable data
            set { this.data = value; }
        }

        // declare a property named Next which return Node data type
        public Node Next
        {// this property use both get and set accessor so this is a read/write property
            // return private Node variable next
            get { return this.next; }
            // assign user specified value to private variable next
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

        // declare private Node data type variable head. Node is a class just like int class ???
        private Node head;
        // declare private int data type variable count
        private int count;

        // creat a public default Constructor (can constructor be private???)
        public LinkedList()
        {// set default values
            // assign null to Node head(both data and next are null???)
            this.head = null;
            // assign 0 to count
            this.count = 0;
        }

        // declare a public property named Empty which return bool data type
        public bool Empty
        {// this property only use get accessor so this is a read only property and return true or fasle
            get { return this.count == 0; }
        }

        // declare a public property named Count which return int data type
        public int Count
        {// this property only use get accessor so this is a read only property and return value of count
            get { return this.count; }
        }

        // creat a method named Add which has object data type output and has two argument int index and object o
        public object Add(int index, object o)
        {
            // use if statement to control the user specified index won't smaller than 0
            if ( index < 0)
            {// if index < 0, throw a exception
                throw new ArgumentOutOfRangeException("Index " + index);
            }
            // use if statement to control the user specified index won't bigger than count
            if ( index > count)
            {// if index > count, assign the heap of count to index
                index = count;
            }

            // current point to the same heap that head point to 
            Node current = this.head;
            // use if statement to deal with Empty is true or index == 0 is ture
            if (this.Empty || index == 0)
            {// when count is 0 and index is 0 
                //creat a Node object and invoke Node class constructor. assign o to data and assign head to next.Then head point to this Node object
                // Node X = new Node();
                // X.data = o;
                // X.Next = head;
                // head = X;
                this.head = new Node(o, this.head);
            }
            // when count is not 0 and index == 0 is fasle
            else
            {// use for loop to process current = current.Next which measn change the heap that current point to until the loop stop
                for (int i = 0; i < index -1; i++ )
                {
                    current = current.Next;
                }
                // Node x = new Node(o, current.Next);
                // x.data = o;
                // x.Next = current.Next;
                // current.Next = x;
                current.Next = new Node(o, current.Next);
                 
            }
            // count++
            count++;
            // return o
            return o;
        }
        public object Add(object o)
        {
            return this.Add(count, o);
        }

    }
}

