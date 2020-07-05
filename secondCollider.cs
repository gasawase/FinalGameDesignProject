using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class secondCollider : MonoBehaviour
{
    public GameObject gameObjectPlayer;
    public Flowchart flowchart;
    public Flowchart secFlow;

    public GameObject panel;

    public Animator animatorVar;

    private bool closedOrNot = false;

    public void OnTriggerEnter2D(Collider2D coll2)
    {
        if (coll2.gameObject.tag == "Player" && flowchart.GetBooleanVariable("bocBool") == true)
        {
            var animatorVar = gameObjectPlayer.GetComponent<Animator>();
            Player.speed = 0;
            GameManager.IsInputEnabled = false;
            animatorVar.speed = 0; //STOPS FRAME
            panel.gameObject.SetActive(true);
            //panel.gameObject.SetActive(true);
        }
    }

    public void closePopUp ()
    {
        panel.gameObject.SetActive(false);
             
    }

    public void actionsOnClose()
    {
            secFlow.SetBooleanVariable("secEnd", true);  
            var animatorVar = gameObjectPlayer.GetComponent<Animator>();
            Player.speed = 2;
            animatorVar.speed = 1;
            Debug.Log(animatorVar.speed);
            Debug.Log("Debug1");
            GameManager.IsInputEnabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
