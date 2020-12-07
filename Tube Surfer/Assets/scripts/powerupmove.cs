using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupmove : MonoBehaviour
{
    //public GameObject target;
    //public Vector3 startPosTarget;
    //public Vector3 startPosObj;
    //public Vector3 difference;
    //void Start()
    //{
    //    startPosTarget = target.transform.position;
    //    startPosObj = this.transform.position;
    //}
    //void LateUpdate()
    //{
    //    difference = target.transform.position - startPosTarget;
    //    this.transform.position = startPosObj + difference;
    //}

    Collider m_Collider;
    Vector3 m_Center;
    private GameObject closestTube;
    private float startPosTarget;
    public float startPosObj;
    private float difference;


    void Start()
    {
        closestTube = findClosestTube();
        //Fetch the Collider from the GameObject
        m_Collider = closestTube.GetComponent<Collider>();
        //Fetch the center of the Collider volume
        m_Center = m_Collider.bounds.center;

        startPosTarget = closestTube.transform.position.z;
        startPosObj = this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {


        if (closestTube == null)
        {
            Destroy(this.gameObject);
            
        }
        else
        {
           

            difference = closestTube.transform.position.z - startPosTarget;
            this.transform.position = new Vector3(transform.position.x, transform.position.y, startPosObj + difference);
        }
       
        

    }

    void LateUpdate()
    {

    }

    private GameObject findClosestTube()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Tube");
        GameObject closesttube = null;

        if (objs.Length != 0)
        {
             closesttube = objs[0];
        }
        else
        {
            return null;
        }
        float closestDistance=0;
        bool first = true;

        foreach (var obj in objs)
        {
            float distance = Vector3.Distance(obj.transform.position, transform.position);
            if (first)
            {
                closestDistance = distance;

                first = false;
            }
            else if (distance < closestDistance)
            {
                closesttube = obj;
                closestDistance = distance;
            }

        }
        return closesttube;
    }
}
