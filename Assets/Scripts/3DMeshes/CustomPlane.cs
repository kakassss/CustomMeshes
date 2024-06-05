using System;
using UnityEngine;

namespace _3DMeshes
{
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class CustomPlane : MonoBehaviour
    {
        [SerializeField] private int _width;
        [SerializeField] private int _height;
        
        private void OnEnable()
        {
            Quad();
        }

        private void Quad()
        {
            Mesh mesh = new Mesh();

            mesh.name = "Custom Quad";

            Vector3[] vertices = new Vector3[8];
            Vector3[] normals = new Vector3[8];
            int[] triangles = new int[_width * 3];
            
            vertices[0] = Vector3.zero;
            vertices[1] = Vector3.up;
            vertices[2] = Vector3.right;
            vertices[3] = new Vector3(1, 1);
            vertices[4] = new Vector3(2, 0);
            vertices[5] = new Vector3(2, 1);
            vertices[6] = new Vector3(3, 0);
            vertices[7] = new Vector3(3, 1);
            

            for (int i = 0; i < normals.Length; i++)
            {
                normals[i] = Vector3.back;
            }
            
            for (int i = 0; i < _width; i++)
            {
                if (i % 2 == 0)
                {
                    triangles[3*i] = i;
                    triangles[3*i + 1] = i + 1;
                    triangles[3*i + 2] = i + 2;
                }

                if (i % 2 == 1)
                {
                    triangles[3*i] = i;
                    triangles[3*i + 1] = i + 2;
                    triangles[3*i + 2] = i + 1;
                }
            }
            
            
            mesh.vertices = vertices;
            mesh.normals = normals;
            mesh.triangles = triangles;
        
        
            GetComponent<MeshFilter>().mesh = mesh;
        }
    }
}
