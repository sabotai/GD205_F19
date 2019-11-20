using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //dont forget to add this to scripts in which you use AI functions!

public class MyAgent : MonoBehaviour
{
    NavMeshAgent steve; //create a new navmeshagent to manipulate in our script
    public Vector3 dest; //this will serve as our destination for steve

    // Start is called before the first frame update
    void Start()
    {
        steve = GetComponent<NavMeshAgent>(); //assign it to be the one attached to the same gameobject
    }

    // Update is called once per frame
    void Update()
    {

        //create a ray using the method we previously emplyed in the laser script
        //the next four lines are literally copied and pasted from that script
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction * 100f, Color.cyan);
        if (Physics.Raycast(laser, out hit, 10000f) && Input.GetMouseButton(0))
        {
            //if our ray hit something, update dest to be the point that our ray hit
            dest = hit.point;
        }
        //update steves destination to dest, wherever we last clicked
        steve.destination = dest;

        
    }
}
