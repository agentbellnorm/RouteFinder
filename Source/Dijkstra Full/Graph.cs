//Route Finder
//By Morgan Bentell
//morgan.bentell@gmail.com
//Version 1.0
//May 2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Dijkstra_Full
{
    class Graph
    {
        private List<Node> nodeList;
        int[,] adjMatrix;

        public List<Node> Nodes { get { return nodeList; } }

        public Graph()
        {
            nodeList = new List<Node>();
        }

        public string[] Dijkstra(string _s, string _d)
        {
            Node src = nodeList[getIdByNodeName(_s)];
            Node dst = nodeList[getIdByNodeName(_d)];
            Route rt = new Route();
            HashSet<Node> S = new HashSet<Node>();
            List<string> route = new List<string>();
            S.Add(src);
            HashSet<Node> V = new HashSet<Node>(nodeList);
            int[] d = new int[Node.numberOfNodes]; //shortest distances
            int[] p = new int[Node.numberOfNodes]; //predecessors
            for (int i = 0; i < p.Length; i++)
            {
                if(i != src.Id)
                    p[i] = src.Id;
            } 

            for (int i = 0; i < d.Length; i++)
            {
                d[i] = adjMatrix[src.Id, i];
            }
            
            for (int i = 0; i < Node.numberOfNodes; i++)
            {
                HashSet<Node> nodesOnlyInV = new HashSet<Node>(V);
                nodesOnlyInV.ExceptWith(S);
                Node cn = smallestInD_NotInS(d, nodesOnlyInV);
                S.Add(cn);
                route.Add(cn.Name);
                nodesOnlyInV.ExceptWith(S);
                foreach (Node n in nodesOnlyInV)
                {
                    int newPossible = Math.Abs(d[cn.Id] + adjMatrix[n.Id, cn.Id]);

                    if ((d[n.Id]) > newPossible)
                    {
                        p[n.Id] = cn.Id;
                        d[n.Id] = newPossible;
                    }
                        
                }
                if (cn == dst)
                {
                    int nId = dst.Id;
                    while(true)
                    {
                        rt.addNode(nodeList[nId].Name);
                        if (nId == src.Id)
                            break;
                        nId = p[nId];
                    }
                    rt.setCost(d[dst.Id]);
                    break;
                }
            }
            return rt.printRoute();

        }

        private Node smallestInD_NotInS(int[] arr, HashSet<Node> vExceptS)
        {
            int min = Int32.MaxValue;
            int smallestId = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (vExceptS.Contains(nodeList[i]))
                {
                    min = arr[i];
                    smallestId = i;
                    break;
                }
            }
            foreach (Node n in vExceptS)
            {
                if (arr[n.Id] < min)
                {
                    min = arr[n.Id];
                    smallestId = n.Id;
                }

            }
            return nodeList[smallestId];
        }

        public int getIdByNodeName(string n)
        {
            for (int i = 0; i < Node.numberOfNodes; i++)
            {
                if (n == nodeList[i].Name)
                    return nodeList[i].Id;
            }
            return -1;
        }

        public void addNode(string name)
        {
            nodeList.Add(new Node(name));
        }

        public List<string> getConnected(string name)
        {
             List<string> connected = new  List<string>();
            int thisNodeId = getIdByNodeName(name);
            for (int i = 0; i < Node.numberOfNodes; i++)
            {
                if (adjMatrix[thisNodeId, i] != Int32.MaxValue)
                    connected.Add(nodeList[i].Name);
            }

            return connected;
        }

        public bool initGraph(XmlDocument doc)
        {
            try
            {
                nodeList = new List<Node>();
                Node.Reset();
                foreach (XmlNode n in doc.SelectNodes("graph/node"))
                    nodeList.Add(new Node(n.SelectSingleNode("name").InnerText));
                adjMatrix = new int[Node.numberOfNodes, Node.numberOfNodes];
                for (int i = 0; i < Node.numberOfNodes; i++)
                {
                    for (int j = 0; j < Node.numberOfNodes; j++)
                    {
                        adjMatrix[i, j] = int.MaxValue;
                    }
                }

                foreach (XmlNode n in doc.SelectNodes("graph/edge"))
                {
                    string from = n.SelectSingleNode("from").InnerText;
                    string to = n.SelectSingleNode("to").InnerText;
                    int cost = Convert.ToInt32(n.SelectSingleNode("cost").InnerText);
                    adjMatrix[getIdByNodeName(from), getIdByNodeName(to)] = cost;
                    adjMatrix[getIdByNodeName(to), getIdByNodeName(from)] = cost;
                }
            }
            catch
            { 
                return false;
            }
                
            return true;
        }

        public bool hasNode(string look)
        {
            foreach (Node n in nodeList)
                if (n.Name == look) return true;
            return false;
        }

        public bool hasRoute(string src, string dst)
        {
            int s = getIdByNodeName(src);
            int d = getIdByNodeName(dst);
            if (adjMatrix[s, d] != Int32.MaxValue)
                return true;
            return false;
        }
            
    }
}
