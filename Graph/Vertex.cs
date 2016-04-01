using System;

namespace DataStructures.Graph
{
    public class Vertex
    {
        public bool wasVisited;
        public string label;

        public Vertex(string label)
        {
            this.label = label;
        }
    }
}
