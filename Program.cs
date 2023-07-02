using System;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace StackOdev
{
    class program
    {
        static void main(string[] args)
        {
            Stack MyStack = new Stack();
            int Choice = menu(); 
            while (Choice != 0)
            {
                switch(Choice)
                {
                    case 1:
                        Console.WriteLine("int: "); int = int.Parse(Console.ReadLine()); 
                        MyStack.push(int); break; 
                    case 2:
                        MyStack.pop();break; 
                    case 3: 
                        
                }
            }
            
            while (Choice != 0)
            {

            }
                
        }

         private static int menu()
        {
            int Choice;
            Console.WriteLine("1 - Push");
            Console.WriteLine("2 - Pop");
            Console.WriteLine("3 - Switch"); 
            Choice = int.Parse(Console.ReadLine());
            return Choice;

        }
    }
    class Node
    {
        public int data;
        public Node next; 
        public Node(int data) 
        {
            this.data = data;
            next = null;
        }
    }
    class Stack
    {
        Node top;
        Node last;

        public Stack()
        {
            top = null; 

        }
        public void push(int data)
        {
            Node element = new Node(data);
            if(top == null) 
            {
                top = element;
                Console.WriteLine("Stack has been created..");
            }
            else
            {
                element.next = top; 
                top = element; 
                Console.WriteLine("item added");
            }

        }
        public  int pop(int data)
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty!");
                return -1;
            }
            else
            {
                int x = top.data; 
                top = top.next;
                Console.WriteLine(x + "has been removed from stack");
                return x;
            }
        }
        public void print()
        {
            if( top == null)
                {
                Console.WriteLine("Stack is empty");
                }
            else
            {
                Node temp = top;
                
                while (temp!=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public static void Reverse(Stack<int> stack)
        {
            
            if (stack.Count == 0)
                return;

            int element = stack.Pop();
            Reverse(stack);
            InsertAndRearrange(stack, element);
        }
        public static void InsertAndRearrange(Stack<int> stack, int element)
        {
            
            if (stack.Count == 0)
                stack.Push(element);
            else
            {
                
                int temp = stack.Pop();
                InsertAndRearrange(stack, element);
                
                stack.Push(temp);
            }
        }
    
    }
}