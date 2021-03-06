RouteFinder
===========

An application that uses Dijksta's Algorithm to find the shortest paths in XML graphs. The intended scope of use
is to calculate travel time between cities. The repo contains an executeable version of the application and two example 
graphs represented both graphically and in XML. Further, and maybe more interestingly, the repo holds the source code 
of the application.

The euro_train_map is a map over train connections between major european cities and the time each distance takes.
The example_graph is a simple weighted undirected graph intended for instructional purposes.

The application supports four features.

1. Create new graph. By adding nodes and edges, the user can create new graphs. To view the structure of a serialized graph,      check out example_graph.xml

2. Add to an existing graph by loading and adding nodes and edges to existing files.

3. View connections (edges) in a graph.

4. Calculate the shortest path between two nodes in a graph.

