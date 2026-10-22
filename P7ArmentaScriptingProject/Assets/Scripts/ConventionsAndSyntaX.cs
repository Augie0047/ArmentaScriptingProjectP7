using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntaX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This line is here  to tell me the x posiution of the object in the scene
        Debug.Log(transform.position.x);

          
    }

    // Update is called once per frame
    void Update()
    {
        //This line is here to tell me the y poistion of the object
        if (transform.position.y <= 5f) 
        {
            Debug.Log("I'm about to hit the ground");
        }
        else
        {
            Debug.Log("Yay I'm safe");
        }
    }
}
