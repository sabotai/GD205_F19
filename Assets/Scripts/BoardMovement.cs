using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    //this script must be attached to a game object in your scene to be used
    //you can do this by dragging it onto the gameObject

    //declare a new public vector3
    //public means we can assign it in the inspector
    //to give it an initial assignment, we have to use new Vector3(xValue, yValue, zValue)
    public Vector3 pos = new Vector3(5f,10f,15f); //float values should be followed by the letter f
    public Transform playerPiece; //store the transform of our playerPiece ... dont forget to assign it in the inspector
    float tileAmount = 1f;
    public Transform hazard;
    public Vector3 playerStart;

    // Start is called before the first frame update
    void Start()
    {
        //store our starting position with playerStart
        playerStart = playerPiece.position;
    }

    // Update is called once per frame
    void Update()
        {//we are accessing the Input class and its method GetKeyDown which runs everytime the key specified is newly pressed down
            //Keys can be specified using KeyCode
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            //show us a message in the console
            print("w key was pressed");

            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,0f, tileAmount);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //we can use - to move it the opposite direction
            playerPiece.position += new Vector3(0f, 0f, -tileAmount);
        }

        //if the position of our hazard (dont forget to assign it in the inspector) is the same position as our player piece...
        if (hazard.position == playerPiece.position)
        {
            playerPiece.position = playerStart; //then reset the position to the starting position
        }
    }
}
