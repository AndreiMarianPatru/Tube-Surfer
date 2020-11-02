using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hit");
        if (other.gameObject.tag == "Tube")
        {
            Destroy(other.gameObject);
        }
    }
}
