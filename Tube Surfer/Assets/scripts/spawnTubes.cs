﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTubes : MonoBehaviour
{
    public GameObject[] tubes;
   
    public float time;
    public GameObject temp;
    private float timeTemp;
   
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTubes());
        //timeTemp = time;
        //temp = Instantiate(tube1, new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 90));
        //temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0, 360));
    }

    // Update is called once per frame
    void Update()
    {
     
        Debug.Log("deltatime "+ Time.timeSinceLevelLoad + " timetemp "+timeTemp);
        if (Time.timeSinceLevelLoad >= timeTemp)
        {
            Debug.Log("here");
            StartCoroutine(SpawnTubes());

            //timeTemp += time;
            //temp=Instantiate(tube1, new Vector3(0,0,0), Quaternion.Euler(0, 90, 90));
            //temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0,360));
        }
    }

    IEnumerator SpawnTubes()
    {
        int tempint = Random.Range(0, tubes.Length - 1);
        timeTemp += time;
        temp = Instantiate(tubes[tempint], new Vector3(0, 0, 0), Quaternion.Euler(0, 90, 90));
        temp.transform.RotateAround(temp.GetComponent<Collider>().bounds.center, Vector3.forward, Random.Range(0, 360));
        yield return null;
    }
}
