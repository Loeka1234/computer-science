namespace AlgorithmsAndDataStructures.LinkedList
{
    /// <summary>
    ///     Represents a node in a linked list
    /// </summary>
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}