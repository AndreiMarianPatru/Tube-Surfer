using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class spawnTubes : MonoBehaviour
{
    
    public  GameObject[] tubes;
    public GameObject PowerUpPrefab;

    //public float time;
    public  GameObject temp;
   // private float timeTemp;
   
    
    // Start is called before the first frame update
    void Start()
    {
       // GameObject zero=Instantiate(tubes[0], new Vector3(0, 0, 0), tubes[0].transform.rotation);
    //    zero.name = "Zero";
        //GameObject ninety=Instantiate(tubes[0], new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 270));
        //ninety.name = "90";
       // Time.timeScale = 4;
        //StartCoroutine(SpawnTubes());
        //timeTemp = time;
        //temp = Instantiate(tube1, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 90));
        //temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
     
       //// Debug.Log("deltatime "+ Time.timeSinceLevelLoad + " timetemp "+timeTemp);
       // if (Time.timeSinceLevelLoad >= timeTemp)
       // {
       //     Debug.Log("here");
       //     StartCoroutine(SpawnTubes());

       //     //timeTemp += time;
       //     //temp=Instantiate(tube1, new Vector3(0,0,0), Quaternion.Euler(0, 90, 90));
       //     //temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0,360));
       // }
    }

    public  IEnumerator SpawnTubes(Vector3 position)
    {
        int tempint = Random.Range(0, tubes.Length);

        GameObject temp = Instantiate(tubes[tempint], position, tubes[tempint].transform.rotation);
        SpawnPoweUPs(position);
        Debug.Log("tube instantiated at "+position);
        //temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0, 360));
        //Time.timeScale=0;
        yield return new WaitForFixedUpdate();
       
    }

    public void SpawnPoweUPs(Vector3 position)
    {
        GameObject Powerup = Instantiate(PowerUpPrefab, new Vector3(2.25f, -1.8f, Random.Range(position.z - 20, position.z + 20)), Quaternion.identity);
    }

   
}
