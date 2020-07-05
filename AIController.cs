using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject Target;
    //random movement
    public float roamRadius = 20;
    Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 startposition = Enemy.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 playerPos = Target.transform.position;
        Vector2 enemPos = Enemy.transform.position;

        Vector2 delta = playerPos - enemPos;
        float deltaX = delta.x;
        float deltaY = delta.y;
        Vector2 fwrR = new Vector2(-1, 1);

        if (deltaX >= 0)
        {
            if (deltaY >= 0)
            {
                Enemy.transform.Translate(Enemy.transform.position * fwrR * Time.deltaTime);
                Debug.Log("AHHHH");
            }
        }

            //if(deltaX > deltaY) //x direction (left right)
           // {
            //    if
                //if positive
                //else if negative
           // }
          //  else if(deltaY > deltaX) //y direction (up down)
           // {
                //if positive
                //else if negative

           // }

    }
    public Vector3 converV2toV3(Vector2 converV2)
    {
        float cordax = converV2.x;
        float corday = converV2.y;
        Vector3 fakeBitch = new Vector3(cordax, corday, 0); //fakeBitch = the asshole 3D to 2D

        return fakeBitch;
    }
}
