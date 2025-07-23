namespace ListaDuplamenteEncadeada
{
    internal class DLinkedList
    {
        public Node Head { get; private set; }
        private Node _tail;
        public int Size;

        public DLinkedList()
        {
            Size = 0;

            Head = new Node(null);
            _tail = new Node(null);

            Head.Next = _tail;
            _tail.Prev = Head;
        }


        // Usar propriedades para retornar informações sem alterar dados.
        // Usar métodos para realizar ações que modificam o objeto;

        public void AddFirst(Node node)
        {
            Node first = Head.Next;

            node.Next = first;
            node.Prev = Head;

            Head.Next = node;
            first.Prev = node;
            Size++;

        }

        public Node RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }

            Node removed = _tail.Prev;

            _tail.Prev = removed.Prev;
            _tail.Prev.Next = _tail;

            removed.Next = null;
            removed.Prev = null;

            Size--;

            return removed;
        }
        public static void AddAfter(Node after, Node node)
        {
            node.Prev = after;
            node.Next = after.Next;

            after.Next.Prev = node;
            after.Next = node;
        }

        public void Remove(Node node)
        {
            if (node == null || node.Prev == null || node.Next == null)
                throw new InvalidOperationException("Nó inválido para remoção.");

            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;

            node.Next = null;
            node.Prev = null;

            Size--;
        }

        public bool IsEmpty => Size == 0;
    }
}
