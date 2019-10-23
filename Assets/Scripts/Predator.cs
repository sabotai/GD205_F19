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
        
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);

        rb.AddForce(targetDir * forceAmt);
    }
}
