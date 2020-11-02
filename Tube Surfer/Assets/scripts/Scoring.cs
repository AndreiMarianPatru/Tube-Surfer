using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{

    public float score;

    public TextMeshProUGUI scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        scoreUI.text = Mathf.RoundToInt(score).ToString();
    }
}
