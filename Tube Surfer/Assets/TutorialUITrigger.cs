using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUITrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private TutorialPowerUpsEnable powerups;
    void Start()
    {
        powerups = GameObject.Find("GameManager").GetComponent<TutorialPowerUpsEnable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "trigger1")
        {
            Debug.Log("callbefore");
            StartCoroutine(powerups.ActivateUI1());
        }
        if (other.gameObject.name == "trigger2")
        {
            StartCoroutine(powerups.ActivateUI2());
        }
        if (other.gameObject.name == "trigger3")
        {
            StartCoroutine(powerups.ActivateUI3());
        }

    }
}
