using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SimpleMesh : MonoBehaviour
{
    private void OnEnable()
    {
        var mesh = new Mesh
        {
            name = "My Mesh",
            vertices = new[]
            {
                Vector3.zero, 
                Vector3.right, 
                Vector3.up, 
                
                new Vector3(1f, 1f)
            },
            triangles = new int[]
            {
                0,2,1,
                1, 2, 3
            },
            normals = new Vector3[]
            {
                Vector3.back,
                Vector3.back, 
                Vector3.back,
                Vector3.back,
            },
            uv = new Vector2[]
            {
                Vector3.zero, 
                Vector3.right, 
                Vector3.up,  
                Vector2.one,
            },
            tangents = new Vector4[]
            {
                new Vector4(1,0,0,-1),
                new Vector4(1,0,0,-1),
                new Vector4(1,0,0,-1),
                new Vector4(1f, 0f, 0f, -1f)
            },
            
        };

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
