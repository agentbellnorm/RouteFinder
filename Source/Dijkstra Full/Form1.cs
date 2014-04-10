//Route Finder
//By Morgan Bentell     
//morgan.bentell@gmail.com
//Version 1.0
//May 2013

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;

namespace Dijkstra_Full
{
    public partial class Form1 : Form
    {
        Graph graph;
        List<Node> adjList;
        XmlDocument doc;
        OpenFileDialog ofd;
        string currentDoc;
        string currentPath;
        public Form1()
        {
            InitializeComponent();
            graph = new Graph();
            currentDoc = "[No map loaded]";
            toolStripStatusLabel1.Text = "Current map: " + currentDoc;

        }

        private void AddCityButton_Click(object sender, EventArgs e)
        {
            if (doc == null)
                toolStripStatusLabel1.Text = "Please load or create new map before adding";
            else if (graph.hasNode(addCityName_Box.Text))
                toolStripStatusLabel1.Text = "City already exists";
            else
            {
                if (addCityName_Box.Text == "")
                    toolStripStatusLabel1.Text = "City must have name";
                else
                {
                    XmlNode node = doc.CreateElement("node");
                    XmlNode name = doc.CreateElement("name");
                    name.InnerText = addCityName_Box.Text;
                    node.AppendChild(name);
                    doc.DocumentElement.AppendChild(node);
                    doc.Save(currentPath);
                    toolStripStatusLabel1.Text = name.InnerText + " was added to the map";
                    graph.initGraph(doc);
                    updateLists();

                }

            }
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Current map: " + currentDoc;
            cityList.DisplayMember = "Name";
            cityList.Items.Clear();
            adjList = new List<Node>();
            foreach (Node n in graph.Nodes)
                adjList.Add(n);
            adjList.Sort();
            foreach (Node n in adjList)
            {
                cityList.Items.Add(n);

            }
        }

        private void cityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectionsList.Items.Clear();
            string parentName = adjList[cityList.SelectedIndex].Name;
            foreach(string s in graph.getConnected(parentName))
            {
                connectionsList.Items.Add(s);
            }
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Current map: " + currentDoc;
            calculateRouteFromList.Items.Clear();
            calculateRouteToList.Items.Clear();
            List<Node> l = new List<Node>();
            foreach (Node n in graph.Nodes)
                l.Add(n);
            l.Sort();
            foreach (Node n in l)
            {
                calculateRouteFromList.Items.Add(n.Name);
                calculateRouteToList.Items.Add(n.Name);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (calculateRouteToList.SelectedItem == null || calculateRouteFromList.SelectedItem == null)
                toolStripStatusLabel1.Text = "Please choose two cities";

            else if (calculateRouteFromList.SelectedItem.ToString() == calculateRouteToList.SelectedItem.ToString())
            {
                toolStripStatusLabel1.Text = "Please choose two unique cities";
            }
            else
            {
                
                string from = calculateRouteFromList.SelectedItem.ToString();
                string to = calculateRouteToList.SelectedItem.ToString();
                string[] resultStringArr = graph.Dijkstra(from, to);
                resultLabel.Text = resultStringArr[0];
                richTextBox1.Text = resultStringArr[1];
                totTimeLabel.Text = resultStringArr[2];
            }

        }



        private void loadButton_Click(object sender, EventArgs e)
        {
            loadDoc();
        }
        
        private void loadDoc()
        {
            doc = new XmlDocument();
            ofd = new OpenFileDialog();
            ofd.Filter = "XML | *.xml";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string[] filePath = Regex.Split(path, @"\\");
                currentDoc = filePath[filePath.Length - 1];
                try
                {
                    doc.Load(ofd.FileName);
                    if (graph.initGraph(doc))
                    {
                        toolStripStatusLabel1.Text = "Current map: " + currentDoc;
                        currentPath = ofd.FileName;
                        updateLists();
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Error while loading file!";
                    }
                }
                catch
                {
                    toolStripStatusLabel1.Text = "Error while loading file!";
                }

            }

        }

        private void addRouteButton_Click(object sender, EventArgs e)
        {
            int dummy;
            if (doc == null)
                toolStripStatusLabel1.Text = "Please load or create new map before adding";
            else
            {
                if (addRouteFromList.Text == "" || addRouteToList.Text == "" || addJourneyCost_Box.Text == "")
                    toolStripStatusLabel1.Text = "Please enter all fields for new route";
                else if (!Int32.TryParse(addJourneyCost_Box.Text, out dummy))
                    toolStripStatusLabel1.Text = "Cost can only contain digits";
                else if (graph.hasRoute(addRouteFromList.Text, addRouteToList.Text))
                    toolStripStatusLabel1.Text = "Route already exists";
                else if (addRouteFromList.Text == addRouteToList.Text)
                    toolStripStatusLabel1.Text = "Please choose two unique cities";
                else
                {
                    XmlNode edge = doc.CreateElement("edge");
                    XmlNode from = doc.CreateElement("from");
                    XmlNode to = doc.CreateElement("to");
                    XmlNode cost = doc.CreateElement("cost");
                    from.InnerText = addRouteFromList.Text;
                    to.InnerText = addRouteToList.Text;
                    cost.InnerText = addJourneyCost_Box.Text;
                    edge.AppendChild(from);
                    edge.AppendChild(to);
                    edge.AppendChild(cost);
                    doc.DocumentElement.AppendChild(edge);
                    doc.Save(currentPath);
                    toolStripStatusLabel1.Text = from.InnerText + " -> " + to.InnerText + " was added";
                    graph.initGraph(doc);
                }
            }
        }

        private void updateLists()
        {
            addRouteToList.Items.Clear();
            addRouteFromList.Items.Clear();
            List<Node> l = new List<Node>();
            foreach (Node n in graph.Nodes)
                l.Add(n);
            l.Sort();
            foreach (Node n in l)
            {
                addRouteToList.Items.Add(n.Name);
                addRouteFromList.Items.Add(n.Name);
            }
 
        }

        private void createNewMapbtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML | *.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter wrt = new XmlTextWriter(sfd.FileName, Encoding.UTF8);
                XmlDocument newDoc = new XmlDocument();
                newDoc.LoadXml("<graph></graph>");
                wrt.Formatting = Formatting.Indented;
                //wrt.WriteStartElement("graph");
                //wrt.WriteString("");
                //wrt.WriteEndElement();
                //wrt.Close();
                newDoc.Save(wrt);
                currentPath = sfd.FileName;
                doc = newDoc;
                wrt.Close();
                string[] filePath = Regex.Split(sfd.FileName, @"\\");
                currentDoc = filePath[filePath.Length - 1];
                toolStripStatusLabel1.Text = "Current map: " + currentDoc;
                graph.initGraph(doc);
                updateLists();

            }

        }
    }
}
