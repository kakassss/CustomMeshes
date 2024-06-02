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
            name = "My Mesh"
        };

        mesh.vertices = new Vector3[]
        {
            Vector3.zero, Vector3.right *5 , Vector3.up
        };

        mesh.triangles = new int[]
        {
            0,2,1
        };
        
        GetComponent<MeshFilter>().mesh = mesh;
    }
}
