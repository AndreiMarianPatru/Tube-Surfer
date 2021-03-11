using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    private PowerUps powers;
    public AudioSource audioSource;
    private bool flag;
    void Start()
    {
        powers = GameObject.Find("GameManager").GetComponent<PowerUps>();
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource.Play();
            Debug.Log("collision powerup");
            if (flag == false)
            {
                flag = true;
                Debug.Log("this is called");
                
                StartCoroutine(powers.GetPowerups());
            }
        }
       
      
    }
    private void OnTriggerExit(Collider other)
    {
        flag = false;

    }
}
