using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : MonoBehaviour
{
    public Transform target;
    Rigidbody rb;
    public float forceAmt = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = Vector3.Normalize(transform.position - target.position);

        rb.AddForce(targetDir * forceAmt);
    }
}
