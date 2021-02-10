using System;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PowerUps : MonoBehaviour
{
    public bool GhostActive;

    public Slider ghostslider;
    public bool ScoreActive;
    public Slider scoreslider;
    public TextMeshProUGUI scoreUI;
    public bool SlowdownActive;
    public Slider slowdownslider;
    private bool slowdowsnactive1;
    private bool slowdowsnactive2;

    private float t;

    private float timer;

    private GameObject[] Tubes;


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
        slowdowsnactive1 = false;
        slowdowsnactive2 = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.timeSinceLevelLoad >= timer) StartCoroutine(GetPowerups());

        //if (Input.GetKeyDown("t") && GhostActive == false)
        //{
        //    Debug.Log("t");
        //    StartCoroutine(Ghost());
        //}

        //if (Input.GetKeyDown("y") && ScoreActive == false)
        //{
        //    Debug.Log("y");
        //    StartCoroutine(ScoreMultiplier());
        //}

        //if (Input.GetKeyDown("u") && SlowdownActive == false)
        //{
        //    Debug.Log("u");
        //    StartCoroutine(Slowdown());
        //}

        if (GhostActive) ghostslider.value -= Time.deltaTime / 5;
        if (ScoreActive) scoreslider.value -= Time.deltaTime / 5;

        if (SlowdownActive) slowdownslider.value -= Time.deltaTime / 5;
        // Debug.Log("Speed "+move.speed);
    }


    private IEnumerator Ghost()
    {
        GhostActive = true;
        ghostslider.value = 1;
        Tubes = FindTubes();
        for (var i = 0; i < Tubes.Length; i++)
            foreach (Transform child in Tubes[i].transform)
                if(child.gameObject.tag=="Obstacle")
                child.gameObject.GetComponent<MeshCollider>().enabled = false;

        yield return new WaitForSeconds(5);
        GhostActive = false;
        Tubes = FindTubes();
        for (var i = 0; i < Tubes.Length; i++)
            foreach (Transform child in Tubes[i].transform)
                if (child.gameObject.tag == "Obstacle")
                    child.gameObject.GetComponent<MeshCollider>().enabled = true;
    }

    private IEnumerator ScoreMultiplier()
    {
        ScoreActive = true;
        scoreslider.value = 1;
        gameObject.GetComponent<Scoring>().boost = 5;
        if (scoreUI)
        {
            scoreUI.color = new Color32(0, 255, 0, 255);

        }
        yield return new WaitForSeconds(5);
        ScoreActive = false;
        gameObject.GetComponent<Scoring>().boost = 1;
        if (scoreUI)
        {
            scoreUI.color = new Color32(255, 255, 255, 255);

        }
    }

    private IEnumerator Slowdown()
    {
  
        slowdownslider.value = 1;
        SlowdownActive = true;
        double elapsed = 0f;
        double waitTime = Math.Sqrt(3f);
        var startSpeed = move.speed;
        var targetSpeed = move.speed / 2;

        while (elapsed < waitTime)
        {
            elapsed += Time.deltaTime / waitTime;
            move.speed = Mathf.Lerp(startSpeed, targetSpeed, (float)elapsed);
            yield return null;
        }

   
        yield return new WaitForSeconds(2);
    

        elapsed = 0f;
        while (elapsed < waitTime)
        {
            elapsed += Time.deltaTime / waitTime;
            move.speed = Mathf.Lerp(targetSpeed, startSpeed, (float)elapsed);
            yield return null;
        }
     
        SlowdownActive = false;
      
    }


    private GameObject[] FindTubes()
    {
        GameObject[] result;
        result = GameObject.FindGameObjectsWithTag("Tube");
        return result;
    }

    private void powerselector()
    {
        var temp = Random.Range(0, 3);
        if ((GhostActive && SlowdownActive && ScoreActive)||(GhostActive&&ScoreActive&&move.speed<=10)) return;
        switch (temp)
        {
            case 0:
                if (!GhostActive)
                    StartCoroutine(Ghost());
                else
                    powerselector();
                break;
            case 1:
                if (!SlowdownActive&&move.speed>10)
                    StartCoroutine(Slowdown());
                else
                    powerselector();
                break;
            case 2:
                if (!ScoreActive)
                    StartCoroutine(ScoreMultiplier());
                else
                    powerselector();
                break;
            default:
                return;
        }
    }


    public IEnumerator GetPowerups()
    {
        timer += Random.Range(10, 20);
        powerselector();
        yield return new WaitForEndOfFrame();
    }
}