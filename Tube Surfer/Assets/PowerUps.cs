using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PowerUps : MonoBehaviour
{
    public bool GhostActive;
    public bool ScoreActive;
    public bool SlowdownActive;
    public TextMeshProUGUI scoreUI;

    private GameObject[] Tubes;

    public Slider ghostslider;
    public Slider scoreslider;
    public Slider slowdownslider;

    private float timer;
   

    // Start is called before the first frame update
    private void Start()
    {
        
        GhostActive = false;
        ScoreActive = false;
        SlowdownActive = false;
        ghostslider.value = 0;
        slowdownslider.value = 0;
        scoreslider.value = 0;

        timer = Random.Range(10, 20);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.timeSinceLevelLoad >= timer)
        {
            StartCoroutine(GetPowerups());
        }

        if (Input.GetKeyDown("t") && GhostActive == false)
        {
            Debug.Log("t");
            StartCoroutine(Ghost());
        }
        if (Input.GetKeyDown("y") && ScoreActive == false)
        {
            Debug.Log("y");
            StartCoroutine(ScoreMultiplier());
        }
        if (Input.GetKeyDown("u") && SlowdownActive == false)
        {
            Debug.Log("u");
            StartCoroutine(Slowdown());
        }

        if (GhostActive)
        {
            ghostslider.value -= Time.deltaTime / 5;

        }
        if (ScoreActive)
        {
            scoreslider.value -= Time.deltaTime / 5;

        }
        if (SlowdownActive)
        {
            slowdownslider.value -= Time.deltaTime / 5;

        }


    }

    private IEnumerator Ghost()
    {
        GhostActive = true;
        ghostslider.value = 1;
        Tubes = FindTubes();
        for (var i = 0; i < Tubes.Length; i++)
            foreach (Transform child in Tubes[i].transform)
                child.gameObject.GetComponent<MeshCollider>().enabled = false;

        yield return new WaitForSeconds(5);
        GhostActive = false;
        Tubes = FindTubes();
        for (var i = 0; i < Tubes.Length; i++)
            foreach (Transform child in Tubes[i].transform)
                child.gameObject.GetComponent<MeshCollider>().enabled = true;
    }

    private IEnumerator ScoreMultiplier()
    {
        ScoreActive = true;
        scoreslider.value = 1;
        gameObject.GetComponent<Scoring>().boost = 5;
        scoreUI.color=new Color32(0, 255, 0, 255);
        yield return new WaitForSeconds(5);
        ScoreActive = false;
        gameObject.GetComponent<Scoring>().boost = 1;
        scoreUI.color = new Color32(255, 255, 255, 255);
    }

    private IEnumerator Slowdown()
    {
        
        SlowdownActive = true;
        slowdownslider.value = 1;
        Tubes = FindTubes();
        foreach (GameObject tube in Tubes)
        {
            move localMove = tube.GetComponent<move>();
            localMove.speed = localMove.speed / 2;
        }
        
        
        yield return new WaitForSeconds(5);
        SlowdownActive = false;
        foreach (GameObject tube in Tubes)
        {
            move localMove = tube.GetComponent<move>();
            localMove.speed *= 2;
        }
       
    }



    private GameObject[] FindTubes()
    {
        GameObject[] result;
        result = GameObject.FindGameObjectsWithTag("Tube");
        return result;
    }

    private void powerselector()
    {
        int temp = Random.Range(0, 3);
        if (GhostActive && SlowdownActive && ScoreActive)
        {
            return;
        }
        switch (temp)
        {
            case 0:
                if (!GhostActive)
                {
                    StartCoroutine(Ghost());
                }
                else
                {
                    powerselector();
                }
                break;
            case 1:
                if (!SlowdownActive)
                {
                    StartCoroutine(Slowdown());
                }
                else
                {
                    powerselector();
                }
                break;
            case 2:
                if (!ScoreActive)
                {
                    StartCoroutine(ScoreMultiplier());
                }
                else
                {
                    powerselector();
                }
                break;
            
        }
        

    }


    private IEnumerator GetPowerups()
    {
        timer +=Random.Range(10, 20);
        powerselector();
        yield return new WaitForEndOfFrame();
    }
}