using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arboles.Clases
{
    class Binary_tree
    {
        private Node Root;

        public Binary_tree()
        {
            Root = null;
        }

        #region Insercion
        public void Insertion(int date)
        {
            Root = RecursiveInsertion(Root, date);
        }

        private Node RecursiveInsertion(Node Current_node, int date)
        {
            if (Current_node == null)
            {
                return new Node(date);
            }
            if (date < Current_node.Value)
            {
                Current_node.Left = RecursiveInsertion(Current_node.Left, date);
            }
            else
            {
                Current_node.Right = RecursiveInsertion(Current_node.Right, date);
            }
            return Current_node;
        }
        #endregion

        #region Eliminar
        public void Eliminate(int date)
        {
            Root = DeleteRecursive(Root, date);
        }

        private Node DeleteRecursive(Node Current_node, int date)
        {
            if (Current_node == null)
            {
                return Current_node;
            }
            if (date < Current_node.Value)
            {
                Current_node.Left = DeleteRecursive(Current_node.Left, date);
            }
            else if (date > Current_node.Value)
            {
                Current_node.Right = DeleteRecursive(Current_node.Right, date);
            }
            else
            {
                if (Current_node.Left == null)
                {
                    return Current_node.Right;
                }
                else if (Current_node.Right == null)
                {
                    return Current_node.Left;
                }
                Current_node.Value = FindMinimumValue(Current_node.Right);
                Current_node.Right = DeleteRecursive(Current_node.Right, Current_node.Value);
            }
            return Current_node;
        }

        private int FindMinimumValue(Node Current_node)
        {
            int MinValor = Current_node.Value;
            while (Current_node.Left != null)
            {
                MinValor = Current_node.Left.Value;
                Current_node = Current_node.Left;
            }
            return MinValor;
        }
        #endregion

        #region Buscar
        public bool Search(int date)
        {
            return RecursiveSearch(Root, date);
        }

        private bool RecursiveSearch(Node Current_node, int date)
        {
            if (Current_node == null)
            {
                return false;
            }
            if (date == Current_node.Value)
            {
                return true;
            }
            if(date < Current_node.Value)
            {
                return RecursiveSearch(Current_node.Left, date);
            }
            else
            {
                return RecursiveSearch(Current_node.Right, date);
            }
        }
        #endregion

        #region Imprimir
        public void PrintOrder()
        {
            RecursivePrintOrder(Root);
        }

        private void RecursivePrintOrder(Node Current_node)
        {
            if (Current_node != null)
            {
                RecursivePrintOrder(Current_node.Left);
                Console.Write(Current_node.Value + "\t");
                RecursivePrintOrder(Current_node.Right);
            }
        }
        #endregion
    }
}