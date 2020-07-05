using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class UIOnClick : MonoBehaviour
{
    public Animator animatorVar;
    public GameObject gameObjectPlayer;
    public void LoadScene (string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }
    public void ExitGame ()
    {
        Application.Quit();
    }

    public GameObject panel;
    public void CloseWindow ()
    {
        panel.gameObject.SetActive(false);
    }

    public void closePopUpCollider()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("escape")) 
        {
            Application.Quit();
        }
        
    }
}
