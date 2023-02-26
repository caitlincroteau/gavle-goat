using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFighter : MonoBehaviour
{
    public float FireFighterSpeed = 10f;
    public bool goingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(goingRight) {
            transform.position += Vector3.right * FireFighterSpeed * Time.deltaTime;
        } else {
            transform.position += Vector3.left * FireFighterSpeed * Time.deltaTime;
        }
       
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            Destroy(other.gameObject);
        } 
    }
}
