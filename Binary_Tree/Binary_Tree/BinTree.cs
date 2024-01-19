using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinTree //Binary tree which you can fill it up using level order
    {
        public GList list; //LinkList to store the nodes
        public Node root; //root of the tree

        public BinTree()
        {
            list = new GList();
        }

        public void Add(int x) //function to get the a number as the input
        {
            if (root == null)
            {
                root = new Node(x);
                list.Add(root);
                ListToBinary();
            }
            else
            {
                Node temp = new Node(x);
                list.Add(temp);
                ListToBinary();
            }
        }

        public void ListToBinary() //convert the list to an actual binary tree
        {
            NodeQueue q = new NodeQueue(list.Allnodes());
            Node current = root.link;
            if (root == null)
            {
                return;
            }

            q.push(root);

            while (current!=null)
            {
                Node parent = q.pop();
                Node left = (current);
                Node right = null;

                q.push(left);
                current = current.link;
                if (current!=null)
                {
                    right = current;
                    q.push(right);
                    current = current.link;
                }
                parent.LChild = left;
                parent.RChild = right;
            }


        }

        public void Delete(int x) //you can delete the a node by just simply put a number as input
        {
            list.delete(x);
            ListToBinary();
        }

        public int Sum() //sums all the nodes data and returns it
        {
            Node p = list.first;
            int s = 0;

            while (p != null)
            {
                s += p.data;
                p = p.link;
            }
            return s;
        }

        public int Level() //returns the total level of the tree
        {
            Node p = root;
            int level = 0;
            while (p != null)
            {
                level++;
                p = p.LChild;
            }

            return level-1;
        }

        public int Nodes()
        {
            return list.Allnodes();
        }

        public int Leaves()//return the total amounts of the leaves
        {
            Node p = list.first;
            int leaves = 0;
            while (p != null)
            {
                if (p.LChild == null && p.RChild == null)
                {
                    leaves++;
                }
                p = p.link;
            }
            return leaves;
        }

        public void Print_Inorder(Node r) //prints the tree as InOrder
        {
            if (r != null)
            {
                Print_Inorder(r.LChild);
                Console.Write(r.data+",");
                Print_Inorder(r.RChild);
            }
            else
                return;
        }

        public void Print_Preorder(Node r) //prints the tree as PreOrder
        {
            if (r != null)
            {
                Console.Write(r.data + ",");
                Print_Preorder(r.LChild);
                Print_Preorder(r.RChild);
            }
            else
                return;
        }

        public void Print_Postorder(Node r) //prints the tree as PostOrder
        {
            if (r != null)
            {
                Print_Postorder(r.LChild);
                Print_Postorder(r.RChild);
                Console.Write(r.data + ",");
            }
            else
                return;
        }
    }
}
