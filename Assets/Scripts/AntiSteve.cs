using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //dont forget to add this! its necessary to use navmesh stuff

public class AntiSteve : MonoBehaviour
{

    //In this script, we check if a gameobject with a rigidbody has entered our trigger.
    //we had to make sure to add the extra collider to our gameobject and set isTrigger to on
    //then we positioned it in front of joe

    NavMeshAgent joe; //create a navmeshagent to manipulate
    // Start is called before the first frame update
    void Start()
    {
        joe = GetComponent<NavMeshAgent>(); //assign it to be whatever is attached to the same gameobject
    }

    // Update is called once per frame
    void Update()
    {
    }

    //OnTriggerStay will be executed every frame in which something occupies the trigger collider we created
    void OnTriggerStay(Collider triggerReport)
    {
        Debug.Log("trigger entered");

        //if the collider that entered our trigger is named steveobject
        if (triggerReport.name == "SteveObject")
        {
            Debug.Log("STEVE LOCATED");

            //now that we know its that gosh darned steve, update joes destination to go after steve
            joe.destination = triggerReport.transform.position;
        }
    }
}
