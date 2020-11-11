using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteTube : MonoBehaviour
{
    spawnTubes spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawn=GameObject.Find("GameManager").GetComponent<spawnTubes>();
       
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
            Debug.Log("this is called");
            StartCoroutine(spawn.SpawnTubes(new Vector3(other.gameObject.transform.position.x, other.gameObject.transform.position.y, other.gameObject.transform.position.z-113.6f)));
            Destroy(other.gameObject);
        }
    }
}
