using System.Collections;
using TMPro;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public bool GhostActive;
    public bool ScoreActive;
    public TextMeshProUGUI scoreUI;

    private GameObject[] Tubes;

    // Start is called before the first frame update
    private void Start()
    {
        GhostActive = false;
        ScoreActive = false;
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



    private GameObject[] FindTubes()
    {
        GameObject[] result;
        result = GameObject.FindGameObjectsWithTag("Tube");
        return result;
    }
}