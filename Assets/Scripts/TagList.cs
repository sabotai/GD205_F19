using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagList : MonoBehaviour
{

    public GameObject[] objectTagArray; //store our array of gameobjects... we made it public so we can see it in the inspector
    public string tagName; //let the developer type the tag in the inspector

    // Start is called before the first frame update
    void Start()
    {
        objectTagArray = GameObject.FindGameObjectsWithTag(tagName); //assign out all the gameobjects with the tag we typed in the inspector
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
