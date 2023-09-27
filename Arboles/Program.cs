using Arboles.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Binary_tree My_binary_Tree = new Binary_tree();

            My_binary_Tree.Insertion(40);
            My_binary_Tree.Insertion(60);
            My_binary_Tree.Insertion(20);
            My_binary_Tree.Insertion(100);
            My_binary_Tree.Insertion(80);

            Console.WriteLine("Imprimir arbol en orden antes de eliminar 60...");
            My_binary_Tree.PrintOrder();

            My_binary_Tree.Eliminate(40);

            Console.WriteLine("\nImprimir arbol en orden despues de eliminar 60...");
            My_binary_Tree.PrintOrder();

            int SearchValue = 40;
            bool found = My_binary_Tree.Search(SearchValue);

            if (found)
            {
                Console.WriteLine($"\nEl valor {SearchValue} fue encontrado en el árbol.");
            }
            else
            {
                Console.WriteLine($"\nEl valor {SearchValue} no fue encontrado en el árbol.");
            }
            Console.ReadKey();
        }
    }
}