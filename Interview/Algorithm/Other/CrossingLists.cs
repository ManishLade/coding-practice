using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.Data_Structure;

namespace Interview.Algorithm.Other
{
    // 检查两个单链表是相交
    class CrossingLists
    {
        public static void Check()
        {
            // List 1 nodes
            Node _list1_node2 = new Node(2);
            Node _list1_node3 = new Node(3);

            // List 2 nodes
            Node _list2_node2 = new Node(11);
            Node _list2_node3 = new Node(12);
            Node _list2_node4 = new Node(13);
            Node _list2_node5 = new Node(14);

            // Public nodes
            Node _public_node1 = new Node(20);
            Node _public_node2 = new Node(21);
            Node _public_node3 = new Node(22);

            // List 1
            LinkedList _list1 = new LinkedList(1);
            _list1.Add(_list1_node2);
            _list1.Add(_list1_node3);
            _list1.Add(_public_node1);
            _list1.Add(_public_node2);
            _list1.Add(_public_node3);

            // List 2
            LinkedList _list2 = new LinkedList(10);
            _list2.Add(_list2_node2);
            _list2.Add(_list2_node3);
            _list2.Add(_list2_node4);
            _list2.Add(_list2_node5);
            _list2.Add(_public_node1);

            // Start to check
            if (_list1.GetLastNode() == _list2.GetLastNode())
                System.Console.WriteLine("Crossing!");
            else
                System.Console.WriteLine("Not crossing!");
        }
    }
}