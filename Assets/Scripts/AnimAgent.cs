using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//THIS IS AN EXAMPLE OF COMBINING THE SCRIPTS WE DID THIS WEEK WITH THE ANIMATOR CONTROLLER
//We can set AnimState based on whether the navMesh is moving or not by checking the velocity



public class AnimAgent : MonoBehaviour
{
    NavMeshAgent agent;
    public Vector3 dest;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction * 100f, Color.cyan);
        if (Physics.Raycast(laser, out hit, 10000f) && Input.GetMouseButton(0))
        {
            agent.destination = hit.point;
        }

        if (agent.velocity == Vector3.zero)
        {
            myAnim.SetInteger("AnimState", 0);
        }
        else
        {
            myAnim.SetInteger("AnimState", 5);
        }
    }
}
