using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPowerups : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
     
        
        List<GameObject> Children = new List<GameObject>();
        foreach (Transform child in transform)
        {
            if (child.tag == "PowerUP")
            {
                Children.Add(child.gameObject);
            }
        }
        int temp = Random.Range(0, Children.Count);

        for (int i = 0; i < Children.Count; i++)
        {
            if (i != temp)
            {
                Children[i].active = false;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
