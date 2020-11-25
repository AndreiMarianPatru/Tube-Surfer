using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectPowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    private PowerUps powers;
    void Start()
    {
        PowerUps powers = GameObject.Find("GameManager").GetComponent<PowerUps>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(powers.GetPowerups());
    }
}
