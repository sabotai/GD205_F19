﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : MonoBehaviour
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
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);

        rb.AddForce(targetDir * forceAmt);
    }
}
