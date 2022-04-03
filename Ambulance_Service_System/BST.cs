using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Service_System
{
    internal class BST
    {

        public NodeBST root;
        public BST()
        {
            root = null;
        }
        public void insert(NodeBST newNode, BSTTypes type)
        {
            if (root == null)
            {
                root = newNode;
                newNode.parent = null;
            }
            else
            {
                NodeBST node = root;
                while (node != null)
                {
                    if (ECF.findLargestNode(newNode.data, node.data, type) > 0)
                    {
                        if (node.right == null)
                        {
                            node.right = newNode;
                            newNode.parent = node;
                            break;
                        }
                        node = node.right;
                    }
                    else
                    {
                        if (node.left == null)
                        {
                            node.left = newNode;
                            newNode.parent = node;
                            break;
                        }
                        node = node.left;
                    }
                }
            }
        }
        public NodeBST search(string data, BSTTypes type)
        {
            NodeBST node = root;
            while (node != null)
            {
                if (ECF.findLargestNode(node.data, data, type) == 0)
                {
                    return node;
                }
                else if (ECF.findLargestNode(node.data, data, type) < 0)
                {

                    node = node.right;
                }
                else
                {
                    node = node.left;
                }
            }
            return node;
        }
    }

}
