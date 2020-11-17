using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    public static float score;
    public float boost;

    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        boost = 1;
    }

    // Update is called once per frame
    void Update()
    {
        score += (1 * Time.deltaTime)*boost;
        scoreUI.text = Mathf.RoundToInt(score).ToString();
    }
}
