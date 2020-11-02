using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisableSpaceUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI SpaceTXT;
    [SerializeField]
    private TextMeshProUGUI qeTXT;
    [SerializeField]
    private TextMeshProUGUI CanJump;
    [SerializeField]
    private TextMeshProUGUI CanNotJump;
    // Start is called before the first frame update
    void Start()
    {
        qeTXT.enabled = false;
        CanNotJump.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpaceTXT.enabled = false;
            CanJump.enabled = false;
            qeTXT.enabled = true;
            CanNotJump.enabled = true;
        }
    }

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        customimage.enabled = false;
    //    }
    //}

    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("deletetxt");
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Debug.Log("deletetxt");
    //        Destroy(GameObject.Find("SpaceTXT"));
    //    }
    //}
}
