using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeScene : MonoBehaviour
{
    public Color loadToColor = Color.black;
    public void OnTriggerEnter2D(Collider2D colNextScene)
    {
        if (colNextScene.gameObject.tag == "Player")
        {
            Initiate.Fade("InsideCastle",loadToColor,1.0f);
            //SceneManager.LoadScene(2);
        }
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
