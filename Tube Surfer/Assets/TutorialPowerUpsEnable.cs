using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPowerUpsEnable : MonoBehaviour
{
    // Start is called before the first frame update
    private bool mycontinue;
    public GameObject UI1;
    public GameObject UI2;
    public GameObject UI3;

    void Start()
    {
        mycontinue = false;
        
        UI1.SetActive(false); 
        UI2.SetActive(false); 
        UI3.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            mycontinue = true;
        }

     

       
        
    }

    public IEnumerator ActivateUI1()
    {
        
        Debug.Log("call1");
        mycontinue = false;
        Debug.Log("call1");

        Time.timeScale = 0;
        Debug.Log("call1");

        UI1.SetActive(true);

        Debug.Log("call1");

        while (mycontinue == false)
        {
            yield return new WaitForSecondsRealtime(0.1f);
            Debug.Log("call2");

        }
        Debug.Log("call1");

        UI1.SetActive(false);

        Debug.Log("call1");

        Time.timeScale = 1;
        Debug.Log("call1");

        mycontinue = false;
        Debug.Log("call1");

        yield return null;
        Debug.Log("call1");

    }
    public IEnumerator ActivateUI2()
    {
        mycontinue = false;
        Time.timeScale = 0;
        UI2.SetActive(true);

        while (mycontinue == false)
        {
            yield return new WaitForSecondsRealtime(0.1f);

        }
        UI2.SetActive(false);

        Time.timeScale = 1;
        mycontinue = false;
        yield return null;
    }
    public IEnumerator ActivateUI3()
    {
        mycontinue = false;
        Time.timeScale = 0;
        UI3.SetActive(true);

        while (mycontinue == false)
        {
            yield return new WaitForSecondsRealtime(0.1f);

        }
        UI3.SetActive(false);

        Time.timeScale = 1;
        mycontinue = false;
        yield return null;
    }
}
