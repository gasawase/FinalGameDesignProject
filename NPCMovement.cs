using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class NPCMovement : MonoBehaviour
{
    public GameObject npc;
    Vector2 startPosition;
    public float distanceFromStart = 0;
    public int maxToMove;
    public bool moveAway = true;
    public bool fungFlip = false;
    public Flowchart dingleBerry;
    public int minDistance;
    public float timeWait;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = npc.transform.position;
        //StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSecondsRealtime (timeWait);
    }

    // Update is called once per frame
    void Update()
    {
        //maxToMove = the farthest it goes to the right
        //moveAway = if it goes left or right; right = true, left = false
        //minDistance = the farthest it goes to the left
        if(distanceFromStart < maxToMove && moveAway && !dingleBerry.GetBooleanVariable("funFlip"))//each single movement
        {
            transform.Translate(+1*speed, 0, 0);
            distanceFromStart = Vector2.Distance(startPosition, npc.transform.position);
        }
        else if(distanceFromStart > minDistance && !moveAway && !dingleBerry.GetBooleanVariable("funFlip"))
        {
            transform.Translate(-1*speed, 0, 0);
            //distanceFromStart = Vector2.Distance(npc.transform.position, startPosition);
            distanceFromStart = npc.transform.position.x - startPosition.x;
        } 
        else
        {
            moveAway = !moveAway;
            dingleBerry.SetBooleanVariable("funFlip", true);
        }
    }
}
