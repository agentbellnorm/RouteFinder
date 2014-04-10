//Route Finder
//By Morgan Bentell
//morgan.bentell@gmail.com
//Version 1.0
//May 2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra_Full
{
    class Node : IComparable
    {
        private string _name;
        private int _id;
        public static int numberOfNodes = 0;


        public string Name { get { return _name; } }
        public int Id { get { return _id; } }

        public Node(string n)
        {
            _name = n;
            _id = ++numberOfNodes;
            _id--;
        }

        public static void Reset()
        {
            numberOfNodes = 0;
        }


        int IComparable.CompareTo(object obj)
        {
            Node n = (Node)obj;
            return string.Compare(this.Name, n.Name);
        }


    }
}
