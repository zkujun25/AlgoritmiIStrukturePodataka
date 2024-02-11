using System;
using System.Collections;
using System.Collections.Generic;

namespace Shortest_Path
{
    public enum DirectionType
    {
        Directed,
        Undirected
    }
    internal class Graph : IEnumerable
    {
        internal Vertex[] vertices;
        PartiallyOrderedTree pot;

        public Graph(int[] nodes)
        {
            vertices = new Vertex[nodes.Length];
            pot = new PartiallyOrderedTree(this);
            for (int i = 0; i < vertices.Length; i++)
            {
                this.vertices[i] = new Vertex(nodes[i]);
                vertices[i].Index = i + 1;

            }
        }

        public void AddEdge(int source, int destination, double cost, DirectionType direction)
        {
            if (direction == DirectionType.Undirected)
            {
                
                vertices[source].AddEdge(destination, cost); 
                vertices[destination].AddEdge(source, cost); 
            }
            else
            {
                vertices[source].AddEdge(destination, cost); 
            }
        }

            IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var vertex in vertices)
                yield return vertex;
        }
        public void Display()
        {
            foreach (var o in this)
                Console.WriteLine(o);

            pot.Display();

        }
        public void FindShortestPath()
        {
            int a, b;
            
            List<Edge> successors;
            vertices[0].Distance = 0;
            this.Display();
            int i = 0;
            while (pot.last > 1)
            {
                b = pot.queue[1];
                pot.Swap(1, pot.last);
                --pot.last;
                pot.BubbleDown(1);
                successors = vertices[b].Neighbors;
                a = b;
                foreach (Edge edge in successors)
                {
                    if (vertices[a].Distance > vertices[b].Distance + edge.Cost)
                    {
                        vertices[a].Distance = vertices[b].Distance + edge.Cost;
                        pot.BubbleUp(vertices[a].Index);
                    }
                    a++;
                }
                this.Display();
            }
            --pot.last;
            this.Display();
        }
    }
}
