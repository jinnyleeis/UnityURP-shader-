using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forfix : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer[] renderers = FindObjectsOfType(typeof(MeshRenderer)) as MeshRenderer[];
    
    foreach (MeshRenderer item in renderers)
{
    if (item.materials != null)
    {
        foreach (Material mat in item.materials)
        {
            Shader sha = mat.shader;
            sha = Shader.Find(sha.name);
            mat.shader = sha;
            item.material = mat;
        }
    }
}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
