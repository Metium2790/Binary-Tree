using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class Node //node class
    {
        public int data;
        public bool flag;
        public Node link;
        public Node LChild; //usage is for the tree
        public Node RChild; //usage is for the tree
        public GList dlink;

        public Node(int d)
        {
            data = d;
            flag = false;
            link = null;
            dlink = null;
            LChild = null;
            RChild = null;
        }

    }

    public class GList //a generalized list which also can be used as a simple LinkedList
    {
        public Node first;

        public void Add(Node d = null, GList l = null) //Adds a node to the list
        {
            if (d != null)
            {
                if (first != null)
                {
                    Node p = first;
                    while (p.link != null)
                    {
                        p = p.link;
                    }
                    p.link = d;
                }
                else
                {
                    first = d;
                }
            }
            else if (l != null)
            {
                if (first != null)
                {
                    Node p = first;
                    while (p.link != null)
                    {
                        p = p.link;
                    }
                    p.link = l.first;
                }
                else
                {
                    first = l.first;
                }
            }
        }


        public void Add_dlink(Node p, Node d = null, GList l = null) //Adds a node to the down list of the chosen node
        {
            if (d != null)
            {
                if (p.flag == false)
                {
                    p.flag = true;
                    GList newlink = new GList();

                    newlink.Add(d);

                    p.dlink = newlink;
                }
                else
                {
                    p.dlink.Add(d);
                }
            }
            else if (l != null)
            {
                if (p.flag == false)
                {
                    p.flag = true;

                    p.dlink = l;
                }
                else
                {
                    p.dlink.Add(l: l);
                }
            }
        }

        public void Display() //Prints out the list
        {
            Node p = first;
            Console.Write("<");
            if (p != null)
            {
                while (p != null)
                {
                    Console.Write(p.data);
                    if (p.flag)
                    {
                        p.dlink.Display();
                    }
                    if (p.link != null)
                        Console.Write(",");
                    p = p.link;
                }
                Console.Write(">");
            }
        }

        public int Depth() //Finds the depth of the generalized list
        {
            int dep = 0;
            int n = 0;
            Node p = first;

            while (p != null)
            {
                if (p.flag == true)
                {
                    n = p.dlink.Depth();
                    if (n > dep)
                    {
                        dep = n;
                    }
                }
                p = p.link;
            }
            return dep + 1;
        }

        public int Allnodes() //finds the total amount of the nodes
        {
            int n = 0;
            Node p = first;

            while (p != null)
            {
                if (p.flag == true)
                {
                    n += p.dlink.Allnodes();
                }
                p = p.link;
                n++;
            }
            return n;
        }

        public void delete(int x) //deletes the chosen data out of the list
        {
            Node q = null;
            Node p = first;
            while (p != null)
            {
                if (p.flag == true)
                {
                    p.dlink.delete(x);
                }
                if (p.data == x)
                {
                    if (q != null)
                    {
                        q.link = p.link;
                        p.link = null;
                        p = q.link;
                    }
                    else
                    {
                        first = p.link;
                        p.link = null;
                        p = first;
                    }
                }
                else
                {
                    q = p;
                    p = p.link;
                }
            }
        }


        public bool Comparison(GList L) //Compares 2 lists with each other. if they're qeual, it returns true. if not it returns false
        {
            bool result = false;
            Node p = first;
            Node q = L.first;

            while (q != null && p != null)
            {
                if (q.flag == true && p.flag == true)
                {
                    result = p.dlink.Comparison(q.dlink);
                    if (p.data == q.data)
                        result = true;
                    q = q.link;
                    p = p.link;
                }
                else if (q.flag == false && p.flag == false)
                {
                    if (q.data != p.data)
                    {
                        result = false;
                        break;
                    }
                    q = q.link;
                    p = p.link;

                }
                else
                {
                    q = q.link;
                    p = p.link;
                    result = false;
                    break;
                }
            }
            return result;
        }

    }
}
