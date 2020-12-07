using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private bool onGround;
    private Rigidbody rb;

    private bool up;
    private bool down;
   

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        up = false;
        down = false;
        onGround = false;
       
    }

    private void Update()
    {
        //Debug.Log(rb.velocity);
        if (Input.GetKey("w"))
            up = true;
        else
            up = false;
        if (Input.GetKey("s"))
            down = true;
        else
            down = false;
        // Debug.Log(rb.velocity.y);
        var clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -1.694134f, -0.56f);
        transform.position = clampedPosition;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        

        if (up && onGround)
            rb.AddForce(0, 6.5f, 0, ForceMode.Impulse);
        if (down && onGround == false)
        {
            rb.AddForce(0, -6.5f, 0, ForceMode.Impulse);
        }
        else
        {
            rb.AddForce(Physics.gravity * 1.0f);

        }


        
    }

    void LateUpdate()
    {
     
    }


    private void OnCollisionStay(Collision collisionInfo)
    {
        // Debug-draw all contact points and normals
        foreach (var contact in collisionInfo.contacts)
            if (contact.otherCollider.gameObject.tag == "Tube")
                onGround = true;
//Debug.Log("og "+onGround);
    }

    private void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Tube")
            //Debug.Log("no tube");
            onGround = false;
        //  Debug.Log("og " + onGround);
        // Debug-draw all contact points and normals
        //foreach (ContactPoint contact in collisionInfo.contacts)
        //{
        //    if (contact.otherCollider.gameObject.tag == "Tube")
        //    {
        //        onGround = false;
        //        Debug.Log("og " + onGround);


        //    }
        //}
    }
}