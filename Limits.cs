using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limits : MonoBehaviour
{
    public GameObject topRightLimitGO;
    public GameObject bottomLeftLimitGO;
    private Vector2 topRightLimit;
    private Vector2 bottomLeftLimit;
    // Start is called before the first frame update
    void Start()
    {
        topRightLimit = topRightLimitGO.transform.position;
        bottomLeftLimit = bottomLeftLimitGO.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
