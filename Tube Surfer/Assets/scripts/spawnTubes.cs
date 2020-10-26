using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTubes : MonoBehaviour
{
    public  GameObject tube1;
    public float time;
    public GameObject temp;
    private float timeTemp;
   
    
    // Start is called before the first frame update
    void Start()
    {
        timeTemp = time;
        temp = Instantiate(tube1, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 90));
        temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Time.time >= timeTemp)
        {
            timeTemp += time;
            temp=Instantiate(tube1, new Vector3(0,0,0), Quaternion.Euler(0, 90, 90));
            temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0,360));
        }
    }

    IEnumerable SpawnTubes()
    {
        yield return null;
    }
}
