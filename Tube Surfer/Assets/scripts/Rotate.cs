using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Collider m_Collider;
    Vector3 m_Center;


    void Start()
    {
        //Fetch the Collider from the GameObject
        m_Collider = GetComponent<Collider>();
        //Fetch the center of the Collider volume
        m_Center = m_Collider.bounds.center;
    }

    // Update is called once per frame
        void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.RotateAround(m_Center, Vector3.forward, 80 * Time.deltaTime);
           
           // Debug.Log("a");
        }
        if (Input.GetKey("d"))
        {
            transform.RotateAround(m_Center, Vector3.forward, -80 * Time.deltaTime);
          
          //  Debug.Log("d");
        }

    }
}
