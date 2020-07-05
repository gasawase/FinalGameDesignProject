using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class doneTalking : MonoBehaviour
{
    public Flowchart flowchart;

    public GameObject panel;
    public GameObject gameObjectPlayer;
    public GameObject gameObjectNewSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("doneTalking")) //after fungus flowchart
        {
            Debug.Log("Debug2");
            Player.speed = 2;
            
            GameManager.IsInputEnabled = true;
            //Player.stopOnFrame(gameObjectPlayer, "AllSprites", 0, 0.11f);
            //Player.tryAgain("stoppedBack", 0);
            Player.changeSprite(gameObjectPlayer, true);
            Player.changeSprite(gameObjectNewSprite, false);
        }
    }
}
