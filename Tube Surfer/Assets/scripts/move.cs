using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public static float speed;
    bool flag;
    int temptime;
    // Start is called before the first frame update
    void Start()
    {
        speed=5.0f;
        flag=false;
        temptime=10;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0.0f,0.0f,speed) * Time.deltaTime, Space.World);
       //Debug.Log("speed= "+speed);
        if(Time.realtimeSinceStartup>=temptime)
        {
            flag=true;
            temptime+=10;
            increaseSpeed();
        }
    }

    public void increaseSpeed()
    {
        if (speed <= 20&&flag==true)
        {
            speed+=0.5f;
            
        }
        flag=false;

    }
}
