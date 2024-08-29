using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphDrawer : MonoBehaviour
{
    public Color vertexColor = Color.red;
    public Color edgeColor = Color.green;
    public float vertexSize = 0.5f;

    private Graph graph;

    void Start()
    {
        graph = new Graph(5.0f);

        Vertex v1 = new Vertex(new Vector3(0,0,0));
        Vertex v2 = new Vertex(new Vector3(5,0,0));
        Vertex v3 = new Vertex(new Vector3(10,0,0));
        Vertex v4 = new Vertex(new Vector3(10,5,0));
        Vertex v5 = new Vertex(new Vector3(15,5,0));
        Vertex v6 = new Vertex(new Vector3(15,10,0));
        Vertex v7 = new Vertex(new Vector3(15,15,0));
        Vertex v8 = new Vertex(new Vector3(10,15,0));
        Vertex v9 = new Vertex(new Vector3(5,15,0));
        Vertex v10 = new Vertex(new Vector3(0,15,0));
        Vertex v11 = new Vertex(new Vector3(0,10,0));
        Vertex v13 = new Vertex(new Vector3(5,10,0));
        Vertex v12 = new Vertex(new Vector3(0,5,0));
        Vertex v14 = new Vertex(new Vector3(5,5,0));

        graph.AddVertex(v1);
        graph.AddVertex(v2);
        graph.AddVertex(v3);
        graph.AddVertex(v4);
        graph.AddVertex(v5);
        graph.AddVertex(v6);
        graph.AddVertex(v7);
        graph.AddVertex(v8);
        graph.AddVertex(v9);
        graph.AddVertex(v10);
        graph.AddVertex(v11);
        graph.AddVertex(v12);
        graph.AddVertex(v13);
        graph.AddVertex(v14);

        graph.AddEdge(v1, v2);
        graph.AddEdge(v2, v3);
        graph.AddEdge(v3, v4);
        graph.AddEdge(v4, v5);
        graph.AddEdge(v5, v6);
        graph.AddEdge(v6, v7);
        graph.AddEdge(v7, v8);
        graph.AddEdge(v8, v9);
        graph.AddEdge(v9, v10);
        graph.AddEdge(v10, v11);
        graph.AddEdge(v11, v12);
        graph.AddEdge(v12, v1);
        graph.AddEdge(v9, v13);
        graph.AddEdge(v11, v13);
        graph.AddEdge(v12, v14);
    }

    private void OnDrawGizmos()
    {
        if (graph == null) return;

        Gizmos.color = vertexColor;
                
        foreach (Vertex vertex in graph.Vertices)
        {
            Gizmos.DrawSphere(vertex.Position, vertexSize);
        }

        Gizmos.color = edgeColor;
                
        foreach (Vertex vertex in graph.Vertices)
        {
            foreach (Edge edge in vertex.Edges)
            {
                Gizmos.DrawLine(edge.Start.Position, edge.End.Position);
            }
        }
    }
}
