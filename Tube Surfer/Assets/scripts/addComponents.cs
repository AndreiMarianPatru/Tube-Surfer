using UnityEngine;

public class addComponents : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.AddComponent<Rotate>();
        gameObject.AddComponent<move>();
        gameObject.tag = "Tube";

        foreach (Transform child in transform)
        {
           
              
                child.gameObject.AddComponent<Rigidbody>();
                child.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                child.gameObject.GetComponent<Rigidbody>().useGravity = false;
                child.gameObject.AddComponent<MeshCollider>();
                child.gameObject.AddComponent<ObstacleCollision>();
                child.gameObject.tag = "Obstacle";



        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}