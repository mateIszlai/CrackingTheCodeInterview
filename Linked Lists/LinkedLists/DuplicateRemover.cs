using LinkedLists.Models;
using System.Collections.Generic;

namespace LinkedLists
{
    public class DuplicateRemover
    {
        public Node<int> Remove(Node<int> linkedList)
        {
            var numbers = new HashSet<int>();
            var node = linkedList;
            while (node.Next != null)
            {
                if (numbers.Contains(node.Data))
                {
                    linkedList = linkedList.Delete(node.Data);
                }
                numbers.Add(node.Data);
                node = node.Next;
            }

            return linkedList;
        }
    }
}
