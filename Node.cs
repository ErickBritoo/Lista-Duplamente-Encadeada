namespace ListaDuplamenteEncadeada
{
    internal class Node
    {
        public string Item { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }

        public Node(string item, Node prev = null, Node next = null)
        {
            Item = item;
            Prev = prev;
            Next = next;
        }

        public override string ToString()
        {
            string prevItem = Prev?.Item ?? "Nulo";
            string nextItem = Next?.Item ?? "Nulo";
            return $"[{prevItem} <- {Item} -> {nextItem}]";
        }

    }
}
