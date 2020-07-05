using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Interactions : MonoBehaviour
{
    public GameObject gameObjectPlayer;
    public GameObject gameObjectNewSprite;
    public Flowchart flowchart;

    public GameObject panel;
    //public string fungusString;

    public void OnTriggerEnter2D(Collider2D coll)
    {
        flowchart.SetBooleanVariable("shit", true);
        if (coll.gameObject.tag == "Player" && flowchart.GetBooleanVariable("fungBool") == true)
        {
            //flowchart.SetBooleanVariable("fungBool", true);
            Player.speed = 0;
            
            GameManager.IsInputEnabled = false;
            //Player.stopOnFrame(gameObjectPlayer, "AllSprites", 0, 0.11f);
            //Player.tryAgain("stoppedBack", 0);
            Player.changeSprite(gameObjectPlayer, false);
            Player.changeSprite(gameObjectNewSprite, true);
        }
    }

        public void OnClick()
    {
        panel.gameObject.SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //panel.gameObject.SetActive(false);
        //flowchart.SetBooleanVariable("fungBool", true);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(flowchart.GetBooleanVariable("fungBool"));
    }
}
