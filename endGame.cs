using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class endGame : MonoBehaviour
{
    public Flowchart flowchart1;
    public Flowchart flowchart2;

    public Color loadToColor = Color.black;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart1.GetBooleanVariable("endGame"))
        {
            Initiate.Fade("theEnd",loadToColor,1.0f);
        }

        if(flowchart2.GetBooleanVariable("endGame"))
        {
            Initiate.Fade("theEnd",loadToColor,1.0f);
        }
    }
}
