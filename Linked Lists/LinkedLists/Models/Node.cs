using System;

namespace LinkedLists.Models
{
    public class Node<T> : IEquatable<Node<T>>
    {
        public Node<T> Next { get; set; } = null;
        public T Data { get; private set; }

        public Node(T data)
        {
            Data = data;
        }

        public void Append(T newData)
        {
            Node<T> end = new Node<T>(newData);
            var node = this;
            while (node.Next != null)
            {
                node = node.Next;
            }
            node.Next = end;
        }

        public Node<T> Delete(T data)
        {
            var n = this;
            if(n.Data.Equals(data))
            {
                return this.Next;
            }

            while (n.Next != null)
            {
                if (n.Next.Data.Equals(data))
                {
                    n.Next = n.Next.Next;
                    return this;
                }
                n = n.Next;
            }
            return this;
        }

        public bool Equals(Node<T> other)
        {
            var node = this;
            var otherNode = other;
            while(node.Next != null)
            {
                if (!node.Data.Equals(otherNode.Data))
                    return false;

                node = node.Next;
                otherNode = otherNode.Next;
            }

            node = this;
            otherNode = other;

            while(otherNode.Next != null)
            {
                if (!node.Data.Equals(otherNode.Data))
                    return false;

                node = node.Next;
                otherNode = otherNode.Next;
            }

            return true;
        }
    }
}
