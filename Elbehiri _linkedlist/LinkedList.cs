using Elbehiri_linkedlist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Elbehiri_linkedlist
{
    internal class MyLinkedList
    {
        private Node _head;

        // check out if the newadd is added or not in the linkedlist
        private bool ChkAdd = false;
        Node _Prev = new Node("");
        
        // add node in the linkedlist
        public void Add(string payload)
        {
            ChkAdd = false;
            Node NewNode = new Node(payload);

         // condition if the linkedlist is null
            if (_head == null)
            {
                _head = NewNode;
                _Prev = NewNode;
                ChkAdd = true;

                return;
            }
        // make a swap to sort the names 
            if (String.Compare(_head.Data, NewNode.Data) > 0)
            {
                ChkAdd = true;
                Node temp = _head;
                _head = NewNode;
                _head.Next = temp;
                return;
            }
        // make a loop to place the newnode in the sortedlist

            Node current = _head;
            _Prev = _head;
            while (current.Next != null)
            {
                if (String.Compare(current.Data, NewNode.Data) > 0)
                {
                    NewNode.Next = current;
                    _Prev.Next = NewNode;
                    return;
                }
                if (current.Next.Next == null)
                {
                    if (String.Compare(current.Next.Data, NewNode.Data) > 0)
                    {
                        ChkAdd = true;
                        Node temp = current.Next;
                        current.Next = NewNode;
                        NewNode.Next = temp;
                    }
                }
                _Prev = current;
                current = current.Next;
            }

         // check out if the newadd is added or not , and add it in the lionkedlist if not.
            if (ChkAdd == false)
            {
                if (String.Compare(current.Data, NewNode.Data) < 0)
                {
                    current.Next = NewNode;
                    return;
                }
                else
                {
                    Node temp = _Prev.Next;
                    _Prev.Next = NewNode;
                    NewNode.Next = temp;
                    return;
                }
            }
            current = current.Next;
        }
        // ...make a search method.
        public bool Search(string payload)
        {
            Node current = _head;
            if (_head.Next == null && String.Compare(current.Data, payload) == 0)
            {
                return true;

            }
            while (current.Next != null)
            {
                if (String.Compare(current.Data, payload) == 0)
                {
                    return true;

                }
                current = current.Next;
            }
            if (current.Next == null && String.Compare(current.Data, payload) == 0)
            {
                return true;

            }
            return false;
        }

        // make a remove method
        public void Remove(string payload)

        {
            Node current = _head;
            _Prev = _head;
            while (current.Next != null)
            {
                if (String.Compare(current.Data, payload) == 0)
                {
                    if (_head == current)
                    {
                        _head = current.Next;
                        return;
                    }
                    else
                    {
                        _Prev.Next = current.Next;
                        return;
                    }
                }

                _Prev = current;
                current = current.Next;
            }
           
            if (_head.Next == null)
            {
                _head = null;
            }
            else
            {
                _Prev.Next = null;
                return;
            }


        }
        // make a print method
        public void PrintList()
        {
            Node current = _head;
            Console.WriteLine("=====================");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}