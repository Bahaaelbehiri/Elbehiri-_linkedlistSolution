using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elbehiri_linkedlist
{
    internal class Node
    {
        public string Data { get; set; }
        public Node Next;
        public Node(string data)
        {
            Data = data;
        }
        public Node(string data, Node next)
        {
            Data = data;
            Next = next;
        }


    }
}