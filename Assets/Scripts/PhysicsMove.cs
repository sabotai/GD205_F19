using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsMove : MonoBehaviour
{
    Rigidbody rb; //create a new rigidbody object
    public float forceAmt = 100f; //use this public float to control the amount of thrust

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //assign it using the rigidbody attached to the same gameobject
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //check if the key w is being pressed at all (getkey, not getkeydown... getkeydown is only once when the key is being newly pressed)
        if (Input.GetKey(KeyCode.W))
        {
            //access our rigidbody rb and addforce in the direction forward multiplied times a force amount
            rb.AddForce(new Vector3(0f,0f,1f) * forceAmt);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //access our rigidbody rb and addforce in the direction backward multiplied times a force amount
            rb.AddForce(new Vector3(0f, 0f, -1f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //access our rigidbody rb and addforce in the direction left multiplied times a force amount
            rb.AddForce(new Vector3(-1f, 0f, 0f) * forceAmt);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //access our rigidbody rb and addforce in the direction right multiplied times a force amount
            rb.AddForce(new Vector3(1f, 0f, 0f) * forceAmt);
        }
        //add thrust movement in the other directions
    }
    
    //OnCollisionEnter will run any time a collision happens between this game object and another one
    void OnCollisionEnter(Collision colReport) //the Collision class stores all the information about the collision 
    {
        //we are checking the tag of the thing we hit using first the collision and then the game object to access the tag property
        if (colReport.gameObject.CompareTag("collectible")) //does it have a tag matching this string?
        {   //if so, destroy the gameObject we collided with
            Destroy(colReport.gameObject);
        }
    }
}
