using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {   //simple command access
            Console.WriteLine("1-Make a tree(20 max)");
            Console.WriteLine("2-Add to tree");
            Console.WriteLine("3-Delete something from the tree");
            Console.WriteLine("4-Sum the tree datas");
            Console.WriteLine("5-Find total level of the tree");
            Console.WriteLine("6-Find the total amount of nodes");
            Console.WriteLine("7-Find the total amount of leaves");
            Console.WriteLine("8-Print the Preorder of the tree");
            Console.WriteLine("9-Print the Inorder of the tree");
            Console.WriteLine("10-Print the Postorder of the tree");
            Console.WriteLine("0-EXIT");

            //Array to store the trees
            BinTree[] trees = new BinTree[20];
            int treenum = -1;
            int tree = 0; //amount of the active trees

            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.Write("Trees: ");
                for (int i = 0; i < tree; i++)
                {
                    Console.Write((i + 1) + ",");
                }

                Console.WriteLine("");
                string CMD = Console.ReadLine();

                switch (CMD)
                {
                    case "1":
                        trees[tree] = new BinTree();
                        tree++;
                        Console.WriteLine("Tree maded!!");
                        break;
                    case "2":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Your Data inside the new node: ");
                        int newnode = Int32.Parse(Console.ReadLine());
                        trees[treenum-1].Add(newnode);
                        Console.WriteLine("ADDED");
                        break;
                    case "3":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("The data you want to delete: ");
                        int chosendata = Int32.Parse(Console.ReadLine());
                        trees[treenum-1].Delete(chosendata);
                        Console.WriteLine("DELETED");
                        break;
                    case "4":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Sum of the NODES: " + trees[treenum-1].Sum());
                        break;
                    case "5":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Total level of the Tree: " + trees[treenum-1].Level());
                        break;
                    case "6":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Total amounts of the nodes: " + trees[treenum-1].Nodes());
                        break;
                    case "7":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Total amounts of the Leaves: " + trees[treenum-1].Leaves());
                        break;
                    case "8":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Preorder of the tree: ");
                        trees[treenum-1].Print_Preorder(trees[treenum-1].root);
                        Console.WriteLine("");
                        break;
                    case "9":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Inorder of the tree: ");
                        trees[treenum-1].Print_Inorder(trees[treenum-1].root);
                        Console.WriteLine("");
                        break;
                    case "10":
                        Console.WriteLine("which Tree you want to choose?");
                        treenum = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Postorder of the tree: ");
                        trees[treenum-1].Print_Postorder(trees[treenum-1].root);
                        Console.WriteLine("");
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please use the right command");
                        break;
                }
            }
        }
    }
}//Made by Mohammad Mahdi Mohammadi (AKA Metium)
