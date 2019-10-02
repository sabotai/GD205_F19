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
    void Update()
    {
        //check if the key w is being pressed at all (getkey, not getkeydown... getkeydown is only once when the key is being newly pressed)
        if (Input.GetKey(KeyCode.W))
        {
            //access our rigidbody rb and addforce in the direction backwards multiplied times a force amount
            //we are making it move backwards because our plane was created backwards
            rb.AddForce(new Vector3(0f,0f,-1f) * forceAmt);
        }

        //add thrust movement in the other directions
    }
}
