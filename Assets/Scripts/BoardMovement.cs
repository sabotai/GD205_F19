using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    //float x = 5f;
    //float y = 10f;
    //float z = 15f;
    public Vector3 pos = new Vector3(5f,10f,15f);
    public Transform playerPiece;
    float tileAmount = 1f;
    public Transform hazard;
    public Vector3 playerStart;

    // Start is called before the first frame update
    void Start()
    {
        playerStart = playerPiece.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("space key was pressed");
            playerPiece.position += new Vector3(0f,0f, tileAmount);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerPiece.position += new Vector3(0f, 0f, -tileAmount);
        }

        if (hazard.position == playerPiece.position)
        {
            //Destroy(playerPiece.gameObject);
            playerPiece.position = playerStart;
        }
    }
}
