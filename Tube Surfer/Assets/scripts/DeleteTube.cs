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
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("hit");
     

        if (other.gameObject.tag == "Tube")
        {
            StartCoroutine(wait());
            StartCoroutine(spawn.SpawnTubes(new Vector3(0,0, other.gameObject.transform.position.z-113.5f)));
            Destroy(other.gameObject);
        }
       
        
    }
    private IEnumerator wait()
    {
        yield return new WaitForFixedUpdate();
    }
}
