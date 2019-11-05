using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float boomAmt = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction * 100f, Color.cyan);
        if (Physics.Raycast(laser, out hit, 10000f) && Input.GetMouseButton(0)){
            Debug.Log("you hit " + hit.transform.gameObject.name + "something with the ray");
            if (hit.rigidbody)
            {
                Vector3 whichDirection = Random.insideUnitSphere;
                 hit.rigidbody.AddForce(whichDirection * boomAmt);
            }
        }
    }
}
