using System;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    public List<Vertex> Vertices { get; set; } //список точек
    public float EdgeLength { get; set; } //длина грани

    public Graph(float edgeLength)
    {        
        if (edgeLength <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(edgeLength), "Длина грани должна быть больше 0");
        }
        EdgeLength = edgeLength;
        Vertices = new List<Vertex>();
    }

    public void AddVertex(Vertex v)
    {
        if (v != null)
        {
            Vertices.Add(v);
        }
        else { Debug.LogError("Попытка добавить null точку"); }
    }

    public void AddEdge(Vertex startV, Vertex endV)
    {
        if (Vector3.Distance(startV.Position, endV.Position) == EdgeLength)
        {
            Edge edge = new Edge(startV, endV);
            startV.Edges.Add(edge);
            endV.Edges.Add(edge);
        }
        else
        {
            Debug.LogError("Длина грани не соответствует заданной");
        }
    }
}
public class Vertex
{
    public Vector3 Position { get; set; } //позиция точки
    public List<Edge> Edges { get; set; } //связанные грани

    public Vertex(Vector3 pos)
    {
        Position = pos;
        Edges = new List<Edge>();
    }
}
public class Edge
{
    public Vertex Start { get; set; }  // начало
    public Vertex End { get; set; } //конец

    public Edge(Vertex start, Vertex end)
    {
        Start = start;
        End = end;
    }
    public float Length()
    {
        return Vector3.Distance(Start.Position, End.Position);  //длина грани
    }
}
