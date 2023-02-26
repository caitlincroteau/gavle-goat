using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldLady : MonoBehaviour
{   
    public float speed = 2.5f;
    Vector3 velocity = Vector3.zero;
    
    
    float decisionTimer = .5f;
    float decisionCountdown = 0f;

    public float oddsToStop = 0.1f;

    public float xWall = 9.5f;
    public float yWall = 5f; 
    // Start is called before the first frame update
    void Start()
    {
       decide(); 
    }

    // Update is called once per frame
    void Update()
    {
        decisionCountdown -= Time.deltaTime;
        if(decisionCountdown <= 0f){
            decide();
        }
        transform.position += velocity * Time.deltaTime;
        checkBoundaries();
    }

    void decide(){
        decisionCountdown = decisionTimer;
        // decide  whethjer to stop
        if(Random.Range(0f, 1f) <= oddsToStop) {
            velocity = Vector3.zero;
            return;
        }
        // pick direction
        float angle = Random.Range(0f, Mathf.PI * 2);
        //velocity is how much we will change the position by. These x, y values are the change, not the target coordinates.
        velocity = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * speed;
    }

    void checkBoundaries() {

        Vector3 currentPosition = transform.position;
        // check horizontal boundaries
        if( transform.position.x > xWall) { // right
            currentPosition.x = xWall;
        } else if (transform.position.x < -xWall) { // left
            currentPosition.x = -xWall;
        }

        if(transform.position.y > yWall) {
            currentPosition.y = yWall;
        } else if(transform.position.y < -yWall) {
            currentPosition.y = -yWall;
        }

        transform.position = currentPosition;

    }
}
