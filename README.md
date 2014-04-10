RouteFinder
===========

An application that uses Dijksta's Algorithm to find the shortest paths in XML graphs. The intended field of application
is to calculate travel time between cities. The repo contains an executeable version of the application and two example 
graphs represented both graphically and in XML. Further, and maybe moreinterestingly, the repo holds the source code 
of the application.

The euro_train_map is a map over train connections between major european cities and the time each distance takes.
The example_graph is a simple weighted undirected graph intendet for instructional purposes.

The application offers three features.

1. Create new graph. By adding nodes and edges, the user can create new graphs.
  The XML-structure of a map is as follows:
<code>
  <xml>
    <graph>
      <node>
        <name>A</name>
      </node>
      <node>
        <name>B</name>
      </node>
      <edge>
        <from>A</from>
        <to>B</to>
        <cost>10</cost>
      </edge>
    </graph>
  </xml>
</code>
   

2. Add to existing graph by loading and adding nodes and edges to existing files.

3. View connections in a graph.

4. Calculate the shortest path between to nodes in a graph. 
