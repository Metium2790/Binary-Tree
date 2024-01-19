using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class NodeQueue //a Simple Queue which stores nodes
    {
        public int Maxsize;
        private Node[] arr; //The Array which datas would be store in
        private int front; //front of the queue
        private int rear; //rear of the queue

        public NodeQueue(int max) //construction method
        {
            Maxsize = max;
            arr = new Node[Maxsize];
            front = -1;
            rear = -1;
        }

        public void push(Node x) //add up a data to the queue
        {
            if (QueueFull())
            {
                Console.WriteLine("Queue is Full!!!");
            }
            else if (QueueEmpty())
            {
                arr[++rear] = x;
                front = rear;
            }
            else
            {
                arr[++rear] = x;
            }
        }

        public Node pop() //deletes a data from the queue and returns it
        {
            if (QueueEmpty())
            {
                return null;
            }
            else
            {
                Node item = arr[front];
                for (int i = 0; i < rear+1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                rear--;
                return item;
            }
        }

        public bool QueueEmpty() //checks if the queue is empty or not
        {
            if (front == rear && front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool QueueFull() //checks if the queue is full
        {
            if (front == 0 && rear == Maxsize - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
