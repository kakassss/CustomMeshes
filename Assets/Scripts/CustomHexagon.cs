using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomHexagon : MonoBehaviour
{
    private void OnEnable()
    {
        QuadWith9Triangles();
    }


    private void QuadWith9Triangles()
    {
        Mesh mesh = new Mesh();

        mesh.name = "Custom QuadWith9Triangles";

        Vector3[] vertices = new Vector3[9];
        Vector3[] normals = new Vector3[9];
        int[] triangles = new int[24];
        
        vertices[0] = new Vector3(0,0);
        
        vertices[1] = new Vector3(0,1);
        vertices[2] = new Vector3(0.5f,0.5f);
        vertices[3] = new Vector3(1, 0);
        
        vertices[4] = new Vector3(0.5f, -0.5f);
        vertices[5] = new Vector3(0, -1);
        
        vertices[6] = new Vector3(-0.5f, -0.5f);
        vertices[7] = new Vector3(-1, 0);
        vertices[8] = new Vector3(-0.5f, 0.5f);

        for (int i = 0; i < triangles.Length / 3; i++)
        {
            triangles[3 * i] = 0;
            triangles[3 * i + 1] = i + 1;
            triangles[3 * i + 2] = i + 2;
        }
        
        triangles[^1] = 0;
        triangles[^1] = 8;
        triangles[^1] = 1;
        
        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = Vector3.back;
        }
        
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.triangles = triangles;
        
        GetComponent<MeshFilter>().mesh = mesh;
    }
    
    private void Quad()
    {
        Mesh mesh = new Mesh();

        mesh.name = "Custom Quad";

        Vector3[] vertices = new Vector3[4];
        Vector3[] normals = new Vector3[4];
        int[] triangles = new int[6];
        
        vertices[0] = Vector3.zero;
        vertices[1] = Vector3.right;
        vertices[2] = Vector3.up;
        vertices[3] = new Vector3(1, 1);

        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        
        triangles[3] = 2;
        triangles[4] = 3;
        triangles[5] = 1;
        
        normals[0] = Vector3.back;
        normals[1] = Vector3.back;
        normals[2] = Vector3.back;
        normals[3] = Vector3.back;


        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.triangles = triangles;
        
        
        GetComponent<MeshFilter>().mesh = mesh;
    }
}
