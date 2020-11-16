using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getsize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3 objectSize = Vector3.Scale(transform.localScale, mesh.bounds.size);
        Debug.Log(objectSize+" "+gameObject.name);
        //Time.timeScale=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
