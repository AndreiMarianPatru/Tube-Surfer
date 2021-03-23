using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getsize : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    private float elapsed; // set to zero to start interpolation
    private float waitTime; // waitTime in seconds
    private float power;

    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3 objectSize = Vector3.Scale(transform.localScale, mesh.bounds.size);
          Debug.Log(objectSize+" "+gameObject.name);
        //Time.timeScale=0;
        elapsed = 0;
        waitTime = 3;

    }


    private float x;
    void Update()
    {
        //elapsed += Time.deltaTime / waitTime;
        //x =Mathf.Lerp(20, 10, elapsed);

        //// .. and increase the elapsed interpolater
       

        //Debug.Log(x);
        //if (x == 10)
        //{
        //    Debug.Log(Time.timeSinceLevelLoad);
        //    Time.timeScale = 0;
        //}

    }

}
 
