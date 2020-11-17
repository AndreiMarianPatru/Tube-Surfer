using System.Collections;
using TMPro;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public bool GhostActive;
    public bool ScoreActive;
    public bool SlowdownActive;
    public TextMeshProUGUI scoreUI;

    private GameObject[] Tubes;

    // Start is called before the first frame update
    private void Start()
    {
        GhostActive = false;
        ScoreActive = false;
        SlowdownActive = false;
    }

    // Update is called once per frame
    private void Update()
    {
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
    }

    private IEnumerator Ghost()
    {
        GhostActive = true;
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
        move.speed = move.speed / 2;
        yield return new WaitForSeconds(5);
        SlowdownActive = false;
        move.speed *= 2;
    }



    private GameObject[] FindTubes()
    {
        GameObject[] result;
        result = GameObject.FindGameObjectsWithTag("Tube");
        return result;
    }
}