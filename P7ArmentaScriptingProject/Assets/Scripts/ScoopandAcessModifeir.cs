using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoopandAcessModifeir : MonoBehaviour
{


    //creating a public varible that can be accessed by other scripts
    public int alpha = 5;

    //creating 2 private varible that can only be acessed by other scripts
    private int beta = 0;

        private int gamma = 5;
    //creating a methond that can be accessed by other scripts
    private AnotherClass myOtherClass;
       
        // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    void Example (int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " + alpha);
    }
}
