using System;

namespace DataStructures.Graph
{
    public class Graph
    {
        private const int NUM_VERTICES = 20;
        private Vertex[] vertices;
        private int[,] adjMatrix;
        int numVerts;

        public Graph()
        {
            vertices = new Vertex[NUM_VERTICES];
            adjMatrix = new int[NUM_VERTICES, NUM_VERTICES];
            numVerts = 0;
            for(int j = 0; j < NUM_VERTICES; j++)
            {
                for(int k = 0; k < NUM_VERTICES; k++)
                {
                    adjMatrix[j, k] = 0;
                }
            }
        }

        public void AddVertex(string label)
        {
            vertices[numVerts] = new Vertex(label);
            numVerts++;
        }

        public void AddEdge(int start, int end)
        {
            adjMatrix[start, end] = 1;
            adjMatrix[end, start] = 1;
        }

        public void ShowVertex(int v)
        {
            Console.WriteLine(vertices[v].label);
        }

        public int NoSuccessors()
        {
            bool isEdge;
            for(int row = 0; row <= NUM_VERTICES - 1; row++)
            {
                isEdge = false;
                for(int col = 0; col <= NUM_VERTICES - 1; col++)
                {
                    if(adjMatrix[row, col] > 0)
                    {
                        isEdge = true;
                        break;
                    }
                }
                if (!isEdge)
                {
                    return row;
                }
            }
            return -1;
        }

        public void DelVertex()
        {

        }

    }
}
