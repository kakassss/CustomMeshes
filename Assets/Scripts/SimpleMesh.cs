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
            vertices = new Vector3[]
            {
                Vector3.zero, 
                Vector3.right, 
                Vector3.up, 
                
                // Vector3.right, 
                // Vector3.up, 
                new Vector3(1,1), 
            },
            triangles = new int[]
            {
                0,2,1,
                2,3,1
            },
            normals = new Vector3[]
            {
                Vector3.back,
                Vector3.back, 
                Vector3.back,
                Vector3.back,
               
            },
            
        };

        GetComponent<MeshFilter>().mesh = mesh;
    }
}
