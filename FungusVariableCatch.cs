using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class GameEnd : MonoBehaviour
{
    public Flowchart flowchartEnd;
    public bool flowEndGameVal;
    public Color loadToColor = Color.black;
   

    public void endScene()
    {
   
    }
    // Start is called before the first frame update
    void Start()
    {
        // flowEndGameVal = flowchartEnd.GetBooleanVariable("endGame");
        // Debug.Log(flowEndGameVal);
        // if(flowEndGameVal == true)
        // {

        // }              
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchartEnd.GetBooleanVariable("endGame"))
        {
            Initiate.Fade("theEnd",loadToColor,1.0f);            
        }
    }
}
