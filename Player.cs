using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb2d;
    public static float speed = 2;
    public static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //PLAYER MOVEMENT AND ANIMATION

        if (GameManager.IsInputEnabled)
        {
            playerMove();
        }
        
    }
    public void playerMove ()
    {
        horizontal = Input.GetAxis("Horizontal"); //returns 1 or -1 to move left and right
        vertical = Input.GetAxis("Vertical"); //returns 1 or -1 to move up or down

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * Time.deltaTime * speed);

        if (vertical < 0)
        {
            anim.SetBool("moveFor", true);
            anim.SetBool("moveBack", false);
            anim.SetBool("moveLeft", false);
            anim.SetBool("moveRight", false);

        }

        else if (vertical > 0)
        {
            anim.SetBool("moveFor", false);
            anim.SetBool("moveBack", true);
            anim.SetBool("moveLeft", false);
            anim.SetBool("moveRight", false);
        }

        else if (horizontal > 0)
        {
            anim.SetBool("moveFor", false);
            anim.SetBool("moveBack", false);
            anim.SetBool("moveLeft", false);
            anim.SetBool("moveRight", true);
        }

        else if (horizontal < 0)
        {
            anim.SetBool("moveFor", false);
            anim.SetBool("moveBack", false);
            anim.SetBool("moveLeft", true);
            anim.SetBool("moveRight", false);
        }

        else if (horizontal == 0 || vertical == 0)
        {
            anim.SetBool("moveFor", false);
            anim.SetBool("moveBack", false);
            anim.SetBool("moveLeft", false);
            anim.SetBool("moveRight", false);
        }

    }
    //make a method for stopping the animation on a specific frame here

    public static void changeSprite (GameObject gameObject, bool boolVal)
    {
        gameObject.SetActive(boolVal);
    }

}
