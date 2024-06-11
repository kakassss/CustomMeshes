using System;
using UnityEngine;

namespace _3DMeshes
{
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class CustomPlane : MonoBehaviour
    {
        [SerializeField] private int _planeSize;
        
        private int _width;
        private int _height;
        
        private void OnEnable()
        {
            Plane();
        }
        
        private void Plane()
        {
            Mesh mesh = new Mesh();

            mesh.name = "Custom Plane";

            _width = _planeSize;
            _height = _planeSize;

            float verticleCount = Mathf.Pow(_width + 1, 2);
            
            Vector3[] vertices = new Vector3[Mathf.FloorToInt(verticleCount)];
            Vector3[] normals = new Vector3[Mathf.FloorToInt(verticleCount)];
            int[] triangles = new int[_width * _height * 6];

            int verticesIndex = 0;
            for (int i = 0; i < _width + 1; i++)
            {
                for (int j = 0; j < _height + 1; j++)
                {
                    vertices[verticesIndex] = new Vector3( j , i);
                    verticesIndex++;
                }
            }

            int triangleIndex = 0;
            int vertIndex = 0;

            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    triangles[triangleIndex] = vertIndex;
                    triangles[triangleIndex + 1] = vertIndex + _height + 1;
                    triangles[triangleIndex + 2] = vertIndex + 1;
                    
                    triangles[triangleIndex + 3] = vertIndex + _height + 1;
                    triangles[triangleIndex + 4] = vertIndex + _height + 2;
                    triangles[triangleIndex + 5] = vertIndex + 1;

                    vertIndex++;
                    triangleIndex += 6;
                }
                vertIndex++;
            }

            
            for (int i = 0; i < normals.Length; i++)
            {
                normals[i] = Vector3.back;
            }
            
            mesh.vertices = vertices;
            mesh.normals = normals;
            mesh.triangles = triangles;
        
        
            GetComponent<MeshFilter>().mesh = mesh;
        }
    }
}
