using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mayor : MonoBehaviour

{
    public Transform playerLocation;
    public float speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerX = playerLocation.position.x;
        float playerY = playerLocation.position.y;

        //change in x, y
        float deltaX = gameObject.transform.position.x - playerX;
        float deltaY = gameObject.transform.position.y - playerY;
        Vector3 deltaPosition = new Vector3 (deltaX, deltaY, 0);

        //normalize delta vector
        deltaPosition = deltaPosition.normalized;

        //set speed
        deltaPosition *= speed * Time.deltaTime;

        //apply delta to mayor's positon
        gameObject.transform.position += deltaPosition;

    }
}

//figure out direction of mayor in relation to player
//figure out x and y directions

//normalize
//apply speed and delta time

