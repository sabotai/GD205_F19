using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieInput : MonoBehaviour
{
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("AnimState", -1);
    }
}
