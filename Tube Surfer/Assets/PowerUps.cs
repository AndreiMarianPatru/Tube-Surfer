using System.Collections;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public bool GhostActive;

    private GameObject[] Tubes;

    // Start is called before the first frame update
    private void Start()
    {
        GhostActive = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown("t") && GhostActive == false)
        {
            Debug.Log("t");
            StartCoroutine(Ghost());
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

    private GameObject[] FindTubes()
    {
        GameObject[] result;
        result = GameObject.FindGameObjectsWithTag("Tube");
        return result;
    }
}