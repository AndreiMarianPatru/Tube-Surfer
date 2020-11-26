using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPowerUPs : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public GameObject aaa;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTER");
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("enter too close to obstacle");
            //  transform.parent.GetComponent<powerupmove>().enabled = false;
            //  transform.parent.position=new Vector3(transform.parent.position.x, transform.parent.position.y, transform.parent.position.z+100);
            //transform.parent.position = Vector3.zero;
            //transform.parent.transform.Translate(0, 0, 20);
            //  transform.parent.transform.Translate(new Vector3(0.0f, 0.0f, 20) * Time.deltaTime, Space.World);
            //  aaa.transform.SetPositionAndRotation(new Vector3(100, 100, 100), Quaternion.identity);
            aaa.GetComponent<powerupmove>().startPosObj += 2;


            //  transform.parent.GetComponent<powerupmove>().enabled = true;

        }
    }

    public void OnTriggerStay(Collider other)
    {
        Debug.Log("STAY");

        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("stay too close to obstacle");
           // transform.parent.GetComponent<powerupmove>().enabled = false;
            //  transform.parent.position=new Vector3(transform.parent.position.x, transform.parent.position.y, transform.parent.position.z+100);
            //transform.parent.position = Vector3.zero;
            //transform.parent.transform.Translate(0, 0, 20);
            //  transform.parent.transform.Translate(new Vector3(0.0f, 0.0f, 20) * Time.deltaTime, Space.World);
           // transform.parent.transform.position.Set(100, 100, 100);
          //  transform.parent.GetComponent<powerupmove>().enabled = true;
         // aaa.transform.SetPositionAndRotation(new Vector3(100,100,100),Quaternion.identity );
         aaa.GetComponent<powerupmove>().startPosObj += 2;







        }
    }
}
