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
    public Transform playerPiece; //store the transform of our playerPiece ... dont forget to assign it in the inspector
    float tileAmount = 1f;
    public Transform hazard, obstacle;
    public Transform[] manyHazards;
    public Vector3 playerStart;
    public TextMesh playerMsg;
    public AudioClip deathClip;
    AudioSource myAud;
    public Transform key;
    bool hasKey = false;

    // Start is called before the first frame update
    void Start()
    {
        //store our starting position with playerStart
        playerStart = playerPiece.position;
        myAud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
        {
        Vector3 newPos = playerPiece.position; //create a temporary vector3 to store a new hypothetical position

        if (Input.anyKeyDown) //reset player message if any key is pressed down (when they start playing again)
        {
            playerMsg.text = "use WASD to move";

        }
        //we are accessing the Input class and its method GetKeyDown which runs everytime the key specified is newly pressed down
        //Keys can be specified using KeyCode
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            //show us a message in the console
            print("w key was pressed");

            //update newPos to be the new position after pressing the w key
            newPos += new Vector3(0f, 0f, tileAmount);

        }

        //same as above but for backwards
        if (Input.GetKeyDown(KeyCode.S))
        {
            newPos += new Vector3(0f, 0f, -tileAmount);
        }
        //same as above but for left
        if (Input.GetKeyDown(KeyCode.A))
        {
            newPos += new Vector3(-tileAmount, 0f, 0f);
        }
        //same as above but for right
        if (Input.GetKeyDown(KeyCode.D))
        {
            newPos += new Vector3(tileAmount, 0f, 0f);
        }
        //same as above but for up
        if (Input.GetKeyDown(KeyCode.E))
        {
            newPos += new Vector3(0f, tileAmount, 0f);
        }
        //same as above but for down
        if (Input.GetKeyDown(KeyCode.Q))
        {
            newPos += new Vector3(0f, -tileAmount, 0f); //update newPos to be our potential new position
        }
        if (obstacle.position != newPos) //only update our playerPiece position if it is NOT the same as the obstacle
        {
            //update the playerpiece pos to be the newPos
            playerPiece.position = newPos;
        } else
        { //if youre in the same hypothetical position as the obstacle
            if (hasKey) //if you also have the key
            {
                obstacle.position = new Vector3(999999999f, 9999f, 9f); //send the obstacle off screen
            }
        }
        if (key.position == playerPiece.position)
        {
            key.gameObject.SetActive(false); //hide the key
            playerMsg.text = "key obtained!"; //give the player a new message
            hasKey = true; //store the value for whether we have the key or not
        }
    //if the position of our hazard (dont forget to assign it in the inspector) is the same position as our player piece...
        for (int i = 0; i < manyHazards.Length; i++) //use a loop to check each one of the positions in our transform array (manyhazards)
        {
            if (manyHazards[i].position == playerPiece.position) //check if our playerpiece is in the same position as this particular one from manyHazards
            {
                playerMsg.text = "u mest up ):"; //update the text property of playerMsg to tell our player what happened
                playerPiece.position = playerStart; //then reset the position to the starting position
                myAud.PlayOneShot(deathClip, 1f);
            }
        }
    }
}
