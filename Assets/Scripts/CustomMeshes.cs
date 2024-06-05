using UnityEngine;

public class CustomMeshes : MonoBehaviour
{
    private void OnEnable()
    {
        Triangle();
    }

    private void Triangle()
    {
        Mesh mesh = new Mesh();

        mesh.name = "Custom Quad";

        Vector3[] vertices = new Vector3[3];
        Vector3[] normals = new Vector3[3];
        int[] triangles = new int[3];
        Vector2[] uv = new Vector2[3];
        
        vertices[0] = Vector3.zero;
        vertices[1] = Vector3.right;
        vertices[2] = Vector3.up;
        
        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        
        normals[0] = Vector3.back;
        normals[1] = Vector3.back;
        normals[2] = Vector3.back;
        
        uv[0] = Vector2.zero;
        uv[1] = Vector2.right;
        uv[2] = Vector2.up;
        
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.triangles = triangles;
        mesh.uv = uv;
        
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
        
        triangles[^3] = 0;
        triangles[^2] = 8;
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

    private void Pentagon()
    {
        Mesh mesh = new Mesh();

        mesh.name = "Custom Pentagon";

        Vector3[] vertices = new Vector3[6];
        Vector3[] normals = new Vector3[6];
        int[] triangles = new int[15];
        
        vertices[0] = new Vector3(0,0.35f);
        vertices[1] = new Vector3(0, 0.6f);
        vertices[2] = new Vector3(0.4f, 0.3f);
        vertices[3] = new Vector3(0.2f, -0.1f);
        vertices[4] = new Vector3(-0.2f, -0.1f);
        vertices[5] = new Vector3(-0.4f, 0.3f);
        
        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        
        triangles[3] = 0;
        triangles[4] = 2;
        triangles[5] = 3;
        
        triangles[6] = 0;
        triangles[7] = 3;
        triangles[8] = 4;
        
        triangles[9] = 0;
        triangles[10] = 4;
        triangles[11] = 5;
        
        triangles[12] = 0;
        triangles[13] = 5;
        triangles[14] = 1;
        
        for (int i = 0; i < normals.Length; i++)
        {
            normals[i] = Vector3.back;
        }
        
        mesh.vertices = vertices;
        mesh.normals = normals;
        mesh.triangles = triangles;
        
        GetComponent<MeshFilter>().mesh = mesh;
        
        
    }
    
    private void Hexagon()
    {
        Mesh mesh = new Mesh();

        mesh.name = "Custom Hexagon";

        Vector3[] vertices = new Vector3[7];
        Vector3[] normals = new Vector3[7];
        int[] triangles = new int[18];
        
        vertices[0] = new Vector3(0,0); 
        vertices[1] = new Vector3(0f, 0.5f);
        vertices[2] = new Vector3(0.4f,0.2f);
        vertices[3] = new Vector3(0.4f, -0.2f);
        vertices[4] = new Vector3(0,-0.5f);
        vertices[5] = new Vector3(-0.4f, -0.2f);
        vertices[6] = new Vector3(-0.4f, 0.2f);

        for (int i = 0; i < triangles.Length / 3; i++)
        {
            triangles[3 * i] = 0;
            triangles[3 * i + 1] = i + 1;
            triangles[3 * i + 2] = i + 2;
        }
        
        triangles[15] = 0;
        triangles[16] = 6;
        triangles[17] = 1;
        
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
