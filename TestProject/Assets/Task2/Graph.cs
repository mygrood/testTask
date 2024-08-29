using System;
using System.Collections.Generic;
using UnityEngine;

public class Graph
{
    public List<Vertex> Vertices { get; set; } //������ �����
    public float EdgeLength { get; set; } //����� �����

    public Graph(float edgeLength)
    {        
        if (edgeLength <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(edgeLength), "����� ����� ������ ���� ������ 0");
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
        else { Debug.LogError("������� �������� null �����"); }
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
            Debug.LogError("����� ����� �� ������������� ��������");
        }
    }
}
public class Vertex
{
    public Vector3 Position { get; set; } //������� �����
    public List<Edge> Edges { get; set; } //��������� �����

    public Vertex(Vector3 pos)
    {
        Position = pos;
        Edges = new List<Edge>();
    }
}
public class Edge
{
    public Vertex Start { get; set; }  // ������
    public Vertex End { get; set; } //�����

    public Edge(Vertex start, Vertex end)
    {
        Start = start;
        End = end;
    }
    public float Length()
    {
        return Vector3.Distance(Start.Position, End.Position);  //����� �����
    }
}
