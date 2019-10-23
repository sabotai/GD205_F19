using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
{
    public Transform target; //the thing we want to chase
    Rigidbody rb; //reference for our rigidbody
    public float forceAmt = 10f; //amount to multiply to the direction to move it

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //assign it to the rigidbody attached to the same game object
    }

    // Update is called once per frame
    void Update()
    {
        //by calculating the direction, we know which way to send the predator
        //target.position (prey) - transform.position (predator) gives us the relative distance of the target
        //Vector3.Normalize will convert this distance into a direction e.g., a distance of (2, 1, 0) is a direction of (1, 0.5, 0) 
        //all values in directions are between -1 and 1, so up is (0,1,0) meaning not left or right, up on the x and not forward or backward
        //left and down would be (-1, -1, 0), meaning left, down, and neither fwd nor bwd
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
        
        //we use the add force function/method of rigidbody
        //to add force in the direction to move toward the target multiplied by an amount of force
         rb.AddForce(targetDir * forceAmt);
    }
}
