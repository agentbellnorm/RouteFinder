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
    class Route
    {
        private Stack<string> _nodes;
        private int _totCost;
        private string src;

        public Route()
        {
            _nodes = new Stack<string>();
        }


        public void addNode(string n)
        {
            if (_nodes.Count == 0)
                src = n;
            _nodes.Push(n);
        }

        public void setCost(int c)
        {
            _totCost = c;
        }

        public string[] printRoute()
        {
            int hours = _totCost / 60;
            int minutes = _totCost % 60;
            string[] printString = new string[3];
            printString[0] = "The fastest route from " + _nodes.Peek() + " to " + src + " is:\n\n";
            printString[1] = "";
            while (_nodes.Count > 0)
                printString[1] += _nodes.Pop() + "\n";
            printString[2] = "The total travel time is " + Convert.ToString(hours) + " hours and " + Convert.ToString(minutes) + " minutes";
            return printString;

        }

    }
}
