using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    private bool jump;

    private bool onGround;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        jump = false;
        onGround = false;

    }

    void Update()
    {
        //Debug.Log(rb.velocity);
        if (Input.GetKey("space"))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
       // Debug.Log(rb.velocity.y);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((jump == true) && (onGround == false))
        {
           // Debug.Log("wanted to jump but in air");
        }
            if ((jump == true)&& (onGround==true))
        {
           // Debug.Log("jump");
          //  Debug.Log("og " + onGround);

            rb.AddForce(0, 4, 0, ForceMode.Impulse);

        }
            

        rb.AddForce(Physics.gravity * 1.0f);

        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, -1.694148f, -0.56f);
        transform.position = clampedPosition;

    }

  
    void OnCollisionStay (Collision collisionInfo)
    {
        // Debug-draw all contact points and normals
        foreach (ContactPoint contact in collisionInfo.contacts)
        {
            if (contact.otherCollider.gameObject.tag == "Tube")
            {
                onGround = true;
//Debug.Log("og "+onGround);

            }
        }
    }
    void OnCollisionExit(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Tube")
        {
            //Debug.Log("no tube");
            onGround = false;
          //  Debug.Log("og " + onGround);
        }
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
