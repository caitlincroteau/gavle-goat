using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFighterSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fireFighter;
    private float timer;
    public bool sendRight = true;

    public float MaxY = 4f;
    public float MinY = -4f;
    // Start is called before the first frame update
    void Start()
    {
        timer = Random.Range(.5f, 3f);
        Instantiate(fireFighter, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        
        if(timer <= 0f){
            //reset timer
            timer = Random.Range(.5f, 3f);
        
            //set new y position for spawner
            float yPos = Random.Range(MinY,MaxY);
            transform.position = new Vector3 (transform.position.x, yPos, transform.position.z);
            
            //spawn firefigher and set its direction
            GameObject newFF = Instantiate(fireFighter, transform.position, transform.rotation);
            newFF.GetComponent<FireFighter>().goingRight = sendRight;
        }
        
    }
}
