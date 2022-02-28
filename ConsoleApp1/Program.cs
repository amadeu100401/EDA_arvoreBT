﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaGenetica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            Node root = null;
            root = tree.InsertNode(root, 10);
            tree.InsertNode(root, 20);
            tree.InsertNode(root, 30);
            tree.InsertNode(root, 40);
            tree.LeafNode(root.LeftNode);

            Console.WriteLine(root.LeftNode.LeftNode.Father.Value);
        }
    }

}