using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialActivatePowerUPs : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PowerupUI;
    public PowerUps PowerUpscript;
    void Start()
    {
        PowerupUI.SetActive(false);
        PowerUpscript.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        PowerupUI.SetActive(true);
        PowerUpscript.enabled = true;
    }
}
