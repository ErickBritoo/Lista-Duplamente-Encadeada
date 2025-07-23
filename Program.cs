using System.Collections.Generic;

namespace ListaDuplamenteEncadeada
{
    class Program
    {
        static public void Main()
        {
            DLinkedList list = new();

            Node node1 = new("Erick");
            Node node2 = new("Ana");
            Node node3 = new("Maria");

            list.AddFirst(node1);
            list.AddFirst(node2);
            list.AddFirst(node3);

            ExibirItems(list);

            Node node4 = new("Diana");
            DLinkedList.AddAfter(node2, node4);
            
            ExibirItems(list);

        }

        static void ExibirItems(DLinkedList lista)
        {
            Node? atual = lista.Head.Next;
            while (atual != null)
            {
                Console.Write(atual.Item);
                if (atual.Next != null)
                    Console.Write(" <-> ");
                atual = atual.Next;
            }
            Console.WriteLine();
        }

    }
}